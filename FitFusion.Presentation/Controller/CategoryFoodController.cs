using FitFusion.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Presentation.Controller;

public class CategoryFoodController
{
    private readonly CategoryFoodService _categoryFoodService;
    public CategoryFoodController()
    {
        _categoryFoodService = new CategoryFoodService();
    }


}
