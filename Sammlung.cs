using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunstgegenstände;

public class Sammlung
{
    List<Kunstgegenstand> _kunstgegenstaende;

    public Sammlung()
    {
        _kunstgegenstaende = new List<Kunstgegenstand>();
    }


    public bool Add(Kunstgegenstand k)
    {
        if (k.GetPreis() >= 100)
        {
            _kunstgegenstaende.Add(k);
            return true;
        }
        else
        {
            return false;
        }
    }
}
