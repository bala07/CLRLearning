namespace CLRLearning.OperatorOverloading
{
    public class Complex
    {
        public int RealPart { get; set; }

        public int ImaginaryPart { get; set; }
        
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
                       {
                           RealPart = c1.RealPart + c2.RealPart,
                           ImaginaryPart = c1.ImaginaryPart + c2.ImaginaryPart
                       };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
                       {
                           RealPart = c1.RealPart - c2.RealPart,
                           ImaginaryPart = c1.ImaginaryPart - c2.ImaginaryPart
                       };
        }
    }
}
