using System;

namespace Fractions
{
    public partial struct Fraction
    {
        public bool positive;      // if fraction positive or not
        public int integ;          // integer part
        public int numerator;
        public int denumenator;

        public Fraction(bool pos, int inte, int num, int denum)
        {
            if (denum == 0)
            {
                throw new ArgumentException("Denumenator can't be 0");
            }
            positive = pos;
            integ = inte;
            numerator = num;
            denumenator = denum;
            if (numerator < 0)
            {
                positive = !positive;
                numerator *= -1;
            }
            if (integ < 0)
            {
                positive = !positive;
                integ *= -1;
            }
            if (denumenator < 0)
            {
                positive = !positive;
                denumenator *= -1;
            }
        }

        public Fraction(int num, int denum)
        {
            if (denum == 0)
            {
                throw new ArgumentException("Denumenator can't be 0");
            }
            positive = true;
            integ = 0;
            numerator = num;
            denumenator = denum;
            if (numerator < 0)
            {
                positive = !positive;
                numerator *= -1;
            }
            if (denumenator < 0)
            {
                positive = !positive;
                denumenator *= -1;
            }
        }

        public static Fraction toFraction(int n)
        {
            Fraction res = new Fraction(true, n, 0, 1);
            if (res.numerator < 0)
            {
                res.positive = !res.positive;
                res.numerator *= -1;
            }
            return res;
        }

        public override string ToString()
        {
            return $"{(positive ? "":"-")}{integ} {numerator}/{denumenator}";
        }

        public static string toString(Fraction fr)
        {
            return $"{(fr.positive ? "" : "-")}{fr.integ} {fr.numerator}/{fr.denumenator}";
        }
    }
}