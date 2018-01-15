<%@ Page Language="C#" AutoEventWireup="true" CodeFile="import.aspx.cs" Inherits="import" %>

<!DOCTYPE html>
<script runat="server">

   


</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 20px;
        }
        .auto-style3 {
            margin-left: 21px;
        }
        .auto-style4 {
            margin-left: 22px;
        }
        .auto-style5 {
            margin-left: 23px;
            font-weight: bold;
        }
        .auto-style6 {
            color: #FFFFFF;
        }
        .auto-style7 {
            margin-left: 21px;
            font-weight: bold;
        }
        .auto-style8 {
            margin-left: 20px;
            font-weight: bold;
        }
        .auto-style9 {
            height: 500px;
            width: 146px;
        }
        .auto-style10 {
            font-weight: bold;
            margin-left: 19px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <table style="font-family:Arial">
    <tr>
        <td colspan="2" style="width:800px; height:80px; background-color:#3399FF; 
            text-align:center">
            <h1>
                WebSite Header
            </h1>

          
        </td>
    </tr>
    <tr>
        <td style="background-color:#66FFFF; " class="auto-style9">
            <h3>Menu</h3>

       </td>

        <td style="height:500px; background-color:#9999FF; width:650px">

            <div>
                 <asp:Label ID="Lblstatus" runat="server"></asp:Label>

                </div>
                


             <div>
                 <strong>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style8" Width="295px" />
                
                 </strong>
            </div>


            <div>
                </div>

          <div>
          <asp:TextBox ID="Factor1txt" runat="server" CssClass="auto-style3" Width="193px"></asp:TextBox>
              <strong>
              <asp:Label ID="Factor1lbl" runat="server" Text="Factor 1" CssClass="auto-style6"></asp:Label>
              </strong>
          </div>    
            
            <div>

                </div>
                
            
            <div>
             <asp:TextBox ID="Factor2txt" runat="server" CssClass="auto-style2" Width="193px"></asp:TextBox>
                <strong>
                <asp:Label ID="Factor2lbl" runat="server" Text="Factor 2" CssClass="auto-style6"></asp:Label>
                </strong>
                </div>


            <div>

                </div>

            <div>
                <asp:TextBox ID="Factor3txt" runat="server" CssClass="auto-style3" Width="191px"></asp:TextBox>
                <strong>
                <asp:Label ID="Factor3lbl" runat="server" Text="Factor 3" CssClass="auto-style6"></asp:Label>
                </strong>
            </div>

            <div>

                </div>

            <div>
                <asp:TextBox ID="Factor4txt" runat="server" CssClass="auto-style3" Width="191px"></asp:TextBox>
                <strong>
                <asp:Label ID="Factor4lbl" runat="server" Text="Factor 4" CssClass="auto-style6"></asp:Label>
                </strong>
            </div>


            <div>

                </div>



            <div>
                <asp:TextBox ID="Factor5txt" runat="server" CssClass="auto-style4" Width="188px"></asp:TextBox>
                <strong>
                <asp:Label ID="Factor5lbl" runat="server" Text="Factor 5" CssClass="auto-style6"></asp:Label>
                </strong>
            </div>

            <div>

                </div>


           



            <div>
                <strong>
                <asp:Button ID="Loadmutualbtn" runat="server" Text="Load mutual" Width="85px" CssClass="auto-style5" OnClick="Loadmutualbtn_Click" />
                <asp:Button ID="Forecastbtn" runat="server" Text="Forecast" Width="86px" CssClass="auto-style7" />
                </strong>
                </div>

            <div>
                </div>

            <div>
                <strong>
                <asp:Button ID="Importbtn" runat="server" Text="Import into Database" Width="196px" CssClass="auto-style7" OnClick="Importbtn_Click" />
            
                </strong>
           </div>

            <div>
                </div>

            <div>
                  <strong>
                  <asp:Button ID="Delbtn" runat="server" Text="Delete data" CssClass="auto-style10" Width="198px" OnClick="Delbtn_Click" />
                  </strong>
                </div>



                 

                 
       </td>
       
    </tr>

           




    <tr>
        <td colspan="2" style="background-color:#3399FF; text-align:center">
            <b>Website Footer-align:center">
            <b>Website Footer</b>
        </td>
    </tr>
</table>
    
    </form>
</body>
</html>
