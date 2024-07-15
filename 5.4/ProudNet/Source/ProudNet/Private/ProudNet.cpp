// Copyright Epic Games, Inc. All Rights Reserved.

#include "ProudNet.h"
#include "Misc/MessageDialog.h"
#include "Modules/ModuleManager.h"
#include "Interfaces/IPluginManager.h"
#include "Misc/Paths.h"
#include "HAL/PlatformProcess.h"
//#include "ProudNetLibrary/ExampleLibrary.h"

#define LOCTEXT_NAMESPACE "FProudNetModule"

void FProudNetModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module

}

void FProudNetModule::ShutdownModule()
{
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FProudNetModule, ProudNet)
