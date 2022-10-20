<%@ Page Title="" Language="C#" MasterPageFile="~/MiPagina.Master" AutoEventWireup="true" CodeBehind="Deduccion.aspx.cs" Inherits="Pregunta1.Deduccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:HiddenField runat="server" ID="hf_Control" />
    <div class="contenedor">

        <h2>Deducciones del Empleado</h2>

        Codigo<asp:TextBox ID="txtCodigo" runat="server" Height="22px"></asp:TextBox> <br />
        Id Empleado<asp:TextBox ID="txtEmpleado" runat="server"></asp:TextBox><br /><br />
        Cooperativa<asp:TextBox ID="txtCooperativa" runat="server"></asp:TextBox><br /><br />
        Prestamo<asp:TextBox ID="txtPrestamo" runat="server"></asp:TextBox><br /><br />
        Ahorro<asp:TextBox ID="txtAhorro" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btn_guardar" runat="server" Text="Incluir" OnClick="btn_Guardar_Click" />
    </div>
</asp:Content>
