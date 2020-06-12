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
		AppKit.NSTextField NumDisplay { get; set; }

		[Action ("Btn0:")]
		partial void Btn0 (Foundation.NSObject sender);

		[Action ("Btn1:")]
		partial void Btn1 (Foundation.NSObject sender);

		[Action ("Btn2:")]
		partial void Btn2 (Foundation.NSObject sender);

		[Action ("Btn3:")]
		partial void Btn3 (Foundation.NSObject sender);

		[Action ("Btn4:")]
		partial void Btn4 (Foundation.NSObject sender);

		[Action ("Btn5:")]
		partial void Btn5 (Foundation.NSObject sender);

		[Action ("Btn6:")]
		partial void Btn6 (Foundation.NSObject sender);

		[Action ("Btn7:")]
		partial void Btn7 (Foundation.NSObject sender);

		[Action ("Btn8:")]
		partial void Btn8 (Foundation.NSObject sender);

		[Action ("Btn9:")]
		partial void Btn9 (Foundation.NSObject sender);

		[Action ("BtnEqual:")]
		partial void BtnEqual (Foundation.NSObject sender);

		[Action ("BtnMinus:")]
		partial void BtnMinus (Foundation.NSObject sender);

		[Action ("BtnPlus:")]
		partial void BtnPlus (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (NumDisplay != null) {
				NumDisplay.Dispose ();
				NumDisplay = null;
			}
		}
	}
}
