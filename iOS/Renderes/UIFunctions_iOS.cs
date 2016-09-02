using System;
using LifeCycleExample.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(UIFunctions_iOS))]

namespace LifeCycleExample.iOS
{
    public class UIFunctions_iOS : IUIFunctions
    {
        public UIFunctions_iOS()
        {
        }

        public void Alert(string message)
        {
            throw new NotImplementedException();
        }

        public void Alert(string message, string title, string okButtonText, string cancelButtonText)
        {
            var alert = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);

            if (!string.IsNullOrEmpty(cancelButtonText))
                alert.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, (obj) => {}));

            if (!string.IsNullOrEmpty(okButtonText))
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (obj) => { }));
        }
    }
}

