using ProjetoFiapCoinProva.Layers.Data.Config;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProjetoFiapCoinProva.Droid.Layers.Data.Config.DBConfig))]
namespace ProjetoFiapCoinProva.Droid.Layers.Data.Config
{
    public class DBConfig : IDBConfig
    {
        private String _path;
        public String Path
        {
            get
            {
                if (String.IsNullOrEmpty(_path))
                {
                    _path =
                        System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return _path;
            }
        }
    }
}