using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libATMHudSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, SmartLink = true, Frameworks="AudioToolbox QuartzCore CoreGraphics")]
[assembly: LinkerSafe]