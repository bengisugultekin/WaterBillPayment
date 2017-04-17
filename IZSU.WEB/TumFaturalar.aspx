<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TumFaturalar.aspx.cs" Inherits="IZSU.WEB.TumFaturalar" %>

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
        <h1 class="alert alert-info" role="alert">Fatura Listesi</h1>
        <br />
        <div class="table-responsive">
            <table style="text-align: center" class="table table-responsive table-hover table-condensed">

                <tr>
                    <th style="text-align: center">Abone ID</th>
                    <th style="text-align: center">Odeme Tutarı</th>
                    <th style="text-align: center">Önceki Sayaç</th>
                    <th style="text-align: center">Güncel Sayaç</th>
                    <th style="text-align: center">Fatura Tarihi</th>
                    <th style="text-align: center">Tahsilat Durumu</th>
                </tr>


                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr class="<%#Eval("Tahsilat").ToString() == "True" ? "success" : "danger" %>">
                            <td><%#Eval("AboneID") %></td>
                            <td><%#Eval("OdemeTutari") %></td>
                            <td><%#Eval("OncekiSayac") %></td>
                            <td><%#Eval("GuncelSayac") %></td>
                            <td><%#Eval("FaturaTarihi") %></td>
                            <td><%#Eval("Tahsilat").ToString() == "True" ? "Ödendi" : "Ödenmedi" %></td>                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>


            </table>

        </div>
    </div>

</body>
</html>
