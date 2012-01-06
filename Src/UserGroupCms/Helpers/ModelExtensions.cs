using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Helpers
{
    public static class ModelExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItems<T>(
this IEnumerable<AbstractModel<T>> models, AbstractModel<T> selectedItem)
        {
            if (selectedItem == null)
                return null;

            return models.ToSelectListItems(selectedItem.Id);
        }

        public static IEnumerable<SelectListItem> ToSelectListItems<T>(
      this IEnumerable<AbstractModel<T>> models, IEnumerable<AbstractModel<T>> selectedItems)
        {
            IEnumerable<int?> selectedIds = null;

            if (selectedItems != null)
                selectedIds = from s in selectedItems select s.Id;

            return models.ToSelectListItems(selectedIds);
        }

        public static IEnumerable<SelectListItem> ToSelectListItems<T>(
              this IEnumerable<AbstractModel<T>> models, IEnumerable<int?> selectedIds)
        {
            return
                models.OrderBy(m => m.Name)
                      .Select(m =>
                          new SelectListItem
                          {
                              Selected = (selectedIds.Contains(m.Id)),
                              Text = m.Name,
                              Value = m.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems<T>(
          this IEnumerable<AbstractModel<T>> models, int? selectedId)
        {
            return models.ToSelectListItems(new[] {selectedId});
        }
    }
}
