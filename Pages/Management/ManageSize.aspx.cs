using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageSize : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SizeModel model = new SizeModel();
        Size s = createSize();

        labelResult.Text = model.InsertSize(s);
    }

    private Size createSize()
    {
        Size s = new Size();
        s.Name = txtName.Text;

        return s;
    }
}