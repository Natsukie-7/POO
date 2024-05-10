using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
	public abstract class Cliente // Classes abstratas não podem ser instanciadas
	{
		protected int codigo { get; set; }
		protected string name{ get; set; }
		protected string endereco{ get; set; }
		protected double saldo{ get; set; }
		public int idade { get; set; }

		public Cliente(int codigo, string name, string endereco, double saldo, int idade)
		{
			this.codigo = codigo;
			this.name = name;
			this.endereco = endereco;
			this.saldo = saldo;
			this.idade = idade;
		}

		public abstract object Dados();
		public abstract void AvaliarIdade();
	}
}