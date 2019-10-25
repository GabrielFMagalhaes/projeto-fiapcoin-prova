using System;
using System.Collections.Generic;
using System.Windows.Input;
using ProjetoFiapCoinProva.Model;
using ProjetoFiapCoinProva.Layers.Service;
using ProjetoFiapCoinProva.Views.Components;
using Xamarin.Forms;

namespace ProjetoFiapCoinProva.ViewModel
{
    public class MoedaDetalheViewModel
    {

        public MoedaDetalheViewModel()
        {
            int id = Global.MoedaDetalhe.IdMoeda;
            Moeda = new MoedaService().GetById(id);
            // Criando o Grafico
            Grafico = GerarGraficoPizza();
        }


        public MoedaDetalheViewModel(Model.MoedaModel _moeda)
        {
            Moeda = _moeda;
        }

        private Model.MoedaModel moeda;
        public Model.MoedaModel Moeda
        {
            get
            {
                return moeda;
            }
            set
            {
                moeda = value;
            }
        }

        private OxyPlot.PlotModel GerarGraficoPizza()
        {
            //CONFIGURACAO
            var valores = new OxyPlot.Series.PieSeries();
            valores.Stroke = OxyPlot.OxyColors.White;
            valores.StrokeThickness = 1.0;
            valores.Diameter = 1.0;
            valores.InnerDiameter = 0.0;
            valores.StartAngle = 90.0;
            valores.AngleSpan = 360.0;
            valores.AngleIncrement = 1.0;
            valores.OutsideLabelFormat = "{2:0} %";
            valores.InsideLabelFormat = "{1}";
            valores.TickDistance = 0.5;
            valores.TickRadialLength = 6;
            valores.TickHorizontalLength = 1;
            valores.TickLabelDistance = 1;
            valores.InsideLabelPosition = 0.5;
            valores.FontSize = 12;


            valores.Slices.Add(
                new OxyPlot.Series.PieSlice("Cotação Real", Moeda.CotacaoRealMoeda));
            valores.Slices.Add(
                new OxyPlot.Series.PieSlice("Cotação Dolar", Moeda.CotacaoDolarMoeda));


            // ADICIONANDO OS VALORES NO GRÁFICO
            var plotModel = new OxyPlot.PlotModel();
            plotModel.IsLegendVisible = true;
            plotModel.Series.Add(valores);


            return plotModel;
        }
        private OxyPlot.PlotModel grafico;
        public OxyPlot.PlotModel Grafico
        {
            get
            {
                return grafico;
            }
            set
            {
                grafico = value;
            }
        }
    }
}
