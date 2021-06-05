using System;
using System.Text.RegularExpressions;

class Fraction : IComparable<Fraction>, IEquatable<Fraction>
{
    private long Top { get; set; }
    private long Bottom { get; set; } 
    public Fraction(long top, long bottom)
    {
        Top = top;
        Bottom = bottom;
    }
    public Fraction(long top)
    {
        Top = top;
        Bottom = 1;
    }
    public Fraction()
    {
        Top = 0;
        Bottom = 1;
    }
   
    public double GetFraction()
    {
        return (double) (Top / Bottom);
    }
    public override string ToString()
    {
        return (Top.ToString() + "/" + Bottom.ToString());
    }
    public static bool TryParse(string N, out Fraction f)
    {
        f = null;
        Regex pattern1 = new Regex(@"^(\d*)[/](\d*)$");
        Regex pattern2 = new Regex(@"^\d*$");
        Regex pattern3 = new Regex(@"^(\d*)[.,](\d*)$");
        if (pattern1.IsMatch(N))
        {
            string[] words = N.Split(new char[] { '/' });
            long numerator = long.Parse(words[0]);
            long denumerator = long.Parse(words[1]);
            f = new Fraction(numerator, denumerator);
            return true;
        }
        else if (pattern2.IsMatch(N))
        {
            long numerator = long.Parse(N);
            long denumerator = 1;
            f = new Fraction(numerator, denumerator);
            return true;
        }
        else if (pattern3.IsMatch(N))
        {
            string[] words = N.Split(new char[] { '.', ',' });
            long numerator = long.Parse(words[0]);
            long denumerator = long.Parse(words[1]);
            f = new Fraction(numerator, denumerator);
            return true;
        }
        else
            return false;
    }
    public static Fraction Parse(string N)
    {
        Fraction F;
        if (TryParse(N, out F))
            return F;
        throw new ArgumentException("Incorrect input");
    }

    public bool Equals(Fraction N)
    {
        if (N == null)
            return false;
        else
            return (Top * N.Bottom == N.Top * Bottom);
    }
    public int CompareTo(Fraction N)
    {
        return ((Top * N.Bottom).CompareTo(N.Top * Bottom));
    }

    public double ToDouble(IFormatProvider provider)
    {
        return GetFraction();
    }

    public short ToInt16(IFormatProvider provider)
    {
        return Convert.ToInt16(GetFraction());
    }

    public int ToInt32(IFormatProvider provider)
    {
        return Convert.ToInt32(GetFraction());
    }

    public long ToInt64(IFormatProvider provider)
    {
        return Convert.ToInt64(GetFraction());
    }
    public decimal ToDecimal(IFormatProvider provider)
    {
        return Convert.ToDecimal(GetFraction());
    }

    public static Fraction operator +(Fraction N1, Fraction N2)
    {
        return new Fraction(N1.Top * N2.Bottom + N2.Top * N1.Bottom, N1.Bottom * N2.Bottom);
    }
    public static Fraction operator -(Fraction N1, Fraction N2)
    {
        return new Fraction(N1.Top * N2.Bottom - N2.Top * N1.Bottom, N1.Bottom * N2.Top);
    }
    public static Fraction operator *(Fraction N1, Fraction N2)
    {
        return new Fraction(N1.Top * N2.Top, N1.Bottom * N2.Bottom);
    }
    public static Fraction operator /(Fraction N1, Fraction N2)
    {
        return new Fraction(N1.Top * N2.Bottom, N1.Bottom * N2.Top);
    }

    public static bool operator <(Fraction N1, Fraction N2)
    {
        return (N1.Top * N2.Bottom < N1.Bottom * N2.Top);
    }
    public static bool operator >(Fraction N1, Fraction N2)
    {
        return (N1.Top * N2.Bottom > N1.Bottom * N2.Top);
    }
    public static bool operator !=(Fraction N1, Fraction N2)
    {
        return (N1.Top * N2.Bottom != N1.Bottom * N2.Top);
    }
    public static bool operator ==(Fraction N1, Fraction N2)
    {
        return (N1.Top * N2.Bottom == N1.Bottom * N2.Top);
    }
    public static bool operator <=(Fraction N1, Fraction N2)
    {
        return (N1.Top * N2.Bottom <= N1.Bottom * N2.Top);
    }
    public static bool operator >=(Fraction N1, Fraction N2)
    {
        return (N1.Top * N2.Bottom >= N1.Bottom * N2.Top);
    }

    public long GCD(long N1, long N2)
    {
        if (N1 > N2)
        {
            (N1, N2) = (N2, N1);
        }
        while (N2 != 0)
        {
            N1 %= N2;
            (N1, N2) = (N2, N1);
        }
        long Res = N1;
        return Res;
    }
}
