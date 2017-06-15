using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Money
    {
        public long Rubl { get; set; }
        public int Kopeek { get; set; }
        public Money() { }

        public Money(long rub, int kop)
        {
            Rubl = rub;
            Kopeek = kop;
        }

        public static Money operator +(Money m1,Money m2)
        {
            return new Money(m1.Rubl+m2.Rubl,m1.Kopeek+m2.Kopeek);
        }

        public static Money operator -(Money m1, Money m2)
        {
            return new Money(m1.Rubl - m2.Rubl, m1.Kopeek - m2.Kopeek);
        }

        public static Money operator *(Money m1, int m)
        {
            return new Money(m1.Rubl * m, m1.Kopeek * m);
        }

        public static Money operator /(Money m1, int m)
        {
            return new Money(m1.Rubl / m, m1.Kopeek / m);
        }

        public static Money operator /(Money m1, Money m2)
        {
            return new Money(m1.Rubl / m2.Rubl, m1.Kopeek / m2.Kopeek);
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return (m1.Rubl == m2.Rubl && m1.Kopeek == m2.Kopeek);

            //return new Money(m1.Rubl == m2.Rubl, m1.Kopeek / m2.Kopeek);
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return (m1.Rubl != m2.Rubl && m1.Kopeek != m2.Kopeek);

            //return new Money(m1.Rubl == m2.Rubl, m1.Kopeek / m2.Kopeek);
        }
        public override string ToString()
        {
            return String.Format($"{Rubl}.{Kopeek}");
        }
    }
}
