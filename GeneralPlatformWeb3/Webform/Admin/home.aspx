<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ExamLib.Webform.Admin.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="common/css/styling.css" />
    <link rel="stylesheet" href="common/css/icons.css" />

    <%--<link rel="stylesheet" href="common/css/stylesheets.css">--%>
    <%--<link rel="stylesheet" href="common/css/stylesheet.css">--%>
    <style type="text/css">
        body {
            min-height: 100%;
            font-family: "Segoe UI", arial, sans-serif;
            font-size: 12px;
            position: relative;
            background: url('../img/backgrounds/default.jpg') left top repeat;
        }

        .body {
            position: relative;
            margin-top: 50px;
            margin-left: 100px;
            margin-right: 100px;
            padding: 0px 0px 0px 20px;
        }

            .body .navigation {
                padding: 10px 0px 25px;
                margin: 0px;
                list-style: none;
                display: block;
                position: relative;
            }

        ul, ol {
            padding: 0;
            margin: 0 0 10px 25px;
        }

        .body .navigation li {
            margin-left: 10px;
            margin-bottom: 10px;
            display: block;
            float: left;
        }

        li {
            line-height: 20px;
        }

        .body .navigation .button {
            width: 300px;
            height: 200px;
            display: block;
            padding: 5px;
            background: #009AD7;
            text-decoration: none;
            position: relative;
        }

        a {
            outline: none !important;
        }

        a {
            color: #08c;
            text-decoration: none;
        }



        .body .navigation .button .icon {
            float: left;
            /*display: block;*/
            width: 44px;
            height: 44px;
            border: 3px solid #FFF;
            margin: 15px 20px 12px;
            -moz-border-radius: 50%;
            -webkit-border-radius: 50%;
            border-radius: 50%;
            text-align: center;
        }

            .body .navigation .button .icon [class^="ico-"] {
                font-size: 27px;
                color: #FFF;
                line-height: 45px;
            }


        .body .navigation .button .title {
            width: 200px;
            height: 44px;
            margin-top: 10px;
            margin-left: 5px;
            float: left;
            font-size: 18px;
            color: #FFF;
            line-height: 44px;
        }

        .body .navigation .button .name {
            width: 280px;
            margin-left: 20px;
            min-height: 80px;
            float: left;
            font-size: 14px;
            color: #FFF;
            line-height: 20px;
        }
    </style>
    <script>
        window.onload = function () {
            // Translate the dialog box texts.
            var divCourse_Edit = document.getElementById("divCourse_Edit");
            if (divCourse_Edit != null) {
                divCourse_Edit.onclick = CourseEdit();
            }

            //oEditor.FCKLanguageManager.TranslatePage(document);

            //window.parent.SetAutoSize(true);
        }
        function CourseEdit() {
            //   self.location = "../JumpPage.aspx?FunctionName=Course-Edit";
            var a = document.createElement("a");
            var node = document.createTextNode("link");
            a.appendChild(node);
            a.setAttribute("href", "../JumpPage.aspx?FunctionName=Course-Edit");
            var myspan = document.createElement("sp1");
            myspan.innerText = "ABC";
            a.appendChild(myspan);
            addIframe(a);
        }
        function fun() {
            var a = document.createElement("a");
            var node = document.createTextNode("link");
            a.appendChild(node);
            a.setAttribute("href", "../JumpPage.aspx?FunctionName=Course-Edit");
            var myspan = document.createElement("sp1");
            myspan.innerText = "ABC";
            a.appendChild(myspan);
            //var row = document.getElementById("row").value - 1;
            //var col = document.getElementById("col").value - 1;
            //var table = document.getElementById("test");
            //var tr = table.getElementsByTagName("tr")[row];
            //var td = tr.getElementsByTagName("td")[col];
            //td.appendChild(a);
            addIframe(a);
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divNBU" runat="server">
            <asp:Image ID="Image1" ImageUrl="~/pic/Nbu_Index1.png" runat="server" Height="600px" Width="800px" />
        </div>
        <div id="divJT" runat="server" class="body">
            <ul class="navigation">
                <li>
                    <a href="home.aspx" class="button">

                        <div class="icon">
                            <span class="ico-monitor"></span>
                        </div>
                        <div class="title" id="divCourse_Edit">
                            答题步骤：
                        </div>

                        <div class="name">
                            <span>1、试卷习题管理-》完成试卷(参加答题)</span><br />
                            <span>2、生成试卷：选择：知识竞赛1706，然后单击右上角按钮【生成试卷】</span><br />
                            <span>3、查看批次：单击试卷【知识竞赛1706】后面的【查看批次】</span><br />

                        </div>
                    </a>
                </li>
                <li>
                    <a href="home.aspx" class="button yellow">

                        <div class="icon">
                            <span class="ico-cog-2"></span>
                        </div>
                        <div class="title">
                            答题步骤：
                        </div>

                        <div class="name">
                            <span>4、完成试卷：单击某一批次中的【完成试卷】</span><br />
                            <span>5、完成题目：单击题目后面的【完成题目】</span><br />
                            <span>6、上一道、下一道：切换题目</span><br />

                        </div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button green">

                        <div class="icon">
                            <span class="ico-pen-2"></span>
                        </div>
                        <div class="title">
                            标题3
                        </div>

                        <div class="name">内容3</div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button red">
                        <div class="icon">
                            <span class="ico-globe-3"></span>
                        </div>
                        <div class="title">
                            标题4
                        </div>

                        <div class="name">内容4</div>
                    </a>
                </li>
                <li>
                    <a href="home.aspx" class="button dblue">

                        <div class="icon">
                            <span class="ico-layout-7"></span>
                        </div>
                        <div class="title">
                            标题5
                        </div>

                        <div class="name">内容5</div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button purple">

                        <div class="icon">
                            <span class="ico-box"></span>
                        </div>
                        <div class="title">
                            标题6
                        </div>

                        <div class="name">内容6</div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button orange">

                        <div class="icon">
                            <span class="ico-cloud"></span>
                        </div>
                        <div class="title">
                            标题7
                        </div>

                        <div class="name">内容7</div>
                    </a>

                </li>

                <li>
                    <a href="home.aspx" class="button block">

                        <div class="icon">
                            <span class="ico-info-2"></span>
                        </div>
                        <div class="title">
                            标题8
                        </div>

                        <div class="name">内容8</div>
                    </a>

                </li>

            </ul>
        </div>
        <div id="divTzJsie" runat="server" class="body">
            <ul class="navigation">
                <li>
                    <a href="home.aspx" class="button">

                        <div class="icon">
                            <span class="ico-monitor"></span>
                        </div>
                        <div class="title" id="divCourse_Edit">
                            答题步骤：
                        </div>

                        <div class="name">
                            <span>1、试卷习题管理-》完成试卷(参加答题)</span><br />
                            <span>2、生成试卷：选择：知识竞赛1706，然后单击右上角按钮【生成试卷】</span><br />
                            <span>3、查看批次：单击试卷【知识竞赛1706】后面的【查看批次】</span><br />

                        </div>
                    </a>
                </li>
                <li>
                    <a href="home.aspx" class="button yellow">

                        <div class="icon">
                            <span class="ico-cog-2"></span>
                        </div>
                        <div class="title">
                            答题步骤：
                        </div>

                        <div class="name">
                            <span>4、完成试卷：单击某一批次中的【完成试卷】</span><br />
                            <span>5、完成题目：单击题目后面的【完成题目】</span><br />
                            <span>6、上一道、下一道：切换题目</span><br />

                        </div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button green">

                        <div class="icon">
                            <span class="ico-pen-2"></span>
                        </div>
                        <div class="title">
                            标题3
                        </div>

                        <div class="name">内容3</div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button red">
                        <div class="icon">
                            <span class="ico-globe-3"></span>
                        </div>
                        <div class="title">
                            标题4
                        </div>

                        <div class="name">内容4</div>
                    </a>
                </li>
                <li>
                    <a href="home.aspx" class="button dblue">

                        <div class="icon">
                            <span class="ico-layout-7"></span>
                        </div>
                        <div class="title">
                            标题5
                        </div>

                        <div class="name">内容5</div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button purple">

                        <div class="icon">
                            <span class="ico-box"></span>
                        </div>
                        <div class="title">
                            标题6
                        </div>

                        <div class="name">内容6</div>
                    </a>

                </li>
                <li>
                    <a href="home.aspx" class="button orange">

                        <div class="icon">
                            <span class="ico-cloud"></span>
                        </div>
                        <div class="title">
                            标题7
                        </div>

                        <div class="name">内容7</div>
                    </a>

                </li>

                <li>
                    <a href="home.aspx" class="button block">

                        <div class="icon">
                            <span class="ico-info-2"></span>
                        </div>
                        <div class="title">
                            标题8
                        </div>

                        <div class="name">内容8</div>
                    </a>

                </li>

            </ul>
        </div>

        <script type="text/javascript" src="common/lib/jquery-1.9.0.min.js"></script>
        <script type="text/javascript" src="common/js/sccl.js"></script>
        <script type="text/javascript" src="common/js/sccl-util.js"></script>
    </form>
</body>
</html>
