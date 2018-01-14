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
    /// PaymentMethods
    /// </summary>
    [DataContract]
    public partial class PaymentMethods :  IEquatable<PaymentMethods>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethods" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="_Default">_Default.</param>
        /// <param name="PaymentInstrument">PaymentInstrument.</param>
        /// <param name="Links">Links.</param>
        public PaymentMethods(string Id = null, bool? _Default = null, PaymentInstrument PaymentInstrument = null, PaymentMethodLinks Links = null)
        {
            this.Id = Id;
            this._Default = _Default;
            this.PaymentInstrument = PaymentInstrument;
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
        /// <summary>
        /// Gets or Sets PaymentInstrument
        /// </summary>
        [DataMember(Name="paymentInstrument", EmitDefaultValue=false)]
        public PaymentInstrument PaymentInstrument { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PaymentMethodLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethods {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  PaymentInstrument: ").Append(PaymentInstrument).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as PaymentMethods);
        }

        /// <summary>
        /// Returns true if PaymentMethods instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethods other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.PaymentInstrument == other.PaymentInstrument ||
                    this.PaymentInstrument != null &&
                    this.PaymentInstrument.Equals(other.PaymentInstrument)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.PaymentInstrument != null)
                    hash = hash * 59 + this.PaymentInstrument.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }
    }

}
