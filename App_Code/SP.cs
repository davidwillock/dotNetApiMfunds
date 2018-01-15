using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SP
/// </summary>
public class SP : IComparable<SP>
{
    public SP(DateTime effectiveDate, double amount)
    {

        Date = effectiveDate;
        SPindex = amount;


    }



    public DateTime Date { get; set; }
    public Double SPindex { get; set; }



    public int CompareTo(SP some)
    {

        return Date.CompareTo(some.Date);
    }


}

