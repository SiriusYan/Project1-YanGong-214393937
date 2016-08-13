using System;
using System.IO;
using UIKit;

namespace Project1
{
	public partial class ViewController : UIViewController
	{
		string seguedata = "";
		string date;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.

		}

		public ViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton2781_TouchUpInside(UIButton sender)
		{
			date = "2.7.2016";
		}

		partial void Btn1_TouchUpInside(UIButton sender)
		{
			date =  "1.7.2016";
		}



		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			var controller = (UIMemoList)segue.DestinationViewController;
			controller.Title = date;

		}
	}
}

