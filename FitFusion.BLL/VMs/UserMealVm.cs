using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class UserMealVm
{
    public Guid Id { get; set; }
    public DateTime MealTime { get; set; } 
    public int TotalCalories { get; set; }
    public double TotalProtein { get; set; }
    public double TotalFat { get; set; }
    public double TotalCarbonhydrat { get; set; }
    public string MealType { get; set; } // 1 Sabah, 2 Öğlen , 3 Akşam , 4 Yatsı :)
}
