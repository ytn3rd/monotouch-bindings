using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libdtipl.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, SmartLink = true, LinkerFlags = "-lxml2")]
[assembly: LinkerSafe]
