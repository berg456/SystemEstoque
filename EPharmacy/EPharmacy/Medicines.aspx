<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medicines.aspx.cs" Inherits="EPharmacy.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
<html lang="en">
  <head>
    <title>Medicines</title>
    <link rel="stylesheet" href="Medicines.css">
  </head>
  <body>
    <div id="BigCont">
      <div id="Ti"><h3>Medicines</h3></div>
      <div id="I"></div><br><br>
      <div id="Bloc1">
        <input type="text" name="" id="MName" placeholder="Medicine Name">
          <asp:DropDownList ID="MType" runat="server">
              <asp:ListItem Text="Sirop" Value="Sirop"></asp:ListItem>
              <asp:ListItem Text="Tablets" Value="Tablets"></asp:ListItem>
              <asp:ListItem Text="Injection" Value="Injection"></asp:ListItem>
              <asp:ListItem Text="Perfusion" Value="Perfusion"></asp:ListItem>
          </asp:DropDownList>
        <input type="number" name="" id="MQty" placeholder="Quantity">
        <input type="number" name="" id="MPrice" placeholder="Price">
          <asp:DropDownList ID="MMan" runat="server">
              <asp:ListItem Text="Shalina" Value="Shalina"></asp:ListItem>
              <asp:ListItem Text="IndiaMed" Value="IndiaMed"></asp:ListItem>
              <asp:ListItem Text="Karnamed" Value="KarnaMed"></asp:ListItem>
              <asp:ListItem Text="Phizer" Value="Phizer"></asp:ListItem>
              <asp:ListItem Text="DelhyMed" Value="DelhyMed"></asp:ListItem>
          </asp:DropDownList>
        
      </div><br><br><br>
      <div id="BtDiv">
        <button>Add</button>   <button>Edit</button>   <button>Delete</button>

      </div>
        <div id="GVDiv">

            <asp:GridView ID="MedGV" runat="server" Height="135px">
            </asp:GridView>

        </div>
    </div>
  </body>
</html>
</asp:Content>
