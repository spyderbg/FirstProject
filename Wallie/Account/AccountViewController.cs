
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class AccountViewController : UIViewController
	{
		#region View life cycle 

		public AccountViewController() : base( "AccountViewController", null ) {}
		public AccountViewController( IntPtr ptr ) : base( ptr ) {}
		public AccountViewController( NSCoder coder ) : base( coder ) {}
		public AccountViewController( string nibName, NSBundle bundle ) : base( nibName, bundle ) {}

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

