using FitFusion.Entity.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Entity.NewEntity;

public class UserMeal : BaseEntity
{
    public DateTime MealTime { get; set; }
    public int TotalCalories { get; set; }
    public double TotalProtein { get; set; }
    public double TotalFat { get; set; }
    public double TotalCarbonhydrat { get; set; }
    public string MealType { get; set; } // 1 Sabah, 2 Öğlen , 3 Akşam , 4 Yatsı :)


    //nav.prop
    public virtual User User { get; set; }
    public Guid UserId { get; set; }

    public virtual List<UserFood> UserFoods { get; set; } 
}
