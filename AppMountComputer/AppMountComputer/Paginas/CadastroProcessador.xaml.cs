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
	public partial class CadastroProcessador : ContentPage
	{
		public CadastroProcessador ()
		{
			InitializeComponent ();

		}

        public void salvarAction(object Sender, EventArgs args)
        {
            Processador p = new Processador();
            p.marca = marca.Text;
            p.linha = linha.Text;
            p.modelo = modelo.Text;
            if( preco.Text !=null){
                p.preco = double.Parse(preco.Text);
            }
            else { p.preco = 0; }

            Database database = new Database();
            database.Cadastro(p);

            App.Current.MainPage =
                new NavigationPage(new ConsultaProcessador());
        }
	}
}