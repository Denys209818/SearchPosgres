using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Bogus.DataSets.Name;

namespace SearchElement.Classes
{
    [Table("tblUser")]
    public class User
    {
        [Key, Required]
        public int id { get; set; }
        [Required, StringLength(255)]
        public string name { get; set; }
        [Required, StringLength(255)]
        public string surname { get; set; }
        [Required, StringLength(255)]
        public string lastname { get; set; }

        [Required, StringLength(15)]
        public string telNumer { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int weigth { get; set; }
        [Required]
        public int footSize { get; set; }
        [Required]
        public byte state { get; set; }

        [NonSerialized]
        public Gender gender;
    }
}
