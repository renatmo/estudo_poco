namespace br.com.LojaVeiculos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MULTA
    {
        public int ID { get; set; }

        public int ID_VEICULO { get; set; }

        public DateTime DAT_OCORRENCIA { get; set; }

        [Required]
        [StringLength(300)]
        public string DES_OCORRENCIA { get; set; }

        public decimal VAL_MULTA { get; set; }

        public int QTD_PONTOS { get; set; }

        public virtual TB_VEICULO TB_VEICULO { get; set; }
    }
}
