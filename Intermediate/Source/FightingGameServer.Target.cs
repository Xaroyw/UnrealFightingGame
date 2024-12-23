using UnrealBuildTool;

public class FightingGameServerTarget : TargetRules
{
	public FightingGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FightingGame");
	}
}
