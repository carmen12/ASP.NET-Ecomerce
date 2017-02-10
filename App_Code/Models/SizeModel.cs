using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SizeModel
/// </summary>
public class SizeModel
{
    public string InsertSize(Size size)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            db.Sizes.Add(size);
            db.SaveChanges();

            return size.Name + " was succesfully added!";

        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
    public string UpdateSize(int id, Size size)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            Size p = db.Sizes.Find(id);

            p.Name = size.Name;
            db.SaveChanges();

            return size.Name + " was succesfully updated!";
        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
    public string DeleteSize(int id)
    {
        try
        {
            TshirtDBEntities db = new TshirtDBEntities();
            Size p = db.Sizes.Find(id);

            db.Sizes.Attach(p);
            db.Sizes.Remove(p);
            db.SaveChanges();
            return p.Name + " was succesfully deleted!";
        }
        catch (Exception e)
        {
            return "Error " + e;
        }
    }
}
