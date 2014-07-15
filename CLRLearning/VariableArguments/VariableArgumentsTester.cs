using System;

namespace CLRLearning.VariableArguments
{
    public class VariableArgumentsTester : ITester
    {
        public void Test()
        {
            var myMath = new MyMath();

            Console.WriteLine(myMath.Add(1, 2, 3, 4, 5));
            Console.WriteLine(myMath.Add(1, 2));

            Console.WriteLine(myMath.Subtract(1, 2, 3, 4, 5, 6));
            Console.WriteLine(myMath.Subtract(5, 3, 2));
        }
    }
}
