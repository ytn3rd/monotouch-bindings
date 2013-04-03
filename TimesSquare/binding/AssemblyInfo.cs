using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libTimesSquare.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, SmartLink = true, Frameworks = "CoreGraphics")]
[assembly: LinkerSafe]
