using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakenFirstCode
{
    [Table("FoodArtikels")]
    class FoodArtikel:Artikel
    {
        public int Houdbaarheid { get; set; }
    }
}
