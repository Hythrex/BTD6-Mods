// imports

using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Utils;
using Assets.Scripts.Unity;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppSystem.Collections.Generic;
using Assets.Scripts.Simulation.Towers;
using UnhollowerBaseLib;
using MelonLoader;
using HarmonyLib;

namespace True_Sun_God_Tower
{
    public class SunMonkey : ModTower
    {
        public override SpriteReference IconReference => Game.instance.model.GetTowerWithName("SuperMonkey").icon; // get supermonkey's stuff

        public override SpriteReference PortraitReference => Game.instance.model.GetTowerWithName("SuperMonkey").portrait;
        public override string BaseTower => TowerType.SuperMonkey;
        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Description => "Shoots powerful beams to destroy any bloon that gets near it. It i extremely useful for MOAB class type bloons.";

        public override string TowerSet => MAGIC;

        public override string DisplayName => "True Sun God";

        public override int Cost => 600;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.radius = 6;
            towerModel.radiusSquared = 36;
            foreach (var weaponModel in towerModel.GetWeapons())
            {
                weaponModel.Rate = 0; // makes it go incredible fast
                /* basically the code that makes hypersonic mods :/ 
                   yeah im not that creative
                */
            }
        }
    }
}
