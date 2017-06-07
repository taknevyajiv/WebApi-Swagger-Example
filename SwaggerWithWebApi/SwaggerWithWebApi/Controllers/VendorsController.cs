using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DAL;

namespace SwaggerWithWebApi.Controllers
{
    /// <summary>
    /// Exposes all available operations for the Vendor entity
    /// </summary>
    public class VendorsController : ApiController
    {
        private AdventureWorks2014Entities db = new AdventureWorks2014Entities();

        // GET: api/Vendors
        /// <summary>
        /// This operation retrieves all the available vendors for AdventureWorks company
        /// </summary>
        /// <returns>List of vendors</returns>
        public IQueryable<Vendor> GetVendors()
        {
            return db.Vendors;
        }

        // GET: api/Vendors/5
        /// <summary>
        /// This operation retrieves a single vendor for corresponding ID passed in
        /// </summary>
        /// <param name="id">Vendor ID</param>
        /// <returns>Vendor</returns>
        [ResponseType(typeof(Vendor))]
        public IHttpActionResult GetVendor(int id)
        {
            Vendor vendor = db.Vendors.Find(id);
            if (vendor == null)
            {
                return NotFound();
            }

            return Ok(vendor);
        }

        // PUT: api/Vendors/5
        /// <summary>
        /// This operation is to update an existing vendor
        /// </summary>
        /// <param name="id">Vendor ID</param>
        /// <param name="vendor">Vendor object to be modified</param>
        /// <returns>HttpStatusCode</returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVendor(int id, Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendor.BusinessEntityID)
            {
                return BadRequest();
            }

            db.Entry(vendor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Vendors
        /// <summary>
        /// This operation is to create a new vendor
        /// </summary>
        /// <param name="vendor">Vendor details</param>
        /// <returns>Success/Failure</returns>
        [ResponseType(typeof(Vendor))]
        public IHttpActionResult PostVendor(Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vendors.Add(vendor);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (VendorExists(vendor.BusinessEntityID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vendor.BusinessEntityID }, vendor);
        }

        // DELETE: api/Vendors/5
        /// <summary>
        /// This operation is to delete an existing vendor
        /// </summary>
        /// <param name="id">ID of the vendor to be deleted</param>
        /// <returns>OK</returns>
        [ResponseType(typeof(Vendor))]
        public IHttpActionResult DeleteVendor(int id)
        {
            Vendor vendor = db.Vendors.Find(id);
            if (vendor == null)
            {
                return NotFound();
            }

            db.Vendors.Remove(vendor);
            db.SaveChanges();

            return Ok(vendor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendorExists(int id)
        {
            return db.Vendors.Count(e => e.BusinessEntityID == id) > 0;
        }
    }
}