using FitFusion.Presentation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Presentation;

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
    public UserDetailController UserDetailControls { get { return new UserDetailController(); } }
    public FoodController FoodControllers { get {  return new FoodController(); } }
    public CategoryController CategoryControllers { get { return new CategoryController();} }
    public UserMealController UserMealControllers { get { return new UserMealController(); } }
    public UserFoodController UserFoodControllers { get { return new UserFoodController(); } }
    public PortionController PortionControllers { get { return new PortionController(); } }
}
