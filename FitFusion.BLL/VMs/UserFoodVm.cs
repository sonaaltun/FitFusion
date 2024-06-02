using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class UserFoodVm
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int TotalCalories { get; set; } // burada almak gerek, burdan categoryfood'a ve foodportion'a göndereceğiz
    public double TotalProtein { get; set; }
    public double TotalFat { get; set; }
    public double TotalCarbonhydrat { get; set; }
}
