using FitFusion.Entity.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Entity.NewEntity;

public class UserFood:BaseEntity
{
    public string Name { get; set; }
    public int TotalCalories { get; set; } // burada almak gerek, burdan categoryfood'a ve foodportion'a göndereceğiz
    public double TotalProtein { get; set; }
    public double TotalFat { get; set; }
    public double TotalCarbonhydrat { get; set; }

    //nav prop

    public virtual Food Food { get; set; }
    public Guid FoodId { get; set; }
    public virtual Portion Portion { get; set; }
    public  Guid PortionId { get; set; }
    public virtual UserMeal UserMeal { get; set; }
    public Guid UserMealId { get; set; }
}
