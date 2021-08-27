using System;

namespace APICatalogoJogo.Exceptions
{
    public class JogoNaoCadastradoException
    {
          public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo não está cadastrado")
        { }
    }
    }
}