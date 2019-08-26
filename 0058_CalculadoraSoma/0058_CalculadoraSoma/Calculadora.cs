﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _0058_CalculadoraSoma {
    class Calculadora {

        //public static int Soma(int n1, int n2) {
        //    return n1 + n2;
        //}
        //public static int Soma(int n1, int n2, int n3) {
        //    return n1 + n2 + n3;
        //}
        //public static int Soma(int n1, int n2, int n3, int n4) {
        //    return n1 + n2 + n3 + n4;
        //}
        //ANTES
        //public static int Soma(int[] numeros) {
        //    int soma = 0;
        //    for (int i = 0; i < numeros.Length; i++) {
        //        soma += numeros[i];
        //    }

        //    return soma;
        //}
        //DEPOIS
        public static int Soma(params int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }

            return soma;
        }
    }
}
