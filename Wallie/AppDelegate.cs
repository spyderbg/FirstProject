using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		protected virtual UIWindow CreateFullScreenWindow()
		{
			return new UIWindow( UIScreen.MainScreen.Bounds );
		}

		protected virtual UIViewController CreateMainViewController()
		{
			Application.MainViewController = new MainViewController();
			return Application.MainViewController;
		}

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication application, NSDictionary launcOptions)
		{
			Application.Window = CreateFullScreenWindow();
		
//			UIViewController vc = null;
//			
//			if (vc != null)
//			{
//				Application.ViewController = vc;
//				Application.Window.AddSubview(vc.View);
//				Application.Window.MakeKeyAndVisible();
//				
//				return true; 
//			}
			
			if( CreateMainViewController() == null )
			{
				Console.WriteLine( "ERROR: root view controller has not been loaded successfully" );
				return false;
			}				
			
			Application.ViewController = Application.MainViewController;

			Application.Window.AddSubview( Application.ViewController.View );			
			Application.Window.MakeKeyAndVisible();
					
			return true;
		}
	}
}

