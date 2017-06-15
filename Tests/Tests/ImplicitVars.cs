using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class ImplicitVars
    {
        #region Incorrect Declaration


        //public var SomeField = "someValue";
        //public static var SomeMethod() { Some Code }


        //public static void AnotherMethod()
        //{
        //    var x;
        //    x = 5;
        //    var y = null;
        //}
        //public static void Somemethod(var someInt)
        //{
        //}

        #endregion
        #region correctDeclaration

        //public static void Somemethod(int someInt)
        //{
        //    var Intvar = 11;
        //    var m = new Money();
        //    var somevariable = "someValue";
        //somevariable=null;
        //}


        #endregion
    }
}
