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
    public partial class MoedaDetalhe : ContentPage
    {
        public MoedaDetalhe()
        {
            InitializeComponent();
        }
        public void VoltarClicked(object o, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}