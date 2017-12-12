using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class detailsViewControllerResult : UIViewController
    {
        public float num1;
		public float num2;
		public float result;

	
		public detailsViewControllerResult (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			
            labelDetailsResult.Text = num1.ToString() + " / " + num2.ToString() + "²" + " = " + result.ToString();

        }
    }
}