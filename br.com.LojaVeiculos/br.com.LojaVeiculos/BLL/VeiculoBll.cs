using br.com.LojaVeiculos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace br.com.LojaVeiculos.BLL
{
    public class VeiculoBll
    {
        VeiculoDal _VeiculoDal = null;


        internal object obterVeiculo()
        {
            _VeiculoDal = new VeiculoDal();

            return _VeiculoDal.obterVeiculo();

        }
    }
}