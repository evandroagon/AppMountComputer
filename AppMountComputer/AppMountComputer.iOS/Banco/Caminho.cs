using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AppMountComputer.Banco;
using AppMountComputer.iOS.Banco;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caminho))]
namespace AppMountComputer.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");
            string caminhoBanco = Path.Combine(caminhoBiblioteca, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}