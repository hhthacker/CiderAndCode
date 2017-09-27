namespace CiderAndCode.Web.DataModels
{
    public class AppleFact
    {
        public int Id { get; set; }
        public AppleType Type { get; set; }
        public string Fact { get; set; }
        public string Fiction { get; set; }
    }
}