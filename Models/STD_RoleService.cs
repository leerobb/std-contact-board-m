using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace STD_Contact_Board.Models
{
    public class STD_RoleService : ISTD_RoleService
    {
        private ApplicationDbContext _db;

        public STD_RoleService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<STD_Role> GetAll()
        {
            var roles = _db.STD_Roles.Select(product => new
            {
                product.Id,
                product.Name                
            }).ToList().Select(x => new STD_Role()
            {
                Id = x.Id,
                Name = x.Name                
            }).ToList();

            return roles;
        }

        public IEnumerable<STD_Role> Read()
        {
            return GetAll();
        }

        public void Create(STD_Role product)
        {
            var entity = new STD_Role();

            entity.Name = product.Name;

            _db.STD_Roles.Add(entity);
            _db.SaveChanges();

            product.Id = entity.Id;

        }

        public void Update(STD_Role product)
        {
            STD_Role entity = new STD_Role();

            entity.Id = product.Id;
            entity.Name = product.Name;

            _db.STD_Roles.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Destroy(STD_Role product)
        {
            var entity = new STD_Role();

            entity.Id = product.Id;

            _db.STD_Roles.Attach(entity);
            _db.STD_Roles.Remove(entity);
            _db.STD_Roles.Remove(entity);

            _db.SaveChanges();

        }

    }
}