using System;
using System.Web.UI;

using IDS.ComponentModel;
using IDS.Logging;
using IDS.Portal;
using IDS.Web.UI.WebControls;
using IDS.Web.UI.WebInput;

namespace OnlineBanking
{
    public partial class BusinessForm : PortalModuleControl
    {
        private static readonly LogHelper logger = new LogHelper(LogSystem.CreateTypeContextLogger());

        #region Component Settings
        /*
		 * An example of a consuming a configurable Portal service.  The type of this property can be any type
		 * (it does not have to specifically be object).  The WellKnownComponent = true property in the attribute
		 * informs portal to display a dropdown of services of this type in the module editor.
		 */
        //[ComponentSetting("Configurable Service", "Services", WellKnownComponent = true)]
        //public object ConfigurableService { get; set; }

        /*
		 * An example of consuming a configurable setting.  The type of this property can be any value type
		 * or any reference type that can be parsed or serialized.  Note:  Any string that is displayed to
		 * the end user should also have an IDS.ComponentModel.Localizable attribute
		 */
        //[ComponentSetting("Configurable Property", "Settings")]
        //public string ConfigurableProperty { get; set; }
        #endregion Component Settings

        /*
		 * Delete this method and the accompanying .resx and .es.resx files to disable Spanish localization.
		 * Otherwise, just delete this comment.
		 * See http://wiki.idsus.com:8081/download/attachments/13893993/Command+Spanish+Design.docx
		 */
        public override void LoadLanguageDefaults(System.Globalization.CultureInfo culture)
        {
            base.LoadLanguageDefaults(culture);
            IDS.Globalization.Localizer.CreateFor(this).ApplyResources();
        }
    }
}
