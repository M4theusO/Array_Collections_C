﻿
namespace bytebank.Modelos.ADM.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        protected internal override double getBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
