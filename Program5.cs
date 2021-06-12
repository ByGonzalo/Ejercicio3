using System;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {       

        static void Main(string[] args)
        {
            Thread H1 = new Thread(new ThreadStart(pro1));            
            Thread H2 = new Thread(new ThreadStart(pro2));            
            Thread H3 = new Thread(new ThreadStart(pro3));
            H1.Start();
            H2.Start();
            H3.Start();
        }
        public void pro1()
        {
            int i ;
            int p=0;
            for(i = 0; i <= 10; i++)
            {
                p = i * 5;
                Console.WriteLine(i + " * 5 = " + p);
            }            
        }
        public void pro2()
        {
            int i ;
            int p = 0;
            for (i = 0; i <= 10; i++)
            {
                p = i * 10;
                Console.WriteLine(i + " * 10 = " + p);
            }            
        }
        public void pro3()
        {
            int i ;
            int p = 0;
            for (i = 0; i <= 15; i++)
            {
                p = i * 5;
                Console.WriteLine(i + " * 15 = " + p);
            }            
        }
    }
}
