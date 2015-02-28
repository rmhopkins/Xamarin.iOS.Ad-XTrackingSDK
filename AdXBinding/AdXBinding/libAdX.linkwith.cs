using System;
using ObjCRuntime;

[assembly: LinkWith ("libAdX.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
