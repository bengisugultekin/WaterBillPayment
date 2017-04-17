using IZSU.DAL;
using IZSU.Entity.Model;
using System;
using System.Web.UI;

namespace IZSU.WEB
{
    public partial class AboneDuzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListAboneTipi.DataSource = AboneTuruRepository.GetAllAboneTurus();
                DropDownListAboneTipi.DataBind();
            }
        }

        protected void ButtonAra_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = string.Empty;

            int aboneNo = int.Parse(AboneNo.Value);

            var result = AboneRepository.GetViewAbone(aboneNo);
            if (result != null)
            {

                TxtAdSoyad.Text = result.AboneAdSoyad;
                DropDownListAboneTipi.ClearSelection();
                DropDownListAboneTipi.Items.FindByValue(result.AboneTuruAd).Selected = true;


                LabelAdSoyad.Visible = true;
                TxtAdSoyad.Visible = true;
                LabelTip.Visible = true;
                DropDownListAboneTipi.Visible = true;
                ButtonKaydet.Visible = true;
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", "alert('Aradığınız abone bulunamamıştır.')", true);

            }
        }

        protected void ButtonKaydet_Click(object sender, EventArgs e)
        {
            Abone degisenAbone = new Abone();

            degisenAbone.AboneID = int.Parse(AboneNo.Value);

            degisenAbone.AboneAdSoyad = TxtAdSoyad.Text;

            if (DropDownListAboneTipi.SelectedIndex == 0) //Ev
            {
                degisenAbone.AboneTuruID = 1;
            }
            else
            {
                degisenAbone.AboneTuruID = 2;
            }


            AboneRepository.UpdateAbone(degisenAbone);


            Response.Redirect("TumAboneler.aspx");


        }
    }
}

