// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class GeocodePointsItem
    {
        internal static GeocodePointsItem DeserializeGeocodePointsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GeoJsonPoint geometry = default;
            CalculationMethodEnum? calculationMethod = default;
            IReadOnlyList<UsageTypeEnum> usageTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("geometry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geometry = GeoJsonPoint.DeserializeGeoJsonPoint(property.Value);
                    continue;
                }
                if (property.NameEquals("calculationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    calculationMethod = new CalculationMethodEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usageTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UsageTypeEnum> array = new List<UsageTypeEnum>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new UsageTypeEnum(item.GetString()));
                    }
                    usageTypes = array;
                    continue;
                }
            }
            return new GeocodePointsItem(geometry, calculationMethod, usageTypes ?? new ChangeTrackingList<UsageTypeEnum>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeocodePointsItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGeocodePointsItem(document.RootElement);
        }
    }
}
