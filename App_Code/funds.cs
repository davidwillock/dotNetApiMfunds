using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for funds
/// </summary>
public class funds : IComparable<funds>
{
    public funds(String symbol,DateTime date,Double open, Double high, Double low, Double close,Double close_adj ,int volume)
    {

        Date = date;
       
        Open = open;
        High = high;
        Low = low;
        Close = close;
        Close_adj = close_adj;
        Volume = volume;
        Symbol = symbol;

               
    }




         public String Symbol { get; set; }

        public DateTime Date { get; set; }
       
        public Double Open { get; set; }
        public Double High { get; set; }
        public Double Low { get; set; }
        public Double Close { get; set; }

        public Double Close_adj { get; set; }
        public int Volume { get; set; }
        






    public int CompareTo(funds other)
    {
        return Date.CompareTo(other.Date);
    }
}

    
