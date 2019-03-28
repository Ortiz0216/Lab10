using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab10.Pages
{
    public class NewModel : PageModel
    {
        private readonly ILogger _log;

        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        [StringLength(30)]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(30)]
        public string LastName {get; set;}

        [BindProperty]
        [Display(Name = "Credit Card Number")]
        [Required]
        [CreditCard]
        [StringLength(20)]
        public string CCNumber {get; set;}
        public NewModel (ILogger<IndexModel> log)
        {
            _log = log;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            _log.LogWarning(FirstName);
            _log.LogWarning(LastName);
        }
    }
}