// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DefenderEasm;

namespace Azure.ResourceManager.DefenderEasm.Models
{
    internal partial class EasmWorkspaceListResult
    {
        internal static EasmWorkspaceListResult DeserializeEasmWorkspaceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<EasmWorkspaceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EasmWorkspaceData> array = new List<EasmWorkspaceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EasmWorkspaceData.DeserializeEasmWorkspaceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EasmWorkspaceListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
