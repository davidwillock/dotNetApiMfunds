using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Hosting;



public partial class import : System.Web.UI.Page
    {

 
 
    List<funds> mutuals;

    managefunds thefunds = new managefunds();

    protected void Page_Load(object sender, EventArgs e)
    {

       
     





        if (IsPostBack)
        {

            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MfundsConnectionString"].ConnectionString);
                conn.Open();

                string checkUser = "Select count(*) from Symbols";

                SqlCommand com = new SqlCommand(checkUser, conn);

                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                Lblstatus.Text = temp.ToString();


                conn.Close();



            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message.ToString());

            }


        }
    }

        void SQLhelperInsert(DateTime date, double ir, double sp, double dow, double nas,SqlConnection conn)
    {

        double test1 = 1.1;

        string insertUser = "Insert into FinancialInstruments (EPOCH,IR,DOW,SP,NAS) values (@date,@ir,@dow,@sp,@nas)";
        SqlCommand com = new SqlCommand(insertUser, conn);

        /*
        com.Parameters.AddWithValue("@date", date);
        com.Parameters.AddWithValue("@ir", test1);
        com.Parameters.AddWithValue("@nas", test1);
        com.Parameters.AddWithValue("@dow", test1);
        */

        com.Parameters.Add("@date", SqlDbType.DateTime)
            .Value = date;   //DateTime.Now;

       
        com.Parameters.Add("@ir", SqlDbType.Decimal)
             .Value = System.Convert.ToDecimal(ir);

        com.Parameters.Add("@sp", SqlDbType.Decimal)
            .Value = System.Convert.ToDecimal(sp);

        com.Parameters.Add("@dow", SqlDbType.Decimal)
           .Value = System.Convert.ToDecimal(dow);

        com.Parameters.Add("@nas", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(nas);

        com.ExecuteNonQuery();


    }



    void SQLhelperInsertFunds(String symbol, DateTime date, double open, double high, double low, double close,double closeadj,Int32 volume, SqlConnection conn)
    {

        

        string insertUser = "Insert into Symbols  (symbol_,epoch_,open_,high_,low_,close_,close_adj,volume_) values (@symbol,@date,@open,@high,@low,@close,@closeadj,@volume)";

        

        SqlCommand com = new SqlCommand(insertUser, conn);




        com.Parameters.Add("@date", SqlDbType.DateTime)
            .Value = date;   //DateTime.Now;


        com.Parameters.Add("@symbol", SqlDbType.NVarChar)
             .Value = System.Convert.ToString(symbol);

        com.Parameters.Add("@open", SqlDbType.Decimal)
            .Value = System.Convert.ToDecimal(high);

        com.Parameters.Add("@high", SqlDbType.Decimal)
           .Value = System.Convert.ToDecimal(low);

        com.Parameters.Add("@low", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(close);

        com.Parameters.Add("@close", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(close);

        com.Parameters.Add("@closeadj", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(closeadj);

        com.Parameters.Add("@volume", SqlDbType.Int)
       .Value = System.Convert.ToInt32(volume);



        com.ExecuteNonQuery();


    }




    void SQLhelperInsertPDataCalanderReturn(String Return, double y2016, double y2015, double y2014, double y2013, double y2012, double y2011,double y2010, double y2009,double y2008 ,SqlConnection conn)
    {


        string insertCalander = "Insert into Symbols  (Return_,Y2016_,Y2015_,Y2014_,Y2013_,Y2012_,Y2011_,Y2010_,Y2009_,Y2008_) values (@return,@y2016,@y2015,@y2014,@y2013,@y2012,@y2011,@y2010,@y2009,y2008)";

        SqlCommand com = new SqlCommand(insertCalander, conn);

        
        com.Parameters.Add("@return", SqlDbType.NVarChar)
             .Value = System.Convert.ToString(Return);

        com.Parameters.Add("@y2016", SqlDbType.Decimal)
            .Value = System.Convert.ToDecimal(y2016);

        com.Parameters.Add("@y2015", SqlDbType.Decimal)
           .Value = System.Convert.ToDecimal(y2015);

        com.Parameters.Add("@y2014", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(y2014);

        com.Parameters.Add("@y2013", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(y2013);

        com.Parameters.Add("@y2012", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(y2012);

        com.Parameters.Add("@y2012", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(y2012);

        com.Parameters.Add("@y2011", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(y2011);

        com.Parameters.Add("@y2010", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(y2010);

        com.Parameters.Add("@y2009", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(y2009);

        com.Parameters.Add("@y2008", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(y2008);


        com.ExecuteNonQuery();


    }


    void SQLhelperInsertPDataReturn(String Return, double OneMonth, double ThreeMonth, double SixMonth, double YTD, double OneYear, double ThreeYear, double FiveYear,double TenYear, SqlConnection conn)
    {

 
  
  string insertReturn = "Insert into Symbols  (Return_,OneMonth_,ThreeMonth_,SixMonth_, YTD_,OneYear_,ThreeYear_,FiveYear_,TenYear_) values (@Return,@OneMonth,@ThreeMonth,@SixMonth,@Ytd,@OneYear,@ThreeYear,@FiveYear,@TenYear)";



        SqlCommand com = new SqlCommand(insertReturn, conn);



        com.Parameters.Add("@Return", SqlDbType.NVarChar)
            .Value = System.Convert.ToString(Return);

        com.Parameters.Add("@OneMonth", SqlDbType.Decimal)
            .Value = System.Convert.ToDecimal(OneMonth);

        com.Parameters.Add("@ThreeMonth", SqlDbType.Decimal)
           .Value = System.Convert.ToDecimal(ThreeMonth);

        com.Parameters.Add("@SixMonth", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(SixMonth);

        com.Parameters.Add("@Ytd", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(YTD);

        com.Parameters.Add("@OneYear", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(OneYear);

         com.Parameters.Add("@ThreeYear", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(ThreeYear);

         com.Parameters.Add("@FiveYear", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(FiveYear);

         com.Parameters.Add("@TenYear", SqlDbType.Decimal)
        .Value = System.Convert.ToDecimal(TenYear);

    
        com.ExecuteNonQuery();


    }













    void SQLhelperInsertPerformance(String symbol, double Mer, double Assets, double Rank, double StdDev, double VolatileRank,double MstarRisk ,double Alpha, double Beta,double Rsquared,String RRSPElegability ,String Load,double MaxFrontEnd,double MaxBackEnd,double NavPs, String SalesOpen,SqlConnection conn) { 


              
        string insertPerforma = "Insert into PerformanceData(SymID, MER_, Assets_, Rank_, StdDev_, VolatileRank_, MstarRisk_, Alpha_, Beta_, Rsquared_, RRSPEligibility_, Load_, MaxFrontEnd_, MaxBackEnd_, SaleOpen_, NavPS_) values(@SymID, @Mer, @Assets, @Rank, @StdDev, @VolatileRank, @MstarRisk, @Alpha, @Beta, @Rsquared, @RRSPEligibility, @Load, @MaxFrontEnd, @MaxBackEnd, @SaleOpen, @NavPS)";

        SqlCommand com = new SqlCommand(insertPerforma, conn);

        com.Parameters.Add("@symbol", SqlDbType.NVarChar)
             .Value = System.Convert.ToString(symbol);

        com.Parameters.Add("@Mer", SqlDbType.Decimal)
            .Value = System.Convert.ToDecimal(Mer);

        com.Parameters.Add("@Assets", SqlDbType.Decimal)
           .Value = System.Convert.ToDecimal(Assets);

        com.Parameters.Add("@Rank", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(Rank);

        com.Parameters.Add("@StdDev", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(StdDev);

        com.Parameters.Add("@VolatileRank", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(VolatileRank);

        com.Parameters.Add("@MstarRisk", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(MstarRisk);

        com.Parameters.Add("@Alpha", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(Alpha);

        com.Parameters.Add("@Beta", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(Beta);

       

        com.Parameters.Add("@Rsquared", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(Rsquared);


        com.Parameters.Add("@RRSPEligibility", SqlDbType.NVarChar)
           .Value = System.Convert.ToString(symbol);

        com.Parameters.Add("@Load", SqlDbType.NVarChar)
          .Value = System.Convert.ToString(symbol);

        com.Parameters.Add("@MaxFrontEnd", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(MaxFrontEnd);


        com.Parameters.Add("@MaxBackEnd", SqlDbType.Decimal)
         .Value = System.Convert.ToDecimal(MaxBackEnd);



        com.Parameters.Add("@SaleOpen@Load", SqlDbType.NVarChar)
         .Value = System.Convert.ToString(SalesOpen);

        com.Parameters.Add("@NavPS", SqlDbType.Decimal)
          .Value = System.Convert.ToDecimal(NavPs);



        com.ExecuteNonQuery();


    }















    protected void Loadmutualbtn_Click(object sender, EventArgs e)
    {



        if (FileUpload1.HasFile)
        {
            try
            {
                string filename = FileUpload1.FileName;



                // StreamReader sr = new StreamReader(VirtualPathProvider.("/data/"+filename));


                String relative = "~\\data\\" + filename;
                string absolute = HttpContext.Current.Server.MapPath(relative);

               

                  thefunds.UploadDataFiles(absolute);
                  mutuals =  thefunds.fundData.ToList();
                  Session["INDEXES"] = mutuals;











            }
            catch (Exception ex)
            {
                // StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        }





    }

    protected void Importbtn_Click(object sender, EventArgs e)
    {

        double[][] input;
        int size = 20000;

        input = new double[size][];
   

        List<funds> mdata = (List<funds>)Session["INDEXES"];

     


        try
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MfundsConnectionString"].ConnectionString);
            conn.Open();


            
           
            







            foreach (funds fd in mdata)
            {



                    SQLhelperInsertFunds(fd.Symbol, fd.Date, fd.Open, fd.Low, fd.High, fd.Close, fd.Close_adj, fd.Volume, conn);
                 
            }
   


        }
                 catch (Exception ex)
                {

                  ex.ToString();



                }


            }







    protected void Delbtn_Click(object sender, EventArgs e)
    {


        try
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MfundsConnectionString"].ConnectionString);
            conn.Open();

            string checkUser = "Delete from Symbols";

            SqlCommand com = new SqlCommand(checkUser, conn);

            // int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            // Lblstatus.Text = temp.ToString();

            com.ExecuteNonQuery();

            conn.Close();



        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.Message.ToString());

        }








    }







    }













