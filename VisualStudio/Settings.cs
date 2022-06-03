using ModSettings;
using UnityEngine;
using MelonLoader;

namespace JTspectreItemPack
{
    internal class DiySettings : JsonModSettings
    {
        [Section("Colliders")]

        [Name("Enable Collision : Oil Barrel, Tent")]
        [Description("If enabled, you will not be able to walk through these objects. If disabled, you can.")]
        public bool diyBoardsBoolVal = true;
        
        /*
        [Name("Num")]
        [Description("Don't change it!! Default=19")]
        [Slider(0, 31)]
        public int diyBoardLayerNum = 19;
        */

    }


    internal static class Settings
    {
        public static DiySettings options;

        public static void OnLoad()
        {
            options = new DiySettings();
            options.AddToModSettings("JTspectre's Item Pack", MenuType.Both);
        }
    }


}
