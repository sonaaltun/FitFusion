using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class FoodPortionVm
{
    public Guid Id { get; set; }
    public string PortionType { get; set; }
    public string FoodName { get; set; }
    public int Calories { get; set; }
}
