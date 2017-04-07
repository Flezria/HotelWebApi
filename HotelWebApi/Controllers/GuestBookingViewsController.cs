using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HotelWebApi;

namespace HotelWebApi.Controllers
{
    public class GuestBookingViewsController : ApiController
    {
        private HotelContext db = new HotelContext();

        // GET: api/GuestBookingViews
        public IQueryable<GuestBookingView> GetGuestBookingView()
        {
            return db.GuestBookingView;
        }

        // GET: api/GuestBookingViews/5
        [ResponseType(typeof(GuestBookingView))]
        public async Task<IHttpActionResult> GetGuestBookingView(string id)
        {
            GuestBookingView guestBookingView = await db.GuestBookingView.FindAsync(id);
            if (guestBookingView == null)
            {
                return NotFound();
            }

            return Ok(guestBookingView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GuestBookingViewExists(string id)
        {
            return db.GuestBookingView.Count(e => e.Name == id) > 0;
        }
    }
}