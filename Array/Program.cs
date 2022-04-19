/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    //Array: array are use to store multiple values in a single variable 
    //array are group of similer type of object 
    //array containt data and value
    //01234 array always start with 0 index ex: Bhopal
                                               //012345

    {
        int[] arr = new int[10];//array stored inside the heap memories it is global array
        Program[] data = new Program[10];
        

        static void Main(string[] args)
        {
            Program p1 = new Program();
            
            int[] arr = { 100,200,4000,300,200,2000};
            char[] charector = { 'a','c','d','a'};
            string[] place = { "Bhopal","Indore","Ujjain", "Banglore"};
            bool[] status = { true, false,true,false,true};
             Console.WriteLine(place);
            Console.WriteLine(arr);
            Console.WriteLine(place[3]);

            //Console.WriteLine(status);//System.Boolean[] it is called repar class
            // Console.WriteLine(charector);// it is take ascii value


            // int[] age;
            // age= { 100,200,4000,300,200,20 }; we cant initialize this type

            int[] age;
            age = new int [10];//if you want we can initallize in this type ,array index start with 0 but size is  10
            Console.WriteLine(age[0]);//default value coming because we can't initialized the value
            age[0] = 20;
            age[2] = 24;
            age[3] = 27;
            age[4] = 30;
            age[5] = 23;
            age[6] = 11;
            age[7] = 12;
            age[8] = 40;
            age[9] = 50;
            Console.WriteLine(age[9]);
           // Console.WriteLine(age[10]);//indext out of rang exception

            string[] name = new string[7];
            Console.WriteLine(name[4]);// it will give default value blank speac
            name[0] = "Sachin";
            name[1] = "Nisha";
            name[2] = "Divya";
            name[3] = "Moni";
            name[4] = "Kabi";
            name[5] = "Joy";
            name[6] = "Dhani";

            int[] data = new int[3];
            int[] test = new Int32[4];// this is chiled class array so it will store homozinouse data type
            test[0] = 123;//array is homozinouse data type if data type is integer then it will take only integer value
         //   test[1] = "Kaviya";// int is integer type it can't take other data type blc it is homozinouse data type
            test[2] = 'D';
            //  test[3] = true;
            object[] obj = new object[10];// we can declare array as a object because , object is a parent class  we can take here any data type
            obj[0] = "Sonam";
            obj[1] = 'c';
            obj[2] = 123;
            obj[3] = true;
            Console.WriteLine(name[4]);



            Console.ReadLine();

        }
    }
}*/
/*using System;
public class Array
{
    static void Main()
    {
        int[] arr = new int[10];
        //{10,20,38,50,7,30,5,27,49,40}
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 38;
        arr[3] = 50;
        arr[4] = 7;
        arr[5] = 30;
        arr[6] = 5;
        arr[7] = 27;
        arr[8] = 49;
        arr[9] = 40;
        int mini = arr[0];
        for (int i=0; i<arr.Length;i++)
        {

            if (arr[i] < mini)
                { 
                mini = arr[i];
            }
        }
        Console.WriteLine("Minimum Value of arry "+mini);
        Console.ReadLine();

    }
}*/
/*using System;
public class Array
{
    static void Main()
    {
        int[] arr = new int[10];
        //{10,20,38,50,7,30,5,27,49,40}
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 38;
        arr[3] = 50;
        arr[4] = 7;
        arr[5] = 30;
        arr[6] = 5;
        arr[7] = 27;
        arr[8] = 49;
        arr[9] = 40;
        int Max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] > Max)
            {
                Max = arr[i];
            }
        }
        Console.WriteLine("The maximum value of array"+Max);
        Console.ReadLine();

    }
}*/
/*using System;
public class Array
{
    static void Main()
    {
        int[] arr = new int[10];
        //{10,20,38,50,7,30,5,27,49,40}
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 38;
        arr[3] = 50;
        arr[4] = 7;
        arr[5] = 30;
        arr[6] = 5;
        arr[7] = 27;
        arr[8] = 49;
        arr[9] = 40;
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] %2==0)
            {
                Console.WriteLine("The even number of the array" + arr[i]);


            }
        }
        Console.ReadLine();

    }
}*/
/*using System;
public class Array
{
    static void Main()
    {
        int[] arr = new int[10];
        //{10,20,38,50,7,30,5,27,49,40}
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 38;
        arr[3] = 50;
        arr[4] = 7;
        arr[5] = 30;
        arr[6] = 5;
        arr[7] = 27;
        arr[8] = 49;
        arr[9] = 40;
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] % 2 != 0)
            {
                Console.WriteLine("The odd number of the array" + arr[i]);


            }
        }
        Console.ReadLine();

    }
}*/
/*using System;
public class Array
{
    static void Main()
    {
        int[] arr = new int[10];
        //{10,20,38,50,7,30,5,27,49,40}
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 38;
        arr[3] = 50;
        arr[4] = 7;
        arr[5] = 30;
        arr[6] = 5;
        arr[7] = 27;
        arr[8] = 49;
        arr[9] = 40;
        int Sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Sum += arr[i];
        }
        Console.WriteLine("Sum of Array="+Sum);
        Console.ReadLine();

    }
}*/
/*using System;
public class Array
{
    static void Main()
    {
        int[] arr = new int[10];
        //{10,20,38,50,7,30,5,27,49,40}
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 38;
        arr[3] = 50;
        arr[4] = 7;
        arr[5] = 30;
        arr[6] = 5;
        arr[7] = 27;
        arr[8] = 49;
        arr[9] = 40;
        int Sum = 0;
        int Avg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Sum += arr[i];
        }
        Avg = Sum / arr.Length;
        Console.WriteLine("Sum of Array=" + Sum);
        Console.WriteLine("Avg of Array=" + Avg);

        Console.ReadLine();

    }
}*/
/*using System;
public class Swap
{
    public static void Main()
    {

        int i = 0, j = 0;
        int[] arr = new int[] { 10, 20, 38, 20, 7, 30, 5, 27, 5, 40 };
        for (i = 0; i < arr.Length; i++)
        {
            for (j = 0; j < arr.Length; j++)
            {
                if (i == j)
                    continue;
                if (arr[j] == arr[i])
                    break;
            }
            if (arr.Length == j)
            {
                Console.Write(arr[i] + " ");
            }
        }
        Console.ReadLine();
    }
    }*/
