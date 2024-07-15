// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class ProudNet : ModuleRules
{
	public ProudNet(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        string rootDirectory = thirdPartyRootDirectory();

        PublicIncludePaths.AddRange(
			new string[] {
                Path.Combine(ModuleDirectory, rootDirectory, "include")
            }
			);
				
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
                "Core",
                "CoreUObject",
                "Engine",
                "Projects"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicDefinitions.Add("UNICODE");
            PublicDefinitions.Add("_UNICODE");
            // Add the import library
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, rootDirectory, "lib", "x64", "v140", "Release", "ProudNetClient.lib"));
        }
        else if (Target.Platform == UnrealTargetPlatform.IOS)
        {
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, rootDirectory, "lib", "IOS", "LLVM", "arm64only", "Release", "libProudNetClient.a"));
            //IOS�� ��� libiconv.2.tbd ���̺귯���� ��θ� �߰������� ������ �־�� �մϴ�.(������ ���� ������ ���� �� iconv ���� ��ũ ���� �߻�)
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, rootDirectory, "lib", "IOS", "LLVM", "arm64only", "Release", "libiconv.2.tbd"));
        }
        else if (Target.Platform == UnrealTargetPlatform.Android)
        {
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, rootDirectory, "lib", "NDK", "r20", "cmake", "clangRelease", "arm64-v8a", "libProudNetClient.a"));
        }
        else if (Target.Platform == UnrealTargetPlatform.Linux)
        {
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, rootDirectory, "lib", "x86_x64-linux", "Release" , "libProudNetClient.a"));
        }
    }

    private string thirdPartyRootDirectory()
    {
        return Path.Combine(ModuleDirectory, "../ThirdParty/ProudNetLibrary");
    }
}
 