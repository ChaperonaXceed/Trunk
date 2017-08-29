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

    public static int ProvideValue( int value, bool saquare = false )
    {
      if( saquare )
        return value * value;

      return ValueProvider.ProvideValue( value );
    }
  }
}
