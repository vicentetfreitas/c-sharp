using System;
using System.Globalization;
namespace _0047_ClasseFuncionario {
    class Funcionario {
        public string Nome;
        public Double SalarioBruto;
        public Double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

       public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + ((SalarioBruto * porcentagem) / 100.0);
        }
        public override string ToString() {
            return Nome
            + ", "
            + " R$ "
            + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)  ;
        }
    }
} 
