using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using PropertyChanged;
using System.ComponentModel;

namespace LifeCycleExample
{
    [ImplementPropertyChanged]
    public class HomePageViewModel 
    {
        public string LabelPresentation { get; } = "Fala Galera!";

        public string LabelClickCount { get; set;} = "0";

        public Command ClickCommand
        {
            get
            {
                return new Command(async (obj) => await Count());
            }
        }

        private int _count { get; set; }

        public HomePageViewModel()
        {
        }

        public async Task Count()
        {
            LabelClickCount = _count++.ToString();
        }
    }
}

