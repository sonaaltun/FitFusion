using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class FoodVm
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int CaloriesPerServing { get; set; }
    public double Protein { get; set; }
    public double Fat { get; set; }
    public double Carbonhydrat { get; set; }
    
}
