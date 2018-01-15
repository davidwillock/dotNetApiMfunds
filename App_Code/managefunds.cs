using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;





/// <summary>
/// Summary description for managefunds
/// </summary>
public class managefunds
{
    public managefunds()
    {


}


    public static double MaxFund { get; private set; }
    public static double MinFund { get; private set; }


    public static DateTime MaxDate { get; private set; }

    public static DateTime MinDate { get; private set; }


    List<funds> fundIndex = new List<funds>();
    readonly List<InstrumentIndexes> data = new List<InstrumentIndexes>();



    public void UploadDataFiles(String funds)
    {

        if (!File.Exists(funds))
        {
            throw new Exception(" Unable to access file funds ");



        }

        try
        {

            UploadFunds(funds);



        }
        catch
        {

            throw new Exception(" Unable to process  file funds ");

        }

    }




    public IList<InstrumentIndexes> Data
    {


        get { return data; }


    }


    public IList<funds> fundData
    {


        get { return fundIndex; }


    }





    public void UploadFunds(string path)
    {


        String symbol = Path.GetFileNameWithoutExtension(path);


        string DATE_HEADER = "Date";
        string ADJ_CLOSE = "Adj Close";

        string SYMBOL = symbol;
        string OPEN = "Open";
        string HIGH = "High";
        string LOW = "Low";
        string CLOSE = "Close";
        string VOLUME = "Volume";



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

            

            while (reader.next())
            {


                DateTime date = reader.getDate(DATE_HEADER);
                double close_adj = reader.getDouble(ADJ_CLOSE);
                double open = reader.getDouble(OPEN);
                double high = reader.getDouble(HIGH);
                double low = reader.getDouble(LOW);
                double close = reader.getDouble(CLOSE);
                int volume = reader.getInt(VOLUME);
                funds temp = new funds(symbol,date, open, high,low,close, close_adj,volume);
                fundIndex.Add(temp);


                if (close_adj > MaxFund) MaxFund = close_adj;
                if (close_adj < MinFund) MinFund = close_adj;






            }

            reader.close();
            fundIndex.Sort();

        }


        if (MaxDate > fundIndex[fundIndex.Count - 1].Date)
        {
            MaxDate = fundIndex[fundIndex.Count - 1].Date;

        }
        if (MinDate < fundIndex[0].Date)
        {
            MinDate = fundIndex[0].Date;

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


    void getAllFundsbyFolder(String[] args)
    {


        foreach (String path in args)
        {
            if (File.Exists(path))
            {
                // This path is a file
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory
               // do nothing ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }
        }

    }


    void  ProcessFile(String path)
    {

        string ext = Path.GetExtension(path);
      

        if (ext.Equals("csv"))
        {
            UploadFunds(path);
            
        }


    }





    


}