using System;
using System.Globalization;
//Construtor => É uma operação especial da classe, que executa no momento da instanciação do objeto
//•Usos comuns:
//• Iniciar valores dos atributos
//• Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação(injeção de dependência)
//•Se um construtor customizado não for especificado, a classe disponibiliza oconstrutor padrão:
//• Produto p = new Produto();
//•É possível especificar mais de um construtor na mesma classe(sobrecarga)
//Sobrecarga => É uma recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, 
//porem com diferentes listas de parâmetros.
//get acessado
//set alterado

namespace _0053_OperacaoBancaria {
    class ContaBancaria {
        //==========Ordem Sugerida==========
        //1.Atributos Privados
        //2.Propriedaeds autoimplementadas
        //3.Construtores
        //4.Propriedades customizadas
        //5.Outros métodos da classe
        //==================================
        public int Numero { get; private set; }//Conta não pode ser alterada
        public string Titular { get; set; }
        public double Saldo { get; private set; }//O saldo só pode ser alterado por: deposito ou saldo

        //Construtor com 2 argumentos
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        //Construtor com 3 argumentos
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        //Metodos/Propriedades
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5;

        }

        //Exemplo de sobreposição
        public override string ToString() {
            return "Conta: " + Numero +
                ", Titular: " + Titular +
                ", Saldo R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
