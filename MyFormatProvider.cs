using System;

namespace MyFormatProviders;

public class MyFormatProvider : IFormatProvider, ICustomFormatter
{
    public object GetFormat(Type formatType) => formatType == typeof(ICustomFormatter) ? this : null;

    public string Format(string format, object arg, IFormatProvider formatProvider) => arg switch
    {
      double x => x switch
      {
          > 5 => x.ToString("0"),
          > 0.5 => x.ToString("0.0"),
          _ => x.ToString("0.00")
      },          
      null => null,
      _ => arg.ToString(),
    };
}