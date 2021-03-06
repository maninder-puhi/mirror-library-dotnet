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
    /// Model for CreateCustomer
    /// </summary>
    [DataContract]
    public partial class CreateCustomer :  IEquatable<CreateCustomer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCustomer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Identifier">Identifier (required).</param>
        /// <param name="PaymentMethod">PaymentMethod.</param>
        public CreateCustomer(string Description = null, Identifier Identifier = null, CreatePaymentMethod PaymentMethod = null)
        {
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for CreateCustomer and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            this.Description = Description;
            this.PaymentMethod = PaymentMethod;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public Identifier Identifier { get; set; }
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public CreatePaymentMethod PaymentMethod { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomer {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return this.Equals(obj as CreateCustomer);
        }

        /// <summary>
        /// Returns true if CreateCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                return hash;
            }
        }
    }

}
