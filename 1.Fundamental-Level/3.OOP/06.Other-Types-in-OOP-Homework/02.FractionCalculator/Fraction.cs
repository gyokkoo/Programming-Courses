using System;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;

            if (this.Denominator < 0)
            {
                this.Numerator = -numerator;
                this.Denominator = -denominator;
            }
        }

        public long Numerator { get; set; }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be null");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.Numerator * f2.Denominator +
                       f2.Numerator * f1.Denominator;
            long denom = f1.Denominator * f2.Denominator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.Numerator * f2.Denominator -
                       f2.Numerator * f1.Denominator;
            long denom = f1.Denominator * f2.Denominator;

            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            return (decimal)this.Numerator / this.Denominator + "";
        }
    }
}
