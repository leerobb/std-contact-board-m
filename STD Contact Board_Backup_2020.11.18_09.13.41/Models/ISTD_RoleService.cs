using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STD_Contact_Board.Models
{
    public interface ISTD_RoleService
    {
        IList<STD_Role> GetAll();


        IEnumerable<STD_Role> Read();


        void Create(STD_Role product);


        void Update(STD_Role product);


        void Destroy(STD_Role product);
    }
}