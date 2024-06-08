using System.Collections;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Order
    {

        [DisplayName("Mark Seçin: ")]
        public int MarkaId { get; set; }

        [DisplayName("Model Seçin: ")]
        public int ModelId { get; set; }

        [DisplayName("Kasa Tipi Seçin: ")]
        public int KasaId { get; set; }

        [DisplayName("Renk Seçin: ")]
        public int RenkId { get; set; }

        public string OrderNo { get; set; }

        public IEnumerable<Marka> Markas { get; set; }
        public IEnumerable<Model> Models { get; set; }
        public IEnumerable<Kasa> Kasas { get; set; }
        public IEnumerable<Renk> Renks { get; set; }
    }
}
