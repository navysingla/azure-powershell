// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    public partial class KubernetesConfigurationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IKubernetesConfigurationIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IKubernetesConfigurationIdentityInternal
    {

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>The name of the kubernetes cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>Backing field for <see cref="ClusterResourceName" /> property.</summary>
        private string _clusterResourceName;

        /// <summary>
        /// The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S
        /// clusters).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ClusterResourceName { get => this._clusterResourceName; set => this._clusterResourceName = value; }

        /// <summary>Backing field for <see cref="ClusterRp" /> property.</summary>
        private string _clusterRp;

        /// <summary>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S
        /// clusters).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ClusterRp { get => this._clusterRp; set => this._clusterRp = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SourceControlConfigurationName" /> property.</summary>
        private string _sourceControlConfigurationName;

        /// <summary>Name of the Source Control Configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string SourceControlConfigurationName { get => this._sourceControlConfigurationName; set => this._sourceControlConfigurationName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="KubernetesConfigurationIdentity" /> instance.</summary>
        public KubernetesConfigurationIdentity()
        {

        }
    }
    public partial interface IKubernetesConfigurationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The name of the kubernetes cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the kubernetes cluster.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>
        /// The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S
        /// clusters).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).",
        SerializedName = @"clusterResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterResourceName { get; set; }
        /// <summary>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S
        /// clusters).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).",
        SerializedName = @"clusterRp",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterRp { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>Name of the Source Control Configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Source Control Configuration.",
        SerializedName = @"sourceControlConfigurationName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceControlConfigurationName { get; set; }
        /// <summary>
        /// The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000)",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IKubernetesConfigurationIdentityInternal

    {
        /// <summary>The name of the kubernetes cluster.</summary>
        string ClusterName { get; set; }
        /// <summary>
        /// The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S
        /// clusters).
        /// </summary>
        string ClusterResourceName { get; set; }
        /// <summary>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S
        /// clusters).
        /// </summary>
        string ClusterRp { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the resource group.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>Name of the Source Control Configuration.</summary>
        string SourceControlConfigurationName { get; set; }
        /// <summary>
        /// The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000)
        /// </summary>
        string SubscriptionId { get; set; }

    }
}