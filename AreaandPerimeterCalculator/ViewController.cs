using System;

using AppKit;
using Foundation;

namespace AreaandPerimeterCalculator
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

        partial void btnClick(Foundation.NSObject sender)
        {
            double r, a, p;
            string A, P;

            try {
                r = Convert.ToDouble(txtRadius.StringValue);

                if(r > 150) {
                    var alert = new NSAlert();
                    alert.MessageText = "Error";
                    alert.InformativeText = "Data input must be less than 150";
                    alert.RunModal();
                }
                else {
                    a = Math.PI * (r * r);
                    p = Math.PI * (2 * r);

                    a = Math.Round(a, 2);
                    p = Math.Round(p, 2);

                    A = Convert.ToString(a);
                    P = Convert.ToString(p);

                    lbAreaC.StringValue = A;
                    lbPeriC.StringValue = P;
                }
            }
            catch {
                var alert = new NSAlert();

                alert.MessageText = "Error";
                alert.InformativeText = "Invalid Input";
                alert.RunModal();
            }
        }
        partial void btnClickS(Foundation.NSObject sender)
        {
            double b, a, p;
            string A, P;

            try {
                b = Convert.ToDouble(txtBaseS.StringValue);

                if(b > 150) {
                    var alert = new NSAlert();
                    alert.MessageText = "Error";
                    alert.InformativeText = "Data input must be less than 150.";
                    alert.RunModal();
                }
                else {
                    a = b * b;
                    p = 4 * b;

                    a = Math.Round(a, 2);
                    p = Math.Round(p, 2);

                    A = Convert.ToString(a);
                    P = Convert.ToString(p);

                    lbAreaS.StringValue = A;
                    lbPeriS.StringValue = P;
                }
            }
            catch {
                var alert = new NSAlert();
                alert.MessageText = "Error";
                alert.InformativeText = "Invalid Input.";
                alert.RunModal();
            }
        }
        partial void btnClickR(Foundation.NSObject sender)
        {
            double b, l, a, p;
            string A, P;

            try {
                b = Convert.ToDouble(txtBaseR.StringValue);

                if (b > 150) {
                    var alert = new NSAlert();
                    alert.MessageText = "Error";
                    alert.InformativeText = "Base length must be less than 150.";
                    alert.RunModal();
                }
                else {
                    try {
                        l = Convert.ToDouble(txtHeightR.StringValue);

                        if(l > 150) {
                            var alert = new NSAlert();
                            alert.MessageText = "Error";
                            alert.InformativeText = "Height must be less than 150.";
                            alert.RunModal();
                        }
                        else {
                            a = b * l;
                            p = (2 * b) + (2 * l);

                            a = Math.Round(a, 2);
                            p = Math.Round(p, 2);

                            A = Convert.ToString(a);
                            P = Convert.ToString(p);

                            lbAreaR.StringValue = A;
                            lbPeriR.StringValue = P;
                        }
                    }
                    catch {
                        var alert = new NSAlert();
                        alert.MessageText = "Error";
                        alert.InformativeText = "Invalid Input.";
                        alert.RunModal();
                    }
                }
            }
            catch {
                var alert = new NSAlert();
                alert.MessageText = "Error";
                alert.InformativeText = "Invalid Input.";
                alert.RunModal();
            }
        }
    }
}
