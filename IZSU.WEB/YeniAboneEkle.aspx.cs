using IZSU.DAL;
using IZSU.Entity.Model;
using System;

namespace IZSU.WEB
{
    public partial class YeniAboneEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListAboneTipi.DataSource = AboneTuruRepository.GetAllAboneTurus();
                DropDownListAboneTipi.DataBind();
            }
        }



        protected void kaydet_Click(object sender, EventArgs e)
        {
            Abone yeniAbone = new Abone();
            yeniAbone.AboneAdSoyad = TxtAdSoyad.Text;


            if (DropDownListAboneTipi.SelectedIndex == 0)
            {
                yeniAbone.AboneTuruID = 1;
            }
            else
            {
                yeniAbone.AboneTuruID = 2;
            }

            AboneRepository.AddAbone(yeniAbone);

            Response.Redirect("TumAboneler.aspx");

        }
    }
}