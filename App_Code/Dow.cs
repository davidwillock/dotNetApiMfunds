using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Dow
/// </summary>
public class Dow : IComparable<Dow>
{
    public Dow(DateTime mydate, double amount  )
    {

        Date = mydate;
        DOWindex = amount;
    }




    public DateTime Date { get; set; }
    public Double DOWindex { get; set; }


    public int CompareTo(Dow other)
    {
        return Date.CompareTo(other.Date);
    }
}