/*using System;
//Jagged array is a array of arrays such that member arrays can be of different sizes.
//In other words, the length of each array index can differ.
//The elements of Jagged Array are reference types and initialized to null by default. 
//Jagged Array can also be mixed with multidimensional arrays.Here, the number of rows will be fixed at
//the declaration time, but you can vary the number of columns.

//In Jagged arrays, user has to provide the number of rows only. 
//If the user is also going to provide the number of columns, then this array will be no more Jagged Array.

//use:Jagged arrays are a special type of arrays that can be used to store rows of data of varying lengths 
//to improve performance when working with multi-dimensional arrays. 
//An array may be defined as a sequential collection of elements of the same data type
public class Employee
{
   public static void Main()
    {
        //object
        string[] employee = new string[4];
        employee[0] = "FullTimeEmployee";
        employee[1] = "PartTimeEmployee";
        employee[2] = "ContactBasedEmployee";
        employee[3] = "Others";

        string[][] jagged = new string[4][];
        jagged[0] = new string[4];
        jagged[1] = new string[4];
        jagged[2] = new string[4];
        jagged[3] = new string[4];

        jagged[0][0] = "TCS";
        jagged[0][1] = "Sonam";
        jagged[0][2] = "fullStackDev";
        jagged[0][3] = "others";

        jagged[1][0] = "IBM";
        jagged[1][1] = "Sachin";
        jagged[1][2] = "Dev";
        jagged[1][3] = "others";

        jagged[2][0] = "Google";
        jagged[2][1] = "Suchi";
        jagged[2][2] = "webDev";
        jagged[2][3] = "others";

        jagged[3][0] = "Oracal";
        jagged[3][1] = "Nish";
        jagged[3][2] = "saftwareTester";
        jagged[3][3] = "others";

        for (int i=0; i<jagged.Length; i++)
        {
           Console.WriteLine(employee[i]);
            string[] innerjagged = jagged[i];
            for (int j = 0; j < innerjagged.Length; j++)
            {
                Console.WriteLine(innerjagged[j]);
            }
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VirtualOverrideNew
{
    class Circle
    {
        public virtual void Area(double r)
        {
            Console.WriteLine(String.Format("Area of Circle : {0}", Math.PI * r * r));
        }
    }
    class Sphere : Circle
    {
        public override void Area(double r)
        {
            Console.WriteLine(String.Format("Area of Circle : {0}", 4 * Math.PI * r * r));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sphere C = new Sphere();
            C.Area(4);
            Console.ReadLine();
        }
    }
}*/

using System;
public  class Customer
{
    //   Customer()
    //{
    //}
    public virtual void Check()
    {
        Customer b = new Customer();
        Console.WriteLine("Customer");
    }
   public static void Main()
    {
        Customer a = new Customer();
        Order v = new Order();
        v.
        Customer c = new Product();
        
    }
}
public class Product: Customer
{
    public new void Check()
    {
        //Customer c = new Product();
        Console.WriteLine("Product");

    }
}
public class Order: Product
{
    public new void Check()
    {
        Console.WriteLine("Order");

    }

}
