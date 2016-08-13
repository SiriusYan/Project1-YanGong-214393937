using System;
using System.Collections.Generic;
using System.IO;
using Foundation;
using UIKit;
namespace Project1
{
	public class TableDelegate:UITableViewDelegate
	{
		public TableDelegate()
		{
		}
		public TableDelegate(IntPtr handle) : base(handle)
		{
		}

		public TableDelegate(NSObjectFlag t) : base(t)
		{
		}
		public override UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewRowAction hiButton = UITableViewRowAction.Create(
				UITableViewRowActionStyle.Default,
				"Delete",
				delegate
				{
					
				});
			return new UITableViewRowAction[] { hiButton };
		}
	}
}

