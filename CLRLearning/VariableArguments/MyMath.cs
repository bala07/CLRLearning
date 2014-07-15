using System.Linq;

namespace CLRLearning.VariableArguments
{
    public class MyMath
    {
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Add(int operand1, int operand2, int operand3)
        {
            return operand1 + operand2 + operand3;
        }

        public int Add(params int[] operands)
        {
            return operands.Sum();
        }

        public int Subtract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int Subtract(int operand1, int operand2, int operand3)
        {
            return operand1 - operand2 - operand3;
        }

        public int Subtract(params int[] operands)
        {
            var diff = operands[0];
            for (var i = 1; i < operands.Length; ++i)
            {
                diff -= operands[i];
            }

            return diff;
        }
    }
}
