using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace NoFogOfWar
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            _ = Configs.Instance;

            Harmony harmony = new Harmony("com.nofogofwar");

            harmony.PatchAll();
        }
    }
}