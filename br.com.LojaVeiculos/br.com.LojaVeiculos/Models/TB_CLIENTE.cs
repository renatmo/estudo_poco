namespace br.com.LojaVeiculos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CLIENTE()
        {
            TB_VEICULO = new HashSet<TB_VEICULO>();
            TB_ENDERECO = new HashSet<TB_ENDERECO>();
        }

        [Key]
        public int ID_cliente { get; set; }

        [Required]
        [StringLength(300)]
        public string NM_CLIENTE { get; set; }

        public DateTime DT_NASCIMENTO { get; set; }

        public bool FL_ATIVO { get; set; }

        [Required]
        [StringLength(50)]
        public string NM_TELEFONE { get; set; }

        [StringLength(50)]
        public string NM_PAI { get; set; }

        [StringLength(50)]
        public string NM_MAE { get; set; }

        [StringLength(50)]
        public string NM_LOGRADOURO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_VEICULO> TB_VEICULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ENDERECO> TB_ENDERECO { get; set; }
    }
}
