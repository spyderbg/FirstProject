// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Wallie
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITabBarController tabBarController { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tabBarController != null) {
				tabBarController.Dispose ();
				tabBarController = null;
			}
		}
	}
}
