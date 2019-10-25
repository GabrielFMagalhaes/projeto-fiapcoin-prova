using ProjetoFiapCoinProva.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFiapCoinProva.Layers.Data
{
    class MoedaData
    {
        private Config.DBConnection _dbConn;

        public MoedaData()
        {
            _dbConn = new Config.DBConnection();
            _dbConn.Connection.CreateTable<MoedaModel>();
        }


        public IList<MoedaModel> GetAll()
        {
            return _dbConn.Connection.Table<MoedaModel>().ToList();
        }


        public void InsertAll(IList<MoedaModel> _moedas)
        {
            _dbConn.Connection.InsertAll(_moedas);
        }

        public void DropTable()
        {
            _dbConn.Connection.DropTable<Model.MoedaModel>();
        }
    }
}
