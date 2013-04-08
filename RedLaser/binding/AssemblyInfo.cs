using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkWith ("libRedLaserSDK.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, 
                     Frameworks = "AudioToolbox AVFoundation CFNetwork CoreMedia CoreVideo OpenGLES Security SystemConfiguration CoreLocation", 
                     ForceLoad = true, SmartLink = true, IsCxx = true, LinkerFlags = "-lstdc++")]
[assembly: LinkerSafe]
