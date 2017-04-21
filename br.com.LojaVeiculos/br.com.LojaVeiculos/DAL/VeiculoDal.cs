using br.com.LojaVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace br.com.LojaVeiculos.DAL
{
    public class VeiculoDal : IDisposable
    {
        banco _Banco = null;



        internal List<TB_VEICULO> obterVeiculo()
        {
            try
            {
                _Banco = new banco();

                return _Banco.TB_VEICULO.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _Banco.Dispose();
        }
    }
}