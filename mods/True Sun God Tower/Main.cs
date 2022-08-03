using BTD_Mod_Helper;
using MelonLoader;
using HarmonyLib;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Utils;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;

[assembly: MelonInfo(typeof(True_Sun_God_Tower.TemplateMain), "True Sun God in shop", "0.0.1", "Hythrex")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace True_Sun_God_Tower
{
    public class TemplateMain : BloonsTD6Mod
    { 
        public override void OnMainMenu()
        {
            base.OnMainMenu();
        }

        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Mod Loaded.");
        }
    }

    [HarmonyPatch(typeof(Tower), "Initialise")]

    public class TowerInitialise_Patch
    {
        [HarmonyPrefix]

        public static bool Prefix(Tower __instance, ref Model modelToUse)
        {
            if (!modelToUse.name.Contains("SunMonkey"))
                return true;

            modelToUse = Game.instance.model.GetTower(TowerType.SuperMonkey, 5, 2, 0); // get true sun god model
            return true;
        }
    }
}
