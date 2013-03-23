using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libFlurry.a", LinkTarget.Simulator | LinkTarget.ArmV7,Frameworks = "SystemConfiguration", ForceLoad = true, SmartLink = true)]
[assembly: LinkerSafe]