using FitFusion.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Entity.NewEntity;

public class UserDetail:BaseEntity
{
    public double Weight { get; set; }
    public double Height { get; set; }

    //navProp
    public virtual User User { get; set; }
    public virtual Guid UserId { get; set; }
}
