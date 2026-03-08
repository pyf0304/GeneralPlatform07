<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmDispUserMenu" CodeBehind="wfmDispUserMenu.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmTestMenu</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <style type="text/css">
        .style1 {
            FONT-SIZE: 12px;
            COLOR: #000099;
            FONT-FAMILY: Verdana;
        }

        .style2 {
            FONT-SIZE: 12px;
            COLOR: #0000ff;
            FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif;
        }

        A:link {
            COLOR: #003366;
            TEXT-DECORATION: none;
        }

        A:visited {
            COLOR: #003366;
            TEXT-DECORATION: none;
        }

        A:hover {
            BACKGROUND-COLOR: #ffff99;
            TEXT-DECORATION: underline;
        }

        A:active {
            COLOR: #669966;
            TEXT-DECORATION: none;
        }

        BODY {
            BACKGROUND-COLOR: #daefdc;
        }
    </style>

    <script language="JavaScript" type="text/javascript">
<!--
    /*
    function showthis(Tid)
    {
        var c=document.getElementsByTagName("table");
        var l=c.length;
        var i;
        for(i=0;i<l;i++)
        {
            str = c[i].id;
            str = str.substr(0,4);
            if(str=="menu")
            {
                if(c[i].id==Tid)
                    if(c[i].style.display=="")
                        c[i].style.display="none";
                    else	
                        c[i].style.display="";
                else c[i].style.display="none";
            }
        }
    }
    */
    function showthis(Tid)
    {
        var c=document.getElementsByTagName("table");
        var l=c.length;
        var i;
        if (Tid.length == 8)
        {
            //alert("length == 8");
            for(i=0;i<l;i++)
            {
                str = c[i].id;		    
                if(str==Tid)
                {
                    if(c[i].style.display=="")
                        c[i].style.display="none";
                    else	
                        c[i].style.display="";
                    break;
                }
            }
        }
        else     
        {
            for(i=0;i<l;i++)
            {
                str = c[i].id;
                str = str.substr(0,4);
                if(str=="menu")
                {
                    c[i].style.display="none";
                }
            }
            showFather(Tid);
            showBrother(Tid);
            showSon(Tid);
        }
	
    }
    function showSon(Tid)
    {
        var c=document.getElementsByTagName("table");
        c[Tid].style.display="";
        var i;
        for(i=0;i<9;i++)
        {
            if(c[Tid+i]!=null)
            { 
                if( c[Tid+i].style.display="none")
                    c[Tid+i].style.display="";
            }
        }
    }
    function showFather(Tid)
    {
        var c=document.getElementsByTagName("table");
        if(Tid !="menu")
        {
            var father = Tid.substring(0,Tid.length-1);
            if( c[father]!=null)
            {  c[father].style.display="";
                showFather(father);
            }
        }
        else
            return;
    }
    function showBrother(Tid)
    {
        var c=document.getElementsByTagName("table");
        if(Tid !="menu")
        {
            var father=Tid.substring(0,Tid.length-1);
            if(c[father]!=null)
                showSon(father);
        }
    }
    -->
    </script>

</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="Table1" style="z-index: 101; left: 2px; cursor: hand; border-top-style: groove; border-right-style: groove; border-left-style: groove; position: absolute; top: 13px; background-color: #daefe6; border-bottom-style: groove"
            cellspacing="1" cellpadding="1"
            width="164" border="1">
            <tr>
                <td>
                    <span id="spanMenu" runat="server"></span>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
