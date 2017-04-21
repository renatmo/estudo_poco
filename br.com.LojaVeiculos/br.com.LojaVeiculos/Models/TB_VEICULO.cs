namespace br.com.LojaVeiculos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_VEICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_VEICULO()
        {
            TB_MULTA = new HashSet<TB_MULTA>();
        }

        public int ID { get; set; }

        public int ID_CLIENTE { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_MARCA { get; set; }

        [Required]
        [StringLength(100)]
        public string DES_MODELO { get; set; }

        public int NUM_ANO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_COR { get; set; }

        public virtual TB_CLIENTE TB_CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MULTA> TB_MULTA { get; set; }
    }
}
