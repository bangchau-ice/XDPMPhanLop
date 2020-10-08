<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridJob.aspx.cs" Inherits="Todolist.GridJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<asp:FormView ID="chitietJob" runat="server">
      <ItemTemplate>
          <table>
            <tr>
                <td>ID:</td>
                <td><%# Eval("job_id") %></td>
            </tr>
             <tr>
                <td>tiêu đề:</td>
                <td><%# Eval("job_title") %></td>
             </tr>
              <tr>
                  <td>ngày bắt đầu:</td>
                   <td><%# Eval("job_starday") %></td>
              </tr>
              <tr>
                  <td>ngày kết thúc:</td>
                   <td><%# Eval("job_endday") %></td>
             </tr>
              <tr>
                  <td>phạm vi:</td>
                   <td><%# Eval("job_circle") %></td>
             </tr>
              <tr>
                  <td>tệp đính kèm:</td>
                   <td><%# Eval("job_attachments") %></td>
                  
             </tr>
              <tr>
                  <td>nooiji dung cmt: </td>
                  <td><%# Eval("cmt_content") %></td>
              </tr>
              <tr>
                  <td>tên nv: </td>
                  <td><%# Eval("user_id") %></td>
              </tr>
     </table>
   </ItemTemplate>
</asp:FormView>
</body>
    </html>