using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunstgegenstände;
/// <summary>
/// Erstellt einen Kunstgegenstand
/// </summary>
public class Kunstgegenstand
{
    string _titel;

    bool _verkaufbar = false;

    double _preis = 0;
    /// <summary>
    /// Erstellt einen Kunstgegenstand mit Namen
    /// </summary>
    /// <param name="titel">Der Name des Kunstgegenstandes
    public Kunstgegenstand(string titel) 
    {
        _titel = titel;
    }
    /// <summary>
    /// Erstellt einen Kunstgegenstand mit Namen und festlegung ob er verkaufbar ist.
    /// </summary>
    /// <param name="titel">Der Name des Kunstgegenstandes
    /// <param name="verkaufbar">Festlegung
    public Kunstgegenstand(string titel, bool verkaufbar) 
    { 
        _titel = titel;
        _verkaufbar = verkaufbar;
    }

}
