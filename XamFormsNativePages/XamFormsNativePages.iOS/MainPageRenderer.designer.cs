// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamFormsNativePages.iOS
{
    [Register ("MainPageRenderer")]
    partial class MainPageRenderer
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button { get; set; }

        [Action ("ButtonPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonPressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (button != null) {
                button.Dispose ();
                button = null;
            }
        }
    }
}