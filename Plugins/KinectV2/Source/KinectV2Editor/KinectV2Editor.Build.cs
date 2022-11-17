using UnrealBuildTool;
//IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
//UE_ENABLE_INCLUDE_ORDER_DEPRECATED_IN_501


public class KinectV2Editor : ModuleRules
{
    public KinectV2Editor(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateIncludePaths.Add("KinectV2Editor/Private");

        PublicIncludePaths.Add("KinectV2Editor/Public");

        PublicDependencyModuleNames.AddRange(
            new string[] { 
				"Core", 
				"CoreUObject", 
				"Engine", 
				"Slate",
				"BlueprintGraph",
                "AnimGraph",
                "AnimGraphRuntime",
                "KinectV2"
			}
        );

        PrivateDependencyModuleNames.AddRange(
            new string[] {
				"SlateCore",
				"UnrealEd",
                "GraphEditor",
			}
        );

        /*CircularlyReferencedDependentModules.AddRange(
            new string[] {
                "UnrealEd",
                "GraphEditor",
            }
        ); */

    }
}