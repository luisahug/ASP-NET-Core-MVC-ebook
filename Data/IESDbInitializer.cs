using Capitulo01.Models;
using System.Linq;

namespace Capitulo01.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Departamentos.Any())
            {
                return;
            }

            var departamentos = new Departamento[]
            {
                new Departamento { Nome="Ciência da Computação"},
                new Departamento {Nome="Engenharia de Software"}
            };

            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }

            var instituicoes = new Instituicao[]
            {
				new Instituicao()
				{
					Nome = "UFRGS",
					Endereco = "Porto Alegre"
				},
				new Instituicao()
				{
					Nome = "Feevale",
					Endereco = "Novo Hamburgo"
				},
				new Instituicao()
				{
					Nome = "Unisinos",
					Endereco = "São Leopoldo"
				},
				new Instituicao()
				{
					Nome = "Faccat",
					Endereco = "Taquara"
				},
				new Instituicao()
				{
					Nome = "PUCRS",
					Endereco = "Porto Alegre"
				}
			};

			foreach (Instituicao i in instituicoes)
			{
				context.Instituicoes.Add(i);
			}

            context.SaveChanges();
        }
    }
}
