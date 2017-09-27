using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.ViewModels
{
    public class ViewBushelsRequest
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int NumberOfBushels { get; set; }
        public bool Ripeness { get; set; }
        public bool Pressed { get; set; }
    }
}