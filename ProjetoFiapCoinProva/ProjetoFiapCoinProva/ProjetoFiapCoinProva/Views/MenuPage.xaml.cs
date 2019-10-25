using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFiapCoinProva.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

        }
        public void MoedaClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<MoedaPage>(new MoedaPage(), "MoedaPageAbrir");
        }
    }
}