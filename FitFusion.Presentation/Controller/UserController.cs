using FitFusion.BLL.Services;
using FitFusion.Entity.NewEntity;
using FitSecretProject.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FitFusion.Presentation.Controller;

public class UserController
{
    private readonly UserService _userService;
    

    public UserController()
    {
        _userService = new UserService();
    }


public  bool CheckPassword(string password)
    {
        bool resultPassword;
        var regex = new Regex("^(?=.*[A-Z]{2,})(?=.*[!:+*]{2,})(?=.*[0-9])(?=.*[a-z]{3,})[A-Za-z!:+*0-9]{8,}$");

        if (regex.IsMatch(password))
        {
            resultPassword = true;
        }
        else
        {
            resultPassword = false;
        }
        return resultPassword;
    }

public  string PasswordHash(string password)

    {
        SHA256 hashPassword = SHA256.Create();
        password = string.Concat(hashPassword.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString()));
        return password;
    }

    public bool SignUp(string firstName, string lastName, string mail, string password, string password2)
    {

        if (firstName == null || lastName == null || mail == null || password == null || password2 == null)
        {
            MessageBox.Show("Please fill the all fields");
            return false;
        }
        else
        {
            if (password != password2)
            {
                MessageBox.Show("The password does not match each other.");
                return false;
            }
            else if (UnitOfWork.Instance.UserControls.CheckPassword(password) == false)
            {
                MessageBox.Show("Please choose a password that complies with the password rules.\nPassword Rules:\n-Password must be 8 characters at least\n-Password must contains two capital letters at least\n-Password must contains two number at least\n-Password must contais three lowercase letters\n-Password must contains two special characters'!, :, +, *' at least");
                return false;
            }
            else
            {
                if (_userService.Get(x => x.Mail == mail) != null) // contains kullanabiliriz
                {
                    MessageBox.Show("This email is already used.");
                    return false;
                }
                else
                {
                    var hashPass = UnitOfWork.Instance.UserControls.PasswordHash(password);
                    User user = new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Mail = mail,
                        Password = hashPass,
                    };
                    _userService.Add(user);
                    MessageBox.Show("Registration Successful");
                    return true;
                }
            }
        }
    }

    public bool Login(string email, string password)
    {
        var hashedPass = UnitOfWork.Instance.UserControls.PasswordHash(password);
        if (email == null || password == null)
        {
            MessageBox.Show("Please enter the Email and Password fields completely.");
            return false;
        }
        else if (_userService.Get(x => x.Mail == email && x.Password == hashedPass) != null)
        {
            
            var user = _userService.Get(x => x.Mail == email && x.Password == hashedPass);
            MessageBox.Show("Login successful.");
            MainScreen mainScreen = new MainScreen(user);
            mainScreen.Show();
            return true;
        }
        else
        {
            MessageBox.Show("Username or password is wrong.");
            return false;
        }

    }
    public bool AdminLogin(string email, string password )
    {
        
        if (email == null || password == null)
        {
            MessageBox.Show("Please enter the Email and Password fields completely.");
            return false;
        }
        else if (_userService.Get(x => x.Mail == email && x.Password == password) != null)
        {

            var user = _userService.Get(x => x.Mail == email && x.Password == password && x.IsAdmin == true);
            MessageBox.Show("Login successful.");
            AdminMainScreen mainScreen = new AdminMainScreen(user);
            mainScreen.Show();
            return true;
        }
        else
        {
            MessageBox.Show("Username or password is wrong.");
            return false;
        }

    }

    public double BodyIndex (string userWeight, string userrHeight , User user)
    {
        if (UnitOfWork.Instance.UserDetailControls.CheckUserIndex(user))
        {
            UnitOfWork.Instance.UserDetailControls.UpdateUserDetail(user , userWeight , userrHeight);
        }
        else
        {
            UserDetail userDetail = new UserDetail()
            {
                UserId = user.Id,
                Weight= Convert.ToDouble(userWeight),
                Height= Convert.ToDouble(userrHeight),
            };

            if (UnitOfWork.Instance.UserDetailControls.AddUserDetail(userDetail))
            {
                MessageBox.Show("Body mass index was added to the system.");
            }
            else
            {
                MessageBox.Show("An error was encountered while adding the body index to the system.");
            }
        }
        double weight = Convert.ToDouble(userWeight);
        double height = Convert.ToDouble(userrHeight);
         return  weight / (height * height);
    }

    public List<User> GetAllUsers ()
    {
        return _userService.GetAll(x => x.Statu != Entity.Enums.Statu.Deleted).ToList();
    }
}
