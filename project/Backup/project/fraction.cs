using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class fraction
    {
        private int n, d;
        public void Reduce()
        {
            int a, b;
            if (d < 0)
            {
                d = -d;
                n = -n;
            }
            a = Math.Abs(n);
            b = Math.Abs(d);
            while (a != b)
                if (a > b)
                    a -= b;
                else b -= a;
            n /= a;
            d /= a;
        }
        public int Num
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
        public int Den
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public fraction()
        {
            this.n = 0;
            this.d = 1;
        }
        public fraction(int a)
        {
            this.n = a;
            this.d = 1;
        }
        public fraction(int a, int b)
        {
            if (b == 0)
            {
                System.Windows.Forms.MessageBox.Show("Denominator couldn't be a ZERO!!!!!11!1");
                b = 1;
            }
            this.n = a;
            this.d = b;
            Reduce();
        }
        public fraction(fraction x)
        {
            n = x.n;
            d = x.d;
        }
        public static fraction operator +(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.Num = x.Num * y.Den + y.Num * x.Den;
            z.Den = x.Den * y.Den;
            z.Reduce();
            return z;
        }
        public static fraction operator -(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.Num = x.Num * y.Den - y.Num * x.Den;
            z.Den = x.Den * y.Den;
            z.Reduce();
            return z;
        }
        public static fraction operator *(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.Num = x.Num * y.Num;
            z.Den = x.Den * y.Den;
            z.Reduce();
            return z;
        }
        public static fraction operator /(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.Num = x.Num * y.Den;
            z.Den = x.Den * y.Num;
            z.Reduce();
            return z;
        }
    }
}
