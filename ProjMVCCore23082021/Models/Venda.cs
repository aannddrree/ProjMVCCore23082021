using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjMVCCore23082021.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public string Description { get; set; }


        public virtual Client Client { get; set; }

        
        [NotMapped]
        public virtual List<SelectListItem> Clients { get; set; }

    }
}
