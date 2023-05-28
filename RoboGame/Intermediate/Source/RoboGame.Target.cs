using UnrealBuildTool;

public class RoboGameTarget : TargetRules
{
	public RoboGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("RoboGame");
	}
}
