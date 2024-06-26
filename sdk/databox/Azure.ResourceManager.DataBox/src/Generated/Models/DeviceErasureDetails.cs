// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Device erasure details with erasure completion status and erasureordestructionlog sas key. </summary>
    public partial class DeviceErasureDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceErasureDetails"/>. </summary>
        internal DeviceErasureDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceErasureDetails"/>. </summary>
        /// <param name="deviceErasureStatus"> Holds the device erasure completion status. </param>
        /// <param name="erasureOrDestructionCertificateSasKey"> Shared access key to download cleanup or destruction certificate for device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceErasureDetails(DataBoxStageStatus? deviceErasureStatus, string erasureOrDestructionCertificateSasKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceErasureStatus = deviceErasureStatus;
            ErasureOrDestructionCertificateSasKey = erasureOrDestructionCertificateSasKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Holds the device erasure completion status. </summary>
        public DataBoxStageStatus? DeviceErasureStatus { get; }
        /// <summary> Shared access key to download cleanup or destruction certificate for device. </summary>
        public string ErasureOrDestructionCertificateSasKey { get; }
    }
}
