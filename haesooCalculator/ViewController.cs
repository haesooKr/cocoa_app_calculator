using System;

using AppKit;
using Foundation;

namespace haesooCalculator
{
    public partial class ViewController : NSViewController
    {
        public int Result = 0;
        public bool isNewNum = true;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            Console.WriteLine("Running");
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void BtnNum(NSObject sender)
        {
            NSButton numButton = (NSButton)sender;
            SetNum(numButton.Title);
        }

        partial void BtnPlus(NSObject sender)
        {
            int num = int.Parse(NumDisplay.StringValue);
            Result = Result + num;
            NumDisplay.StringValue = Result.ToString();
            isNewNum = true;
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumDisplay.StringValue = num;
                isNewNum = false;
            } else if (NumDisplay.StringValue == "0")
            {
                NumDisplay.StringValue = num;
            } else
            {
                NumDisplay.StringValue += num;
            }
        }

        public int Plus(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Minus(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
