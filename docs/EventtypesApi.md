# AuthorizeNet.Rest.Api.EventtypesApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEventTypes**](EventtypesApi.md#geteventtypes) | **GET** /eventtypes | Retrieving Event Types


# **GetEventTypes**
> List<EventType> GetEventTypes (string authorization)

Retrieving Event Types

Returns a list of all Webhooks event types

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetEventTypesExample
    {
        public void main()
        {
            
            var apiInstance = new EventtypesApi();
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request

            try
            {
                // Retrieving Event Types
                List&lt;EventType&gt; result = apiInstance.GetEventTypes(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventtypesApi.GetEventTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | 

### Return type

[**List<EventType>**](EventType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

