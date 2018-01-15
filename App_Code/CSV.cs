using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Globalization;


/// <summary>
/// Summary description for CSV
/// </summary>
public class CSV : IDisposable
{

    TextReader _parse;
    private readonly IDictionary<String, int> headers = new Dictionary<String, int>();
    string[] cols;

    public CSV(string file)
    {

        int count = 8;

        _parse = new StreamReader(file);
        string line = _parse.ReadLine();
        string[] items = line.Split(',');

        for (int index = 0; index < items.Length; index++)
        {

            string item = items[index];
            headers.Add(item, index);



            cols = new string[count];

        }

    }

    public string get(int i)
    {

        return cols[i];

    }




    public bool next()
    {



        string line = _parse.ReadLine();

        if (line == null)
        {

            return false;


        }



        string[] items = line.Split(',');
        string item;

        for (int i = 0; i < items.Length; i++)
        {

            item = items[i];
            if (i < cols.Length)
            {

                cols[i] = item;


            }


        }

        return true;





    }



    public string get(string column)
    {

        if (!headers.ContainsKey(column))
        {

            return null;

        }

        int i = headers[column];
        return cols[i];
    }



    public double getDouble(string column)
    {

        string col = get(column);
        return double.Parse(col, CultureInfo.InvariantCulture);

    }

    public DateTime getDate(string column)
    {
        string col = get(column);
        return DateTime.Parse(col, CultureInfo.InvariantCulture);

    }


    public int getInt(string column)
    {
        string col = get(column);
        return int.Parse(col, CultureInfo.InvariantCulture);
    }


    public void close()
    {

        _parse.Close();

    }

    public static DateTime parseDate(string temporal)
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

    #region IDisposable Support
    private bool disposedValue = false; // To detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            disposedValue = true;
        }
    }

    // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
    // ~Class1() {
    //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
    //   Dispose(false);
    // }

    // This code added to correctly implement the disposable pattern.
    void IDisposable.Dispose()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        Dispose(true);
        // TODO: uncomment the following line if the finalizer is overridden above.
        // GC.SuppressFinalize(this);
    }
    #endregion







}