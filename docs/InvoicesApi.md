# AuthorizeNet.Rest.Api.InvoicesApi

All URIs are relative to *https://api.authorize.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoice**](InvoicesApi.md#createinvoice) | **POST** /invoices | Create Invoice API
[**GetAllInvoices**](InvoicesApi.md#getallinvoices) | **GET** /invoices | Get List of Invoices
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /invoices/{invoiceNumber} | Get Invoice Details
[**PerformActions**](InvoicesApi.md#performactions) | **POST** /invoices/{invoiceNumber}/actions | Perform an action on Invoice
[**UpdateInvoice**](InvoicesApi.md#updateinvoice) | **PUT** /invoices/{invoiceNumber} | Update Invoice API


# **CreateInvoice**
> Invoice CreateInvoice (CreateInvoice createInvoice, string authorization = null)

Create Invoice API

ANet API for creating new invoices

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var createInvoice = new CreateInvoice(); // CreateInvoice | The \"create invoice \" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Create Invoice API
                Invoice result = apiInstance.CreateInvoice(createInvoice, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInvoice** | [**CreateInvoice**](CreateInvoice.md)| The \&quot;create invoice \&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetAllInvoices**
> InvoicesCollection GetAllInvoices (int? offset, int? limit, string authorization = null)

Get List of Invoices

ANet API for getting list of invoices

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetAllInvoicesExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var offset = 56;  // int? | Page offset number
            var limit = 56;  // int? | Number of items to be returned
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get List of Invoices
                InvoicesCollection result = apiInstance.GetAllInvoices(offset, limit, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetAllInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Page offset number | 
 **limit** | **int?**| Number of items to be returned | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**InvoicesCollection**](InvoicesCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetInvoice**
> Invoice GetInvoice (string invoiceNumber, string authorization = null)

Get Invoice Details

ANet API to get invoice details

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var invoiceNumber = invoiceNumber_example;  // string | Invoice ID
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Get Invoice Details
                Invoice result = apiInstance.GetInvoice(invoiceNumber, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceNumber** | **string**| Invoice ID | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **PerformActions**
> Invoice PerformActions (string invoiceNumber, InvoiceAction invoiceAction, string authorization = null)

Perform an action on Invoice

ANet API to Perform an action on Invoice

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class PerformActionsExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var invoiceNumber = invoiceNumber_example;  // string | Invoice ID
            var invoiceAction = new InvoiceAction(); // InvoiceAction | Perform an action on invoice
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Perform an action on Invoice
                Invoice result = apiInstance.PerformActions(invoiceNumber, invoiceAction, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.PerformActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceNumber** | **string**| Invoice ID | 
 **invoiceAction** | [**InvoiceAction**](InvoiceAction.md)| Perform an action on invoice | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateInvoice**
> Invoice UpdateInvoice (string invoiceNumber, UpdateInvoice updateInvoice, string authorization = null)

Update Invoice API

ANet APIs for editing an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Model;

namespace Example
{
    public class UpdateInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var invoiceNumber = invoiceNumber_example;  // string | Invoice ID
            var updateInvoice = new UpdateInvoice(); // UpdateInvoice | The \"update invoice \" model
            var authorization = authorization_example;  // string | The value to provide in the Authorization header of ANET API request (optional) 

            try
            {
                // Update Invoice API
                Invoice result = apiInstance.UpdateInvoice(invoiceNumber, updateInvoice, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceNumber** | **string**| Invoice ID | 
 **updateInvoice** | [**UpdateInvoice**](UpdateInvoice.md)| The \&quot;update invoice \&quot; model | 
 **authorization** | **string**| The value to provide in the Authorization header of ANET API request | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

