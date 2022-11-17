// Copyright 1998-2014 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;
using System.Text;


public class K4WLib : ModuleRules
{
    public K4WLib(ReadOnlyTargetRules Target) : base(Target)
    {
        Type = ModuleType.External;
        string SDKDIR = Utils.ResolveEnvironmentVariable("%KINECTSDK20_DIR%");        
        SDKDIR = SDKDIR.Replace("\\", "/");
        string BaseDirectory = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
        string RedistDirectory = Path.Combine(BaseDirectory, "ThirdParty", "Redist");       
        PublicIncludePaths.Add(Path.Combine(SDKDIR, "inc"));
        //PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "inc"));
        //string LibPath =  "C:\Program Files\Microsoft SDKs\Kinect\v2.0_1409"
        //PublicAdditionalLibraries.Add(Path.Combine(SDKDIR, "Lib", "x64"));
        PublicAdditionalLibraries.Add(Path.Combine(SDKDIR, "Lib", "x64", "Kinect20.lib"));
        //PublicAdditionalLibraries.AddRange(new string[]{"Kinect20.lib"});
        PublicDelayLoadDLLs.AddRange(new string[] {"Kinect20.dll"});         
        
    }
}