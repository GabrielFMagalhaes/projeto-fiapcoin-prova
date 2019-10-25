using ProjetoFiapCoinProva.Model;
using ProjetoFiapCoinProva.Layers.Business;
using ProjetoFiapCoinProva.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoFiapCoinProva.ViewModel
{
    public class MoedasSelecionadasViewModel
    {
        public MoedasSelecionadasViewModel()
        {
            ListaMoedas = Global.MoedasRank;

            EntrarClickedCommand = new Command(() => {
                try
                {
                    new MoedaBusiness().DropTable();
                    new MoedaBusiness().InsertAll(listaMoedas);
                    MessagingCenter.Send(listaMoedas, "MoedasRankPageAbrir");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }); ;

        }

        private IList<Model.MoedaModel> listaMoedas;
        public IList<Model.MoedaModel> ListaMoedas
        {
            get
            {
                return listaMoedas;
            }
            set
            {
                listaMoedas = value;
            }
        }

        public ICommand EntrarClickedCommand { get; private set; }


    }
}
