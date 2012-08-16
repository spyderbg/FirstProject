using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public class Application
	{
		#region Initialization functions
		
		public static UIWindow Window { get; set; }		
		private static UIViewController _viewController;		
		public static UIViewController ViewController
		{ 
			get { return _viewController; }
			set	{ _viewController = value; Window.RootViewController = _viewController; }
		}

		public static MainViewController MainViewController { get; set; }

		#endregion
		
		// This is the main entry point of the application.		
		private new static void Main( string[] args )
		{
			AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;

			try
			{
				UIApplication.Main( args, null, "AppDelegate" );
			}
			catch( Exception e )
			{
				Console.WriteLine( "Exception Object: " + e.ToString(), "Error");
			}
		}

		static void HandleUnhandledException (object sender, UnhandledExceptionEventArgs e)
		{
			Console.WriteLine("IsTerminating: " + e.IsTerminating + "Exception Object: " + e.ExceptionObject, "Error");
		}
	}
}
