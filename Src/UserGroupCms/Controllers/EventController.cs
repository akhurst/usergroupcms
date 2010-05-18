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
            BinderHelper.Fill(model.Sponsors, Request.Form["SponsorsList"]);
            BinderHelper.Fill(model.Speakers, Request.Form["SpeakersList"]);

            model.Venue = BinderHelper.Resolve<Venue>(Request.Form["VenuesList"]);

            return base.Edit(model);
        }

        private MultiSelectList GetCompaniesList(Event ev)
        {
            IEnumerable<int?> sponsorIds = null;

            if (ev.Sponsors != null)
                sponsorIds = from s in ev.Sponsors select s.Id;

            IList<Company> companies = AbstractModel<Company>.FindAll(UserGroup);
            return new MultiSelectList(companies, "Id", "Name", sponsorIds);
        }

        private MultiSelectList GetSpeakersList(Event ev)
        {
            IEnumerable<int?> speakerIds = null;

            if (ev.Speakers != null)
                speakerIds = from s in ev.Speakers select s.Id;

            IList<Person> people = AbstractModel<Person>.FindAll(UserGroup);
            return new MultiSelectList(people, "Id", "Name", speakerIds);
        }

        private SelectList GetVenuesList(Event ev)
        {
            IList<Venue> venues = AbstractModel<Venue>.FindAll(UserGroup);
            return new SelectList(venues, "Id", "Name", ev.VenueId);
        }
    }
}