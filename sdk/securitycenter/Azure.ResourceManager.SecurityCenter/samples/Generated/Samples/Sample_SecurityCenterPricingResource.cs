// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityCenterPricingResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPricingsOnSubscriptionCloudPosturePlan()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/GetPricingByNameCloudPosture_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "CloudPosture";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingResource result = await securityCenterPricing.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPricingsOnSubscriptionContainersPlan()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/GetPricingByNameContainers_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "Containers";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingResource result = await securityCenterPricing.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPricingsOnSubscriptionDnsPlan()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/GetPricingByNameDns_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "Dns";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingResource result = await securityCenterPricing.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPricingsOnSubscriptionStorageAccountsPlan()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/GetPricingByNameStorageAccounts_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "StorageAccounts";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingResource result = await securityCenterPricing.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPricingsOnSubscriptionVirtualMachinesPlan()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/GetPricingByNameVirtualMachines_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "VirtualMachines";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingResource result = await securityCenterPricing.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePricingOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/PutPricingByName_example.json
            // this example is just showing the usage of "Pricings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "CloudPosture";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingData data = new SecurityCenterPricingData
            {
                PricingTier = SecurityCenterPricingTier.Standard,
            };
            ArmOperation<SecurityCenterPricingResource> lro = await securityCenterPricing.UpdateAsync(WaitUntil.Completed, data);
            SecurityCenterPricingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePricingOnSubscriptionPartialSuccess()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2023-01-01/examples/Pricings/PutPricingByNamePartialSuccess_example.json
            // this example is just showing the usage of "Pricings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityCenterPricingResource created on azure
            // for more information of creating SecurityCenterPricingResource, please refer to the document of SecurityCenterPricingResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "CloudPosture";
            ResourceIdentifier securityCenterPricingResourceId = SecurityCenterPricingResource.CreateResourceIdentifier(subscriptionId, pricingName);
            SecurityCenterPricingResource securityCenterPricing = client.GetSecurityCenterPricingResource(securityCenterPricingResourceId);

            // invoke the operation
            SecurityCenterPricingData data = new SecurityCenterPricingData
            {
                PricingTier = SecurityCenterPricingTier.Standard,
            };
            ArmOperation<SecurityCenterPricingResource> lro = await securityCenterPricing.UpdateAsync(WaitUntil.Completed, data);
            SecurityCenterPricingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
