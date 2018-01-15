using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InterestRate
/// </summary>

public class InterestRate : IComparable<InterestRate>
{
    public InterestRate(DateTime effectiveDate, double rate)
    {

        Date = effectiveDate;
        Rate = rate;

    }

    public DateTime Date { get; set; }
    public Double Rate { get; set; }



    public int CompareTo(InterestRate some)
    {

        return Date.CompareTo(some.Date);
    }


}





