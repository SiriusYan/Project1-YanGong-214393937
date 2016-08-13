using Foundation;
using System;
using UIKit;
using System.IO;

namespace Project1
{
	public partial class UIEdit : UIViewController
	{
		string[] getdata;
		public UIMemoList list;
		public UIEdit(IntPtr handle) : base(handle)
		{

		}
		public UIEdit()
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MemoHappend.Layer.BorderColor = UIColor.Black.CGColor;
			MemoHappend.Layer.BorderWidth = 1;

			if (list.status == "alter")
			{
				getdata = list.data[list.seguedata].Split(',');

				MemoTitle.Text = getdata[0];
				MemoHappend.Text = getdata[1];
				MemoDate.Text = getdata[2];
				MemoTime.Text = getdata[3];
			}
			else {
				MemoTitle.Text = "";
				MemoHappend.Text = "";
				MemoDate.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
				MemoTime.Text = DateTime.Now.Hour.ToString() +":"+ DateTime.Now.Minute.ToString();

			}

		}

		partial void UIButton2378_TouchUpInside(UIButton sender)
		{
			string title = MemoTitle.Text;
			string memohappen = MemoHappend.Text;
			string date = MemoDate.Text;
			string time = MemoTime.Text;

			SaveData(title, memohappen, date, time);

		}
		void SaveData(string title, string memohappend, string date, string time)
		{
			string data = "";
			var document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string filename = Path.Combine(document, date+".txt");
			data += title;
			data += ",";
			data += memohappend;
			data += ",";
			data += date;
			data += ",";
			data += time;
			data += "\n";
			if (list.status == "alter")
			{
				{
					//File.Delete(filename);
					string dataset = "";

					for (int i = 0; i < list.data.Length; i++)
					{
						if (i == list.seguedata)
						{
							dataset += data;
						}
						else {
							dataset += list.data[i];
							dataset += "\n";
						}
					}
					File.WriteAllText(filename, dataset);

				}

			}
			else { File.AppendAllText(filename, data); }

		}
	}
}