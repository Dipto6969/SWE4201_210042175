using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_A
{
    public class user
    {
        public string _userName{ get; set; }
        public string _pass { get; set; }
        public string _name { get; set; }

        public user(string userName, string pass, string name)
        {
            this._userName = userName;
            this._pass = pass;
            this._name = name;
        }



    }
}

