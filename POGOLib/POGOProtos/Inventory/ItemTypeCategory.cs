// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/ItemTypeCategory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from Inventory/ItemTypeCategory.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemTypeCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/ItemTypeCategory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemTypeCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBJbnZlbnRvcnkvSXRlbVR5cGVDYXRlZ29yeS5wcm90bxIUUE9HT1Byb3Rv",
            "cy5JbnZlbnRvcnkqugIKEEl0ZW1UeXBlQ2F0ZWdvcnkSEgoOSVRFTV9UWVBF",
            "X05PTkUQABIWChJJVEVNX1RZUEVfUE9LRUJBTEwQARIUChBJVEVNX1RZUEVf",
            "UE9USU9OEAISFAoQSVRFTV9UWVBFX1JFVklWRRADEhEKDUlURU1fVFlQRV9N",
            "QVAQBBIUChBJVEVNX1RZUEVfQkFUVExFEAUSEgoOSVRFTV9UWVBFX0ZPT0QQ",
            "BhIUChBJVEVNX1RZUEVfQ0FNRVJBEAcSEgoOSVRFTV9UWVBFX0RJU0sQCBIX",
            "ChNJVEVNX1RZUEVfSU5DVUJBVE9SEAkSFQoRSVRFTV9UWVBFX0lOQ0VOU0UQ",
            "ChIWChJJVEVNX1RZUEVfWFBfQk9PU1QQCxIfChtJVEVNX1RZUEVfSU5WRU5U",
            "T1JZX1VQR1JBREUQDGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Inventory.ItemTypeCategory), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ItemTypeCategory {
    [pbr::OriginalName("ITEM_TYPE_NONE")] ItemTypeNone = 0,
    [pbr::OriginalName("ITEM_TYPE_POKEBALL")] ItemTypePokeball = 1,
    [pbr::OriginalName("ITEM_TYPE_POTION")] ItemTypePotion = 2,
    [pbr::OriginalName("ITEM_TYPE_REVIVE")] ItemTypeRevive = 3,
    [pbr::OriginalName("ITEM_TYPE_MAP")] ItemTypeMap = 4,
    [pbr::OriginalName("ITEM_TYPE_BATTLE")] ItemTypeBattle = 5,
    [pbr::OriginalName("ITEM_TYPE_FOOD")] ItemTypeFood = 6,
    [pbr::OriginalName("ITEM_TYPE_CAMERA")] ItemTypeCamera = 7,
    [pbr::OriginalName("ITEM_TYPE_DISK")] ItemTypeDisk = 8,
    [pbr::OriginalName("ITEM_TYPE_INCUBATOR")] ItemTypeIncubator = 9,
    [pbr::OriginalName("ITEM_TYPE_INCENSE")] ItemTypeIncense = 10,
    [pbr::OriginalName("ITEM_TYPE_XP_BOOST")] ItemTypeXpBoost = 11,
    [pbr::OriginalName("ITEM_TYPE_INVENTORY_UPGRADE")] ItemTypeInventoryUpgrade = 12,
  }

  #endregion

}

#endregion Designer generated code