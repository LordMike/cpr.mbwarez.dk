<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CPRCheck.aspx.cs" Inherits="CPR.CPRCheck" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body { font-family: verdana;font-size: 11px; }
        .Error { color: red; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            Slå en dato op, og se alle mulige kombinationer af CPR numre på den dag. Dette projekt bruger kode fra <a href="http://blog.mbwarez.dk/?p=139">min blog</a>.<br/>
            <br/>
            Dato: <asp:TextBox runat="server" ID="txtDate"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valDateRequired" CssClass="Error" runat="server" Display="Dynamic" ErrorMessage="Påkrævet felt" ControlToValidate="txtDate"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="valDateCustom" CssClass="Error" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="Indtast en gyldig dato" onservervalidate="ValDateCustomServerValidate"></asp:CustomValidator>
            <br/>
            Køn: <asp:DropDownList runat="server" ID="drpDownGender"></asp:DropDownList><br/>
            <asp:Button runat="server" ID="cmdGenerate" Text="Generer" onclick="CmdGenerateClick"/><br/>
            <br/>
            <asp:Label runat="server" CssClass="Error" ID="lblStatus" EnableViewState="False"></asp:Label>
            <br/>
            <br/>
            Mulige kombinationer <b><%= rptPossibles.Items.Count %></b>:<br/>
            <asp:Repeater runat="server" ID="rptPossibles">
                <ItemTemplate>
                    <%# Container.DataItem %><%# (Container.ItemIndex+1) % 8 == 0 ? "<br />" : ", "%>
                </ItemTemplate>
            </asp:Repeater>
            <br/>
            <br />
            Teknisk: Du kan også selv få disse data ud, ved at kigge på denne SOAP service: <a href="CPRService.asmx">SOAP Service</a>.
        </div>
    </form>
</body>
</html>
