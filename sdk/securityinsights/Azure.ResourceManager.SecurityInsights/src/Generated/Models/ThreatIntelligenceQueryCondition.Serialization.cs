// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceQueryCondition : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceQueryCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceQueryCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ThreatIntelligenceQueryCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceQueryCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceQueryCondition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(StixObjectType))
            {
                writer.WritePropertyName("stixObjectType"u8);
                writer.WriteStringValue(StixObjectType);
            }
            writer.WritePropertyName("clauses"u8);
            writer.WriteStartArray();
            foreach (var item in Clauses)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ConditionConnective))
            {
                writer.WritePropertyName("conditionConnective"u8);
                writer.WriteStringValue(ConditionConnective.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ThreatIntelligenceQueryCondition IJsonModel<ThreatIntelligenceQueryCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceQueryCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceQueryCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceQueryCondition(document.RootElement, options);
        }

        internal static ThreatIntelligenceQueryCondition DeserializeThreatIntelligenceQueryCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stixObjectType = default;
            IList<ThreatIntelligenceQueryConditionClause> clauses = default;
            ThreatIntelligenceQueryConnective? conditionConnective = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stixObjectType"u8))
                {
                    stixObjectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clauses"u8))
                {
                    List<ThreatIntelligenceQueryConditionClause> array = new List<ThreatIntelligenceQueryConditionClause>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceQueryConditionClause.DeserializeThreatIntelligenceQueryConditionClause(item, options));
                    }
                    clauses = array;
                    continue;
                }
                if (property.NameEquals("conditionConnective"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionConnective = new ThreatIntelligenceQueryConnective(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ThreatIntelligenceQueryCondition(stixObjectType, clauses, conditionConnective, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreatIntelligenceQueryCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceQueryCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceQueryCondition)} does not support writing '{options.Format}' format.");
            }
        }

        ThreatIntelligenceQueryCondition IPersistableModel<ThreatIntelligenceQueryCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceQueryCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeThreatIntelligenceQueryCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceQueryCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceQueryCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
