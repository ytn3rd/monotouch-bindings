using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libTouchDB.a", LinkTarget.ArmV7 | LinkTarget.Simulator, LinkerFlags = "-lz -lsqlite3", Frameworks = "SystemConfiguration CFNetwork", ForceLoad = true, SmartLink = true)]
[assembly: LinkerSafe]
