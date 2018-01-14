# AuthorizeNet.Rest.Api.WebhooksApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhook**](WebhooksApi.md#createwebhook) | **POST** /webhooks | Create A Webhook
[**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Delete A Webhook
[**GetWebhook**](WebhooksApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Get A Webhook
[**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /webhooks | List My Webhooks
[**PingsWebhook**](WebhooksApi.md#pingswebhook) | **POST** /webhooks/{webhookId}/pings | Pings A Webhook
[**UpdateWebhook**](WebhooksApi.md#updatewebhook) | **PUT** /webhooks/{webhookId} | Update A Webhook


# **CreateWebhook**
> GetWebhookResponse CreateWebhook (CreateWebhookBody createWebhookBody, string authorization = null)

Create A Webhook

Enroll in one or more particular type of event notification

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();
            var createWebhookBody = new CreateWebhookBody(); // CreateWebhookBody | the \"CreateWebhookBody\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Create A Webhook
                GetWebhookResponse result = apiInstance.CreateWebhook(createWebhookBody, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWebhookBody** | [**CreateWebhookBody**](CreateWebhookBody.md)| the \&quot;CreateWebhookBody\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**GetWebhookResponse**](GetWebhookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteWebhook**
> void DeleteWebhook (string webhookId, string authorization = null)

Delete A Webhook

Delete an existing Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();
            var webhookId = webhookId_example;  // string | ID of webhook to return
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Delete A Webhook
                apiInstance.DeleteWebhook(webhookId, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| ID of webhook to return | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetWebhook**
> GetWebhookResponse GetWebhook (string webhookId, string authorization = null)

Get A Webhook

Retrieve details of an existing Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();
            var webhookId = webhookId_example;  // string | ID of webhook to return
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get A Webhook
                GetWebhookResponse result = apiInstance.GetWebhook(webhookId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| ID of webhook to return | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**GetWebhookResponse**](GetWebhookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetWebhooks**
> List<GetWebhookResponse> GetWebhooks (string authorization = null)

List My Webhooks

Retrieve details of existing Webhooks

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // List My Webhooks
                List&lt;GetWebhookResponse&gt; result = apiInstance.GetWebhooks(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message );
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

[**List<GetWebhookResponse>**](GetWebhookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **PingsWebhook**
> void PingsWebhook (string webhookId, string authorization = null)

Pings A Webhook

A test event is sent to the Webhook (in an inactive state) endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class PingsWebhookExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();
            var webhookId = webhookId_example;  // string | ID of webhook to return
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Pings A Webhook
                apiInstance.PingsWebhook(webhookId, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.PingsWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| ID of webhook to return | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateWebhook**
> GetWebhookResponse UpdateWebhook (string webhookId, CreateWebhookBody updateWebhookBody, string authorization = null)

Update A Webhook

Update an existing Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();
            var webhookId = webhookId_example;  // string | ID of webhook to return
            var updateWebhookBody = new CreateWebhookBody(); // CreateWebhookBody | the \"CreateWebhookBody\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Update A Webhook
                GetWebhookResponse result = apiInstance.UpdateWebhook(webhookId, updateWebhookBody, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| ID of webhook to return | 
 **updateWebhookBody** | [**CreateWebhookBody**](CreateWebhookBody.md)| the \&quot;CreateWebhookBody\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**GetWebhookResponse**](GetWebhookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

