using AssimantAdvancedc_01.Generic_Class;
using AssimantAdvancedc_01.Generic_Interface;
using AssimantAdvancedc_01.GenericMethod;
using AssimantAdvancedc_01.multiple_type_parameters;
using System;

namespace AssimantAdvancedc_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Generic class:Actual type when creating an object( is a class created without specifying the data type it will handle upfront; instead, the type is left open—represented by 'T'—until someone uses the class and specifies the type themselves.)
            //why Generic:1:Type Safty,2:Code Reusability,3:Better pereformence,4:Cleaner Code.
            #endregion
            #region Question02
            //Container<int> contain = new Container<int>(2);
            //contain.Add(3);
            //Console.WriteLine(contain.Get(4));

            #endregion
            #region Question03
            //multiple type parameters:A Generic class can have more than one type parameter
            //Pair<int, string> pair = new Pair<int, string>(1, "Rowida");
            //Console.WriteLine($"{pair.Key},{pair.Value}");
            #endregion
            #region Question04
            //Generic Method:A Method can be Genric even if the class is not Generic
            //Container<int> a = new Container<int>(5);
            //Container<int> b = new Container<int>(10);

            //Utility.swap(ref a, ref b);
            //Console.WriteLine($"a={a}, b={b}");
            #endregion
            #region Question05
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int maxnumber= Utility.FindMax(numbers);
            //Console.WriteLine(maxnumber);

            #endregion
            #region Question06
            //Generic interface:An interface defines the "shape" of certain operations without specifying the data type; any class that implements it defines the type itself.
            //IRepository<Product> repo=new ProductRepo();
            //repo.Add(new Product(1,"Laptop",9000));
            //repo.Add(new Product(2, "Mouse", 900));
            //repo.Add(new Product(3, "Keyboard", 250));
            //repo.Delete(2);
            //repo.GetAll();
            //repo.GetById(2);
            #endregion
        }
    }
}
