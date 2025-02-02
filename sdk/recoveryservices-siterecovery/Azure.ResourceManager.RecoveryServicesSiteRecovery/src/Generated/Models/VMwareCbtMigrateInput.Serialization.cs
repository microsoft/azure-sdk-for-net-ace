// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtMigrateInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("performShutdown"u8);
            writer.WriteStringValue(PerformShutdown);
            if (Optional.IsDefined(OSUpgradeVersion))
            {
                writer.WritePropertyName("osUpgradeVersion"u8);
                writer.WriteStringValue(OSUpgradeVersion);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
