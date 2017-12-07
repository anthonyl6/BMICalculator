// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BMICalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonCalculate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelWeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtWeight { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonCalculate != null) {
                buttonCalculate.Dispose ();
                buttonCalculate = null;
            }

            if (labelHeight != null) {
                labelHeight.Dispose ();
                labelHeight = null;
            }

            if (labelResult != null) {
                labelResult.Dispose ();
                labelResult = null;
            }

            if (labelWeight != null) {
                labelWeight.Dispose ();
                labelWeight = null;
            }

            if (txtHeight != null) {
                txtHeight.Dispose ();
                txtHeight = null;
            }

            if (txtWeight != null) {
                txtWeight.Dispose ();
                txtWeight = null;
            }
        }
    }
}