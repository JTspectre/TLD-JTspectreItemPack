using System;
using System.IO;
using System.Linq;
using ModSettings;
using System.Collections.Generic; // List<>
using MelonLoader;
using HarmonyLib;
using UnityEngine;

namespace JTspectreItemPack
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Settings.OnLoad();/// ModSettings
            LoggerInstance.Msg($"JTspectreItemPack - Version {BuildInfo.Version}");
        }
    }
}
