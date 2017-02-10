using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PurchaseModel
/// </summary>
public class PurchaseModel
{
    public string InsertPurchase(Purchase purchase)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            db.Purchases.Add(purchase);
            db.SaveChanges();

            return purchase.Date + " was succesfully added!";

        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
    public string UpdatePurchase(int id, Purchase purchase)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            Purchase p = db.Purchases.Find(id);

            p.Date = purchase.Date;
            p.Amount = purchase.Amount;
            p.IsInCart = purchase.IsInCart;
            p.ProductID = purchase.ProductID;
            db.SaveChanges();
            return purchase.Date + " was succesfully updated!";
        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
    public string DeletePurchase(int id)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            Purchase p = db.Purchases.Find(id);

            db.Purchases.Attach(p);
            db.Purchases.Remove(p);
            db.SaveChanges();
            return p.Date + " was succesfully deleted!";
        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
}