using ProjetoFiapCoinProva.Model;
using ProjetoFiapCoinProva.Layers.Service;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoFiapCoinProva.ViewModel
{
    public class MoedaViewModel
    {
        public MoedaViewModel()
        {
            moedasSelecionadas = new List<MoedaModel>();
            ListaMoedas = new MoedaService().Get();

            //Filtro de moedas -> Filtro de filmes
            //No exemplo de Filmes, serão exibidos 10 filmes
            //Aqui eu exibo somente 2 moedas
            filtrarMaximoMoedas();
            EntrarClickedCommand = new Command(() => {
                try
                {
                    //if(moedasSelecionadas.Count == 3)
                    //{
                        MessagingCenter.Send(ListaMoedas, "MoedasSelecionadasPageAbrir");
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });

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

        private IList<MoedaModel> moedasSelecionadas;
        private MoedaModel _moedaSeleciona;
        public MoedaModel MoedaSelecionada
        {
            get
            {
                //moedasSelecionadas.Remove(_moedaSeleciona);
                return _moedaSeleciona;
            }
            set
            {
                /*if (value != null)
                {
                    if(moedasSelecionadas.Count <= 0)
                    {
                        moedasSelecionadas.Add(value);
                    }
                    else
                    {
                        bool encontrouParecido = false;
                        foreach (MoedaModel moeda in moedasSelecionadas)
                        {
                            if (moeda.IdMoeda == value.IdMoeda)
                            {
                                encontrouParecido = true;
                            }
                        }

                        if(!encontrouParecido)
                        {
                            moedasSelecionadas.Add(value);
                        } else
                        {
                            moedasSelecionadas.Remove(_moedaSeleciona);
                        }
                    }
                    
                }*/
            }
        }
        public ICommand EntrarClickedCommand { get; private set; }

        private void filtrarMaximoMoedas()
        {
            IList<MoedaModel> moedas = new List<MoedaModel>();


            //Adicionei em uma variavel auxiliar, de forma desorganizada, somente
            //para poder rankear por cotação do dolar futuramente.
            moedas.Add(listaMoedas[2]);
            moedas.Add(listaMoedas[1]);
            ListaMoedas = moedas;
           
        }
    }
}
