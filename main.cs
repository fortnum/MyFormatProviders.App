using MyFormatProviders;
using System;

class Program
{
    static void Main()
    {
        var arr = new (string Name, object Value)[] {
            ("999", 999),
            ("0.6", 0.6),
            ("0.01", 0.01),
            ("999.7", 999.7),
            ("0.55", 0.55),
            ("\"\"", ""),
            ("0.000000000000000000001", 0.000000000000000000001),
            ("hello", "hello"),
            ("-77", -77),
            ("null", null),
            ("new object()", new object())
        };

        foreach (var x in arr) { Console.WriteLine($"{x.Name} => " + ((FormattableString)$"{x.Value}").ToString(new MyFormatProvider())); }
    }
}