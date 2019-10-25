using ProjetoFiapCoinProva.Model;
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
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
            this.Detail = new NavigationPage(new MoedaPage());

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<MoedaPage>(this,
                    "MoedaPageAbrir",
                    (sender) =>
                    {
                        this.Detail = new NavigationPage(new MoedaPage());
                        this.IsPresented = false;
                    });

            MessagingCenter.Subscribe<IList<MoedaModel>>(this, "MoedasSelecionadasPageAbrir",
                 (sender) =>
                 {
                     Global.MoedasRank = sender;
                     this.Detail.Navigation.PushAsync(new MoedasPage());
                 });

            MessagingCenter.Subscribe<IList<MoedaModel>>(this, "MoedasRankPageAbrir",
              (sender) =>
              {
                  this.Detail.Navigation.PushAsync(new MoedasRankPage());
              });

            MessagingCenter.Subscribe<MoedaModel>(this, "MoedaDetalheAbrir",
              (sender) =>
              {
                  Global.MoedaDetalhe = sender;
                  this.Detail.Navigation.PushAsync(new MoedaDetalhe());
              });
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MoedaPage>(this, "MoedaPageAbrir");

        }
    }
}