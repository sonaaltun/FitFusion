using FitFusion.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Entity.NewEntity;

public class Category:BaseEntity
{
    public string CategoryName { get; set; }
    public string Description { get; set; }

    //nav prop
    public virtual List<CategoryFood> CategoryFoods { get; set; } //virtual yap
}
