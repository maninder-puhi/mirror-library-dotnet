# AuthorizeNet.Rest.Api.AddressesApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomerAddress**](AddressesApi.md#createcustomeraddress) | **POST** /customers/{customerId}/addresses | Create A Customer Address
[**DeleteAddress**](AddressesApi.md#deleteaddress) | **DELETE** /customers/{customerId}/addresses/{addressId} | Delete Address
[**GetAllCustomerAddresses**](AddressesApi.md#getallcustomeraddresses) | **GET** /customers/{customerId}/addresses | Get All Customer Addresses
[**GetCustomerAddress**](AddressesApi.md#getcustomeraddress) | **GET** /customers/{customerId}/addresses/{addressId} | Get A Customer Address
[**UpdateCustomerAddress**](AddressesApi.md#updatecustomeraddress) | **PUT** /customers/{customerId}/addresses/{addressId} | Update A Customer Address


# **CreateCustomerAddress**
> Address CreateCustomerAddress (string customerId, CreateCustomerAddress createCustomerAddress, string authorization = null)

Create A Customer Address

Create A Customer Address

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateCustomerAddressExample
    {
        public void main()
        {
            
            var apiInstance = new AddressesApi();
            var customerId = customerId_example;  // string | Customer ID
            var createCustomerAddress = new CreateCustomerAddress(); // CreateCustomerAddress | the \"CreateCustomerAddress\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Create A Customer Address
                Address result = apiInstance.CreateCustomerAddress(customerId, createCustomerAddress, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.CreateCustomerAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **createCustomerAddress** | [**CreateCustomerAddress**](CreateCustomerAddress.md)| the \&quot;CreateCustomerAddress\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteAddress**
> void DeleteAddress (string customerId, string addressId, string authorization = null)

Delete Address

Deletes a Address

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class DeleteAddressExample
    {
        public void main()
        {
            
            var apiInstance = new AddressesApi();
            var customerId = customerId_example;  // string | Customer ID
            var addressId = addressId_example;  // string | Address ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Delete Address
                apiInstance.DeleteAddress(customerId, addressId, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.DeleteAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **addressId** | **string**| Address ID | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetAllCustomerAddresses**
> AddressCollection GetAllCustomerAddresses (string customerId, string authorization = null)

Get All Customer Addresses

Get All Customer Addresses

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetAllCustomerAddressesExample
    {
        public void main()
        {
            
            var apiInstance = new AddressesApi();
            var customerId = customerId_example;  // string | Customer ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get All Customer Addresses
                AddressCollection result = apiInstance.GetAllCustomerAddresses(customerId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.GetAllCustomerAddresses: " + e.Message );
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

[**AddressCollection**](AddressCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetCustomerAddress**
> Address GetCustomerAddress (string customerId, string addressId, string authorization = null)

Get A Customer Address

Get A Customer Address

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetCustomerAddressExample
    {
        public void main()
        {
            
            var apiInstance = new AddressesApi();
            var customerId = customerId_example;  // string | Customer ID
            var addressId = addressId_example;  // string | Address ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get A Customer Address
                Address result = apiInstance.GetCustomerAddress(customerId, addressId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.GetCustomerAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **addressId** | **string**| Address ID | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateCustomerAddress**
> Address UpdateCustomerAddress (string customerId, string addressId, CreateCustomerAddress createCustomerAddress, string authorization = null)

Update A Customer Address

Update A Customer Address

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class UpdateCustomerAddressExample
    {
        public void main()
        {
            
            var apiInstance = new AddressesApi();
            var customerId = customerId_example;  // string | Customer ID
            var addressId = addressId_example;  // string | address  ID
            var createCustomerAddress = new CreateCustomerAddress(); // CreateCustomerAddress | the \"UpdateCustomerAddress\" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Update A Customer Address
                Address result = apiInstance.UpdateCustomerAddress(customerId, addressId, createCustomerAddress, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.UpdateCustomerAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID | 
 **addressId** | **string**| address  ID | 
 **createCustomerAddress** | [**CreateCustomerAddress**](CreateCustomerAddress.md)| the \&quot;UpdateCustomerAddress\&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

