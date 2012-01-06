using System.Collections.Generic;
using System.Web.Mvc;
using UserGroupCms.Helpers;
using UserGroupCms.Models;
using System.Linq;

namespace UserGroupCms.Controllers
{
    public class EventController : BaseModelController<Event>
    {
        public override ActionResult Edit(int? id)
        {
            if (!UserIsAdmin())
                return RedirectToAction("List");

            Event ev = ResolveModel(id);

            ViewData["Companies"] = GetCompaniesList(ev);
            ViewData["Speakers"] = GetSpeakersList(ev);
            ViewData["Venues"] = GetVenuesList(ev);

            return View(ResolveModel(id));
        }

        [HttpPost]
        [ValidateInput(true)]
        public override ActionResult Edit(Event model)
        {
//            BinderHelper.Fill(model.Sponsors, Request.Form["SponsorsList"]);
//            BinderHelper.Fill(model.Speakers, Request.Form["SpeakersList"]);

//            model.Venue = BinderHelper.Resolve<Venue>(Request.Form["VenuesList"]);

            return base.Edit(model);
        }

        private IEnumerable<SelectListItem> GetCompaniesList(Event ev)
        {
            IList<Company> companies = AbstractModel<Company>.FindAll(UserGroup);
            return companies.ToSelectListItems(ev.Sponsors);
        }

        private IEnumerable<SelectListItem> GetSpeakersList(Event ev)
        {
            IList<Person> people = AbstractModel<Person>.FindAll(UserGroup);
            return people.ToSelectListItems(ev.Speakers);
        }

        private IEnumerable<SelectListItem> GetVenuesList(Event ev)
        {
            IList<Venue> venues = AbstractModel<Venue>.FindAll(UserGroup);
            return venues.ToSelectListItems(ev.Venue);
        }
    }
}