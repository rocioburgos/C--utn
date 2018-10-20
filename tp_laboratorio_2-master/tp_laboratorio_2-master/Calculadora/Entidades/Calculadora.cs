using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Calculadora
    {
        public double Operar(Numero numeroUno, Numero numeroDos, string operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    resultado = numeroUno.GetNumero() + numeroDos.GetNumero();
                    break;
                case "-":
                    resultado = numeroUno.GetNumero() - numeroDos.GetNumero();
                    break;
                case "/":
                    if (numeroDos.GetNumero() != 0)
                    {
                        resultado = numeroUno.GetNumero() / numeroDos.GetNumero();

                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
                case "*":
                    resultado = numeroUno.GetNumero() * numeroDos.GetNumero();
                    break;

            }

            return resultado;
        }

        public string ValidarOperador(string operador)
        {
            string retorno = "+";
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                retorno = operador;
            }
            return retorno;
        }
    }
}
