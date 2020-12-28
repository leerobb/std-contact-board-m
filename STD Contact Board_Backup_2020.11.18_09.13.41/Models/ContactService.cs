using Microsoft.AspNet.Identity;
using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace STD_Contact_Board.Models
{
    public class ContactService : IContactService
    {
        private ApplicationDbContext _db;

        public ContactService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Contact> GetAll()
        {

            return (IList<Contact>)this._db.Contacts.Select(product => new
            {
                Id = product.Id,
                Role = product.Role_Id,
                Name = product.Name,
                Address= product.Address,
                Phone = product.Phone,
                Fax = product.Fax,
                Email = product.Email,
                Hours = product.Hours,
                Notes = product.Notes,
                Jurisdiction = product.Jurisdiction_Id
                
            }).ToList().Select(x => new Contact()
            {
                Id = x.Id,
                Role_Id = x.Role,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                Fax = x.Fax,
                Email = x.Email,
                Hours = x.Hours,
                Notes = x.Notes,
                Jurisdiction_Id = x.Jurisdiction
            }).ToList<Contact>();
         
        }

        public IList<Contact> GetAll(string jurisId, string roleId)
        {
            if (string.IsNullOrEmpty(jurisId))
                jurisId = "1";

            if (string.IsNullOrEmpty(roleId))
                roleId = "100";

            var contactList = _db.Contacts.ToList();

            if(roleId == "100")
                contactList = _db.Contacts.Where(x => x.Jurisdiction_Id.ToString() == jurisId).ToList();
            else
                contactList = _db.Contacts.Where(x => x.Jurisdiction_Id.ToString() == jurisId && x.Role_Id.ToString() == roleId).ToList();

            return contactList;
        }

        public IEnumerable<Contact> Read()
        {
            return GetAll();
        }

        public IEnumerable<Contact> FilteredRead(string jurisId, string roleId)
        {
            return GetAll(jurisId, roleId);
        }

        public IEnumerable<Contact> ReadAll()
        {
            var contactList = _db.Contacts.ToList();
            var currentUser = _db.Users.ToList().Find(x => x.Id.ToString() == HttpContext.Current.User.Identity.GetUserId());

            contactList = _db.Contacts.Where(x => x.Jurisdiction_Id == currentUser.Jurisdiction).ToList();
            return contactList;
        }


        public void JurisCreate(Contact product)
        {
            var contactList = _db.Contacts.ToList();
            var currentUser = _db.Users.ToList().Find(x => x.Id.ToString() == HttpContext.Current.User.Identity.GetUserId());

            var entity = new Contact();

            entity.Role_Id = product.Role_Id;
            entity.Name = product.Name;
            entity.Address = product.Address;
            entity.Phone = product.Phone;
            entity.Fax = product.Fax;
            entity.Email = product.Email;
            entity.Hours = product.Hours;
            entity.Notes = product.Notes;
            entity.Jurisdiction_Id = currentUser.Jurisdiction;

            _db.Contacts.Add(entity);
            _db.SaveChanges();

            product.Id = entity.Id;

        }


        public void Create(Contact product)
        {
            var entity = new Contact();

            using (_db)
            {
                entity.Role_Id = product.Role_Id;
                entity.Name = product.Name;
                entity.Address = product.Address;
                entity.Phone = product.Phone;
                entity.Fax = product.Fax;
                entity.Email = product.Email;
                entity.Hours = product.Hours;
                entity.Notes = product.Notes;
                entity.Jurisdiction_Id = product.Jurisdiction_Id;

                _db.Contacts.Add(entity);
                _db.SaveChanges();
            }

            product.Id = entity.Id;

        }

        public void Update(Contact product)
        {
            var entity = new Contact();

            entity.Id = product.Id;
            entity.Role_Id = product.Role_Id;
            entity.Name = product.Name;
            entity.Address = product.Address;
            entity.Phone = product.Phone;
            entity.Fax = product.Fax;
            entity.Email = product.Email;
            entity.Hours = product.Hours;
            entity.Notes = product.Notes;
            entity.Jurisdiction_Id = product.Jurisdiction_Id;

            _db.Contacts.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Destroy(Contact product)
        {
            using (_db)
            {
                var std = product;
                _db.Contacts.Attach(std);
                _db.Contacts.Remove(std);
                _db.SaveChanges();
            }
         

        }

        //public ProductViewModel One(Func<ProductViewModel, bool> predicate)
        //{
        //    return GetAll().FirstOrDefault(predicate);
        //}

        //public void Dispose()
        //{
        //    _db.Dispose();
        //}
    }
}