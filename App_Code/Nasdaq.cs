using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Nasdaq
/// </summary>
public class Nasdaq : IComparable<Nasdaq>
{
    public Nasdaq(DateTime effectiveDate, double amount)
    {

        Date = effectiveDate;
        NASindex = amount;


    }
    
        //
        // TODO: Add constructor logic here
        //

       public double NASindex  { get;   set;}
       public DateTime Date { get; set; }

    

    public int CompareTo(Nasdaq other)
    {
        return Date.CompareTo(other.Date);
    }
}