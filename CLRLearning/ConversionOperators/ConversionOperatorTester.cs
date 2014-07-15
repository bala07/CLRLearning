using System;

namespace CLRLearning.ConversionOperators
{
    public class ConversionOperatorTester : ITester
    {
        public void Test()
        {
            Rational rationalFromInt = 15;
            Rational rationalFromDouble = 2.3;

            var intFromRational = (int)rationalFromInt;
            var doubleFromRational = (double)rationalFromDouble;

            Console.WriteLine("Rational from int: {0} , Rational from double: {1}", rationalFromInt.Value, rationalFromDouble.Value);
            Console.WriteLine("int from rational: {0}, double from Rational: {1}", intFromRational, doubleFromRational);
        }
    }
}
