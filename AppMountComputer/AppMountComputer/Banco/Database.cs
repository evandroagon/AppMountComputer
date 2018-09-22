using AppMountComputer.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppMountComputer.Banco
{
    class Database
    {
        private SQLiteConnection _conexao;

        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(databasePath: caminho);
            _conexao.CreateTable<Processador>();
        }

        public List<Processador> Consultar()
        {
            return _conexao.Table<Processador>().ToList();
        }

        public List<Processador> Pesquisar(string palavra)
        {
            return _conexao.Table<Processador>().Where(a => a.marca.Contains(palavra)).ToList();
        }

        public Processador ObterVagaPorId(int id)
        {
            return _conexao.Table<Processador>().Where(a=>a.id==id).FirstOrDefault();
        }

        public void Cadastro(Processador processador)
        {
            _conexao.Insert(processador);
        }

        public void Atualizacao(Processador processador)
        {
            _conexao.Update(processador);
        }

        public void Exclusao(Processador processador)
        {
            _conexao.Delete(processador);
        }

    }
}
