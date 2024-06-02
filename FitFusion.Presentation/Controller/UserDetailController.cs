using FitFusion.BLL.Services;
using FitFusion.Entity.NewEntity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitFusion.Entity;
using User = FitFusion.Entity.NewEntity.User;

namespace FitFusion.Presentation.Controller;

public class UserDetailController
{
    private readonly UserDetailService _userDetailService;
    public UserDetailController()
    {
        _userDetailService = new UserDetailService();
    }


    public bool AddUserDetail (UserDetail userDetail)
    {
        if (_userDetailService.Add(userDetail))
        {
            return true;
        }
        else { return false; }

    }

    public bool UpdateUserDetail (User loginUser ,string weight , string height)
    {
        var userDetail = _userDetailService.Get(x => x.UserId == loginUser.Id);
        userDetail.Height = Convert.ToDouble(height);
        userDetail.Weight = Convert.ToDouble(weight);
        if (_userDetailService.Update(userDetail))
        {
            MessageBox.Show("Your Body Mass Index has been successfully updated.");
            return true;
        }
        else
        {
            MessageBox.Show("An error was encountered while updating body mass index.");
            return false;
        }

        
    }

    public bool CheckUserIndex (Entity.NewEntity.User user)
    {
        if ( _userDetailService.Get(x=> x.UserId == user.Id ) != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}
