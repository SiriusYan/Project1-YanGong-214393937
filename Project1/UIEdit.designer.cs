// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Project1
{
    [Register ("UIEdit")]
    partial class UIEdit
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField MemoDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView MemoHappend { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField MemoTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField MemoTitle { get; set; }

        [Action ("UIButton2378_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton2378_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (MemoDate != null) {
                MemoDate.Dispose ();
                MemoDate = null;
            }

            if (MemoHappend != null) {
                MemoHappend.Dispose ();
                MemoHappend = null;
            }

            if (MemoTime != null) {
                MemoTime.Dispose ();
                MemoTime = null;
            }

            if (MemoTitle != null) {
                MemoTitle.Dispose ();
                MemoTitle = null;
            }
        }
    }
}