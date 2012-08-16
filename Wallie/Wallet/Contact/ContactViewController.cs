
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class ContactViewController : UIViewController
	{
		#region View life cycle 

		public ContactViewController() : base( "ContactViewController", null ) {}
		public ContactViewController( IntPtr ptr ) : base( ptr ) {}
		public ContactViewController( NSCoder coder ) : base( coder ) {}

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

