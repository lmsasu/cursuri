using System.ComponentModel.DataAnnotations;

namespace DemoEF6CodeFirst.DomainModel
{
    public class Customer
    {
        public int Id
        {
            get;
            set;
        }

        [Required]
        [StringLength(100, MinimumLength =3)]
        public string Name
        {
            get;
            set;
        }

        [StringLength(200)]
        public string Address
        {
            get;
            set;
        }
    }
}