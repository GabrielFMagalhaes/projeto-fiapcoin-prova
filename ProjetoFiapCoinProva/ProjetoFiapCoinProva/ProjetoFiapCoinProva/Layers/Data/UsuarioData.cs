using ProjetoFiapCoinProva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFiapCoinProva.Layers.Data
{
    public class UsuarioData
    {

        private Config.DBConnection _dbConn;

        public UsuarioData()
        {
            _dbConn = new Config.DBConnection();
            _dbConn.Connection.CreateTable<UsuarioModel>();
        }


        public UsuarioModel GetByUsuario(String _nomeUsuario)
        {
            return _dbConn.Connection.Table<UsuarioModel>()
                          .Where(u => u.NomeUsuario == _nomeUsuario).SingleOrDefault();
        }


        public void Insert(UsuarioModel _usuario)
        {
            _dbConn.Connection.Insert(_usuario);
        }


        public void Update(UsuarioModel _usuario)
        {
            _dbConn.Connection.Update(_usuario);
        }

        public void DropTable()
        {
            _dbConn.Connection.DropTable<UsuarioModel>();
        }
    }
}
