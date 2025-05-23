// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(PolicyModificationResultConverter))]
    public partial class PolicyModificationResult
    {
        internal static PolicyModificationResult DeserializePolicyModificationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PolicyModification xMsPolicyResult = default;
            string xMsPolicyTokenHash = default;
            JsonWebKey xMsPolicySigner = default;
            string xMsPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x-ms-policy-result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicyResult = new PolicyModification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("x-ms-policy-token-hash"u8))
                {
                    xMsPolicyTokenHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-policy-signer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicySigner = JsonWebKey.DeserializeJsonWebKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x-ms-policy"u8))
                {
                    xMsPolicy = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyModificationResult(xMsPolicyResult, xMsPolicyTokenHash, xMsPolicySigner, xMsPolicy);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PolicyModificationResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePolicyModificationResult(document.RootElement);
        }

        internal partial class PolicyModificationResultConverter : JsonConverter<PolicyModificationResult>
        {
            public override void Write(Utf8JsonWriter writer, PolicyModificationResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override PolicyModificationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyModificationResult(document.RootElement);
            }
        }
    }
}
