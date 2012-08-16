
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class ScanCardViewController : UIViewController
	{
		#region View life cycle 

		public ScanCardViewController() : base( "ScanCardViewController", null ) {}
		public ScanCardViewController( IntPtr ptr ) : base( ptr ) {}
		public ScanCardViewController( NSCoder coder ) : base( coder ) {}

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

