using System;

namespace _0073_FuncoesParaString {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Algumas funções para strings");
            Console.WriteLine();
            string original = "abcde FGHIJ ABC abc DEFG     ";
            Console.WriteLine("=============================");

            string s1 = original.ToUpper();//LETRAS MAIUSCULAS
            string s2 = original.ToLower();//LETRAS MINUSCULAS
            string s3 = original.Trim(); //ESPAÇOS EM BRANCO

            int n1 = original.IndexOf("bc");//PRIMEIRA OCORRENCIA 
            int n2 = original.LastIndexOf("bc");//ULTIMA CORRENCIA 

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);//VARIAVEL NULA
            bool b2 = String.IsNullOrWhiteSpace(original);//VARIAVEL NULA E ESPAÇO EM BRANCO

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4 + "-");
            Console.WriteLine("Substring(3,5): " + s5 + "-");
            Console.WriteLine("Replace('a','x'): " + s6 + "-");
            Console.WriteLine("Replace('abc','xy'): " + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);



            Console.WriteLine();
        }
    }
}
