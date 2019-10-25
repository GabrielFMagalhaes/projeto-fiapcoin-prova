using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjetoFiapCoinProva.Model
{
    public class MoedaModel : INotifyPropertyChanged
    {
        public MoedaModel()
        {

        }

        public MoedaModel(int _id, String _nome, double _cotacaoReal, double _cotacaoDolar )
        {
            this.IdMoeda = _id;
            this.NomeMoeda = _nome;
            this.CotacaoRealMoeda = _cotacaoReal;
            this.CotacaoDolarMoeda = _cotacaoDolar;
        }


        private int idMoeda;
        public int IdMoeda
        {
            get { return idMoeda; }
            set
            {
                if (idMoeda != value)
                {
                    idMoeda = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String nomeMoeda;
        public String NomeMoeda
        {
            get { return nomeMoeda; }
            set
            {
                if (nomeMoeda != value)
                {
                    nomeMoeda = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private double cotacaoRealMoeda;
        public double CotacaoRealMoeda
        {
            get { return cotacaoRealMoeda; }
            set
            {
                if (cotacaoRealMoeda != value)
                {
                    cotacaoRealMoeda = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private double cotacaoDolarMoeda;
        public double CotacaoDolarMoeda
        {
            get { return cotacaoDolarMoeda; }
            set
            {
                if (cotacaoDolarMoeda != value)
                {
                    cotacaoDolarMoeda = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
