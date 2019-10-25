using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProjetoFiapCoinProva.Model
{
    public class UsuarioModel : INotifyPropertyChanged
    {
        private int idUsuario;

        [PrimaryKey]
        public int IdUsuario
        {
            get { return idUsuario; }
            set
            {
                if (idUsuario != value)
                {
                    idUsuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string nomeUsuario;
        public String NomeUsuario
        {
            get { return nomeUsuario; }
            set
            {
                if (nomeUsuario != value)
                {
                    nomeUsuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string senha;
        public String Senha
        {
            get { return senha; }
            set
            {
                if (senha != value)
                {
                    senha = value;
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
