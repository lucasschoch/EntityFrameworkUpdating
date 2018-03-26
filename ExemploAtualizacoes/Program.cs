using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAtualizacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //UpdateSimples();
            //UpdateDependente();            
        }

        private static void UpdateDependente()
        {
            using (ClarifyDBEntities ctx = new ClarifyDBEntities())
            {
                var pessoa = ctx.Pessoas.First(x => x.ID == 12);
                pessoa.PrimeiroNome = "Ronaldão";

                var aluno = ctx.Alunos.First(x => x.IdPessoa == 12);
                aluno.Empresa = "Santander";

                ctx.SaveChanges();
            }
        }

        private static void UpdateSimples()
        {
            using (ClarifyDBEntities ctx = new ClarifyDBEntities())
            {
                var pessoa = ctx.Pessoas.First(x => x.ID == 36);
                pessoa.PrimeiroNome = "Geraldino";

                ctx.SaveChanges();
            }
        }
    }
}
