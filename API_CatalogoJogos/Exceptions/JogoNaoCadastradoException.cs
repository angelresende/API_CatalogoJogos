using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo não está cadastrado")
        { }
    }
}
