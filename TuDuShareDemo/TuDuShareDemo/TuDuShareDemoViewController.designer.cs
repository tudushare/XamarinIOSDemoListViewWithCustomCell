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
	[Register ("TuDuShareDemoViewController")]
	partial class TuDuShareDemoViewController
	{
		[Outlet]
		UIKit.UITableView demoTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (demoTableView != null) {
				demoTableView.Dispose ();
				demoTableView = null;
			}
		}
	}
}
