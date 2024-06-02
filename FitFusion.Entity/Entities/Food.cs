using FitFusion.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using ImageMagick;





namespace FitFusion.Entity.NewEntity;

public class Food:BaseEntity
{
    public string Name { get; set; }
    public int CaloriesPerServing { get; set; } 
    public double Protein { get; set; }
    public double Fat { get; set; }
    public double Carbonhydrat { get; set; }
    public byte[] ImageData { get; set; }




    //nav prop
    public virtual List<CategoryFood> CategoryFood { get; set; }
    public Guid? UserId { get; set; }
    

}
