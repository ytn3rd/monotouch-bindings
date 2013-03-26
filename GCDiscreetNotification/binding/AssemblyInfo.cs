using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libGCDiscreetNotificationView.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, SmartLink = true, Frameworks = "CoreGraphics")]
[assembly: LinkerSafe]