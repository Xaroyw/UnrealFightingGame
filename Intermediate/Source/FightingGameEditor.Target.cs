using UnrealBuildTool;

public class FightingGameEditorTarget : TargetRules
{
	public FightingGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FightingGame");
	}
}
