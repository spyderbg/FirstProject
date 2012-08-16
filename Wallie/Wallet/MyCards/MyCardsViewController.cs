
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class MyCardsViewController : UIViewController
	{
		#region View life cycle 

		public MyCardsViewController() : base( "MyCardsViewController", null ) {}
		public MyCardsViewController( IntPtr ptr ) : base( ptr ) {}
		public MyCardsViewController( NSCoder coder ) : base( coder ) {}

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

