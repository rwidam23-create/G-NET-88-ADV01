using AssimantAdvancedc_01.Generic_Class;
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
        }
    }
}
