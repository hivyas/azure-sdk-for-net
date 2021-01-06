﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphInstanceCollection
    {
        /// <summary>
        ///  Deserialize MediaGraphInstance.
        /// </summary>
        /// <param name="json">The json to be deserialized.</param>
        /// <returns> Deserialized Graph Instance Collection. </returns>
        public static MediaGraphInstanceCollection Deserialize(string json)
        {
            JsonElement element = JsonDocument.Parse(json).RootElement;
            return DeserializeMediaGraphInstanceCollection(element);
        }
    }
}
