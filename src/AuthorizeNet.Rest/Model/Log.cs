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
    /// 
    /// </summary>
    [DataContract]
    public partial class Log :  IEquatable<Log>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        /// <param name="StatusCode">StatusCode.</param>
        /// <param name="RetryStage">RetryStage.</param>
        /// <param name="RetryCountInStage">RetryCountInStage.</param>
        /// <param name="RetryDate">RetryDate.</param>
        /// <param name="Message">Message.</param>
        public Log(int? StatusCode = null, int? RetryStage = null, int? RetryCountInStage = null, string RetryDate = null, string Message = null)
        {
            this.StatusCode = StatusCode;
            this.RetryStage = RetryStage;
            this.RetryCountInStage = RetryCountInStage;
            this.RetryDate = RetryDate;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }
        /// <summary>
        /// Gets or Sets RetryStage
        /// </summary>
        [DataMember(Name="retryStage", EmitDefaultValue=false)]
        public int? RetryStage { get; set; }
        /// <summary>
        /// Gets or Sets RetryCountInStage
        /// </summary>
        [DataMember(Name="retryCountInStage", EmitDefaultValue=false)]
        public int? RetryCountInStage { get; set; }
        /// <summary>
        /// Gets or Sets RetryDate
        /// </summary>
        [DataMember(Name="retryDate", EmitDefaultValue=false)]
        public string RetryDate { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Log {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  RetryStage: ").Append(RetryStage).Append("\n");
            sb.Append("  RetryCountInStage: ").Append(RetryCountInStage).Append("\n");
            sb.Append("  RetryDate: ").Append(RetryDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as Log);
        }

        /// <summary>
        /// Returns true if Log instances are equal
        /// </summary>
        /// <param name="other">Instance of Log to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Log other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    this.RetryStage == other.RetryStage ||
                    this.RetryStage != null &&
                    this.RetryStage.Equals(other.RetryStage)
                ) && 
                (
                    this.RetryCountInStage == other.RetryCountInStage ||
                    this.RetryCountInStage != null &&
                    this.RetryCountInStage.Equals(other.RetryCountInStage)
                ) && 
                (
                    this.RetryDate == other.RetryDate ||
                    this.RetryDate != null &&
                    this.RetryDate.Equals(other.RetryDate)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.RetryStage != null)
                    hash = hash * 59 + this.RetryStage.GetHashCode();
                if (this.RetryCountInStage != null)
                    hash = hash * 59 + this.RetryCountInStage.GetHashCode();
                if (this.RetryDate != null)
                    hash = hash * 59 + this.RetryDate.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }
    }

}
