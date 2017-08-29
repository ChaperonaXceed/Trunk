using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
  public class ValueProvider
  {
    public static int ProvideValue( int value )
    {
      return value * 2;
    }

    public static int ProvideValue( int value, bool square = false )
    {
      if( square )
        return value * value;

      return ValueProvider.ProvideValue( value );
    }

    public static double ProvideValue( double value )
    {
      return value * 2;
    }

    public static double ProvideValue( double value, bool square = false )
    {
      if( square )
        return value * value;

      return ValueProvider.ProvideValue( value );
    }
  }
}
