# AuthorizeNet.Rest.Api.CustomersApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomer**](CustomersApi.md#createcustomer) | **POST** /customers | Create A Customer
[**DeleteCustomer**](CustomersApi.md#deletecustomer) | **DELETE** /customers/{customerId} | Delete customer
[**GetAllCustomers**](CustomersApi.md#getallcustomers) | **GET** /customers | Get All Customers
[**GetCustomer**](CustomersApi.md#getcustomer) | **GET** /customers/{customerId} | Get A Customer
[**UpdateCustomer**](CustomersApi.md#updatecustomer) | **PUT** /customers/{customerId} | Update A Customer


# **CreateCustomer**
> Customer CreateCustomer (CreateCustomer createCustomer, string authorization = null)

Create A Customer

Create A Customer

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var createCustomer = new CreateCustomer(); // CreateCustomer | the \"CreateCustomer\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Create A Customer
                Customer result = apiInstance.CreateCustomer(createCustomer, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCustomer** | [**CreateCustomer**](CreateCustomer.md)| the \&quot;CreateCustomer\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteCustomer**
> void DeleteCustomer (string customerId, string authorization = null)

Delete customer

Deletes a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class DeleteCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | Customer ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Delete customer
                apiInstance.DeleteCustomer(customerId, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomer: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetAllCustomers**
> CustomerCollection GetAllCustomers (string authorization = null)

Get All Customers

Get All Customers

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetAllCustomersExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get All Customers
                CustomerCollection result = apiInstance.GetAllCustomers(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.GetAllCustomers: " + e.Message );
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

[**CustomerCollection**](CustomerCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetCustomer**
> Customer GetCustomer (string customerId, string authorization = null)

Get A Customer

Get A Customer

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | Customer ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get A Customer
                Customer result = apiInstance.GetCustomer(customerId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomer: " + e.Message );
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

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateCustomer**
> Customer UpdateCustomer (string customerId, CreateCustomer createCustomer, string authorization = null)

Update A Customer

Update A Customer

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class UpdateCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | Customer ID
            var createCustomer = new CreateCustomer(); // CreateCustomer | the \"UpdateCustomer\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Update A Customer
                Customer result = apiInstance.UpdateCustomer(customerId, createCustomer, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **createCustomer** | [**CreateCustomer**](CreateCustomer.md)| the \&quot;UpdateCustomer\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

