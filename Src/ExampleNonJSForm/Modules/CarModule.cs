using ExampleNonJSForm.Models;
using Nancy;
using Nancy.ModelBinding;

namespace ExampleNonJSForm.Modules
{
    public class CarModule : NancyModule
    {
        public CarModule() : base("/car")
        {
            Get["/details"] = parameters =>
            {
                return View["CarDetails"];
            };


            Post["/details"] = parameters => {

                var postData = this.Bind<CarDetails>();
                var insuranceForm = new InsuranceForm { CarDetails = postData };

                var sessionObject = Request.Session["InsuranceForm"] as InsuranceForm ?? new InsuranceForm();
                sessionObject.CarDetails = postData;

                return View["PersonalDetails", sessionObject];
            };
        }
    }
}