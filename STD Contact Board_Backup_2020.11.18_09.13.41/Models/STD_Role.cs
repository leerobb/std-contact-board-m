namespace STD_Contact_Board.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STD_Role
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
