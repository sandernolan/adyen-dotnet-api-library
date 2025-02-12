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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
      /// <summary>
    /// Split
    /// </summary>
    [DataContract]
        public partial class Split :  IEquatable<Split>, IValidatableObject
    {
        /// <summary>
        /// The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**.
        /// </summary>
        /// <value>The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum BalanceAccount for value: BalanceAccount
            /// </summary>
            [EnumMember(Value = "BalanceAccount")]
            BalanceAccount = 1,
            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 2,
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 3,
            /// <summary>
            /// Enum MarketPlace for value: MarketPlace
            /// </summary>
            [EnumMember(Value = "MarketPlace")]
            MarketPlace = 4,
            /// <summary>
            /// Enum PaymentFee for value: PaymentFee
            /// </summary>
            [EnumMember(Value = "PaymentFee")]
            PaymentFee = 5,
            /// <summary>
            /// Enum Remainder for value: Remainder
            /// </summary>
            [EnumMember(Value = "Remainder")]
            Remainder = 6,
            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 7,
            /// <summary>
            /// Enum Verification for value: Verification
            /// </summary>
            [EnumMember(Value = "Verification")]
            Verification = 8        }
        /// <summary>
        /// The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**.
        /// </summary>
        /// <value>The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="account">Unique identifier of the account where the split amount should be sent. This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**.  .</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="description">A description of this split..</param>
        /// <param name="reference">Your reference for the split, which you can use to link the split to other operations such as captures and refunds.  This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**. For the other types, we also recommend sending a reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. If the reference is not provided, the split is reported as part of the aggregated [TransferBalance record type](https://docs.adyen.com/reporting/marketpay-payments-accounting-report) in Adyen for Platforms..</param>
        /// <param name="type">The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**. (required).</param>
        public Split(string account = default(string), SplitAmount amount = default(SplitAmount), string description = default(string), string reference = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Split and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Split and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Account = account;
            this.Description = description;
            this.Reference = reference;
        }
        
        /// <summary>
        /// Unique identifier of the account where the split amount should be sent. This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**.  
        /// </summary>
        /// <value>Unique identifier of the account where the split amount should be sent. This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**.  </value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public SplitAmount Amount { get; set; }

        /// <summary>
        /// A description of this split.
        /// </summary>
        /// <value>A description of this split.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Your reference for the split, which you can use to link the split to other operations such as captures and refunds.  This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**. For the other types, we also recommend sending a reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. If the reference is not provided, the split is reported as part of the aggregated [TransferBalance record type](https://docs.adyen.com/reporting/marketpay-payments-accounting-report) in Adyen for Platforms.
        /// </summary>
        /// <value>Your reference for the split, which you can use to link the split to other operations such as captures and refunds.  This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**. For the other types, we also recommend sending a reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. If the reference is not provided, the split is reported as part of the aggregated [TransferBalance record type](https://docs.adyen.com/reporting/marketpay-payments-accounting-report) in Adyen for Platforms.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Split);
        }

        /// <summary>
        /// Returns true if Split instances are equal
        /// </summary>
        /// <param name="input">Instance of Split to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Split input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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