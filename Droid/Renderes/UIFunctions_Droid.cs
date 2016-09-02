using System;
using Android.Widget;
using LifeCycleExample.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(UIFunctions_Droid))]
namespace LifeCycleExample.Droid
{
    public class UIFunctions_Droid : IUIFunctions
    {
        public UIFunctions_Droid()
        {
        }

        public void Alert(string message)
        {
            Toast.MakeText(Forms.Context, message, ToastLength.Short).Show();
        }

        public void Alert(string message, string title, string okButtonText, string cancelButtonText)
        {
            throw new NotImplementedException();
        }
    }
}

