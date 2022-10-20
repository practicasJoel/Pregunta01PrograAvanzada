<%@ Page Title="" Language="C#" MasterPageFile="~/MiPagina.Master" AutoEventWireup="true" CodeBehind="IngresarEmpleado.aspx.cs" Inherits="Pregunta1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <asp:HiddenField runat="server" ID="hf_Control" />
    <div class="contenedor">

        <h2>Datos Empleado</h2>

        Codigo<asp:TextBox ID="txtCodigo" runat="server" Height="22px"></asp:TextBox> <br />
        Nombre<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
        Horas Laboradas<asp:TextBox ID="txtHorasL" runat="server"></asp:TextBox><br /><br />
        Salario por Hora<asp:TextBox ID="txtSalarioXhora" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btn_guardar" runat="server" Text="Incluir" OnClick="btn_Guardar_Click" />
    </div>

</asp:Content>
