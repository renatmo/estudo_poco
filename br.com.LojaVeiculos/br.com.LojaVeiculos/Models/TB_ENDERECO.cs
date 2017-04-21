namespace br.com.LojaVeiculos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ENDERECO
    {
        public int ID { get; set; }
        public string NM_LOGRADOURO { get; set; }
        public string DS_COMPLEMENTO { get; set; }
        public string DS_NUMERO { get; set; }
        public string SG_UF { get; set; }
        public string NM_BAIRRO { get; set; }

    }
}