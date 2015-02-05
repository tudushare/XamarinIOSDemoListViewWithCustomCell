using System;
using UIKit;
using System.Collections.Generic;

namespace TuDuShareDemo
{
	public class DemoTableViewSource : UITableViewSource
	{
		List<Dictionary<string, string>> list;

		public DemoTableViewSource (List<Dictionary<string, string>> list)
		{
			this.list = list;
		}

		#region implemented abstract members of UITableViewSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (DemoTableViewCell.Key) as DemoTableViewCell;

			var item = list [indexPath.Row];
			cell.Populate (item);

			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return list.Count;
		}

		#endregion
	}
}

