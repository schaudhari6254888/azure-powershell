// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>The parameters to provide for the Microsoft Teams channel.</summary>
    public partial class MSTeamsChannelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IMSTeamsChannelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IMSTeamsChannelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AcceptedTerm" /> property.</summary>
        private bool? _acceptedTerm;

        /// <summary>Whether this channel accepted terms</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? AcceptedTerm { get => this._acceptedTerm; set => this._acceptedTerm = value; }

        /// <summary>Backing field for <see cref="CallingWebhook" /> property.</summary>
        private string _callingWebhook;

        /// <summary>Webhook for Microsoft Teams channel calls</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string CallingWebhook { get => this._callingWebhook; set => this._callingWebhook = value; }

        /// <summary>Backing field for <see cref="DeploymentEnvironment" /> property.</summary>
        private string _deploymentEnvironment;

        /// <summary>Deployment environment for Microsoft Teams channel calls</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string DeploymentEnvironment { get => this._deploymentEnvironment; set => this._deploymentEnvironment = value; }

        /// <summary>Backing field for <see cref="EnableCalling" /> property.</summary>
        private bool? _enableCalling;

        /// <summary>Enable calling for Microsoft Teams channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? EnableCalling { get => this._enableCalling; set => this._enableCalling = value; }

        /// <summary>Backing field for <see cref="IncomingCallRoute" /> property.</summary>
        private string _incomingCallRoute;

        /// <summary>Webhook for Microsoft Teams channel calls</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string IncomingCallRoute { get => this._incomingCallRoute; set => this._incomingCallRoute = value; }

        /// <summary>Backing field for <see cref="IsEnabled" /> property.</summary>
        private bool _isEnabled;

        /// <summary>Whether this channel is enabled for the bot</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool IsEnabled { get => this._isEnabled; set => this._isEnabled = value; }

        /// <summary>Creates an new <see cref="MSTeamsChannelProperties" /> instance.</summary>
        public MSTeamsChannelProperties()
        {

        }
    }
    /// The parameters to provide for the Microsoft Teams channel.
    public partial interface IMSTeamsChannelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable
    {
        /// <summary>Whether this channel accepted terms</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this channel accepted terms",
        SerializedName = @"acceptedTerms",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AcceptedTerm { get; set; }
        /// <summary>Webhook for Microsoft Teams channel calls</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Webhook for Microsoft Teams channel calls",
        SerializedName = @"callingWebhook",
        PossibleTypes = new [] { typeof(string) })]
        string CallingWebhook { get; set; }
        /// <summary>Deployment environment for Microsoft Teams channel calls</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Deployment environment for Microsoft Teams channel calls",
        SerializedName = @"deploymentEnvironment",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentEnvironment { get; set; }
        /// <summary>Enable calling for Microsoft Teams channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable calling for Microsoft Teams channel",
        SerializedName = @"enableCalling",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableCalling { get; set; }
        /// <summary>Webhook for Microsoft Teams channel calls</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Webhook for Microsoft Teams channel calls",
        SerializedName = @"incomingCallRoute",
        PossibleTypes = new [] { typeof(string) })]
        string IncomingCallRoute { get; set; }
        /// <summary>Whether this channel is enabled for the bot</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this channel is enabled for the bot",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool IsEnabled { get; set; }

    }
    /// The parameters to provide for the Microsoft Teams channel.
    internal partial interface IMSTeamsChannelPropertiesInternal

    {
        /// <summary>Whether this channel accepted terms</summary>
        bool? AcceptedTerm { get; set; }
        /// <summary>Webhook for Microsoft Teams channel calls</summary>
        string CallingWebhook { get; set; }
        /// <summary>Deployment environment for Microsoft Teams channel calls</summary>
        string DeploymentEnvironment { get; set; }
        /// <summary>Enable calling for Microsoft Teams channel</summary>
        bool? EnableCalling { get; set; }
        /// <summary>Webhook for Microsoft Teams channel calls</summary>
        string IncomingCallRoute { get; set; }
        /// <summary>Whether this channel is enabled for the bot</summary>
        bool IsEnabled { get; set; }

    }
}