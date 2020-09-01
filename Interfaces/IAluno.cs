using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBoletim.Domains;

namespace APIBoletim.Interfaces
{
    interface IAluno
    {
        Aluno Cadastrar(Aluno a);
        List<Aluno> LerTodos();
        Aluno BuscarId(int id);
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);
   
    }
}
