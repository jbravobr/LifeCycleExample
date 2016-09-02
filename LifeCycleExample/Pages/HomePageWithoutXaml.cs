using System;

using Xamarin.Forms;

namespace LifeCycleExample
{
    public class HomePageWithoutXaml : ContentPage
    {
        HomePageViewModel vm { get; set; }

        public HomePageWithoutXaml()
        {
            BindingContext = vm = new HomePageViewModel();


            var lblClickCount = new Label();
            lblClickCount.SetBinding(Label.TextProperty, new Binding("LabelClickCount"));
            lblClickCount.Margin = 20;
            lblClickCount.TextColor = Color.Red;
            lblClickCount.HorizontalOptions = LayoutOptions.CenterAndExpand;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = vm.LabelPresentation, Margin=20},
                    lblClickCount,
                    new Button { Text="Cliquei Aqui e veja a mágica acontecer!", Command = vm.ClickCommand}
                },
                Margin = 50,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}


