// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TuDuShareDemo
{
	[Register ("DemoTableViewCell")]
	partial class DemoTableViewCell
	{
		[Outlet]
		UIKit.UIImageView cellImageView { get; set; }

		[Outlet]
		UIKit.UILabel cellLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (cellLabel != null) {
				cellLabel.Dispose ();
				cellLabel = null;
			}

			if (cellImageView != null) {
				cellImageView.Dispose ();
				cellImageView = null;
			}
		}
	}
}
