using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentVerificationResponse {
    /// <summary>
    /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** > **Account** > **API URLs** > **Additional data settings**.
    /// </summary>
    /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** > **Account** > **API URLs** > **Additional data settings**.</value>
    [DataMember(Name="additionalData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalData")]
    public AnyOfPaymentVerificationResponseAdditionalData AdditionalData { get; set; }

    /// <summary>
    /// Gets or Sets FraudResult
    /// </summary>
    [DataMember(Name="fraudResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraudResult")]
    public FraudResult FraudResult { get; set; }

    /// <summary>
    /// A unique value that you provided in the initial `/paymentSession` request as a `reference` field.
    /// </summary>
    /// <value>A unique value that you provided in the initial `/paymentSession` request as a `reference` field.</value>
    [DataMember(Name="merchantReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantReference")]
    public string MerchantReference { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public CheckoutOrderResponse Order { get; set; }

    /// <summary>
    /// The payment method used in the transaction.
    /// </summary>
    /// <value>The payment method used in the transaction.</value>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  > `pspReference` is returned only for non-redirect payment methods.
    /// </summary>
    /// <value>Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  > `pspReference` is returned only for non-redirect payment methods.</value>
    [DataMember(Name="pspReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pspReference")]
    public string PspReference { get; set; }

    /// <summary>
    /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
    /// </summary>
    /// <value>If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
    [DataMember(Name="refusalReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refusalReason")]
    public string RefusalReason { get; set; }

    /// <summary>
    /// Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
    /// </summary>
    /// <value>Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
    [DataMember(Name="refusalReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refusalReasonCode")]
    public string RefusalReasonCode { get; set; }

    /// <summary>
    /// The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state.
    /// </summary>
    /// <value>The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state.</value>
    [DataMember(Name="resultCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultCode")]
    public string ResultCode { get; set; }

    /// <summary>
    /// Gets or Sets ServiceError
    /// </summary>
    [DataMember(Name="serviceError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceError")]
    public ServiceError ServiceError { get; set; }

    /// <summary>
    /// The shopperLocale value provided in the payment request.
    /// </summary>
    /// <value>The shopperLocale value provided in the payment request.</value>
    [DataMember(Name="shopperLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperLocale")]
    public string ShopperLocale { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentVerificationResponse {\n");
      sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
      sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
      sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  PspReference: ").Append(PspReference).Append("\n");
      sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
      sb.Append("  RefusalReasonCode: ").Append(RefusalReasonCode).Append("\n");
      sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
      sb.Append("  ServiceError: ").Append(ServiceError).Append("\n");
      sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
