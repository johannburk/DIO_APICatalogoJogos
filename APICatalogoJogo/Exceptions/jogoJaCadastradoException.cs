using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogoJogo.Exceptions
{
    public class jogoJaCadastradoException : Exception
    {
        public jogoJaCadastradoException()

        : base("Este jogo já está cadastrado")
        { }
    }
}