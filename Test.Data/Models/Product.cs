using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Data.Models
{
    public class Product
    {
        public int ProductId {
            get;
            set;
        }

        [Required]
        public string Name {
            get;
            set;
        }

        public string Description {
            get;
            set;
        }

        [Required]
        public decimal Price {
            get;
            set;
        }

        public int Inventory {
            get;
            set;
        }

    }
}
