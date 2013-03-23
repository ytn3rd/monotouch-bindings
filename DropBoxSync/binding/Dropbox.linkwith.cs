using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("Dropbox.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, SmartLink = true, Frameworks = "CFNetwork Security SystemConfiguration QuartzCore")]
[assembly: LinkerSafe]
