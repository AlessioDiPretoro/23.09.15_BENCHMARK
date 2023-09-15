<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ecommerce.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center m-4">Carrello</h1>
    <asp:GridView ID="GridView1" CssClass="table table-hover table-bordered container text-center " runat="server" AutoGenerateColumns="false" ItemType="Ecommerce.CartItem">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Foto</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <img src="Content/img/<%# Item.Products.Code%>.jpg" style="max-width: 50px; max-height: 50px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Nome</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Products.Name%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Quantità</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.quantity%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Prezzo cad.</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Products.Price%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Prezzo Totale</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Products.Price*Item.quantity%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Elimina</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Button ID="DeleteThis" runat="server" Text="X" CssClass="btn btn-danger" OnClick="DeleteThis_Click" />
                    <%--<p id="indextCart" runat="server"><%#DataBinder.Eval(Container, "DataItemIndex")%></p>--%>
                </ItemTemplate>

            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    <div class="d-flex justify-content-center">
        <b runat="server" id="totalPrice"></b>
    </div>
    <div class="d-flex justify-content-center mt-2">
        <p runat="server" id="isEmpty"></p>
        <asp:Button CssClass="btn btn-danger" ID="DeleteAll" runat="server" Text="Svuota carrello" OnClick="DeleteAll_Click" />
    </div>
</asp:Content>