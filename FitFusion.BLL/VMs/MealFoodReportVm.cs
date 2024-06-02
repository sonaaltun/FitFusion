using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class MealFoodReportVm
{
    public string FoodName { get; set; }
    public string MealType { get; set; }
    public int TotalAmount { get; set; }
    public Guid FoodId { get; set; }

}
