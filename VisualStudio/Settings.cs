using ModSettings;
using UnityEngine;
using MelonLoader;

namespace JTspectreItemPack
{
    internal class DiySettings : JsonModSettings
    {
        [Section("Colliders: If enabled, these objects will have collision.")]

        [Name("Enable")]
        [Description("Collision: CanvasTent, HockeyPuck, HockeyPuckOfficial, HockeyStick, OilBarrel")]
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
