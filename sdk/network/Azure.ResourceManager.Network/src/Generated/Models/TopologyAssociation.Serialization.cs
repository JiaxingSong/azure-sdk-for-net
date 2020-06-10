// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TopologyAssociation
    {
        internal static TopologyAssociation DeserializeTopologyAssociation(JsonElement element)
        {
            string name = default;
            string resourceId = default;
            AssociationType? associationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("associationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    associationType = new AssociationType(property.Value.GetString());
                    continue;
                }
            }
            return new TopologyAssociation(name, resourceId, associationType);
        }
    }
}