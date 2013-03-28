using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libMapView.a", LinkTarget.ArmV7 | LinkTarget.Simulator, 
                     Frameworks = "CoreFoundation CoreLocation QuartzCore UIKit Foundation CoreGraphics", 
                     LinkerFlags = "-lz -lsqlite3", ForceLoad = true, SmartLink = true, IsCxx = true)]
[assembly: LinkerSafe]
