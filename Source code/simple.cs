using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    public partial struct Fraction
    {

        public static Fraction shorten(Fraction fr)
        {
            int GCF = gcf(fr.numerator, fr.denumenator);
            fr.numerator /= GCF;
            fr.denumenator /= GCF;
            return fr;
        }

        public static Fraction proper(Fraction fr)
        {
            int add = fr.numerator / fr.denumenator;
            fr.integ += add;
            fr.numerator %= fr.denumenator;
            return fr;
        }

        public static Fraction signsFix(Fraction fr)
        {
            if (fr.numerator < 0)
            {
                fr.positive = !fr.positive;
                fr.numerator *= -1;
            }
            if (fr.denumenator < 0)
            {
                fr.positive = !fr.positive;
                fr.numerator *= -1;
            }
            if (fr.integ < 0)
            {
                fr.positive = !fr.positive;
                fr.numerator *= -1;
            }
            return fr;
        }

        /*public static Fraction pos(Fraction fr)
        {
            if (fr.numerator <= 0)
            {
                fr.integ = fr.integ * ((fr.positive) ? 1 : -1);
                
            }
        }*/

        public static Fraction simplify(Fraction fr)
        {
            fr = shorten(fr);
            fr = proper(fr);
            fr = signsFix(fr);
            return fr;
        }

        public static Fraction unproper(Fraction fr)
        {
            fr.numerator = fr.integ * fr.denumenator + fr.numerator;
            fr.integ = 0;
            return fr;
        }
    }
}
