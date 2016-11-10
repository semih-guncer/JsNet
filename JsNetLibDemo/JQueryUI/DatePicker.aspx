<%@ Page Title="JsNet Demo : JQueryUI:DateTime" Language="C#" AutoEventWireup="true" CodeBehind="DatePicker.aspx.cs" Inherits="JsNetLibDemo.JQueryUI.DatePicker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
  <title><%= Page.Title %></title>
  <link rel="stylesheet" type="text/css" href="~/Content/themes/base/jquery-ui.css"/>
  <link rel="stylesheet" type="text/css" href="~/Content/bootstrap.css"/>
  <script type="text/javascript" src="../Scripts/jquery-3.1.1.js"></script>
<!--[if IE]><script type="text/javascript" src='<%# Page.ResolveUrl("~/Scripts/jquery.bgiframe.js") %>'></script><![endif]-->
  <script type="text/javascript" src="../Scripts/jquery-ui-1.12.1.js"></script>
  <script type="text/javascript" src="../Scripts/jquery-ui-i18n.min.js"></script>
  <script type="text/javascript" src="../Scripts/jquery.maskedinput.js"></script>
  <script type="text/javascript" src="../Scripts/jquery.inputmask/jquery.inputmask.bundle.js"></script>
  <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
     
 </head>
 <body>
  <form id="form1" runat="server">
   <div class="content-box">
    <h1><%= Page.Title %></h1>
    <asp:LinkButton ID="lbHome" runat="server" PostBackUrl="~/Default.aspx" Text="Home" /><br />
    <div class="row">
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>DatePicker</p>
      <asp:TextBox runat="server" ID="tbDatePicker" /><br />
<script type="text/javascript">
    $('#tbDatePicker').datepicker(<%= GetExampleDatePicker() %>);
</script>
      <br />
     </div>
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>DatePicker & Masked Input</p>
      <asp:TextBox runat="server" ID="tbDatePickerMaskedInput" /><br />
<script type="text/javascript">
    $('#tbDatePickerMaskedInput').datepicker(<%= GetExampleDatePicker() %>).mask("99.99.9999");
</script>
      <br />
     </div>
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>DatePicker & Input Mask</p>
      <asp:TextBox runat="server" ID="tbDatePickerInputMask" data-inputmask="'alias': 'dd.mm.yyyy'" /><br />
<script type="text/javascript">
    $('#tbDatePickerInputMask').datepicker(<%= GetExampleDatePicker() %>);
</script>
      <br />
     </div>

    </div>

   </div>
  </form>
 </body>
 <script type="text/javascript">
$(<%= GetInitFunction() %>);
 </script>
 </html>
