using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using br.com.LojaVeiculos.DAL;
using br.com.LojaVeiculos.Models;

namespace br.com.LojaVeiculos.BLL
{
    public class ClienteBll
    {
        ClienteDal _ClienteDal = null;

        internal object obterClientes()
        {
            using (_ClienteDal = new ClienteDal())
            {
                return _ClienteDal.obterClientes();
            }


        }

        internal void gravarCliente(TB_CLIENTE oCliente)
        {
            try
            {

                using (_ClienteDal = new ClienteDal())
                {
                    _ClienteDal.gravarCliente(oCliente);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        internal TB_CLIENTE obterClientes(int id)
        {
            try
            {

                using (_ClienteDal = new ClienteDal())
                {
                    return _ClienteDal.obterClientes(id);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void excluirCliente(TB_CLIENTE oCliente)
        {
            try
            {

                using (_ClienteDal = new ClienteDal())
                {
                    _ClienteDal.excluirCliente(oCliente);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}