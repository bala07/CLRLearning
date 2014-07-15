using System;

namespace CLRLearning.OperatorOverloading
{
    public class OperatorOverloadingTester : ITester
    {
        public void Test()
        {
            var c1 = new Complex { RealPart = 1, ImaginaryPart = 2 };
            var c2 = new Complex { RealPart = 5, ImaginaryPart = 7 };

            var c3 = c1 + c2;
            var c4 = c1 - c2;

            Console.WriteLine("[{0} +{1}i] + [{2} +{3}i] = [{4} + {5}i]", c1.RealPart, c1.ImaginaryPart, c2.RealPart, c2.ImaginaryPart, c3.RealPart, c3.ImaginaryPart);
            Console.WriteLine("[{0} +{1}i] - [{2} +{3}i] = [{4} + {5}i]", c1.RealPart, c1.ImaginaryPart, c2.RealPart, c2.ImaginaryPart, c4.RealPart, c4.ImaginaryPart);
        }
    }
}
