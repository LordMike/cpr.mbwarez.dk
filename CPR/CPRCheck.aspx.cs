using System;
using System.Collections.Generic;
using CPR.CPRWebService;
using System.Linq;

namespace CPR
{
    public partial class CPRCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDate.Text = DateTime.Now.ToShortDateString();

                drpDownGender.DataSource = new[] { "Mand", "Kvinde", "Ukendt" };
                drpDownGender.DataBind();
            }
        }

        protected void CmdGenerateClick(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                lblStatus.Text = "Ugyldig input. Prøv dags dato: " + DateTime.Now.ToShortDateString();
                return;
            }

            DateTime date = DateTime.Parse(txtDate.Text);
            List<string> res;

            bool useGender = drpDownGender.Text == "Kvinde" || drpDownGender.Text == "Mand";

            using (CPRServiceSoapClient client = new CPRServiceSoapClient())
            {
                res = useGender ? client.RetrieveCPRGender(date, drpDownGender.Text == "Kvinde" ? Gender.Female : Gender.Male).ToList()
                              : client.RetrieveCPR(date).ToList();
            }

            rptPossibles.DataSource = res;
            rptPossibles.DataBind();
        }

        protected void ValDateCustomServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            // http://stackoverflow.com/questions/939802/date-validation-with-asp-net-validator

            DateTime minDate = new DateTime(1800, 1, 1);
            DateTime maxDate = DateTime.Now.AddYears(2);
            DateTime dt;

            args.IsValid = (DateTime.TryParse(args.Value, out dt)
                            && dt <= maxDate
                            && dt >= minDate);
        }
    }
}