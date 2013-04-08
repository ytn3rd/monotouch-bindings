using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("GoogleMaps", LinkTarget.Simulator | LinkTarget.ArmV7,"-ObjC -lz -licucore -lc++", Frameworks = "AVFoundation CoreData CoreLocation CoreText GLKit ImageIO OpenGLES QuartzCore SystemConfiguration", ForceLoad = true, SmartLink = true)]
[assembly: LinkerSafe]
