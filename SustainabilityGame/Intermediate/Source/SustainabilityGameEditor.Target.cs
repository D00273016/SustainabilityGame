using UnrealBuildTool;

public class SustainabilityGameEditorTarget : TargetRules
{
	public SustainabilityGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SustainabilityGame");
	}
}
