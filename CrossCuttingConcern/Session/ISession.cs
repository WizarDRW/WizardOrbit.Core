
namespace WizardOrbit.Core.CrossCuttingConcern.Session
{
    public interface ISessionRule
    {
        void SetSession(string key, byte[] value);
        void GetSession(string key);
    }
}