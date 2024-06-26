// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm.Models
{
    /// <summary> The Virtual machine inventory item. </summary>
    public partial class VirtualMachineInventoryItem : ScVmmInventoryItemProperties
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineInventoryItem"/>. </summary>
        public VirtualMachineInventoryItem()
        {
            IPAddresses = new ChangeTrackingList<string>();
            InventoryType = ScVmmInventoryType.VirtualMachine;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInventoryItem"/>. </summary>
        /// <param name="inventoryType"> They inventory type. </param>
        /// <param name="managedResourceId"> Gets the tracked resource id corresponding to the inventory resource. </param>
        /// <param name="uuid"> Gets the UUID (which is assigned by VMM) for the inventory item. </param>
        /// <param name="inventoryItemName"> Gets the Managed Object name in VMM for the inventory item. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="osType"> Gets the type of the os. </param>
        /// <param name="osName"> Gets os name. </param>
        /// <param name="osVersion"> Gets os version. </param>
        /// <param name="powerState"> Gets the power state of the virtual machine. </param>
        /// <param name="ipAddresses"> Gets or sets the nic ip addresses. </param>
        /// <param name="cloud"> Cloud inventory resource details where the VM is present. </param>
        /// <param name="biosGuid"> Gets the bios guid. </param>
        /// <param name="managedMachineResourceId"> Gets the tracked resource id corresponding to the inventory resource. </param>
        internal VirtualMachineInventoryItem(ScVmmInventoryType inventoryType, string managedResourceId, string uuid, string inventoryItemName, ScVmmProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, ScVmmOSType? osType, string osName, string osVersion, string powerState, IList<string> ipAddresses, ScVmmInventoryItemDetails cloud, string biosGuid, ResourceIdentifier managedMachineResourceId) : base(inventoryType, managedResourceId, uuid, inventoryItemName, provisioningState, serializedAdditionalRawData)
        {
            OSType = osType;
            OSName = osName;
            OSVersion = osVersion;
            PowerState = powerState;
            IPAddresses = ipAddresses;
            Cloud = cloud;
            BiosGuid = biosGuid;
            ManagedMachineResourceId = managedMachineResourceId;
            InventoryType = inventoryType;
        }

        /// <summary> Gets the type of the os. </summary>
        public ScVmmOSType? OSType { get; }
        /// <summary> Gets os name. </summary>
        public string OSName { get; }
        /// <summary> Gets os version. </summary>
        public string OSVersion { get; }
        /// <summary> Gets the power state of the virtual machine. </summary>
        public string PowerState { get; }
        /// <summary> Gets or sets the nic ip addresses. </summary>
        public IList<string> IPAddresses { get; }
        /// <summary> Cloud inventory resource details where the VM is present. </summary>
        public ScVmmInventoryItemDetails Cloud { get; set; }
        /// <summary> Gets the bios guid. </summary>
        public string BiosGuid { get; }
        /// <summary> Gets the tracked resource id corresponding to the inventory resource. </summary>
        public ResourceIdentifier ManagedMachineResourceId { get; }
    }
}
