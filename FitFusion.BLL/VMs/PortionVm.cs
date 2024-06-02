using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.VMs;

public class PortionVm
{
    public Guid Id { get; set; }
    public string PortionType { get; set; } //1 porsiyon , 1 oz , 100 gr
    public int Amount { get; set; } // 250 gr , 50 gr , 100 gr
}
