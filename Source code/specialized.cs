namespace Fractions
{
    public partial struct Fraction
    {
        private static int gcf(int first, int second)
        {
            while (first != second)
            {
                if (first > second)
                {
                    first = first - second;
                }
                else
                {
                    second = second - first;
                }
            }
            return first;
        }

        public static int lcm(int first, int second)
        {
            return first / gcf(first, second) * second;
        }

        public static int commonDenum(Fraction first, Fraction second)
        {
            return lcm(first.denumenator, second.denumenator);
        }
        public static Fraction toCommonDenum(Fraction fr, int coef)
        {
            if (coef % fr.denumenator != 0) throw new System.ArgumentException();
            int multiplier = coef / fr.denumenator;

            return mult(fr, multiplier);

        }

        public static Fraction mult(Fraction fr, int coef)
        {
            fr.numerator *= coef;
            fr.denumenator *= coef;
            return fr;
        }
    }
}
