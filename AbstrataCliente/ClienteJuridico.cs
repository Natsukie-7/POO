using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
	public class ClienteJuridico : Cliente
	{
		public string cnpj { get; private set; }


		public ClienteJuridico(int codigo, string name, string endereco, double saldo, int idade, string cnpj) : base (codigo, name, endereco, saldo, idade )
		{
			this.cnpj = cnpj;
		}
		public override void AvaliarIdade()
		{
			if (this.idade >=18 && this.idade < 50) 
			{
				Console.WriteLine(this.Dados());
			}
		}

		public override object Dados()
		{
			return new 
			{
				codigo =  this.codigo,
				nome = this.name,
				endereco = this.endereco,
				saldo = this.saldo,
				idade = this.idade,
				cnpj = this.cnpj
			};
		}
	}
}