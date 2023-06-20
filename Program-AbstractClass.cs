using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            rename kiran = new rename();
            kiran.implements("new abstract class");
            Console.ReadLine();
        }
    }


    abstract class test
    {

        public  virtual void implements(string name) { }


    }


    class rename : test
    {
        string correct;

        public override void implements(string name)
         {
             name = name + "\n some thing new";
             Console.Write(name);
         }
         

        public string implement(string name)
        {

            correct = name;

            return correct;

        }
    }

    public interface MyInterface {

        string myMethod();
    }

    public class class2:MyInterface
            {

        public string myMethod()
        {
            return "From Method 1:hi there";
        }

            }
}
