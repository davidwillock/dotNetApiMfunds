using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;

/// <summary>
/// Summary description for director
/// </summary>

/*
public class director
{
    public director()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}

*/



public class director
{



    public static double MaxIr { get; private set; }
    public static double MinIr { get; private set; }

    public static double MaxSp { get; private set; }
    public static double MinSp { get; private set; }

    public static double MaxDow { get; private set; }
    public static double MinDow { get; private set; }

    public static double MaxNas { get; private set; }
    public static double MinNas { get; private set; }


    public static double MaxFund { get; private set; }
    public static double MinFund { get; private set; }







    public static DateTime MaxDate { get; private set; }

    public static DateTime MinDate { get; private set; }


    public static int INPUTSZ { get; private set; }
    public static int OUTPUTSZ { get; private set; }

    List<InterestRate> myRates = new List<InterestRate>();
    List<SP> spIndex = new List<SP>();
    List<Dow> dowIndex = new List<Dow>();
    List<Nasdaq> nasIndex = new List<Nasdaq>();
    List<funds> fundIndex = new List<funds>();
    readonly List<InstrumentIndexes> data = new List<InstrumentIndexes>();




    public void UploadDataFiles(string Ir, string Sp, string Dow, string Nas)
    {

        if (!File.Exists(Ir))
        {
            throw new Exception(" Unable to access file Interest rates ");



        }

        try
        {

            UploadInterestRate(Ir);



        }
        catch
        {

            throw new Exception(" Unable to process  file Intereset rates ");

        }



        if (!File.Exists(Sp))
        {
            throw new Exception(" Unable to access file Interest rates ");



        }

        try
        {


            UploadSpIndex(Sp);
          


        }
        catch
        {

            throw new Exception(" Unable to process  file Intereset rates ");

        }


        try
        {



            UploadNasIndex(Nas);


        }
        catch
        {

            throw new Exception(" Unable to process  file NAS ");

        }

        try
        {



            UploadDowIndex(Dow);


        }
        catch
        {

            throw new Exception(" Unable to process  file DOW ");

        }


        






    }



    public director(int inputsize, int outputsize)
    {



    }



   public IList<InstrumentIndexes> Data
    {


        get { return data; }


    }


    public IList<funds> fundData
    {


        get { return fundIndex; }


    }





    public void getInputData(int offset, double[] input)
    {
        int myoffset = 0;

       for (int i = 0; i <= 10; i++)
        {
            InstrumentIndexes fact = data[myoffset + i];
            input[i * 4] = fact.SP;
            input[i * 4 + 1] = fact.IR;
            input[i * 4 + 2] = fact.DOW;
            input[i * 4 + 3] = fact.NAS;

        }

       
        


        //    }





    }


    public void getOutputData()
    {




    }





    public double getIr(DateTime date)
    {

        double interest = 0;

        foreach (InterestRate r in myRates)
        {

            if (r.Date.CompareTo(date) >= 0)
            {

                return interest;

            }

            interest = r.Rate;
        }


        return interest;
    }


    public double getSPindex(DateTime date)
    {

        double current = 0;

        foreach (SP item in spIndex)
        {

            if (item.Date.CompareTo(date) >= 0)
            {

                return current;

            }

            current = item.SPindex;
        }


        return current;
    }


    public double getDowindex(DateTime date)
    {

        double current = 0;

        foreach (Dow item in dowIndex)
        {

            if (item.Date.CompareTo(date) >= 0)
            {

                return current;

            }

            current = item.DOWindex;
        }


        return current;
    }


    public double getNasindex(DateTime date)
    {

        double current = 0;

        foreach (Nasdaq item in nasIndex)
        {

            if (item.Date.CompareTo(date) >= 0)
            {

                return current;

            }

            current = item.NASindex;
        }


        return current;
    }










    public void UploadInterestRate(string path)
    {





        string DATE_HEADER = "date";


        myRates = new List<InterestRate>();


        if (myRates == null)
        {
            myRates = new List<InterestRate>();

        }
        else
        {
            myRates.Clear();


        }




        using (CSV reader = new CSV(path))
        {

            string value;
            int i = 0;

            while (reader.next())
            {


                DateTime date = reader.getDate(DATE_HEADER);
                double amount = reader.getDouble("prime");
                InterestRate temp = new InterestRate(date, amount);
                myRates.Add(temp);


                if (amount > MaxIr) MaxIr = amount;
                if (amount < MinIr) MinIr = amount;






            }

            reader.close();

            myRates.Sort();

        }

        if (spIndex.Count > 0)
        {

            MaxDate = DateTime.MaxValue;
            MinDate = DateTime.MinValue;

            if (MaxDate > spIndex[spIndex.Count - 1].Date)
            {
                MaxDate = spIndex[spIndex.Count - 1].Date;

            }
            if (MinDate < spIndex[0].Date)
            {
                MinDate = spIndex[0].Date;

            }

        }




    }


