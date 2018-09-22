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
	public partial class MinhasPecas : ContentPage
	{
        private List<Processador> lista { get; set; }

        public MinhasPecas ()
		{
			InitializeComponent ();
            ConstularPecas();
        }

        private void ConstularPecas()
        {

            Database database = new Database();
            lista = database.Consultar();
            ListaProcessadores.ItemsSource = lista;

            lblCount.Text = lista.Count.ToString();
        }

        public void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest =
           (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Processador processador = tapGest.
            CommandParameter as Processador;
            Navigation.PushAsync(new AtualizarProcessador(processador));
        }

        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest =
           (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Processador processador = tapGest.
            CommandParameter as Processador;

            Database database = new Database();
            database.Exclusao(processador);
            ConstularPecas();

        }

        public void PesquisarAction(
            object sender, TextChangedEventArgs args)
        {
            ListaProcessadores.ItemsSource =
                lista.Where(a => a.marca.Contains(args.NewTextValue)).
                ToList();
        }
    }
}