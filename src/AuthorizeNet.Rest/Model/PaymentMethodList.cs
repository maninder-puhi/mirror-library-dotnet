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
    /// PaymentMethodList
    /// </summary>
    [DataContract]
    public partial class PaymentMethodList :  IEquatable<PaymentMethodList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodList" /> class.
        /// </summary>
        /// <param name="PaymentMethods">PaymentMethods.</param>
        public PaymentMethodList(List<PaymentMethods> PaymentMethods = null)
        {
            this.PaymentMethods = PaymentMethods;
        }
        
        /// <summary>
        /// Gets or Sets PaymentMethods
        /// </summary>
        [DataMember(Name="paymentMethods", EmitDefaultValue=false)]
        public List<PaymentMethods> PaymentMethods { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodList {\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
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
            return this.Equals(obj as PaymentMethodList);
        }

        /// <summary>
        /// Returns true if PaymentMethodList instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethodList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentMethods == other.PaymentMethods ||
                    this.PaymentMethods != null &&
                    this.PaymentMethods.SequenceEqual(other.PaymentMethods)
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
                if (this.PaymentMethods != null)
                    hash = hash * 59 + this.PaymentMethods.GetHashCode();
                return hash;
            }
        }
    }

}
