using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShellBug.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_One : ContentPage
    {
        public Page_One()
        {
            InitializeComponent();
        }
    }
}