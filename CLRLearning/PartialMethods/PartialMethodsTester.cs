using System;

namespace CLRLearning.PartialMethods
{
    public class PartialMethodsTester : ITester
    {
        public void Test()
        {
            var classWithPartialMethod = new ClassWithPartialMethod();
            classWithPartialMethod.PrintStringInUpperCase("Hello World!");
        }
    }
}