    public DateTime parseDate(string temporal)
    {

        try
        {
            return DateTime.ParseExact(temporal, "yyyy-mm-dd", CultureInfo.InvariantCulture);

        }
        catch (Exception)
        {

            return default(DateTime);
        }
    }




    public void UploadSpIndex(string path)
    {





        string DATE_HEADER = "Date";
        string ADJ_CLOSE = "Adj Close";


        spIndex = new List<SP>();


        if (spIndex == null)
        {
            spIndex = new List<SP>();

        }
        else
        {
            spIndex.Clear();


        }




        using (CSV reader = new CSV(path))
        {

            string value;
            int i = 0;

            while (reader.next())
            {


                DateTime date = reader.getDate(DATE_HEADER);
                double amount = reader.getDouble(ADJ_CLOSE);
                SP temp = new SP(date, amount);
                spIndex.Add(temp);


                if (amount > MaxIr) MaxIr = amount;
                if (amount < MinIr) MinIr = amount;






            }

            reader.close();
            spIndex.Sort();

        }


        if (MaxDate > spIndex[spIndex.Count - 1].Date)
        {
            MaxDate = spIndex[spIndex.Count - 1].Date;

        }
        if (MinDate < spIndex[0].Date)
        {
            MinDate = spIndex[0].Date;

        }





    }





    public void UploadNasIndex(string path)
    {





        string DATE_HEADER = "Date";
        string ADJ_CLOSE = "Adj Close";


        nasIndex = new List<Nasdaq>();


        if (nasIndex == null)
        {
            nasIndex = new List<Nasdaq>();

        }
        else
        {
            nasIndex.Clear();


        }




        using (CSV reader = new CSV(path))
        {

            string value;
            int i = 0;

            while (reader.next())
            {


                DateTime date = reader.getDate(DATE_HEADER);
                double amount = reader.getDouble(ADJ_CLOSE);
                Nasdaq temp = new Nasdaq(date, amount);
                nasIndex.Add(temp);


                if (amount > MaxNas) MaxNas = amount;
                if (amount < MinNas) MinNas = amount;






            }

            reader.close();
            nasIndex.Sort();

        }


        if (MaxDate > nasIndex[nasIndex.Count - 1].Date)
        {
            MaxDate = nasIndex[nasIndex.Count - 1].Date;

        }
        if (MinDate < nasIndex[0].Date)
        {
            MinDate = nasIndex[0].Date;

        }





    }




    public void UploadDowIndex(string path)
    {





        string DATE_HEADER = "Date";
        string ADJ_CLOSE = "Adj Close";


        dowIndex = new List<Dow>();


        if (dowIndex == null)
        {
            dowIndex = new List<Dow>();

        }
        else
        {
            dowIndex.Clear();


        }




        using (CSV reader = new CSV(path))
        {

            string value;
            int i = 0;

            while (reader.next())
            {


                DateTime date = reader.getDate(DATE_HEADER);
                double amount = reader.getDouble(ADJ_CLOSE);
                Dow temp = new Dow(date, amount);
                dowIndex.Add(temp);


                if (amount > MaxDow) MaxDow = amount;
                if (amount < MinDow) MinDow = amount;






            }

            reader.close();
            dowIndex.Sort();

        }


        if (MaxDate > dowIndex[dowIndex.Count - 1].Date)
        {
            MaxDate = dowIndex[dowIndex.Count - 1].Date;

        }
        if (MinDate < dowIndex[0].Date)
        {
            MinDate = dowIndex[0].Date;

        }





    }




    public void UploadFunds(string path)
    {





        string DATE_HEADER = "Date";
        string ADJ_CLOSE = "Adj Close";


        fundIndex = new List<funds>();


        if (fundIndex == null)
        {
            fundIndex = new List<funds>();

        }
        else
        {
            fundIndex.Clear();


        }




        using (CSV reader = new CSV(path))
        {

            string value;
            int i = 0;

            while (reader.next())
            {


                DateTime date = reader.getDate(DATE_HEADER);
                double amount = reader.getDouble(ADJ_CLOSE);
            //    funds temp = new funds(date, amount);
           //     fundIndex.Add(temp);


                if (amount > MaxFund) MaxFund = amount;
                if (amount < MinFund) MinFund = amount;






            }

            reader.close();
            fundIndex.Sort();

        }


        if (MaxDate > fundIndex[fundIndex.Count - 1].Date)
        {
            MaxDate =fundIndex[fundIndex.Count - 1].Date;

        }
        if (MinDate < fundIndex[0].Date)
        {
            MinDate = fundIndex[0].Date;

        }





    }



























    public void amendIndex()
    {

        foreach (SP sp in spIndex)
        {

            double amountSP = getSPindex(sp.Date);
            double amountDOW = getDowindex(sp.Date); 
            double amountNAS = getNasindex(sp.Date);
            double amountIR = getIr(sp.Date);




            data.Add(new InstrumentIndexes(amountIR,amountNAS, amountDOW, amountSP,sp.Date));

        }




    }



    public void Normalise()
    {






    }



}








