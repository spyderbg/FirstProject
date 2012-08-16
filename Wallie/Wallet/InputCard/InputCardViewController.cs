
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class InputCardViewController : UIViewController
	{
		#region View life cycle 

		public InputCardViewController() : base( "InputCardViewController", null ) {}
		public InputCardViewController( IntPtr ptr ) : base( ptr ) {}
		public InputCardViewController( NSCoder coder ) : base( coder ) {}

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

