using IZSU.DAL;
using System;

namespace IZSU.WEB
{
    public partial class TumFaturalar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = FaturaRepository.GetAllFaturas();
            Repeater1.DataBind();
        }
    }
}