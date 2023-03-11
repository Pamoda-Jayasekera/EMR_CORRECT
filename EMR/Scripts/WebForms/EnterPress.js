//CdnPath=http://ajax.aspnetcdn.com/ajax/4.5.1/1/Enterpress.js
function OnKeyUp(obj) {
    var objval = obj.value;
    if (obj.id == "txtRBClerk" && window.event.keyCode == 13) {
        Response.Write("<script language='javascript'>alert('Enter Pressed!!!')</script>");
    }
}