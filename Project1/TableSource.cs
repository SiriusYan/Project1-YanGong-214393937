using System;
using Foundation;
using UIKit;
using System.IO;
namespace Project1
{
	public class TableSource:UITableViewSource
	{
		string[] tableItems;
		string[] tableItems2;
		string date;
		string CellIdentifier = "TableCell";

		UIMemoList owner;
		public TableSource(string[] items,UIMemoList owner)
		{
			tableItems = items;
			this.owner = owner;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			//tableItems2 = tableItems[indexPath.Row].Split(',');
			string item = tableItems[indexPath.Row];
			//cell.TextLabel.Text = item;
			if (item != string.Empty)
			{
				tableItems2 = item.Split(',');
				cell.TextLabel.Text = tableItems2[0];
				cell.DetailTextLabel.Text = tableItems2[3];
				date = tableItems2[2];
			}
			else {
				cell.TextLabel.Text = null;

			}
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			if (tableItems == null)
			{
				return 0;
			}
		return 	tableItems.Length;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			owner.seguedata = indexPath.Row;
			owner.status = "alter";
		}
		public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		{
			switch (editingStyle)
			{
				case UITableViewCellEditingStyle.Delete:
					// remove the item from the underlying data source

					DeleteData(indexPath.Row);
					// delete the row from the table
					tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
					break;
				case UITableViewCellEditingStyle.None:
					Console.WriteLine("CommitEditingStyle:None called");
					break;
			}
		}
		public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
		{
			return true; // return false if you wish to disable editing for a specific indexPath or for all rows
		}
		public override string TitleForDeleteConfirmation(UITableView tableView, NSIndexPath indexPath)
		{   // Optional - default text is 'Delete'
			return "Delete";
		}
		void DeleteData(int index) {
			var document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string filename = Path.Combine(document, date + ".txt");
			string insertdata = "";


			string[] copyarray = tableItems;
			tableItems = new string[copyarray.Length - 1];
			int u = 0;
			for (int i = 0; i < tableItems.Length; i++)
			{
				if (i != index)
				{
					tableItems[u] = copyarray[i];
					u++;
				}
			}

			if (File.Exists(filename))
			{
				File.Delete(filename);
				for (int i = 0; i < tableItems.Length; i++)
				{
					if ((i + 1) >= tableItems.Length)
					{
						insertdata += tableItems[i];
					}
					else {
						insertdata += tableItems[i] + "\n";

					}
				}
				File.AppendAllText(filename, insertdata);

			}

		}


	}
}

