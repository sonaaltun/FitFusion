using FitFusion.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Entity.NewEntity;

public class CategoryFood:BaseEntity
{
    public string Name { get; set; }
    public int CaloriesPerServing { get; set; } // burada almak gerek, burdan categoryfood'a ve foodportion'a göndereceğiz
    public double Protein { get; set; }
    public double Fat { get; set; }
    public double Carbonhydrat { get; set; }

    //nav prop

    public virtual Food Food { get; set; }
    public Guid FoodId { get; set; }
    public virtual Category Category { get; set; }
    public Guid CategoryId { get; set; }
    public virtual User? User { get; set; }
    public virtual Guid? UserId { get; set; }
}
