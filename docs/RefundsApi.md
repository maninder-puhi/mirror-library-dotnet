# AuthorizeNet.Rest.Api.RefundsApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRefundAPayment**](RefundsApi.md#createrefundapayment) | **POST** /payments/{paymentId}/refunds | 


# **CreateRefundAPayment**
> Payment CreateRefundAPayment (string paymentId, RefundRequest body, string authorization = null)



Create Refund Payment

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateRefundAPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new RefundsApi();
            var paymentId = paymentId_example;  // string | 
            var body = new RefundRequest(); // RefundRequest | 
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                Payment result = apiInstance.CreateRefundAPayment(paymentId, body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.CreateRefundAPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**|  | 
 **body** | [**RefundRequest**](RefundRequest.md)|  | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

