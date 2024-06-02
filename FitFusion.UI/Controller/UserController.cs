using FitFusion.BLL.Services;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.UI.Controller;

public class UserController
{
    private readonly UserService _userService;
    public UserController()
    {
        _userService = new UserService();
    }
    public  bool SignUp (string firstName, string lastName, string  mail, string password , string password2)
    {
        
        if(firstName == null || lastName == null || mail==null || password==null || password2 == null)
        {
            MessageBox.Show("Tüm alanları doldurun.");
            return false;
        }
        else
        {
            if (password != password2)
            {
                MessageBox.Show("Girdiğiniz şifreler birbiriyle eşleşmemektedir.");
                return false;
            }
            else
            {
                if(_userService.Get(x=> x.Mail == mail) != null) // contains kullanabiliriz
                {
                    MessageBox.Show("Girdiğiniz e-mail hesabına kayıtlı hesap bulunmaktadır.");
                    return false;
                }
                else
                {
                    User user = new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Mail = mail,
                        Password = password,
                    };
                    _userService.Add(user);
                    MessageBox.Show("Kayıt Başarılı");
                    return true;
                }
            }
        }
    }

    public bool Login (string email, string password)
    {
        if(email == null || password == null)
        {
            MessageBox.Show("Lütfen Mail ve Şifre alanını eksiksiz giriniz.");
            return false;
        }
        else if(_userService.Get(x=>x.Mail == email && x.Password==password) != null) 
        {
            var user = _userService.Get(x => x.Mail == email && x.Password == password);
            MessageBox.Show("Gİriş başarılı.");
            UserApplicationForm userApplicationForm = new UserApplicationForm(user);
            userApplicationForm.ShowDialog();
            return true;
        }
        else
        {
            MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            return false;
        }

    }




}
