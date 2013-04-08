using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

// CorePlot cannot use smart linking, since it requires -force_load: http://code.google.com/p/core-plot/issues/detail?id=154
[assembly: LinkWith ("libCorePlot-CocoaTouch.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, Frameworks = "CoreGraphics QuartzCore", ForceLoad = true, SmartLink = false, IsCxx = true)]
[assembly: LinkerSafe]
