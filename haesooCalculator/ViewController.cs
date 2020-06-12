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

        partial void Btn0(NSObject sender)
        {
            SetNum("0");
        }

        partial void Btn1(NSObject sender)
        {
            SetNum("1");
        }

        partial void Btn2(NSObject sender)
        {
            SetNum("2");
        }

        partial void Btn3(NSObject sender)
        {
            SetNum("3");
        }

        partial void Btn4(NSObject sender)
        {
            SetNum("4");
        }

        partial void Btn5(NSObject sender)
        {
            SetNum("5");
        }

        partial void Btn6(NSObject sender)
        {
            SetNum("6");
        }

        partial void Btn7(NSObject sender)
        {
            SetNum("7");
        }

        partial void Btn8(NSObject sender)
        {
            SetNum("8");
        }

        partial void Btn9(NSObject sender)
        {
            SetNum("9");
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
            if (NumDisplay.StringValue == "0")
            {
                NumDisplay.StringValue = num;
            }
            else
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
