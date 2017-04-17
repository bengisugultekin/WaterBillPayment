using IZSU.DAL;
using System;

namespace IZSU.WEB
{
    public partial class FaturaGoruntule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonAra_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtAboneNo.Text);

            Repeater1.DataSource = FaturaRepository.GetListeFatura(id);
            Repeater1.DataBind();

          
        }
    }
}