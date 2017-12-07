﻿using System;

using UIKit;

namespace BMICalculator
{
	public partial class ViewController : UIViewController
	{
		float num1;
		float num2;
		float result;
		float calculate;
		float squared;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.



			buttonCalculate.TouchUpInside += ButtonCalculate_TouchUpInside;


		}

		void ButtonCalculate_TouchUpInside(object sender, EventArgs e)
		{
			num1 = float.Parse(txtWeight.Text);
			num2 = float.Parse(txtHeight.Text);
			squared = num2 * num2;
		
			result = num1 / squared;

			if (result >= 25)
			{
				labelResult.TextColor = UIColor.Red;
			}
			else
			{
				labelResult.TextColor = UIColor.Green;
			}

			labelResult.Text = result.ToString();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
