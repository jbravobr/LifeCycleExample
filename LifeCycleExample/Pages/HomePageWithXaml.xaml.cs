using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeCycleExample
{
    public partial class HomePageWithXaml : ContentPage
    {
        public HomePageWithXaml()
        {
            BindingContext = new HomePageViewModel();
            InitializeComponent();
        }
    }
}

