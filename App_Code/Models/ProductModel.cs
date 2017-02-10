using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
   public string InsertProduct(Product product)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            db.Products.Add(product);
            db.SaveChanges();

            return product.Name + " was succesfully added!";

        }
        catch(Exception e)
        {
            return "Error "+e;
        }
    }
    public string UpdateProduct(int id, Product product)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            Product p = db.Products.Find(id);

            p.Name = product.Name;
            p.Price = product.Price;
            p.Image = product.Image;
            p.Description = product.Description;
            p.TypeID = product.TypeID;
            db.SaveChanges();

            return product.Name + " was succesfully updated!";
        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
    public string DeleteProduct(int id)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            Product p = db.Products.Find(id);

            db.Products.Attach(p);
            db.Products.Remove(p);
            db.SaveChanges();
            return p.Name + " was succesfully deleted!";
        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }

    public Product GetProduct(int id)
    {
        try
        {
            using (TshirtDBEntities db = new TshirtDBEntities())
            {
                Product p = db.Products.Find(id);
                return p;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public List<Product> GetAllProducts()
    {
        try
        {
            using (TshirtDBEntities db = new TshirtDBEntities())
            {
                List<Product> products = (from x in db.Products
                                          select x).ToList();
            return products;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public List<Product> GetProductsByType(int typeId)
    {
        try
        {
            using (TshirtDBEntities db = new TshirtDBEntities())
            {
                List<Product> products = (from x in db.Products
                                          where x.TypeID == typeId
                                          select x).ToList();
            return products;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }
}