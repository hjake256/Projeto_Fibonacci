using System;
using System.Text;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Projeto
{
    public class Program
    {   
        public void init(){

           List<Fibonacci> fibonaccis = new List<Fibonacci>();
            XElement xml = XElement.Load("fibonacci.xml");

           foreach(XElement x in xml.Elements()) 
           {

                Double a = 0, fib = 1;

                while (fib <= 5000000000) 
                {

                Console.Write("\n"+a + " " + "\n" + fib + " ");

                /* A partir daqui as variáveis começam a adquirir os valores somados uma da outra para 
                  para gerar a sequencia de Fibonacci! */ 

                a += fib; 
               
                fib += a; 
              
                } 
       
                Console.WriteLine("\n");

          }

     }

        public static void Main(string[] args)
        {
          Program p = new Program();
          p.init();

        }

    }

}