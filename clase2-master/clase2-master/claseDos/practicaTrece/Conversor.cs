using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaTrece
{
    class Conversor
    {

        public static double BinarioDecimal(string binario)
        { 
            int numeroBinario;
            float numeroDecimal=0;
            int contador;

            
            for (contador = 1; contador <=binario.Length; contador++)
            {
                numeroBinario= int.Parse(binario[contador -1].ToString());
              
               numeroDecimal += numeroBinario*(int)Math.Pow(2, binario.Length -contador);

                // numeroDecimal += (int.Parse(binario[contador - 1].ToString())) * (int)Math.Pow(2, binario.Length - contador);
            }

            return numeroDecimal;
            
            
            /*bool resultadoParse = false;
           
            int largoBinario= binario.Length;
            
            resultadoParse= int.TryParse(binario,out numeroDecimal);
           
           
            if (resultadoParse)
            {
                for (contador = 1; contador <= largoBinario; contador++)
                { 
                    
                }
            }
            else
            {
                Console.WriteLine("No se pudo convertir el numero");
            }*/

        
        }




        public static string DecimalBinario(double numeroEntero)
        {
            string binario ="";
            
            while (numeroEntero >0)
            {
                //binario = String.Concat((numeroEntero % 2).ToString(),binario);

                binario = (numeroEntero % 2).ToString()+binario;
                numeroEntero= (int)numeroEntero / 2;
                
            }
            return binario;
        }
    }
}
