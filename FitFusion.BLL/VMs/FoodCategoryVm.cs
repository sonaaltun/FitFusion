using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class FoodCategoryVm
{
    public Guid Id { get; set; }
    public Guid FoodId { get; set; }
    public string FoodName { get; set; }
    public string FoodDescription { get; set; }
    public string CategoryName { get; set; }
    public int CaloriesPerServing { get; set; }
}
