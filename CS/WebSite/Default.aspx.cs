using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Globalization;
using DevExpress.Web.ASPxEditors;

public partial class _Default : System.Web.UI.Page
{
	protected override void InitializeCulture() {
		SetCulture();
		base.InitializeCulture();
	}

	private void SetCulture() {
		HttpCookie c = Request.Cookies["Culture"];
		if (c == null)
			return;
		string langValue = c.Value;
		if (!String.IsNullOrEmpty(langValue)) {

			Culture = langValue;
			UICulture = langValue;

			Thread.CurrentThread.CurrentCulture =
				CultureInfo.CreateSpecificCulture(langValue);
			Thread.CurrentThread.CurrentUICulture = new
				CultureInfo(langValue);
		}
	}

	protected void combo_Init(object sender, EventArgs e) {

		HttpCookie c = Request.Cookies["Culture"];
		if (c == null)
			return;
		ASPxRadioButtonList rbl = (sender as ASPxRadioButtonList);
		ListEditItem item = rbl.Items.FindByValue(c.Value);
		rbl.SelectedItem = item;
	}
}
