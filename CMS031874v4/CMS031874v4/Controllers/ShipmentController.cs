using CMS031874v4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS031874v4.Controllers
{
    public class ShipmentController : Controller
    {
        // GET: Shipment
        public ActionResult Index()
        {
            List<Shipment> shipments = new List<Shipment>();

            using (EntityDataModelContainer context = new EntityDataModelContainer())
            {
                shipments = context.Shipments.ToList();
            }

            return View(shipments);
        }

        public ActionResult Create()
        {
            addShipmentViewModel asvm = new addShipmentViewModel();
            asvm.Booking_date = DateTime.Now.ToString("yyyy-MM-dd");
            asvm.listItem = loadList();
            return View(asvm);
        }

        private List<SelectListItem> loadList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem();
            sli.Text = "Import";
            sli.Value = "Import";
            list.Add(sli);

            sli = new SelectListItem();
            sli.Text = "Export";
            sli.Value = "Export";
            list.Add(sli);

            return list;
        }

        private void loadList2(List<SelectListItem> list)
        {
            SelectListItem sli = new SelectListItem();
            sli.Text = "Pending";
            sli.Value = "Pending";
            list.Add(sli);

            sli = new SelectListItem();
            sli.Text = "In-Progress";
            sli.Value = "In-Progress";
            list.Add(sli);

            sli = new SelectListItem();
            sli.Text = "Arrived";
            sli.Value = "Arrived";
            list.Add(sli);
        }

        [HttpPost]
        public ActionResult Create(addShipmentViewModel asvm)
        {
            using (EntityDataModelContainer context = new EntityDataModelContainer())
            {
                var shipment = new Shipment();

                shipment.Booking_date = DateTime.Now.ToString("yyyy-MM-dd");
                shipment.Shipping_date = asvm.Shipping_date;
                shipment.Destination = asvm.Destination;
                shipment.Type = asvm.Shipping_type;
                shipment.Weight = asvm.Shipping_weight;
                shipment.Ship_regnum = asvm.Ship_regnum;
                shipment.Status = "Pending";
                context.Shipments.Add(shipment);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var shipment = new Shipment();
            editShipmentViewModel esvm = new editShipmentViewModel();

            using (EntityDataModelContainer context = new EntityDataModelContainer())
            {
                shipment = context.Shipments.Where(s => s.Id == id).FirstOrDefault();

                esvm.Id = shipment.Id;
                esvm.Shipping_date = shipment.Shipping_date;
                esvm.Destination = shipment.Destination;
                esvm.Shipping_type = shipment.Type;
                esvm.Shipping_weight = shipment.Weight;
                esvm.Ship_regnum = shipment.Ship_regnum;
                esvm.Status = shipment.Status;

            }
            esvm.listItem = loadList();
            esvm.listItem2 = new List<SelectListItem>();
            loadList2(esvm.listItem2);
            return View(esvm);
        }

        [HttpPost]
        public ActionResult Edit(editShipmentViewModel s)
        {

            using (EntityDataModelContainer context = new EntityDataModelContainer())
            {
                var shipment = context.Shipments.Single(x => x.Id == s.Id);

                shipment.Shipping_date = s.Shipping_date;
                shipment.Destination = s.Destination;
                shipment.Type = s.Shipping_type;
                shipment.Weight = s.Shipping_weight;
                shipment.Ship_regnum = s.Ship_regnum;
                shipment.Status = s.Status;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var shipment = new Shipment();

            using (EntityDataModelContainer context = new EntityDataModelContainer())
            {
                shipment = context.Shipments.Where(x => x.Id == id).FirstOrDefault();
                context.Shipments.Remove(shipment);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}