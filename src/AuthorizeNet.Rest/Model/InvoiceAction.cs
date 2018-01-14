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
    /// Do Action
    /// </summary>
    [DataContract]
    public partial class InvoiceAction :  IEquatable<InvoiceAction>
    {
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Send for "Send"
            /// </summary>
            [EnumMember(Value = "Send")]
            Send,
            
            /// <summary>
            /// Enum Cancel for "Cancel"
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceAction" /> class.
        /// </summary>
        /// <param name="Action">Action (required).</param>
        /// <param name="Date">Date.</param>
        public InvoiceAction(ActionEnum? Action = null, string Date = null)
        {
            // to ensure "Action" is required (not null)
            if (Action == null)
            {
                throw new InvalidDataException("Action is a required property for InvoiceAction and cannot be null");
            }
            else
            {
                this.Action = Action;
            }
            this.Date = Date;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceAction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as InvoiceAction);
        }

        /// <summary>
        /// Returns true if InvoiceAction instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoiceAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                return hash;
            }
        }
    }

}
