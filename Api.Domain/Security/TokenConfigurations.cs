namespace Api.Domain.Security
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }    // Public
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
