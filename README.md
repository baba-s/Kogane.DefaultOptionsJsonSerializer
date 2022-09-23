# Kogane Default Options Json Serializer

デフォルトのオプションを指定できる System.Text.Json.JsonSerializer

```csharp
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private void Awake()
    {
        JsonSerializer.DefaultOptions = new JsonSerializerOptions
        {
            Converters =
            {
                new JsonStringEnumConverter( JsonNamingPolicy.CamelCase )
            },
            Encoder       = JavaScriptEncoder.Create( UnicodeRanges.All ),
            WriteIndented = true,
        };

        var character = new
        {
            id   = 25,
            name = "ピカチュウ",
        };

        Debug.Log( JsonSerializer.Serialize( character ) );
    }
}
```