
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class FAQViewController : UIViewController
	{
		#region View life cycle 

		public FAQViewController() : base( "FAQViewController", null ) {}
		public FAQViewController( IntPtr ptr ) : base( ptr ) {}
		public FAQViewController( NSCoder coder ) : base( coder ) {}

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

