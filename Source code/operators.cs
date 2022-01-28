using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions {
    public partial struct Fraction
    {

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            fr1 = simplify(fr1);
            fr2 = simplify(fr2);
            int cd = commonDenum(fr1, fr2);
            fr1 = toCommonDenum(fr1, cd);
            fr2 = toCommonDenum(fr2, cd);

            int mult1 = (fr1.positive) ? 1 : -1;
            int mult2 = (fr2.positive) ? 1 : -1;
            fr1 = unproper(fr1);
            fr2 = unproper(fr2);
            fr1.numerator *= mult1;
            fr2.numerator *= mult2;

            Fraction res = new Fraction(true, 0, fr1.numerator + fr2.numerator, fr1.denumenator);
            res = simplify(res);

            return res;
        }

        public static Fraction operator +(int n, Fraction fr)
        {
            Fraction fr2 = Fraction.toFraction(n);
            return fr + fr2;
        }

        public static Fraction operator +(Fraction fr, int n)
        {
            Fraction fr2 = Fraction.toFraction(n);
            return fr + fr2;
        }

        public static Fraction operator +(Fraction fr)
        {
            fr.positive = true;
            return fr;
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            return fr1 + (-fr2);
        }

        public static Fraction operator -(int n, Fraction fr)
        {
            return toFraction(n) + (-fr);
        }

        public static Fraction operator -(Fraction fr, int n)
        {
            return fr + (-toFraction(n));
        }

        public static Fraction operator -(Fraction fr)
        {
            fr.positive = !fr.positive;
            return fr;
        }

        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            fr1 = simplify(fr1);
            fr2 = simplify(fr2);
            fr1 = unproper(fr1);
            fr2 = unproper(fr2);
            Fraction res = new Fraction(true, 0, fr1.numerator * fr2.numerator, fr1.denumenator * fr2.denumenator);
            res = simplify(res);
            return res; ;
        }

        public static Fraction operator *(int n, Fraction fr)
        {
            return toFraction(n) * fr;
        }

        public static Fraction operator *(Fraction fr, int n)
        {
            return toFraction(n) * fr;
        }

        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            fr1 = simplify(fr1);
            fr2 = simplify(fr2);
            fr1 = unproper(fr1);
            fr2 = unproper(fr2);
            Fraction res = new Fraction(true, 0, fr1.numerator * fr2.denumenator, fr2.numerator * fr1.denumenator);
            res = simplify(res);
            return res;
        }

        public static Fraction operator /(int n, Fraction fr)
        {
            return toFraction(n) / fr;
        }

        public static Fraction operator /(Fraction fr, int n)
        {
            return toFraction(n) / fr;
        }

        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            fr1 = simplify(fr1);
            fr2 = simplify(fr2);
            return (fr1.numerator == fr2.numerator && fr1.denumenator == fr2.denumenator && fr1.integ == fr2.integ && (fr1.positive && fr2.positive));
        }

        public static bool operator ==(int n, Fraction fr)
        {
            return toFraction(n) == fr;
        }

        public static bool operator ==(Fraction fr, int n)
        {
            return toFraction(n) == fr;
        }

        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            fr1 = simplify(fr1);
            fr2 = simplify(fr2);
            return !(fr1.numerator == fr2.numerator && fr1.denumenator == fr2.denumenator && fr1.integ == fr2.integ && (fr1.positive && fr2.positive));
        }

        public static bool operator !=(int n, Fraction fr)
        {
            return toFraction(n) != fr;
        }

        public static bool operator !=(Fraction fr, int n)
        {
            return toFraction(n) != fr;
        }
    }
}