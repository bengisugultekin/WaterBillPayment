using IZSU.DAL;
using System;

namespace IZSU.WEB
{
    public partial class TumAboneler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = AboneRepository.GetAllAbones();
            Repeater1.DataBind();
        }
    }
}