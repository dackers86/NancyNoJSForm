using Nancy;
using Nancy.Session;

namespace ExampleNonJSForm.Models
{
    public class InsuranceForm
    {
        public string InsuranceNumber { get { return int.MaxValue.ToString(); } }
        public CarDetails CarDetails { get; set; }
        public PersonalDetails PersonalDetails { get; set; }
    }
}