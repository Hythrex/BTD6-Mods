using BTD_Mod_Helper;
using MelonLoader;

[assembly: MelonInfo(typeof(TemplateMod.TemplateMain), "template", "0.1", "Hythrex")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace TemplateMod
{
	public class TemplateMain : BloonsTD6Mod
    {
		// dimeln


		public override void OnMainMenu()
		{
			base.OnMainMenu();
		}

		public override void OnApplicationStart()
        {
            MelonLogger.Msg("Template Mod Loaded!");
        }
    }
}
