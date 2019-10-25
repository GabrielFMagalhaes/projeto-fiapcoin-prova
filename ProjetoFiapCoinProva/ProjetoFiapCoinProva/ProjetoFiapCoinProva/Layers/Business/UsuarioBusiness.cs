using ProjetoFiapCoinProva.Layers.Data;
using ProjetoFiapCoinProva.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFiapCoinProva.Layers.Business
{
    public class UsuarioBusiness
    {
        public UsuarioModel GetByUsuario(String _nomeUsuario)
        {
            return new UsuarioData().GetByUsuario(_nomeUsuario);
        }

        public bool Login(String _nomeUsuario)
        {
            if(GetByUsuario(_nomeUsuario) != null)
            {
                return true;
            }
            else
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.NomeUsuario = _nomeUsuario;
                usuarioModel.Senha = "trocar123";
                Insert(usuarioModel);
                return true;
            }
        }

        public void Insert(UsuarioModel _usuario)
        {
            new UsuarioData().Insert(_usuario);
        }


        public void Update(UsuarioModel _usuario)
        {
            new UsuarioData().Update(_usuario);
        }

        public void DropTable()
        {
            new UsuarioData().DropTable();
        }
    }
}
