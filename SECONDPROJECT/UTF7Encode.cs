using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECONDPROJECT
{
   class UTF7Encode
    {
        static void Main(string[] args)
        {
            //UTF7Encoding encode = new UTF7Encoding();  //Creating a UTF7Encoding Object
            //UTF8Encoding encode = new UTF8Encoding();  //Creating a UTF8Encoding Object
            UTF32Encoding encode = new UTF32Encoding();  //Creating a UTF32Encoding Object
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();//Input from the user
            Console.WriteLine();
            Console.WriteLine("Original string is : ");
            Console.WriteLine(s); //display of the original string
            byte[] bytes = encode.GetBytes(s); //Encoding the string into bytes
            Console.WriteLine();
            Console.Write("Encoded Bytes are : ");
            foreach (byte b in bytes)
            {
                Console.Write("[{0}] ",b);//Encoded bytes output
            }
            Console.WriteLine();
            string decodestring= encode.GetString(bytes);//Decode the bytes back into the string 
            Console.Write("Decoded Bytes are : ");
            Console.WriteLine(decodestring);

        }
    }
}
