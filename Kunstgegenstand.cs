﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
    /// <param name="verkaufbar">Festlegung, ob er verkaufbar ist.
    public Kunstgegenstand(string titel, bool verkaufbar) 
    { 
        _titel = titel;
        _verkaufbar = verkaufbar;
    }
    /// <summary>
    /// Titel des Kunstgegenstandes
    /// </summary>
    /// <returns>Der Name des Gegenstandes</returns>
    public string GetTitel() 
    {
        return _titel;
    }
    /// <summary>
    /// Liest den Preis aus
    /// </summary>
    /// <returns>Der Wert des Kunstgegenstand wird zurückgegeben</returns>
    public double GetPreis() 
    { 
       return _preis;
    }
    /// <summary>
    /// Setzt den Preis
    /// </summary>
    /// <param name="preis">Der Wert des Kunstgegenstandes</param>
    public void SetPreis(double preis) 
    {
        _preis = preis;
    }
    /// <summary>
    /// Liest den Status aus
    /// </summary>
    /// <returns>true, wenn verkaufbar</returns>
    public bool GetVerkaufbar() 
    {
        return _verkaufbar;
    }
    /// <summary>
    /// Legt den Status fest
    /// </summary>
    /// <param name="verkaufbar">true falls verkaufbar</param>
    public void SetVerkaufbar(bool verkaufbar)
    {
        _verkaufbar= verkaufbar;
    }

}
