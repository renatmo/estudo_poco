using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using br.com.LojaVeiculos.Models;

namespace br.com.LojaVeiculos.DAL
{
    public class ClienteDal:IDisposable
    {
        banco _banco = null;

        public void Dispose()
        {
            _banco.Dispose();
        }

        internal List<TB_CLIENTE> obterClientes()
        {
            try
            {
                using (_banco = new banco())
                {
                    return _banco.TB_CLIENTE.ToList();
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        internal void gravarCliente(TB_CLIENTE oCliente)
        {
            try
            {
                using (_banco = new banco())
                {
                    TB_CLIENTE cli = _banco.TB_CLIENTE.Where(c => c.ID_cliente == oCliente.ID_cliente).FirstOrDefault();

                    if (cli == null)
                    {
                        _banco.TB_CLIENTE.Add(oCliente);
                    }
                    else
                    {
                        cli.NM_CLIENTE = oCliente.NM_CLIENTE;
                        cli.DT_NASCIMENTO = oCliente.DT_NASCIMENTO;
                        cli.FL_ATIVO = oCliente.FL_ATIVO;
                        cli.NM_TELEFONE = oCliente.NM_TELEFONE;

                    }

                    _banco.SaveChanges();
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

                using (_banco = new banco())
                {
                    TB_CLIENTE cli = _banco.TB_CLIENTE.Where(c => c.ID_cliente == id).FirstOrDefault();

                    return cli;
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
                using (_banco = new banco())
                {
                    TB_CLIENTE cli = _banco.TB_CLIENTE.Where(c => c.ID_cliente == oCliente.ID_cliente).FirstOrDefault();

                    _banco.TB_CLIENTE.Remove(cli);

                    _banco.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}