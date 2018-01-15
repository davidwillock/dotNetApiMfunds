using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InstrumentIndexes
/// </summary>

public class InstrumentIndexes : IComparable<InstrumentIndexes>
{

    public double IR { get; private set; }
    public double DOW { get; private set; }
    public double NAS { get; private set; }
    public double SP { get; private set; }
    public DateTime DATE { get; private set; }


    public InstrumentIndexes(Double Ir, Double Nas, Double Dow,Double Sp, DateTime Date)
    {


        IR = Ir;
        DOW = Dow;
        DATE = Date;
        NAS = Nas;
        SP = Sp;




    }

    public InstrumentIndexes() { }












    public int CompareTo(InstrumentIndexes other)
    {
        throw new NotImplementedException();
    }
}