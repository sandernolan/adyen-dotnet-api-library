#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCPayoutMethodCheckResult
    /// </summary>
    [DataContract]
        public partial class KYCPayoutMethodCheckResult :  IEquatable<KYCPayoutMethodCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCPayoutMethodCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="payoutMethodCode">The unique ID of the payoput method to which the check applies..</param>
        public KYCPayoutMethodCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string payoutMethodCode = default(string))
        {
            this.Checks = checks;
            this.PayoutMethodCode = payoutMethodCode;
        }
        
        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The unique ID of the payoput method to which the check applies.
        /// </summary>
        /// <value>The unique ID of the payoput method to which the check applies.</value>
        [DataMember(Name="payoutMethodCode", EmitDefaultValue=false)]
        public string PayoutMethodCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCPayoutMethodCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks.ObjectListToString()).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
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
            return this.Equals(input as KYCPayoutMethodCheckResult);
        }

        /// <summary>
        /// Returns true if KYCPayoutMethodCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCPayoutMethodCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCPayoutMethodCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Checks == input.Checks ||
                    this.Checks != null &&
                    input.Checks != null &&
                    this.Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    this.PayoutMethodCode == input.PayoutMethodCode ||
                    (this.PayoutMethodCode != null &&
                    this.PayoutMethodCode.Equals(input.PayoutMethodCode))
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
                if (this.Checks != null)
                    hashCode = hashCode * 59 + this.Checks.GetHashCode();
                if (this.PayoutMethodCode != null)
                    hashCode = hashCode * 59 + this.PayoutMethodCode.GetHashCode();
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