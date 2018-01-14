# AuthorizeNet.Rest.Api.CreditsApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateACredit**](CreditsApi.md#createacredit) | **POST** /credits | 


# **CreateACredit**
> Payment CreateACredit (CreditRequest body, string authorization = null)



Create A Credit

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateACreditExample
    {
        public void main()
        {
            
            var apiInstance = new CreditsApi();
            var body = new CreditRequest(); // CreditRequest | 
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                Payment result = apiInstance.CreateACredit(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditsApi.CreateACredit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditRequest**](CreditRequest.md)|  | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

