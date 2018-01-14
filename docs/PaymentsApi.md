# AuthorizeNet.Rest.Api.PaymentsApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAPayment**](PaymentsApi.md#createapayment) | **POST** /payments | 
[**GetAPayment**](PaymentsApi.md#getapayment) | **GET** /payments/{paymentId} | 
[**GetAllPayments**](PaymentsApi.md#getallpayments) | **GET** /payments | 


# **CreateAPayment**
> Payment CreateAPayment (PaymentRequest paymentRequest, string authorization = null)



Create A Payment

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateAPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsApi();
            var paymentRequest = new PaymentRequest(); // PaymentRequest | charge credit card model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                Payment result = apiInstance.CreateAPayment(paymentRequest, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateAPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentRequest** | [**PaymentRequest**](PaymentRequest.md)| charge credit card model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetAPayment**
> Payment GetAPayment (string paymentId, string authorization = null)



Get A Payment

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetAPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsApi();
            var paymentId = paymentId_example;  // string | 
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                Payment result = apiInstance.GetAPayment(paymentId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetAPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**|  | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetAllPayments**
> PaymentCollection GetAllPayments (string authorization = null)



Get all Payments

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetAllPaymentsExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsApi();
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                PaymentCollection result = apiInstance.GetAllPayments(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetAllPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**PaymentCollection**](PaymentCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

