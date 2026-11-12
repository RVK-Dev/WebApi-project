using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Zxcvbn;

namespace Service
{
    public class PasswordService
    {
        public int Post( string password)
        {
            int res = Zxcvbn.Core.EvaluatePassword(password).Score;
            return res;
        }
    }
}
