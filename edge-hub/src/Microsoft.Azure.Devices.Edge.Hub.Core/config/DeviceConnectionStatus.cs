// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Hub.Core.Config
{
    using System;
    using Microsoft.Azure.Devices.Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    class DeviceConnectionStatus
    {
        public DeviceConnectionStatus(ConnectionStatus status, bool inDeviceScope, DateTime? lastConnectedTimeUtc, DateTime? lastDisconnectedTimeUtc)
        {
            this.Status = status;
            this.LastConnectedTimeUtc = lastConnectedTimeUtc;
            this.LastDisconnectTimeUtc = lastDisconnectedTimeUtc;
            this.InDeviceScope = inDeviceScope;
        }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConnectionStatus Status { get; }

        [JsonProperty(PropertyName = "inDeviceScope")]
        public bool InDeviceScope { get; }

        [JsonProperty(PropertyName = "lastConnectedTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastConnectedTimeUtc { get; }

        [JsonProperty(PropertyName = "lastDisconnectedTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastDisconnectTimeUtc { get; }
    }      
}
