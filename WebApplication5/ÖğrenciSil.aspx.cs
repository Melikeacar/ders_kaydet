using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayerr;
using DataAccessLayer;
using BusinessLogicLayer;

namespace WebApplication5
{
    public partial class ÖğrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            Response.Write(x);
            Entityogrenci ent = new Entityogrenci();
            ent.Id = x;
            BLLOgrenci.OgrenciSilBLL(ent.Id);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}