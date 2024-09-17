using System;
using System.Globalization;


namespace Course {
    class Calculadora {

        public static double PI = 3.14;

        public static double Circunferencia(double r){
            return 2.0 * PI * r;
        }

        public static double Volume(double r){
            return 4.0 / 3.0 * PI * r * r * r;
        }

    }
}