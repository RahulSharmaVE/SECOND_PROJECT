using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECONDPROJECT
{ 
   abstract class Calculation //abstract class
    {
        public abstract void add(int num1, int num2);
        public abstract void sub(int num1, int num2);
        public abstract void mul(int num1, int num2);
        public virtual void div(int num1,int num2)
        {
            Console.WriteLine("This is virtual division method.......");
        }        
    }
    
    class Calculationuse : Calculation         //Abstract Function override
    {
        public override void add(int num1, int num2)
        {
            Console.WriteLine("The addition is : {0}",num1+num2);
        }
        public override void sub(int num1, int num2)
        {
            Console.WriteLine("The Subtraction is : {0}", num1-num2); 
        }
        public override void mul(int num1, int num2)
        {
            Console.WriteLine("The Multiplication is : {0}", num1 * num2);
        }
        public override void div(int num1, int num2)
        {
            Console.WriteLine("The Division is : {0}", num1 / num2);
        }
    }
     class Abstraction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers for addition.....");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            Calculation obj;  //abstract class refrence
            obj = new Calculationuse(); 
            obj.add(num1,num2);
            obj.mul(num1,num2);
            obj.div(num1,num2);
            obj.sub(num1,num2);
            Console.ReadLine();
        }
    }
}
