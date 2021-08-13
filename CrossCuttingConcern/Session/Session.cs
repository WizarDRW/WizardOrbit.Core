using Microsoft.AspNetCore.Http;

namespace WizardOrbit.Core.CrossCuttingConcern.Session
{
    public class Session : ISessionRule
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public Session(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetSession(string key, byte[] value){
            _session.Set("UserID", value);
        }

        public void GetSession(string key)
        {
            var result = _session.GetHashCode();
        }
    }
}