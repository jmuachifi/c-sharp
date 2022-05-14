using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myNum = 15;
            //myNum = 80;//myNum is now 80 

            /*const int myNum = 15;
            myNum = 20; // error*/

            /*String fname = "John ";
            String lname = "Doe";
            String fullname = fname + lname;*/

            /*int x = 20;
            int y = 80;*/
            // int x = 20, y = 80;
            // same value: int x,y; x=y=200;
            //Console.WriteLine(x + y);


            //Automatic Cascading
            int mInt = 10;
            double mDouble = mInt; //int to double
            Console.WriteLine(mDouble);

            //Manual Cascading
            double myDouble = 8.8;
            int myInt =(int) myDouble; //double to int
            Console.WriteLine(myInt);

            //Type conversion Method
            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool = true;

            Console.WriteLine("-----");

            Console.WriteLine(Convert.ToString(myInt2)); //convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2)); //convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2)); //convert double to int
            Console.WriteLine(Convert.ToString(myBool)); //convert boolean to string

        }
    }
}
