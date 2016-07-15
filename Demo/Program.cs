﻿using System;
using System.Collections.Generic;
using System.IO;
using Demo.Util;
using log4net;
using POGOLib.Net;
using POGOLib.Net.Data;
using POGOLib.Pokemon;

namespace Demo
{
    public class Program
    {
        public static string SaveDataPath { get; private set; }
        
        private static readonly ILog Log = LogManager.GetLogger(typeof(POClient));

        /// <summary>
        /// This is just a demo application to test out the library / show a bit how it works.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.Title = "POGO Demo";

            var arguments = ParseArguments(args);

            SaveDataPath = Path.Combine(Environment.CurrentDirectory, "savedata");
            if (!Directory.Exists(SaveDataPath)) Directory.CreateDirectory(SaveDataPath);
            
            string username;

            if (!arguments.ContainsKey("username"))
            {
                Log.Info("Hi, please enter your PTC details.");

                Console.Write("Username: ");
                username = Console.ReadLine();
            }
            else
            {
                username = arguments["username"];
            }

            var client = new POClient(username, LoginProvider.PokemonTrainerClub);
            // Load previous data.
            if (!client.LoadClientData())
            {
                Console.Write("Password: ");
                var password = ConsoleUtil.ReadLineMasked();
                
                // Need to set initial gps data before authenticating!
                if (!client.HasGpsData())
                {
                    Console.Write("First time lat: ");
                    var latitude = Console.ReadLine()?.Replace(".", ",");
                    Console.Write("First time long: ");
                    var longitude = Console.ReadLine()?.Replace(".", ",");

                    client.SetGpsData(double.Parse(latitude), double.Parse(longitude));
                }

                if(!client.Authenticate(password).Result)
                    throw new Exception("Wrong password.");
            }

            // Make sure to save if you want to use save / loading.
            client.SaveClientData();

            Console.ReadKey();
        }

        private static Dictionary<string, string> ParseArguments(IEnumerable<string> args)
        {
            var arguments = new Dictionary<string, string>();

            foreach (var s in args)
            {
                if (!s.StartsWith("--") || !s.Contains("="))
                {
                    Log.Error($"Invalid argument: '{s}'");
                    throw new ArgumentException(nameof(s));
                }

                var argument = s.Substring(2, s.Length - 2);
                var equalPos = s.IndexOf("=", StringComparison.Ordinal) - 2;
                var key = argument.Substring(0, equalPos);
                var value = argument.Substring(equalPos + 1, argument.Length - key.Length - 1);

                arguments.Add(key, value);
            }

            return arguments;
        }
    }
}