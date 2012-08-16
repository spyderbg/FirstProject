
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class DealsViewController : UIViewController
	{
		#region View life cycle 

		public DealsViewController() : base( "DealsViewController", null ) {}
		public DealsViewController( IntPtr ptr ) : base( ptr ) {}
		public DealsViewController( NSCoder coder ) : base( coder ) {}
		public DealsViewController( string nibName, NSBundle bundle ) : base( nibName, bundle ) {}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning( );
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad( );
		}
		
		public override void ViewDidUnload()
		{
			base.ViewDidUnload( );
			ReleaseDesignerOutlets( );
		}
		
		#endregion
	}
}

