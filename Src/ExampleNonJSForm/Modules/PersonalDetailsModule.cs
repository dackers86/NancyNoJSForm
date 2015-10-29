using ExampleNonJSForm.Models;
using Nancy;
using Nancy.ModelBinding;

namespace ExampleNonJSForm.Modules
{
    public class PersonalDetailsModule : NancyModule
    {
        public PersonalDetailsModule() : base("/personaldetails")
        {
            Get["/details"] = parameters =>
            {
                return View["PersonalDetails"];
            };

            Post["/details"] = parameters => {

                var postData = this.Bind<PersonalDetails>();


                var testpostData = this.Bind<InsuranceForm>();

                var sessionObject = Request.Session["InsuranceForm"] as InsuranceForm ?? new InsuranceForm();
                sessionObject.PersonalDetails = postData;

                return View["Thankyou", sessionObject];
            };
        }
    }
}