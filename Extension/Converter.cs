using System.Text;

namespace WizardOrbit.Core.Extension
{
    public class Converter
    {
        public static byte[] ByteConverter(dynamic dynamic)
        {
            byte[] result = Encoding.ASCII.GetBytes(dynamic);
            return result;
        }
    }
}