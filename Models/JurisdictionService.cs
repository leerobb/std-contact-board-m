using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace STD_Contact_Board.Models
{
    public class JurisdictionService : IJurisdictionService
    {
        private ApplicationDbContext _db;

        public JurisdictionService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Jurisdiction> GetAll()
        {
            var jurisList = (IList<Jurisdiction>)this._db.Jurisdictions.Select(product => new
            {
                product.Id,
                product.JurisdictionName,
                product.AgencyName,
                product.MainAddress,
                product.Phone,
                product.Fax
            }).ToList().Select(x => new Jurisdiction()
            {
                Id = x.Id,
                JurisdictionName = x.JurisdictionName,
                AgencyName = x.AgencyName,
                MainAddress = x.MainAddress,
                Phone = x.Phone,
                Fax = x.Fax
            }).ToList<Jurisdiction>();

            return jurisList;
         
        }

        public IList<Jurisdiction> GetOne(string juris)
        {
            if (string.IsNullOrEmpty(juris))
                juris = "1";

            var jurisOne = new ApplicationDbContext().Jurisdictions.ToList().Find(x => x.Id == Int32.Parse(juris));

            IList<Jurisdiction> jurisOneList = new List<Jurisdiction>();
            jurisOneList.Add(jurisOne);

            return jurisOneList;

        }

        public IEnumerable<Jurisdiction> Read()
        {
            return GetAll();
        }

        public IEnumerable<Jurisdiction> FilteredRead(string juris)
        {
            return GetOne(juris);
        }

        public IEnumerable<Jurisdiction> FilteredRead()
        {
            var user = _db.Users.ToList().Find(x => x.Id.ToString() == HttpContext.Current.User.Identity.GetUserId());
            return GetOne(user.Jurisdiction.ToString());
        }

        public void Create(Jurisdiction product)
        {

            var entity = new Jurisdiction();

            entity.JurisdictionName = product.JurisdictionName;
            entity.AgencyName = product.AgencyName;
            entity.MainAddress = product.MainAddress;
            entity.Phone = product.Phone;
            entity.Fax = product.Fax;



            _db.Jurisdictions.Add(entity);
            _db.SaveChanges();

            product.Id = entity.Id;

        }

        public void Update(Jurisdiction product)
        {
            Jurisdiction entity = new Jurisdiction();

            entity.Id = product.Id;
            entity.JurisdictionName = product.JurisdictionName;
            entity.AgencyName = product.AgencyName;
            entity.MainAddress = product.MainAddress;
            entity.Phone = product.Phone;
            entity.Fax = product.Fax;

            _db.Jurisdictions.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();           
        }

        public void Destroy(Jurisdiction product)
        {

 
                var entity = new Jurisdiction();

                entity.Id = product.Id;

            _db.Jurisdictions.Attach(entity);
               
            _db.Jurisdictions.Remove(entity);

            
            _db.Jurisdictions.Remove(entity);

                //var orderDetails = entities.Order_Details.Where(pd => pd.ProductID == entity.ProductID);

                //foreach (var orderDetail in orderDetails)
                //{
                //    entities.Order_Details.Remove(orderDetail);
                //}

                _db.SaveChanges();
            
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