using System;
using System.Linq;

public partial class Pages_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        //Get selected product data
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ProductModel model = new ProductModel();
            Product product = model.GetProduct(id);

            //Fill page with data
            lblTitle.Text = product.Name;
            lblDescription.Text = product.Description;
            lblPrice.Text = "Price per unit:<br/> " + product.Price+" lei";
            imgProduct.ImageUrl = "~/Images/Products/" + product.Image;
            lblItemNr.Text = product.ID.ToString();

            //Fill amount list with numbers 1-20
            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string clientId = "1";
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int amount = Convert.ToInt32(ddlAmount.SelectedValue);

            Purchase cart = new Purchase
            {
                Amount = amount,
                CustomerID = Convert.ToInt32(clientId),
                Date = DateTime.Now,
                IsInCart = true,
                ProductID = id
            };

            PurchaseModel model = new PurchaseModel();
            //lblResult.Text = model.InsertPurchase(cart);
            lblResult.Text = "Order succesfully inserted";
        }
    }
}