/* 
 * Authorize.net REST API
 *
 * Authorize.net REST API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AuthorizeNet.Rest.Model
{
    /// <summary>
    /// Response model for get a Webhook
    /// </summary>
    [DataContract]
    public partial class GetWebhookResponse :  IEquatable<GetWebhookResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWebhookResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookResponse" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="WebhookId">Label of the new Webhook (required).</param>
        /// <param name="Name">Label of the new Webhook.</param>
        /// <param name="Status">Status of the new Webhook (required).</param>
        /// <param name="Url">Callback Url (required).</param>
        /// <param name="EventTypes">List of desired events for subscriptions (required).</param>
        public GetWebhookResponse(SelfLink Links = null, string WebhookId = null, string Name = null, string Status = null, string Url = null, List<string> EventTypes = null)
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for GetWebhookResponse and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            // to ensure "WebhookId" is required (not null)
            if (WebhookId == null)
            {
                throw new InvalidDataException("WebhookId is a required property for GetWebhookResponse and cannot be null");
            }
            else
            {
                this.WebhookId = WebhookId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for GetWebhookResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for GetWebhookResponse and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "EventTypes" is required (not null)
            if (EventTypes == null)
            {
                throw new InvalidDataException("EventTypes is a required property for GetWebhookResponse and cannot be null");
            }
            else
            {
                this.EventTypes = EventTypes;
            }
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public SelfLink Links { get; set; }
        /// <summary>
        /// Label of the new Webhook
        /// </summary>
        /// <value>Label of the new Webhook</value>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public string WebhookId { get; set; }
        /// <summary>
        /// Label of the new Webhook
        /// </summary>
        /// <value>Label of the new Webhook</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Status of the new Webhook
        /// </summary>
        /// <value>Status of the new Webhook</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Callback Url
        /// </summary>
        /// <value>Callback Url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// List of desired events for subscriptions
        /// </summary>
        /// <value>List of desired events for subscriptions</value>
        [DataMember(Name="eventTypes", EmitDefaultValue=false)]
        public List<string> EventTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWebhookResponse {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetWebhookResponse);
        }

        /// <summary>
        /// Returns true if GetWebhookResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetWebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWebhookResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.WebhookId == other.WebhookId ||
                    this.WebhookId != null &&
                    this.WebhookId.Equals(other.WebhookId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.EventTypes == other.EventTypes ||
                    this.EventTypes != null &&
                    this.EventTypes.SequenceEqual(other.EventTypes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.WebhookId != null)
                    hash = hash * 59 + this.WebhookId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.EventTypes != null)
                    hash = hash * 59 + this.EventTypes.GetHashCode();
                return hash;
            }
        }
    }

}
