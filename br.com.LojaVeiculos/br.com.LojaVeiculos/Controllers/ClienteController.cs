using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using br.com.LojaVeiculos.BLL;
using br.com.LojaVeiculos.Models;

namespace br.com.LojaVeiculos.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Index()
        {

            ClienteBll oClienteBll = new ClienteBll();

            var Model = oClienteBll.obterClientes();

            return View(Model);
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id)
        {

            ClienteBll oClienteBll = new ClienteBll();

            var Model = oClienteBll.obterClientes(id);

            return View(Model);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                TB_CLIENTE oCliente = new TB_CLIENTE();
                ClienteBll oClienteBll = new ClienteBll(); 

                oCliente.NM_CLIENTE = collection["NM_CLIENTE"];
                oCliente.DT_NASCIMENTO = Convert.ToDateTime(collection["DT_NASCIMENTO"]);
                oCliente.FL_ATIVO = collection["FL_ATIVO"].Contains("true");
                oCliente.NM_TELEFONE = collection["NM_TELEFONE"];

                oClienteBll.gravarCliente(oCliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id)
        {

            ClienteBll oClienteBll = new ClienteBll();

            var Model = oClienteBll.obterClientes(id);
            
            return View(Model);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                TB_CLIENTE oCliente = new TB_CLIENTE();
                ClienteBll oClienteBll = new ClienteBll();

                oCliente.ID_cliente = id;
                oCliente.NM_CLIENTE = collection["NM_CLIENTE"];
                oCliente.DT_NASCIMENTO = Convert.ToDateTime(collection["DT_NASCIMENTO"]);
                oCliente.FL_ATIVO = collection["FL_ATIVO"].Contains("true");
                oCliente.NM_TELEFONE = collection["NM_TELEFONE"];

                oClienteBll.gravarCliente(oCliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id)
        {

            ClienteBll oClienteBll = new ClienteBll();

            var Model = oClienteBll.obterClientes(id);

            return View(Model);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                TB_CLIENTE oCliente = new TB_CLIENTE();
                ClienteBll oClienteBll = new ClienteBll();

                oCliente.ID_cliente = id;

                oClienteBll.excluirCliente(oCliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
