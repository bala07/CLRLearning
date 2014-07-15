namespace CLRLearning.ConversionOperators
{
    public class Rational
    {
        public double Value { get; set; }

        public static implicit operator Rational(int value)
        {
            var rational = new Rational { Value = value };

            return rational;
        }

        public static implicit operator Rational(double value)
        {
            var rational = new Rational { Value = value };

            return rational;
        }

        public static explicit operator int(Rational rational)
        {
            return (int)rational.Value;
        }

        public static explicit operator double(Rational rational)
        {
            return rational.Value;
        }
    }
}
