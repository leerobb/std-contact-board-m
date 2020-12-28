namespace STD_Contact_Board.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Hours { get; set; }

        public string Notes { get; set; }

        public int Jurisdiction_Id { get; set; }

        public int? Role_Id { get; set; }
    }
}
