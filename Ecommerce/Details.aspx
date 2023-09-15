<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Ecommerce.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Dettagli articolo</h1>
    <div class="col-12 d-flex align-items-stretch justify-content-center">
        <div class="card">
            <div class="d-flex align-items-center justify-content-around">

                <img src="" runat="server" id="img" style="width: 200px; max-height: 250px"
                    class="card-img-top" alt="Manca foto">
            </div>
            <div class="card-body d-flex flex-column">
                <b class="card-text fs-1" runat="server" id="price"></b>
                <h5 class="card-title flex-grow-1" runat="server" id="name"></h5>
                <h5 class="card-title flex-grow-1" runat="server" id="desc"></h5>
                <div class="d-flex justify-content-center">

                <p class="m-0 me-1">Scegli la quantità</p>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1" Text="1"></asp:ListItem>
                    <asp:ListItem Value="2" Text="2"></asp:ListItem>
                    <asp:ListItem Value="3" Text="3"></asp:ListItem>
                    <asp:ListItem Value="4" Text="4"></asp:ListItem>
                    <asp:ListItem Value="5" Text="5"></asp:ListItem>
                </asp:DropDownList>
                </div>
                <asp:Button ID="AddCart" CssClass="btn btn-success mt-2" runat="server" Text="Aggiungi a carrello" OnClick="AddCart_Click" />
            </div>
        </div>
    </div>
</asp:Content>