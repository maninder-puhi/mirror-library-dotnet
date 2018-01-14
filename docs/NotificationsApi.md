# AuthorizeNet.Rest.Api.NotificationsApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNotification**](NotificationsApi.md#getnotification) | **GET** /notifications/{notificationsId} | Get a Notification
[**GetNotifications**](NotificationsApi.md#getnotifications) | **GET** /notifications | Get Notifications


# **GetNotification**
> GetNotificationResponse GetNotification (string notificationsId, string authorization = null)

Get a Notification

Retreives a notification history

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetNotificationExample
    {
        public void main()
        {
            
            var apiInstance = new NotificationsApi();
            var notificationsId = notificationsId_example;  // string | ID of notification to return
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get a Notification
                GetNotificationResponse result = apiInstance.GetNotification(notificationsId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationsId** | **string**| ID of notification to return | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**GetNotificationResponse**](GetNotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetNotifications**
> GetNotificationsResponse GetNotifications (string authorization = null, string deliveryStatus = null, string fromDate = null, string toDate = null, int? offset = null, int? limit = null)

Get Notifications

Retreives notification history

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetNotificationsExample
    {
        public void main()
        {
            
            var apiInstance = new NotificationsApi();
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 
            var deliveryStatus = deliveryStatus_example;  // string | Filter by delivery status (optional) 
            var fromDate = fromDate_example;  // string | Only include notifications after date (optional) 
            var toDate = toDate_example;  // string | Only include notifications before date (optional) 
            var offset = 56;  // int? | Only include notifications above of offset (optional) 
            var limit = 56;  // int? | Limit number of notifications (optional) 

            try
            {
                // Get Notifications
                GetNotificationsResponse result = apiInstance.GetNotifications(authorization, deliveryStatus, fromDate, toDate, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 
 **deliveryStatus** | **string**| Filter by delivery status | [optional] 
 **fromDate** | **string**| Only include notifications after date | [optional] 
 **toDate** | **string**| Only include notifications before date | [optional] 
 **offset** | **int?**| Only include notifications above of offset | [optional] 
 **limit** | **int?**| Limit number of notifications | [optional] 

### Return type

[**GetNotificationsResponse**](GetNotificationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

