// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BMICalculator
{
    [Register ("DetailsViewController")]
    partial class DetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDetailsResult { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelDetailsResult != null) {
                labelDetailsResult.Dispose ();
                labelDetailsResult = null;
            }
        }
    }
}