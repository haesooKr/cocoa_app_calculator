using System;

using AppKit;
using Foundation;

namespace haesooCalculator
{
    public partial class ViewController : NSViewController
    {
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
