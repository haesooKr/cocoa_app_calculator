// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace haesooCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSImageView LogoImage { get; set; }

		[Outlet]
		AppKit.NSTextField NumDisplay { get; set; }

		[Action ("BtnClear:")]
		partial void BtnClear (Foundation.NSObject sender);

		[Action ("BtnEqual:")]
		partial void BtnEqual (Foundation.NSObject sender);

		[Action ("BtnNum:")]
		partial void BtnNum (Foundation.NSObject sender);

		[Action ("BtnOperator:")]
		partial void BtnOperator (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (LogoImage != null) {
				LogoImage.Dispose ();
				LogoImage = null;
			}

			if (NumDisplay != null) {
				NumDisplay.Dispose ();
				NumDisplay = null;
			}
		}
	}
}
