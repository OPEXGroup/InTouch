/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// Audio upload server response.
    /// </summary>
    [DebuggerDisplay("AudioUploadResponse {Server}")]
    [DataContract]
    public class AudioUploadResponse : UploadResponse
    {
        /// <summary>
        /// Audio data.
        /// </summary>
        [DataMember]
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [DataMember]
        [JsonProperty("redirect")]
        public string Redirect { get; set; }
    }
}