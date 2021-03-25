using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tangy.Models
{
    //ESTE CODIGO ESTA DESCARTADO(NO SE ESTA USANDO PARA NADA)
    public class IdentityUserCustomized: IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        /*public IdentityUserCustomized(string _firstName,string _lastName) : base()
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
        }*/

        public IdentityUserCustomized() : base()
        {
            this.FirstName = "Prueba_1";
            this.LastName = "Prueba_2";
        }
    }
}
