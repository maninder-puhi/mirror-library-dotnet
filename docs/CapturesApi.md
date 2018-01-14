# AuthorizeNet.Rest.Api.CapturesApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateACapture**](CapturesApi.md#createacapture) | **POST** /payments/{paymentId}/captures | 


# **CreateACapture**
> Payment CreateACapture (string paymentId, CaptureRequest body, string authorization = null)



Create A Capture

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateACaptureExample
    {
        public void main()
        {
            
            var apiInstance = new CapturesApi();
            var paymentId = paymentId_example;  // string | 
            var body = new CaptureRequest(); // CaptureRequest | 
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                Payment result = apiInstance.CreateACapture(paymentId, body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CapturesApi.CreateACapture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**|  | 
 **body** | [**CaptureRequest**](CaptureRequest.md)|  | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

