<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YeniAboneEkle.aspx.cs" Inherits="IZSU.WEB.YeniAboneEkle" %>

<!DOCTYPE html>

<html lang="tr">
<head>
    <title>IZSU</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>


</head>
<body>

    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="Home.aspx">IZSU</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="Home.aspx">Anasayfa</a></li>
                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Abonelik İşlemleri<span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="TumAboneler.aspx">Tüm Aboneler</a></li>
                        <li><a href="YeniAboneEkle.aspx">Yeni Su Aboneliği</a></li>
                        <li><a href="AboneDuzenle.aspx">Abone Bilgi Düzenle</a></li>
                        <li><a href="AboneSilmek.aspx">İlişki Kesme</a></li>
                    </ul>
                </li>

                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Fatura İşlemleri<span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="TumFaturalar.aspx">Tüm Faturalar</a></li>
                        <li><a href="FaturaGoruntule.aspx">Fatura Bilgisi Görüntüle</a></li>
                        <li><a href="FaturaEkle.aspx">Fatura Ekleme</a></li>
                        <li><a href="FaturaOdeme.aspx">Fatura Ödeme</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </nav>

    <div class="container">
        <h1 class="alert alert-info" role="alert">Yeni Su Aboneliği</h1>
        <br />
        <form id="form1" runat="server">

            <div class="form-group">

                <asp:Label ID="Label2" runat="server" Text="Ad Soyad"></asp:Label>

                <asp:TextBox ID="TxtAdSoyad" runat="server" PlaceHolder="Ad Soyad" CssClass="form-control" required></asp:TextBox>
            </div>

            <div class="form-group">

                <asp:Label ID="Label3" runat="server" Text="Abone Tipi"></asp:Label>

                <asp:DropDownList ID="DropDownListAboneTipi" PlaceHolder="Abone Tipi" CssClass="form-control" runat="server" required></asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="kaydet" runat="server" CssClass="btn btn-default" Text="Kaydet" OnClick="kaydet_Click" />
            </div>
        </form>
    </div>

</body>
</html>
