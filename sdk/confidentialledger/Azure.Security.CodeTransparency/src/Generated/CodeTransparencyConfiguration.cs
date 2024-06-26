// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.CodeTransparency
{
    /// <summary> The Response body of the Configuration API. </summary>
    public partial class CodeTransparencyConfiguration
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

        /// <summary> Initializes a new instance of <see cref="CodeTransparencyConfiguration"/>. </summary>
        internal CodeTransparencyConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparencyConfiguration"/>. </summary>
        /// <param name="policy"></param>
        /// <param name="authentication"></param>
        /// <param name="serviceIdentifier"> did:web identifier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CodeTransparencyConfiguration(CodeTransparencyConfigurationPolicy policy, CodeTransparencyConfigurationAuthentication authentication, string serviceIdentifier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Policy = policy;
            Authentication = authentication;
            ServiceIdentifier = serviceIdentifier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the policy. </summary>
        public CodeTransparencyConfigurationPolicy Policy { get; }
        /// <summary> Gets the authentication. </summary>
        public CodeTransparencyConfigurationAuthentication Authentication { get; }
        /// <summary> did:web identifier. </summary>
        public string ServiceIdentifier { get; }
    }
}
