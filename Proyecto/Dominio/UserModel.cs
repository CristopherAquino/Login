using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
    }

}
