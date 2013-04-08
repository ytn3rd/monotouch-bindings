using System;
using MonoTouch.ObjCRuntime;

// libSDWebImage.a requires -force_load: http://stackoverflow.com/questions/8504953/sdwebimage-setimagewithurl-fails-when-used-to-set-image-of-a-uitableviewcell
[assembly: LinkWith ("libSDWebImage.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, SmartLink = false, Frameworks = "CoreGraphics ImageIO")]
// the LinkerSafe attribute is already in libarclite.linkwith.cs