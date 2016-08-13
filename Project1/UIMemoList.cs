using Foundation;
using System;
using UIKit;
using System.IO;

namespace Project1
{
    public partial class UIMemoList : UITableViewController
    {
		public int seguedata;
		public string status;
		public string[] data;
		UITableView table;
        public UIMemoList (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			LoadData();
			table = this.TableView;
			table.Source = new TableSource(data,this);
			TableDelegate tableDelegate;

			//tableDelegate = new TableDelegate();

			//table.Delegate = tableDelegate;


		}
		void LoadData() {
			
			string document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string filename = Path.Combine(document, Title+".txt");

			if (File.Exists(filename))
			{

				//string linedata = "";
				//int i = 0;
				data=File.ReadAllLines(filename);
			}
		}
		[Action("UIEdit:")]
		public void UnwindToMemo(UIStoryboardSegue segue)
		{
			LoadData();
			table = this.TableView;
			table.Source = new TableSource(data, this);
			
		}
		public void setdata(int data)
		{
			seguedata = data;
		}
		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			var controller = (UIEdit)segue.DestinationViewController;
			controller.list = this;

		}

		partial void UIBarButtonItem2435_Activated(UIBarButtonItem sender)
		{
		}


	}
}