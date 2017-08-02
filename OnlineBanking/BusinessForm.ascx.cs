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
        
        public string greetingLabel = "Hi Manuel Roman";

        [ComponentSetting("Configurable Service", "Services", WellKnownComponent = true)]
        public string GreetingLabel { get { return greetingLabel; } set { greetingLabel = value; } }

        public override void LoadLanguageDefaults(System.Globalization.CultureInfo culture)
        {
            base.LoadLanguageDefaults(culture);
            IDS.Globalization.Localizer.CreateFor(this).ApplyResources();
        }
    }
}
