﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphTopologyCollection
    {
        /// <summary>
        ///  Deserialize MediaGraphTopology.
        /// </summary>
        /// <param name="json">The json data that is to be deserialized.</param>
        /// <returns>A List of MediaGraphTopology.</returns>
        public static MediaGraphTopologyCollection Deserialize(string json)
        {
            JsonElement element = JsonDocument.Parse(json).RootElement;
            return DeserializeMediaGraphTopologyCollection(element);
        }
    }
}
