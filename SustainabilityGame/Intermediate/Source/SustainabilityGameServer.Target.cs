using UnrealBuildTool;

public class SustainabilityGameServerTarget : TargetRules
{
	public SustainabilityGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SustainabilityGame");
	}
}
