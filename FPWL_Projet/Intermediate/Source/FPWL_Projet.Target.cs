using UnrealBuildTool;

public class FPWL_ProjetTarget : TargetRules
{
	public FPWL_ProjetTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FPWL_Projet");
	}
}
