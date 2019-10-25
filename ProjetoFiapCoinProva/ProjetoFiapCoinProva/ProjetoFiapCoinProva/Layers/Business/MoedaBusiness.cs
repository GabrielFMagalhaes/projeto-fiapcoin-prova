using ProjetoFiapCoinProva.Layers.Data;
using ProjetoFiapCoinProva.Layers.Service;
using ProjetoFiapCoinProva.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFiapCoinProva.Layers.Business
{
    public class MoedaBusiness
    {
        public IList<MoedaModel> GetAll()
        {
            return new MoedaData().GetAll();
        }

        public void InsertAll(IList<MoedaModel> _moedas)
        {
            new MoedaData().InsertAll(_moedas);
        }
        public void DropTable()
        {
            new MoedaData().DropTable();
        }
    }
}
