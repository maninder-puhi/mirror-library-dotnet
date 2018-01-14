# AuthorizeNet.Rest.Api.ForcedCapturesApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAForcedCapture**](ForcedCapturesApi.md#createaforcedcapture) | **POST** /forcedcaptures | 


# **CreateAForcedCapture**
> Payment CreateAForcedCapture (ForcedCaptureRequest body, string authorization = null)



Create A Forced Capture

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateAForcedCaptureExample
    {
        public void main()
        {
            
            var apiInstance = new ForcedCapturesApi();
            var body = new ForcedCaptureRequest(); // ForcedCaptureRequest | 
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                Payment result = apiInstance.CreateAForcedCapture(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForcedCapturesApi.CreateAForcedCapture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ForcedCaptureRequest**](ForcedCaptureRequest.md)|  | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

