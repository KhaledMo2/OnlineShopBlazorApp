using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Shared
{
    public class PaymentModel
    {
        [Required(ErrorMessage = "Card number is required")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration date is required")]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "CVV is required")]
        public string CVV { get; set; }
    }
}
