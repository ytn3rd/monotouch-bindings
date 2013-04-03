using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

[assembly: LinkerSafe]
[assembly: LinkWith ("libcocos2d.a",LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, SmartLink = false, Frameworks = "OpenGLES CoreGraphics QuartzCore")]
#if ENABLE_CHIPMUNK_INTEGRATION
[assembly: LinkWith ("libChipmunk.a",LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, SmartLink = false)]
#endif
