using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.ViewModels
{
    public class AllBushels
    {
        public int Id { get; set; }
        public AppleType Type { get; set; }
        public int Quantity { get; set; }
        public bool Ripe { get; set; }
        public bool Pressed { get; set; }
    }
}