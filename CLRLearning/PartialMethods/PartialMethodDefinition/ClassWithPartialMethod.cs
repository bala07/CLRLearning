using System;

namespace CLRLearning.PartialMethods
{
    public partial class ClassWithPartialMethod
    {
        public void PrintStringInUpperCase(String str)
        {
            this.PrintString(str.ToUpper());
        }

        partial void PrintString(String str)
        {
            Console.WriteLine("The string is {0}", str);
        }
    }
}
