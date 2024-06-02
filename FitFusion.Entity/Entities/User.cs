using FitFusion.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Entity.NewEntity;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; } // mail kabul edilecek
    public string Password { get; set; }
    public bool IsAdmin { get; set; } = false;


    //nav prop

    public virtual UserDetail?  UserDetail { get; set; }
    public virtual Guid? UserDetailId { get; set; }
    public List<UserMeal>? UserMeals { get; set; }


}
