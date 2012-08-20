using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;

namespace ZBar
{
	[BaseType (typeof(UIViewController))]
	interface ZBarReaderViewController
	{
		[Export ("readerDelegate")]
		ZBarReaderDelegate ReaderDelegate { get; set; }

		[Export ("scanner")]
		ZBarImageScanner Scanner { get; set; }
	}

	[BaseType (typeof(UIImagePickerController))]
	interface ZBarReaderController
	{

	}

	[BaseType (typeof(UIImagePickerControllerDelegate))]
	interface ZBarReaderDelegate
	{
		[Export ("readerControllerDidFailToRead:withRetry:")]
		void DidFailToRead( ZBarReaderController reader, bool retry );
	}

	[BaseType (typeof(NSObject))]
	interface ZBarImageScanner
	{
		[Export ("setSymbology:config:to:")]
		void SetSymbologyConfig( int symbology, int config, int value );
	}
}
