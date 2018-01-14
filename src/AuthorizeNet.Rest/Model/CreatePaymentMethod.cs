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
    /// Model for CreatePaymentMethod
    /// </summary>
    [DataContract]
    public partial class CreatePaymentMethod :  IEquatable<CreatePaymentMethod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentMethod" /> class.
        /// </summary>
        /// <param name="AddressId">AddressId.</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="_Default">_Default.</param>
        /// <param name="Payment">Payment.</param>
        public CreatePaymentMethod(string AddressId = null, BaseAddress BillTo = null, bool? _Default = null, PaymentInstrument Payment = null)
        {
            this.AddressId = AddressId;
            this.BillTo = BillTo;
            this._Default = _Default;
            this.Payment = Payment;
        }
        
        /// <summary>
        /// Gets or Sets AddressId
        /// </summary>
        [DataMember(Name="addressId", EmitDefaultValue=false)]
        public string AddressId { get; set; }
        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public BaseAddress BillTo { get; set; }
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public PaymentInstrument Payment { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentMethod {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
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
            return this.Equals(obj as CreatePaymentMethod);
        }

        /// <summary>
        /// Returns true if CreatePaymentMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressId == other.AddressId ||
                    this.AddressId != null &&
                    this.AddressId.Equals(other.AddressId)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.Payment == other.Payment ||
                    this.Payment != null &&
                    this.Payment.Equals(other.Payment)
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
                if (this.AddressId != null)
                    hash = hash * 59 + this.AddressId.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.Payment != null)
                    hash = hash * 59 + this.Payment.GetHashCode();
                return hash;
            }
        }
    }

}
