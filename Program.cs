namespace Route_adv01;
internal class Program
{
    static void Main(string[] args)
    {
        #region 1
        // generic class: a class with no spicific parameter type ,it can deal with any type u need
        // we use it to prevent reapeting [DRY]
        #endregion

        #region 3
        // its the ability of the method or class to accept more then one generic type
        #endregion

        #region 4
        // is a function implements its own type 
        #endregion

        #region 6
        // an interface that declares methods or properties using non specific data type
        #endregion

        #region 7
        // force the type to be used by struct
        //public class ValueWrapper<T> where T : struct
        #endregion

        #region 8
        // force the type to be used by class
        //public class ValueWrapper<T> where T : class
        #endregion

        #region 9
        // force the type to be used by class has default construcor
        //public class ValueWrapper<T> where T : new()
        #endregion

        #region 10
        // force the type to be used by interface
        //public class ValueWrapper<T> where T : IFormattable
        #endregion

        #region 11
        // force the type to be used by specific class
        //public class ValueWrapper<T> where T : Pair
        #endregion

        #region 12
        //write the normal constraint and the other one with a 
        //public class ValueWrapper<T> where T : IFormattable , new ()
        #endregion

        #region 13
        // returns the default value for the given type ,0 for ints for example
        #endregion

        #region 15
        // covariance allows more derived types 
        // out keyword  is used with the generic interface to allow the type as output only and not available as parameter 
        #endregion

        #region 16
        //allows the more base types 
        // in keyword allows the type to get in as parameter only and not allowed as output or return type
        #endregion

        #region 17
        //convariance: uses out keyword, generic return type
        //contravariance: uses in keyword , generic parameter type
        #endregion

        #region 18
        // every type has its own version of the static member
        #endregion

        #region 19
        // we declare the type in the inheritance
        #endregion

        #region 20
        // cant solve
        #endregion
    }
}
