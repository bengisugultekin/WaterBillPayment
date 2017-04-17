using IZSU.DAL;
using System;

namespace IZSU.WEB
{
    public partial class FaturaOdeme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                FaturaRepository.UpdateOdenenFatura(id);

                Response.Redirect("FaturaOdeme.aspx");

            }
        }

        protected void ButtonAra_Click(object sender, EventArgs e)
        {
            var result = FaturaRepository.GetOdenmemisFaturalar(int.Parse(TxtAboneNo.Text));

            if (result.Count != 0)
            {
                Repeater1.DataSource = result;
                Repeater1.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Ödenecek fatura yoktur.')", true);

            }



        }
    }
}