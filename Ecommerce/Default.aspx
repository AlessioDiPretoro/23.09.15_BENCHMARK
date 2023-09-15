<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Home Page</h1>
    <div class="row gy-2 container m-auto">
        <asp:Repeater ID="Repeater1" runat="server" ItemType="Ecommerce.Products">
            <ItemTemplate>
                <div class="col-12 col-sm-6 col-md-3  d-flex align-items-stretch">
                    <div class="card d-flex" style="width: 18rem;">
                        <div class="d-flex align-items-center justify-content-around">

                            <img src="Content/img/<%# Item.Code%>.jpg" style="max-width: 100px; max-height: 150px"
                                class="card-img-top" alt="Manca foto">
                            <b class="card-text"><%# Item.Price.ToString("C2") %> </b>
                        </div>
                        <div class="card-body d-flex flex-column">
                            <h5 class="card-title flex-grow-1"><%# Item.Name %> </h5>
                            <a href="Details.aspx?idDetails=<%# Item.Id %> " class="btn btn-primary">Dettagli</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>