namespace STD_Contact_Board.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jurisdiction
    {
        public int Id { get; set; }

        public string JurisdictionName { get; set; }

        public string AgencyName { get; set; }

        public string MainAddress { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }
    }
}
