using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class UserReportVm 
{
    public string FullName { get; set; }
    public int TotalCalories { get; set; }
    public double TotalProtein { get; set; }
    public double TotalFat { get; set; }
    public double TotalCarbonhydrat { get; set; }

}
