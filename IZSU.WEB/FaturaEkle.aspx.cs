using IZSU.DAL;
using IZSU.Entity.Model;
using System;

namespace IZSU.WEB
{
    public partial class FaturaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }     

      
        

        protected void TxtAboneNo_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(TxtAboneNo.Text);
            var fatura = FaturaRepository.GetFatura(id);
            TextBoxOnceki.Text = fatura.GuncelSayac.ToString();
        }

        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            Fatura yeniFatura = new Fatura();
            yeniFatura.AboneID = int.Parse(TxtAboneNo.Text);
            yeniFatura.OncekiSayac = int.Parse(TextBoxOnceki.Text);
            yeniFatura.GuncelSayac = int.Parse(TextBoxGuncel.Text);
            yeniFatura.FaturaTarihi = Convert.ToDateTime(TxtCalendar.Text);

            
            int _AboneTuruID = AboneRepository.FindAboneTuruID(yeniFatura.AboneID).AboneTuruID;
            yeniFatura.OdemeTutari = (decimal)yeniFatura.OdemeHesapla(_AboneTuruID);

            FaturaRepository.AddFatura(yeniFatura);

            Response.Redirect("TumFaturalar.aspx");

            
        }
    }
}