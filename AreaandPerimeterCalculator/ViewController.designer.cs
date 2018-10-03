// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AreaandPerimeterCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextFieldCell lbAreaC { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell lbAreaR { get; set; }

		[Outlet]
		AppKit.NSTextField lbAreaS { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell lbPeriC { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell lbPeriR { get; set; }

		[Outlet]
		AppKit.NSTextField lbPeriS { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell txtBaseR { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell txtBaseS { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell txtHeightR { get; set; }

		[Outlet]
		AppKit.NSTextField txtRadius { get; set; }

		[Action ("btnClick:")]
		partial void btnClick (Foundation.NSObject sender);

		[Action ("btnClickR:")]
		partial void btnClickR (Foundation.NSObject sender);

		[Action ("btnClickS:")]
		partial void btnClickS (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtRadius != null) {
				txtRadius.Dispose ();
				txtRadius = null;
			}

			if (lbAreaC != null) {
				lbAreaC.Dispose ();
				lbAreaC = null;
			}

			if (lbPeriC != null) {
				lbPeriC.Dispose ();
				lbPeriC = null;
			}

			if (txtBaseS != null) {
				txtBaseS.Dispose ();
				txtBaseS = null;
			}

			if (lbAreaS != null) {
				lbAreaS.Dispose ();
				lbAreaS = null;
			}

			if (lbPeriS != null) {
				lbPeriS.Dispose ();
				lbPeriS = null;
			}

			if (txtBaseR != null) {
				txtBaseR.Dispose ();
				txtBaseR = null;
			}

			if (txtHeightR != null) {
				txtHeightR.Dispose ();
				txtHeightR = null;
			}

			if (lbAreaR != null) {
				lbAreaR.Dispose ();
				lbAreaR = null;
			}

			if (lbPeriR != null) {
				lbPeriR.Dispose ();
				lbPeriR = null;
			}
		}
	}
}
