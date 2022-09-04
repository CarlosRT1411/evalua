using System;
using System.IO;

namespace Evalua
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Lenguaje a = new Lenguaje();

                a.Programa();
                //Esto es una prueba
                //Segunda prueba
                //while(!a.FinArchivo())
                //{
                  //  a.NextToken();
                //}
                a.cerrar();
            }
            catch (Exception)
            {
                
            }
        }
    }
}