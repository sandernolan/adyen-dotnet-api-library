#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ServiceError
    /// </summary>
    [DataContract]
        public partial class ServiceError :  IEquatable<ServiceError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceError" /> class.
        /// </summary>
        /// <param name="additionalData">Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Account** &gt; **API URLs**..</param>
        /// <param name="errorCode">The error code mapped to the error message..</param>
        /// <param name="errorType">The category of the error..</param>
        /// <param name="message">A short explanation of the issue..</param>
        /// <param name="pspReference">The PSP reference of the payment..</param>
        /// <param name="status">The HTTP response status..</param>
        public ServiceError(Dictionary<string, string> additionalData = default(Dictionary<string, string>), string errorCode = default(string), string errorType = default(string), string message = default(string), string pspReference = default(string), int? status = default(int?))
        {
            this.AdditionalData = additionalData;
            this.ErrorCode = errorCode;
            this.ErrorType = errorType;
            this.Message = message;
            this.PspReference = pspReference;
            this.Status = status;
        }
        
        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Account** &gt; **API URLs**.
        /// </summary>
        /// <value>Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Account** &gt; **API URLs**.</value>
        [DataMember(Name="additionalData", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The error code mapped to the error message.
        /// </summary>
        /// <value>The error code mapped to the error message.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The category of the error.
        /// </summary>
        /// <value>The category of the error.</value>
        [DataMember(Name="errorType", EmitDefaultValue=false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// A short explanation of the issue.
        /// </summary>
        /// <value>A short explanation of the issue.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The PSP reference of the payment.
        /// </summary>
        /// <value>The PSP reference of the payment.</value>
        [DataMember(Name="pspReference", EmitDefaultValue=false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The HTTP response status.
        /// </summary>
        /// <value>The HTTP response status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceError {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData.ToCollectionsString()).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceError);
        }

        /// <summary>
        /// Returns true if ServiceError instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorType == input.ErrorType ||
                    (this.ErrorType != null &&
                    this.ErrorType.Equals(input.ErrorType))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorType != null)
                    hashCode = hashCode * 59 + this.ErrorType.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}