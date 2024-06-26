// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an upgrade policy - automatic, manual, or rolling.
    /// </summary>
    public partial class UpgradePolicy : ITransportObjectProvider<Models.UpgradePolicy>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<AutomaticOSUpgradePolicy> AutomaticOSUpgradePolicyProperty;
            public readonly PropertyAccessor<Common.UpgradeMode> ModeProperty;
            public readonly PropertyAccessor<RollingUpgradePolicy> RollingUpgradePolicyProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AutomaticOSUpgradePolicyProperty = this.CreatePropertyAccessor<AutomaticOSUpgradePolicy>(nameof(AutomaticOSUpgradePolicy), BindingAccess.Read | BindingAccess.Write);
                this.ModeProperty = this.CreatePropertyAccessor<Common.UpgradeMode>(nameof(Mode), BindingAccess.Read | BindingAccess.Write);
                this.RollingUpgradePolicyProperty = this.CreatePropertyAccessor<RollingUpgradePolicy>(nameof(RollingUpgradePolicy), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.UpgradePolicy protocolObject) : base(BindingState.Bound)
            {
                this.AutomaticOSUpgradePolicyProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AutomaticOSUpgradePolicy, o => new AutomaticOSUpgradePolicy(o)),
                    nameof(AutomaticOSUpgradePolicy),
                    BindingAccess.Read | BindingAccess.Write);
                this.ModeProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapEnum<Models.UpgradeMode, Common.UpgradeMode>(protocolObject.Mode),
                    nameof(Mode),
                    BindingAccess.Read | BindingAccess.Write);
                this.RollingUpgradePolicyProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.RollingUpgradePolicy, o => new RollingUpgradePolicy(o)),
                    nameof(RollingUpgradePolicy),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradePolicy"/> class.
        /// </summary>
        /// <param name='mode'>Specifies the mode of an upgrade to virtual machines in the scale set.<br /><br /> Possible values are:<br /><br 
        /// /> **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by 
        /// using the manualUpgrade action.<br /><br /> **Automatic** - All virtual machines in the scale set are automatically 
        /// updated at the same time.<br /><br /> **Rolling** - Scale set performs updates in batches with an optional pause 
        /// time in between.</param>
        public UpgradePolicy(
            Common.UpgradeMode mode)
        {
            this.propertyContainer = new PropertyContainer();
            this.Mode = mode;
        }

        /// <summary>
        /// Default constructor to support mocking the <see cref="UpgradePolicy"/> class.
        /// </summary>
        protected UpgradePolicy()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal UpgradePolicy(Models.UpgradePolicy protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region UpgradePolicy

        /// <summary>
        /// Gets or sets configuration parameters used for performing automatic OS Upgrade.
        /// </summary>
        /// <remarks>
        /// The configuration parameters used for performing automatic OS upgrade.
        /// </remarks>
        public AutomaticOSUpgradePolicy AutomaticOSUpgradePolicy
        {
            get { return this.propertyContainer.AutomaticOSUpgradePolicyProperty.Value; }
            set { this.propertyContainer.AutomaticOSUpgradePolicyProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets specifies the mode of an upgrade to virtual machines in the scale set.<br /><br /> Possible values 
        /// are:<br /><br /> **Manual** - You  control the application of updates to virtual machines in the scale set. You 
        /// do this by using the manualUpgrade action.<br /><br /> **Automatic** - All virtual machines in the scale set 
        /// are automatically updated at the same time.<br /><br /> **Rolling** - Scale set performs updates in batches with 
        /// an optional pause time in between.
        /// </summary>
        public Common.UpgradeMode Mode
        {
            get { return this.propertyContainer.ModeProperty.Value; }
            set { this.propertyContainer.ModeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the configuration parameters used while performing a rolling upgrade.
        /// </summary>
        /// <remarks>
        /// This property is only supported on Pools with the virtualMachineConfiguration property.
        /// </remarks>
        public RollingUpgradePolicy RollingUpgradePolicy
        {
            get { return this.propertyContainer.RollingUpgradePolicyProperty.Value; }
            set { this.propertyContainer.RollingUpgradePolicyProperty.Value = value; }
        }

        #endregion // UpgradePolicy

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.UpgradePolicy ITransportObjectProvider<Models.UpgradePolicy>.GetTransportObject()
        {
            Models.UpgradePolicy result = new Models.UpgradePolicy()
            {
                AutomaticOSUpgradePolicy = UtilitiesInternal.CreateObjectWithNullCheck(this.AutomaticOSUpgradePolicy, (o) => o.GetTransportObject()),
                Mode = UtilitiesInternal.MapEnum<Common.UpgradeMode, Models.UpgradeMode>(this.Mode),
                RollingUpgradePolicy = UtilitiesInternal.CreateObjectWithNullCheck(this.RollingUpgradePolicy, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}