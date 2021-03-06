// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuit : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowClassicOperations))
            {
                writer.WritePropertyName("allowClassicOperations");
                writer.WriteBooleanValue(AllowClassicOperations.Value);
            }
            if (Optional.IsDefined(CircuitProvisioningState))
            {
                writer.WritePropertyName("circuitProvisioningState");
                writer.WriteStringValue(CircuitProvisioningState);
            }
            if (Optional.IsDefined(ServiceProviderProvisioningState))
            {
                writer.WritePropertyName("serviceProviderProvisioningState");
                writer.WriteStringValue(ServiceProviderProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations");
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Peerings))
            {
                writer.WritePropertyName("peerings");
                writer.WriteStartArray();
                foreach (var item in Peerings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServiceKey))
            {
                writer.WritePropertyName("serviceKey");
                writer.WriteStringValue(ServiceKey);
            }
            if (Optional.IsDefined(ServiceProviderNotes))
            {
                writer.WritePropertyName("serviceProviderNotes");
                writer.WriteStringValue(ServiceProviderNotes);
            }
            if (Optional.IsDefined(ServiceProviderProperties))
            {
                writer.WritePropertyName("serviceProviderProperties");
                writer.WriteObjectValue(ServiceProviderProperties);
            }
            if (Optional.IsDefined(ExpressRoutePort))
            {
                writer.WritePropertyName("expressRoutePort");
                writer.WriteObjectValue(ExpressRoutePort);
            }
            if (Optional.IsDefined(BandwidthInGbps))
            {
                writer.WritePropertyName("bandwidthInGbps");
                writer.WriteNumberValue(BandwidthInGbps.Value);
            }
            if (Optional.IsDefined(GatewayManagerEtag))
            {
                writer.WritePropertyName("gatewayManagerEtag");
                writer.WriteStringValue(GatewayManagerEtag);
            }
            if (Optional.IsDefined(GlobalReachEnabled))
            {
                writer.WritePropertyName("globalReachEnabled");
                writer.WriteBooleanValue(GlobalReachEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuit DeserializeExpressRouteCircuit(JsonElement element)
        {
            Optional<ExpressRouteCircuitSku> sku = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<bool> allowClassicOperations = default;
            Optional<string> circuitProvisioningState = default;
            Optional<ServiceProviderProvisioningState> serviceProviderProvisioningState = default;
            Optional<IList<ExpressRouteCircuitAuthorization>> authorizations = default;
            Optional<IList<ExpressRouteCircuitPeering>> peerings = default;
            Optional<string> serviceKey = default;
            Optional<string> serviceProviderNotes = default;
            Optional<ExpressRouteCircuitServiceProviderProperties> serviceProviderProperties = default;
            Optional<SubResource> expressRoutePort = default;
            Optional<float> bandwidthInGbps = default;
            Optional<int> stag = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> gatewayManagerEtag = default;
            Optional<bool> globalReachEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = ExpressRouteCircuitSku.DeserializeExpressRouteCircuitSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allowClassicOperations"))
                        {
                            allowClassicOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("circuitProvisioningState"))
                        {
                            circuitProvisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProvisioningState"))
                        {
                            serviceProviderProvisioningState = new ServiceProviderProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            List<ExpressRouteCircuitAuthorization> array = new List<ExpressRouteCircuitAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitAuthorization.DeserializeExpressRouteCircuitAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("peerings"))
                        {
                            List<ExpressRouteCircuitPeering> array = new List<ExpressRouteCircuitPeering>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitPeering.DeserializeExpressRouteCircuitPeering(item));
                            }
                            peerings = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceKey"))
                        {
                            serviceKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderNotes"))
                        {
                            serviceProviderNotes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProperties"))
                        {
                            serviceProviderProperties = ExpressRouteCircuitServiceProviderProperties.DeserializeExpressRouteCircuitServiceProviderProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expressRoutePort"))
                        {
                            expressRoutePort = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bandwidthInGbps"))
                        {
                            bandwidthInGbps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("stag"))
                        {
                            stag = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayManagerEtag"))
                        {
                            gatewayManagerEtag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("globalReachEnabled"))
                        {
                            globalReachEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCircuit(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), sku.Value, etag.Value, Optional.ToNullable(allowClassicOperations), circuitProvisioningState.Value, Optional.ToNullable(serviceProviderProvisioningState), Optional.ToList(authorizations), Optional.ToList(peerings), serviceKey.Value, serviceProviderNotes.Value, serviceProviderProperties.Value, expressRoutePort.Value, Optional.ToNullable(bandwidthInGbps), Optional.ToNullable(stag), Optional.ToNullable(provisioningState), gatewayManagerEtag.Value, Optional.ToNullable(globalReachEnabled));
        }
    }
}
