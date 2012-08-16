
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class MainViewController : UIViewController
	{
		#region View life cycle 

		public MainViewController() : base( "MainViewController", null ) {}
		public MainViewController( IntPtr ptr ) : base( ptr ) {}
		public MainViewController( NSCoder coder ) : base( coder ) {}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning( );
		}
		
		public override void ViewDidLoad()
		{
 			base.ViewDidLoad();

			this.View.AddSubview( this.tabBarController.View );
		}
		
		public override void ViewDidUnload()
		{
			base.ViewDidUnload( );
			ReleaseDesignerOutlets( );
		}
		
		#endregion
	}
}

