using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Model
{
    public class Review
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Please select a valid rating between 1 and 5.")]
        public int Rating { get; set; }

        [StringLength(1000, MinimumLength = 20, ErrorMessage = "Review must be at least 20 characters if filled.")]
        public string ReviewDescription { get; set; }

        [Required(ErrorMessage = "Purchase Date is required.")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/2000", "12/31/2099", ErrorMessage = "Purchase Date cannot be in the future.")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Please specify if you would recommend the product.")]
        public string WouldRecommend { get; set; }

        [Required(ErrorMessage = "You must agree to the terms.")]
        public bool AgreeToTerms { get; set; }
    }
}
