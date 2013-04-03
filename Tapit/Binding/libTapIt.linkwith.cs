using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libTapIt.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, SmartLink = false, Frameworks = "CoreGraphics CoreTelephony QuartzCore SystemConfiguration")]
[assembly: LinkerSafe]
