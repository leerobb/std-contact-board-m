using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STD_Contact_Board.Models
{
    public interface IJurisdictionService
    {
        IList<Jurisdiction> GetAll();

        
        IEnumerable<Jurisdiction> Read();

        IEnumerable<Jurisdiction> FilteredRead(string juris);

        IEnumerable<Jurisdiction> FilteredRead();


        void Create(Jurisdiction product);


        void Update(Jurisdiction product);


        void Destroy(Jurisdiction product);
    }
}