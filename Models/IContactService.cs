using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STD_Contact_Board.Models
{
    public interface IContactService
    {
        IList<Contact> GetAll();

        void JurisCreate(Contact product);

        IList<Contact> GetAll(string jurisId, string roleId);

        IEnumerable<Contact> ReadAll();


        IEnumerable<Contact> Read();

        IEnumerable<Contact> FilteredRead(string jurisId, string roleId);


        void Create(Contact product);


        void Update(Contact product);


        void Destroy(Contact product);
    }
}