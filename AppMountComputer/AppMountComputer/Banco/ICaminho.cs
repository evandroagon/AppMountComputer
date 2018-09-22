using System;
using System.Collections.Generic;
using System.Text;

namespace AppMountComputer.Banco
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}
