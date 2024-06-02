using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class UserDetailVm
{
    public Guid Id { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
}
