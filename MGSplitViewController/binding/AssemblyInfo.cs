using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libMGSplitViewControllerSDK.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, Frameworks = "CoreGraphics", ForceLoad = true, SmartLink = true)]
[assembly: LinkerSafe]
