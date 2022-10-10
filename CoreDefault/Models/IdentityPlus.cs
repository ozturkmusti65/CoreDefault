using System.Security.Principal;

namespace CoreDefault.Web.Models
{
    public class IdentityPlus : IIdentity
    {
        public string AuthenticationType => throw new System.NotImplementedException();

        public bool IsAuthenticated => throw new System.NotImplementedException();

        public string Name => throw new System.NotImplementedException();
        public string NameSurname { get; set; }
    }
}
