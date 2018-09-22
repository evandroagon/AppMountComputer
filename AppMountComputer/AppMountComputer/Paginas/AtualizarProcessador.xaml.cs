using AppMountComputer.Banco;
using AppMountComputer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMountComputer.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AtualizarProcessador : ContentPage
	{
        private Processador processador { get; set;  }

		public AtualizarProcessador (Processador processador)
		{
			InitializeComponent ();
            this.processador = processador;

            id.Text = processador.id.ToString();
            marca.Text = processador.marca;
            linha.Text = processador.linha;
            modelo.Text = processador.modelo;
            preco.Text = processador.preco.ToString();

		}

        public void salvarAction(object Sender, EventArgs args)
        {
            //Processador p = new Processador();
            processador.id = int.Parse(id.Text);
            processador.marca = marca.Text;
            processador.linha = linha.Text;
            processador.modelo = modelo.Text;
            processador.preco = double.Parse(preco.Text);

            Database database = new Database();
            database.Atualizacao(processador);

            App.Current.MainPage =
                new NavigationPage(new MinhasPecas());
        }
    }
}