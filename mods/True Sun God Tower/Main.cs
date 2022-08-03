using BTD_Mod_Helper;
using MelonLoader;
using Harmony;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Models;

[assembly: MelonInfo(typeof(TemplateMod.Main), "Your Mod Name", "1.0.0", "Your Name")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace TemplateMod
{
    public class Main : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Msg("ding");
        }

    }
}