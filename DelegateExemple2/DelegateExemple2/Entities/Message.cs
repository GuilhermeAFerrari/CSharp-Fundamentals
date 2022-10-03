using System.Text;

namespace DelegateExemple2.Entities
{
    static class Message
    {
        public static string PrintMessage(OptionMessage optionMessage)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ok! ");
            sb.Append("Here your choice: ");
            sb.Append(optionMessage.Invoke());
            return sb.ToString();
        }
    }
}
