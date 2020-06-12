using System;

using AppKit;
using Foundation;

namespace haesooCalculator
{
    public enum Operators {  None, Add, Sub, Mul, Div }

    public partial class ViewController : NSViewController
    {
        public int Result = 0;
        public int Current = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.None;

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

        partial void BtnOperator(NSObject sender)
        {
            if (!isNewNum)
            {
                Calculate(Current);
            }
            
            NSButton optButton = (NSButton)sender;
            switch (optButton.Title)
            {
                case "+":
                    Opt = Operators.Add;
                    break;
                case "-":
                    Opt = Operators.Sub;
                    break;
                case "X":
                    Opt = Operators.Mul;
                    break;
                case "%":
                    Opt = Operators.Div;
                    break;
                default:
                    break;
            }

            Current = 0;
            NumDisplay.StringValue = Result.ToString();
            isNewNum = true;
        }

        partial void BtnEqual(NSObject sender)
        {
            isNewNum = true;
            Calculate(Current);
            NumDisplay.StringValue = Result.ToString();
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

            Current = int.Parse(NumDisplay.StringValue);
        }

        public void Calculate(int num)
        {
            switch (Opt)
            {
                case Operators.Add:
                    Result += num;
                    break;
                case Operators.Sub:
                    Result -= num;
                    break;
                case Operators.Mul:
                    Result *= num;
                    break;
                case Operators.Div:
                    Result /= num;
                    break;
                default:
                    Result += num;
                    break;
            }
        }
    }
}
