using System;
using System.Drawing;

using Foundation;
using UIKit;
using System.Collections.Generic;

namespace TuDuShareDemo
{
	public partial class TuDuShareDemoViewController : UIViewController
	{
		public TuDuShareDemoViewController (IntPtr handle) : base (handle)
		{
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Create mockup data
			List<Dictionary<string, string>> list = new List<Dictionary<string, string>> ();
			for (int i = 0; i < 20; i++) {
				var item = new Dictionary<string, string> ();
				item.Add ("label", "Item " + i);
				item.Add ("image", "photo.jpg");
				list.Add (item);
			}

			// Add list data to DemoTableViewSource
			demoTableView.Source = new DemoTableViewSource (list);
		}

		#endregion
	}
}

