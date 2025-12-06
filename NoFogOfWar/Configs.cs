using MCM.Abstractions.Base.Global;


namespace NoFogOfWar
{
    public class Configs : AttributeGlobalSettings<Configs>
    {
        public override string Id => "NoFogOfWar";

        public override string DisplayName => "No fog of war";

        public override string FolderName => "NoFogOfWar";

        public override string FormatType => "json2";
    }
}