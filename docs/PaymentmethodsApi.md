# AuthorizeNet.Rest.Api.PaymentmethodsApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentMethod**](PaymentmethodsApi.md#createpaymentmethod) | **POST** /customers/{customerId}/paymentmethods | Create A Payment Method
[**DeletePaymentmethod**](PaymentmethodsApi.md#deletepaymentmethod) | **DELETE** /customers/{customerId}/paymentmethods/{paymentMethodId} | Delete paymentmethods
[**GetCustomerPaymentMethod**](PaymentmethodsApi.md#getcustomerpaymentmethod) | **GET** /customers/{customerId}/paymentmethods/{paymentMethodId} | Get Customer Payment Method
[**GetCustomerPaymentMethods**](PaymentmethodsApi.md#getcustomerpaymentmethods) | **GET** /customers/{customerId}/paymentmethods | Get Customer Payment Methods
[**UpdatePaymentMethod**](PaymentmethodsApi.md#updatepaymentmethod) | **PUT** /customers/{customerId}/paymentmethods/{paymentMethodId} | Update A paymentMethod


# **CreatePaymentMethod**
> PaymentMethod CreatePaymentMethod (string customerId, CreatePaymentMethod createPaymentMethod, string authorization = null)

Create A Payment Method

Create A Payment Method

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreatePaymentMethodExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentmethodsApi();
            var customerId = customerId_example;  // string | Customer ID
            var createPaymentMethod = new CreatePaymentMethod(); // CreatePaymentMethod | the \"CreatePaymentMethod\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Create A Payment Method
                PaymentMethod result = apiInstance.CreatePaymentMethod(customerId, createPaymentMethod, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.CreatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **createPaymentMethod** | [**CreatePaymentMethod**](CreatePaymentMethod.md)| the \&quot;CreatePaymentMethod\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**PaymentMethod**](PaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeletePaymentmethod**
> void DeletePaymentmethod (string customerId, string paymentMethodId, string authorization = null)

Delete paymentmethods

Deletes a paymentmethods

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class DeletePaymentmethodExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentmethodsApi();
            var customerId = customerId_example;  // string | Customer ID
            var paymentMethodId = paymentMethodId_example;  // string | paymentMethod ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Delete paymentmethods
                apiInstance.DeletePaymentmethod(customerId, paymentMethodId, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.DeletePaymentmethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **paymentMethodId** | **string**| paymentMethod ID | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetCustomerPaymentMethod**
> PaymentMethod GetCustomerPaymentMethod (string customerId, string paymentMethodId, string authorization = null)

Get Customer Payment Method

Get Customer Payment Method

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetCustomerPaymentMethodExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentmethodsApi();
            var customerId = customerId_example;  // string | Customer ID
            var paymentMethodId = paymentMethodId_example;  // string | paymentMethod ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get Customer Payment Method
                PaymentMethod result = apiInstance.GetCustomerPaymentMethod(customerId, paymentMethodId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.GetCustomerPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **paymentMethodId** | **string**| paymentMethod ID | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**PaymentMethod**](PaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetCustomerPaymentMethods**
> PaymentMethodCollection GetCustomerPaymentMethods (string customerId, string authorization = null)

Get Customer Payment Methods

Get Customer Payment Methods

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetCustomerPaymentMethodsExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentmethodsApi();
            var customerId = customerId_example;  // string | Customer ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get Customer Payment Methods
                PaymentMethodCollection result = apiInstance.GetCustomerPaymentMethods(customerId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.GetCustomerPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**PaymentMethodCollection**](PaymentMethodCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdatePaymentMethod**
> PaymentMethod UpdatePaymentMethod (string customerId, string paymentMethodId, CreatePaymentMethod createPaymentMethod, string authorization = null)

Update A paymentMethod

Update A paymentMethod

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class UpdatePaymentMethodExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentmethodsApi();
            var customerId = customerId_example;  // string | Customer ID
            var paymentMethodId = paymentMethodId_example;  // string | paymentMethod ID
            var createPaymentMethod = new CreatePaymentMethod(); // CreatePaymentMethod | the \"UpdateAPaymentMethod\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Update A paymentMethod
                PaymentMethod result = apiInstance.UpdatePaymentMethod(customerId, paymentMethodId, createPaymentMethod, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.UpdatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **paymentMethodId** | **string**| paymentMethod ID | 
 **createPaymentMethod** | [**CreatePaymentMethod**](CreatePaymentMethod.md)| the \&quot;UpdateAPaymentMethod\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**PaymentMethod**](PaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

