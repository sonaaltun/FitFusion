using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitFusion.UI.Controller;

namespace FitFusion.UI;

public class UnitOfWork
{
    private static UnitOfWork instance;
    public static UnitOfWork Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UnitOfWork();
            }
            return instance;
        }
    }


    public UserController UserControls { get { return new UserController(); } }
    public CategoryController CategoryControls { get { return new CategoryController(); } }
    public MealController MealControls { get { return new MealController(); } }
    public FoodController FoodControls { get { return new FoodController(); } }
    public PortionController PortionControllers { get { return new PortionController(); } }

}
