﻿using System;
using System.IO;
using Xamarin.Forms;

namespace ProjetoFiapCoinProva.Layers.Data.Config
{
    public class DBConnection : IDisposable
    {
        public SQLite.SQLiteConnection Connection { get; }

        public DBConnection()
        {
            var config = DependencyService.Get<IDBConfig>();
            var caminhoArquivoBanco = Path.Combine(config.Path, "fiapcoin.db");
            Connection = new SQLite.SQLiteConnection(caminhoArquivoBanco);
        }

        public void Dispose()
        {
            if (Connection != null)
            {
                Connection.Dispose(); // Liberar a conexão
            }
        }
    }
}
