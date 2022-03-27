using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay15.Entities
{
    public class Reservation
    {
        [Key]
        
        public int ID { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string First_Name { get; set; }


        [Required]
        [MaxLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [MaxLength (50)]
        public string Birthday { get; set; }

        [Required]
        [MaxLength(50)]
        public string Gender { get; set; }


        [Required]
        [MaxLength(50)]
        [Phone]
        public string Phone_Number { get; set; }

        [Required]
        [EmailAddress]
        public string Email_Address { get; set; }

        [Required]
        public int Number_Guest { get; set; }

        [Required]
        public string Street_Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apt_Suite { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Required]
        [Column(TypeName ="nchar(10)")]
        public string Zip_Code { get; set; }


        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Room_Type { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Room_Floor { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Room_Number { get; set; }

        [Required]
        [Column(TypeName = "float")]

        public float Total_Bill { get; set; }


        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Payment_Type { get; set; }


        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Card_Type { get; set; }

        [Required]
        [MaxLength(50)]
        public string Card_Number { get; set; }

        [Required]
        [MaxLength(50)]
        public string Card_Exp { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Card_CVC { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Arrival_Time { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Leaving_Time { get; set; }

        [Required]
        public bool Check_In { get; set; }

        [Required]
        public int Breakfast { get; set; }

        [Required]
        public int Lunch { get; set; }

        [Required]
        public int Dinner { get; set; }

        [Required]
        public bool Cleaning { get; set; }

        [Required]
        public bool Towel { get; set; }

        [Required]
        public bool S_Surprise { get; set; }

        [Required]
        public bool Supply_Status { get; set; }

        [Required]
        public int Food_Bill { get; set; }
    }
}
