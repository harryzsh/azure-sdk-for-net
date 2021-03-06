// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class AliasType
    {
        internal static AliasType DeserializeAliasType(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<AliasPathType>> paths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paths"))
                {
                    List<AliasPathType> array = new List<AliasPathType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AliasPathType.DeserializeAliasPathType(item));
                    }
                    paths = array;
                    continue;
                }
            }
            return new AliasType(name.Value, Optional.ToList(paths));
        }
    }
}
