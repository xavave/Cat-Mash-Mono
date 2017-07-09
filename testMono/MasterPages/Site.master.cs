using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testMono
{
	public partial class Site : System.Web.UI.MasterPage
	{
protected void btnRestart_Click(object sender, EventArgs e)
{
	SessionHelper.Set<List<Cat>>("cats", null);
	Response.Redirect("~/");
	  }
	}
}
