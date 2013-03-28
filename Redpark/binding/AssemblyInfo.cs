using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libRscMgrUniv.a", LinkTarget.ArmV7 | LinkTarget.Simulator, Frameworks = "ExternalAccessory", ForceLoad = true, SmartLink = true)]
[assembly: LinkerSafe]
