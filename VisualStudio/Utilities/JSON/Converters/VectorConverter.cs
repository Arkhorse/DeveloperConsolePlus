using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeveloperConsolePlus.Utilities.JSON.Converters
{
    public class VectorConverter : JsonConverterFactory
    {
        public override bool CanConvert(System.Type typeToConvert)
        {
            return typeToConvert == typeof(Vector2)
                   || typeToConvert == typeof(Vector3)
                   || typeToConvert == typeof(Vector4);
        }

        public override JsonConverter? CreateConverter(System.Type typeToConvert, JsonSerializerOptions options)
        {
            throw new System.NotImplementedException();
        }

        private static Vector2 PopulateVector2(Utf8JsonReader reader)
        {
            Vector2 result = default;

            reader.Read();

            if (reader.TokenType != JsonTokenType.Null)
            {
                
            }

            return result;
        }

        private static Vector3 PopulateVector3(Utf8JsonReader reader)
        {
            Vector3 result = default;

            return result;
        }

        private static Vector4 PopulateVector4(Utf8JsonReader reader)
        {
            Vector4 result = default;

            return result;
        }
    }
}