using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libMTSCRA.a", LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Thumb, "-lc++", Frameworks = "AudioToolbox CoreGraphics ExternalAccessory", ForceLoad = true, SmartLink = true, IsCxx = true)]
[assembly: LinkerSafe]
