using IZSU.DAL;
using System;
using System.Web.UI;

namespace IZSU.WEB
{
    public partial class AboneSilmek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAra_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = string.Empty;
            TextBoxAboneTipi.Text = string.Empty;

            int aboneNo = int.Parse(TxtAboneNo.Text);

            var result = AboneRepository.GetViewAbone(aboneNo);

            if (result != null)
            {

                TxtAdSoyad.Text = result.AboneAdSoyad;
                TextBoxAboneTipi.Text = result.AboneTuruAd;
                LabelAdSoyad.Visible = true;
                TxtAdSoyad.Visible = true;
                LabelTip.Visible = true;
                TextBoxAboneTipi.Visible = true;
                ButtonSil.Visible = true;

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", "alert('Aradığınız abone bulunamamıştır.')", true);

            }
        }

        protected void ButtonSil_Click(object sender, EventArgs e)
        {
            int aboneNo = int.Parse(TxtAboneNo.Text);


            AboneRepository.DeleteAbone(aboneNo);

            Response.Redirect("TumAboneler.aspx");

        }



    }
}