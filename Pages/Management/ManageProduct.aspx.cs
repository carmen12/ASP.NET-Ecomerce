using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getImages();
        }
    }

    private void getImages()
    {
        try
        {
          string[] images= Directory.GetFiles(Server.MapPath("~/Images/Products/"));

            ArrayList imageList = new ArrayList();

            foreach(string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

            ddlImage.DataSource = imageList;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();

        }
        catch (Exception e)
        {
            lblResult.Text = e.ToString();
        }
    }

    private Product createProduct()
    {
        Product p = new Product();
        p.Name = txtName.Text;
        p.Description = txtDescription.Text;
        p.Price = Convert.ToInt32( txtPrice.Text);
        p.TypeID = Convert.ToInt32(ddlType.SelectedValue);
        p.Image = ddlImage.SelectedValue;

        return p;
    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        ProductModel pm = new ProductModel();
        Product p = createProduct();

        lblResult.Text = pm.InsertProduct(p);
    }
    protected void ddlImage_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}