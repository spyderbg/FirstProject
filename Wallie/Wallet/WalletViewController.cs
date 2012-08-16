
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Wallie
{
	public partial class WalletViewController : UIViewController
	{
		#region View life cycle 

		public WalletViewController() : base( "WalletViewController", null ) {}
		public WalletViewController( IntPtr ptr ) : base( ptr ) {}
		public WalletViewController( NSCoder coder ) : base( coder ) {}
		public WalletViewController( string nibName, NSBundle bundle ) : base( nibName, bundle ) {}
		
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// init 
			this.NavigationItem.Title = "WALLiE";
		}
		
		public override void ViewDidUnload()
		{
			base.ViewDidUnload();
			ReleaseDesignerOutlets();
		}
		
		#endregion

		#region Actions

		partial void actionMyCards( MonoTouch.Foundation.NSObject sender )
		{
			var vc = new MyCardsViewController();
			this.NavigationController.PushViewController( vc, true );
		}

		partial void actionSend( MonoTouch.Foundation.NSObject sender )
		{
			var vc = new SendViewController();
			this.NavigationController.PushViewController( vc, true );
		}

		partial void actionInputCard( MonoTouch.Foundation.NSObject sender )
		{
			var vc = new InputCardViewController();
			this.NavigationController.PushViewController( vc, true );
		}

		partial void actionScanCard( MonoTouch.Foundation.NSObject sender )
		{
			var vc = new ScanCardViewController();
			this.NavigationController.PushViewController( vc, true );
		}

		partial void actionContact( MonoTouch.Foundation.NSObject sender )
		{
			var vc = new ContactViewController();
			this.NavigationController.PushViewController( vc, true );
		}

		partial void actionFAQ( MonoTouch.Foundation.NSObject sender )
		{
			var vc = new FAQViewController();
			this.NavigationController.PushViewController( vc, true );
		}

		#endregion
	}
}

