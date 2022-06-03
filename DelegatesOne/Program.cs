using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesOne
{
    internal class Program
    {
        //Delegate declaration
        public delegate void SimpleMessageDelegate(string msgDel);
        public delegate void addValuesDelegate(int x, int y);
        static void Main(string[] args)
        {
            /*
             * Delegates --> function pointers --> functions are methods
             * --> Delegates points to methods
             * --> Create a delegate
             * --> Using the delegate keyword
             * Rules of using Delegates
             *          -- GLobal declaration
             *          -- Has to have the same signature of the method its trying to call
             *          -- Create an object of the delegate
             *          -- pass the name of the method as a paremeter into the object
             *          -- Use the delegate object to invoke the method
             *          -- Invoke option can be used 
             */

            Console.WriteLine("<<< Program to show the use of Delegates");
            //SimpleMessage("Basic Methods");//Method call
            SimpleMessageDelegate smd = new SimpleMessageDelegate(SimpleMessage);
            smd("Simple message using delegate objects ");
            smd.Invoke("Using invoke in delegate one"); //Invoke option

            Console.WriteLine("The 2nd delegate");
            Program p = new Program();
            addValuesDelegate avd = new addValuesDelegate(p.addValues);
            avd(25, 50);
            avd.Invoke(5, 10); //Invoke option

            Console.ReadLine();//open console
        }
        //Basic method
        public static void SimpleMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        //non-static method 
        public void addValues(int a, int b)
        {
            Console.WriteLine("The values added : "+ (a + b));
        }
    }
}
