using ProjetoFiapCoinProva.Model;
using ProjetoFiapCoinProva.Layers.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoFiapCoinProva.ViewModel
{
    public class MoedasRankViewModel
    {
        public MoedasRankViewModel()
        {
            ListaMoedas = new MoedaBusiness().GetAll();
            ListaMoedas = OrdenarMoedas(ListaMoedas);
            MoedaTappedCommand = new Command(() =>
            {   try
                {
                    MessagingCenter.Send<Model.MoedaModel>(MoedaSelecionada, "MoedaDetalheAbrir");
                } 
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });

        }

        private IList<MoedaModel> OrdenarMoedas(IList<MoedaModel> listaMoedas)
        {
            try
            {
                IEnumerable<MoedaModel> sortedEnum = listaMoedas.OrderByDescending(m => m.CotacaoDolarMoeda);
                listaMoedas = sortedEnum.ToList();
                return listaMoedas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
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

        private Model.MoedaModel moedaSelecionada;
        public Model.MoedaModel MoedaSelecionada
        {
            get
            {
                return moedaSelecionada;
            }
            set
            {
                moedaSelecionada = value;
            }
        }

        public ICommand MoedaTappedCommand { get; private set; }


    }
}
