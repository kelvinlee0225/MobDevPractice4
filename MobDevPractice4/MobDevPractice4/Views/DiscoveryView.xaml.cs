using MobDevPractice4.Models;
using MobDevPractice4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobDevPractice4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryView : ContentView
    {
        public DiscoveryView()
        {
            InitializeComponent();
            BindingContext = new MenuOption();
        }
    }
}