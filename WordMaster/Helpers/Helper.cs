using System.Text.Json;

namespace WordMaster.Helpers
{
    public class Helper
    {
        public static F Convert<F, B>(B param)
        {
            var text = JsonSerializer.Serialize(param);
            return JsonSerializer.Deserialize<F>(text);
        }
    }
}
