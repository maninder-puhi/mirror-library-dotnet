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
    /// Response model for get a Notification
    /// </summary>
    [DataContract]
    public partial class GetNotificationsResponse :  IEquatable<GetNotificationsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetNotificationsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponse" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="Notifications">Notifications (required).</param>
        public GetNotificationsResponse(SelfLink Links = null, List<Notification> Notifications = null)
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for GetNotificationsResponse and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            // to ensure "Notifications" is required (not null)
            if (Notifications == null)
            {
                throw new InvalidDataException("Notifications is a required property for GetNotificationsResponse and cannot be null");
            }
            else
            {
                this.Notifications = Notifications;
            }
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public SelfLink Links { get; set; }
        /// <summary>
        /// Gets or Sets Notifications
        /// </summary>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public List<Notification> Notifications { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetNotificationsResponse {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
            return this.Equals(obj as GetNotificationsResponse);
        }

        /// <summary>
        /// Returns true if GetNotificationsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetNotificationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetNotificationsResponse other)
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
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.SequenceEqual(other.Notifications)
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
                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();
                return hash;
            }
        }
    }

}
