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
    /// Model for BankAccount
    /// </summary>
    [DataContract]
    public partial class BankAccount :  IEquatable<BankAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BankAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        /// <param name="AccountType">AccountType.</param>
        /// <param name="RoutingNumber">RoutingNumber (required).</param>
        /// <param name="AccountNumber">AccountNumber (required).</param>
        /// <param name="NameOnAccount">NameOnAccount (required).</param>
        /// <param name="ECheckType">ECheckType.</param>
        /// <param name="BankName">BankName.</param>
        /// <param name="CheckNumber">CheckNumber.</param>
        public BankAccount(string AccountType = null, string RoutingNumber = null, string AccountNumber = null, string NameOnAccount = null, string ECheckType = null, string BankName = null, string CheckNumber = null)
        {
            // to ensure "RoutingNumber" is required (not null)
            if (RoutingNumber == null)
            {
                throw new InvalidDataException("RoutingNumber is a required property for BankAccount and cannot be null");
            }
            else
            {
                this.RoutingNumber = RoutingNumber;
            }
            // to ensure "AccountNumber" is required (not null)
            if (AccountNumber == null)
            {
                throw new InvalidDataException("AccountNumber is a required property for BankAccount and cannot be null");
            }
            else
            {
                this.AccountNumber = AccountNumber;
            }
            // to ensure "NameOnAccount" is required (not null)
            if (NameOnAccount == null)
            {
                throw new InvalidDataException("NameOnAccount is a required property for BankAccount and cannot be null");
            }
            else
            {
                this.NameOnAccount = NameOnAccount;
            }
            this.AccountType = AccountType;
            this.ECheckType = ECheckType;
            this.BankName = BankName;
            this.CheckNumber = CheckNumber;
        }
        
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }
        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }
        /// <summary>
        /// Gets or Sets NameOnAccount
        /// </summary>
        [DataMember(Name="nameOnAccount", EmitDefaultValue=false)]
        public string NameOnAccount { get; set; }
        /// <summary>
        /// Gets or Sets ECheckType
        /// </summary>
        [DataMember(Name="eCheckType", EmitDefaultValue=false)]
        public string ECheckType { get; set; }
        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }
        /// <summary>
        /// Gets or Sets CheckNumber
        /// </summary>
        [DataMember(Name="checkNumber", EmitDefaultValue=false)]
        public string CheckNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  NameOnAccount: ").Append(NameOnAccount).Append("\n");
            sb.Append("  ECheckType: ").Append(ECheckType).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
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
            return this.Equals(obj as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.NameOnAccount == other.NameOnAccount ||
                    this.NameOnAccount != null &&
                    this.NameOnAccount.Equals(other.NameOnAccount)
                ) && 
                (
                    this.ECheckType == other.ECheckType ||
                    this.ECheckType != null &&
                    this.ECheckType.Equals(other.ECheckType)
                ) && 
                (
                    this.BankName == other.BankName ||
                    this.BankName != null &&
                    this.BankName.Equals(other.BankName)
                ) && 
                (
                    this.CheckNumber == other.CheckNumber ||
                    this.CheckNumber != null &&
                    this.CheckNumber.Equals(other.CheckNumber)
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
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.NameOnAccount != null)
                    hash = hash * 59 + this.NameOnAccount.GetHashCode();
                if (this.ECheckType != null)
                    hash = hash * 59 + this.ECheckType.GetHashCode();
                if (this.BankName != null)
                    hash = hash * 59 + this.BankName.GetHashCode();
                if (this.CheckNumber != null)
                    hash = hash * 59 + this.CheckNumber.GetHashCode();
                return hash;
            }
        }
    }

}
