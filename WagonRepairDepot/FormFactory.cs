using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagonRepairDepot
{
    class FormFactory
    {
        public static RedactorForm ReadOnlyForm(object @obect, Models.IFormModel model)
        {
            RedactorForm form = new RedactorForm(@obect, model);
            form.SetRefreshButton();
            form.MadeReadOnly();
            return form;
        }
        public static RedactorForm CreatorForm(object @obect, Models.IFormModel model)
        {
            RedactorForm form = new RedactorForm(@obect, model);
            form.SetCreateButton();
            return form;
        }
        public static RedactorForm ChangerForm(object @obect, Models.IFormModel model)
        {
            RedactorForm form = new RedactorForm(@obect, model);
            form.SetDeleteButton();
            form.SetSaveButton();
            form.SetRefreshButton();
            return form;
        }
        public static RedactorForm FullForm(object @obect, Models.IFormModel model)
        {
            RedactorForm form = new RedactorForm(@obect, model);
            form.SetDeleteButton();
            form.SetSaveButton();
            form.SetRefreshButton();
            form.SetCreateButton();
            return form;
        }
    }
}
