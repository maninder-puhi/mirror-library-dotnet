# AuthorizeNet.Rest - the C# library for the Authorize.net REST API

Authorize.net REST API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 0.0.9
- Build date: 2018-01-14T14:55:24.306+05:30
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Client;
using Model;

namespace Example
{
    public class Example
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

## Documentation for API Endpoints

All URIs are relative to *https://api.authorize.net/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddressesApi* | [**CreateCustomerAddress**](docs/AddressesApi.md#createcustomeraddress) | **POST** /customers/{customerId}/addresses | Create A Customer Address
*AddressesApi* | [**DeleteAddress**](docs/AddressesApi.md#deleteaddress) | **DELETE** /customers/{customerId}/addresses/{addressId} | Delete Address
*AddressesApi* | [**GetAllCustomerAddresses**](docs/AddressesApi.md#getallcustomeraddresses) | **GET** /customers/{customerId}/addresses | Get All Customer Addresses
*AddressesApi* | [**GetCustomerAddress**](docs/AddressesApi.md#getcustomeraddress) | **GET** /customers/{customerId}/addresses/{addressId} | Get A Customer Address
*AddressesApi* | [**UpdateCustomerAddress**](docs/AddressesApi.md#updatecustomeraddress) | **PUT** /customers/{customerId}/addresses/{addressId} | Update A Customer Address
*CapturesApi* | [**CreateACapture**](docs/CapturesApi.md#createacapture) | **POST** /payments/{paymentId}/captures | 
*CreditsApi* | [**CreateACredit**](docs/CreditsApi.md#createacredit) | **POST** /credits | 
*CustomersApi* | [**CreateCustomer**](docs/CustomersApi.md#createcustomer) | **POST** /customers | Create A Customer
*CustomersApi* | [**DeleteCustomer**](docs/CustomersApi.md#deletecustomer) | **DELETE** /customers/{customerId} | Delete customer
*CustomersApi* | [**GetAllCustomers**](docs/CustomersApi.md#getallcustomers) | **GET** /customers | Get All Customers
*CustomersApi* | [**GetCustomer**](docs/CustomersApi.md#getcustomer) | **GET** /customers/{customerId} | Get A Customer
*CustomersApi* | [**UpdateCustomer**](docs/CustomersApi.md#updatecustomer) | **PUT** /customers/{customerId} | Update A Customer
*EventtypesApi* | [**GetEventTypes**](docs/EventtypesApi.md#geteventtypes) | **GET** /eventtypes | Retrieving Event Types
*ForcedCapturesApi* | [**CreateAForcedCapture**](docs/ForcedCapturesApi.md#createaforcedcapture) | **POST** /forcedcaptures | 
*InvoicesApi* | [**CreateInvoice**](docs/InvoicesApi.md#createinvoice) | **POST** /invoices | Create Invoice API
*InvoicesApi* | [**GetAllInvoices**](docs/InvoicesApi.md#getallinvoices) | **GET** /invoices | Get List of Invoices
*InvoicesApi* | [**GetInvoice**](docs/InvoicesApi.md#getinvoice) | **GET** /invoices/{invoiceNumber} | Get Invoice Details
*InvoicesApi* | [**PerformActions**](docs/InvoicesApi.md#performactions) | **POST** /invoices/{invoiceNumber}/actions | Perform an action on Invoice
*InvoicesApi* | [**UpdateInvoice**](docs/InvoicesApi.md#updateinvoice) | **PUT** /invoices/{invoiceNumber} | Update Invoice API
*NotificationsApi* | [**GetNotification**](docs/NotificationsApi.md#getnotification) | **GET** /notifications/{notificationsId} | Get a Notification
*NotificationsApi* | [**GetNotifications**](docs/NotificationsApi.md#getnotifications) | **GET** /notifications | Get Notifications
*PaymentmethodsApi* | [**CreatePaymentMethod**](docs/PaymentmethodsApi.md#createpaymentmethod) | **POST** /customers/{customerId}/paymentmethods | Create A Payment Method
*PaymentmethodsApi* | [**DeletePaymentmethod**](docs/PaymentmethodsApi.md#deletepaymentmethod) | **DELETE** /customers/{customerId}/paymentmethods/{paymentMethodId} | Delete paymentmethods
*PaymentmethodsApi* | [**GetCustomerPaymentMethod**](docs/PaymentmethodsApi.md#getcustomerpaymentmethod) | **GET** /customers/{customerId}/paymentmethods/{paymentMethodId} | Get Customer Payment Method
*PaymentmethodsApi* | [**GetCustomerPaymentMethods**](docs/PaymentmethodsApi.md#getcustomerpaymentmethods) | **GET** /customers/{customerId}/paymentmethods | Get Customer Payment Methods
*PaymentmethodsApi* | [**UpdatePaymentMethod**](docs/PaymentmethodsApi.md#updatepaymentmethod) | **PUT** /customers/{customerId}/paymentmethods/{paymentMethodId} | Update A paymentMethod
*PaymentsApi* | [**CreateAPayment**](docs/PaymentsApi.md#createapayment) | **POST** /payments | 
*PaymentsApi* | [**GetAPayment**](docs/PaymentsApi.md#getapayment) | **GET** /payments/{paymentId} | 
*PaymentsApi* | [**GetAllPayments**](docs/PaymentsApi.md#getallpayments) | **GET** /payments | 
*RefundsApi* | [**CreateRefundAPayment**](docs/RefundsApi.md#createrefundapayment) | **POST** /payments/{paymentId}/refunds | 
*WebhooksApi* | [**CreateWebhook**](docs/WebhooksApi.md#createwebhook) | **POST** /webhooks | Create A Webhook
*WebhooksApi* | [**DeleteWebhook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Delete A Webhook
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Get A Webhook
*WebhooksApi* | [**GetWebhooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhooks | List My Webhooks
*WebhooksApi* | [**PingsWebhook**](docs/WebhooksApi.md#pingswebhook) | **POST** /webhooks/{webhookId}/pings | Pings A Webhook
*WebhooksApi* | [**UpdateWebhook**](docs/WebhooksApi.md#updatewebhook) | **PUT** /webhooks/{webhookId} | Update A Webhook


## Documentation for Models

 - [Model.AddressCollection](docs/AddressCollection.md)
 - [Model.AddressLinks](docs/AddressLinks.md)
 - [Model.AddressList](docs/AddressList.md)
 - [Model.Addresses](docs/Addresses.md)
 - [Model.AmountDetail](docs/AmountDetail.md)
 - [Model.BankAccount](docs/BankAccount.md)
 - [Model.BaseAddress](docs/BaseAddress.md)
 - [Model.Batch](docs/Batch.md)
 - [Model.CaptureRequest](docs/CaptureRequest.md)
 - [Model.CollectionLinks](docs/CollectionLinks.md)
 - [Model.CreateCustomer](docs/CreateCustomer.md)
 - [Model.CreateCustomerAddress](docs/CreateCustomerAddress.md)
 - [Model.CreateInvoice](docs/CreateInvoice.md)
 - [Model.CreatePaymentMethod](docs/CreatePaymentMethod.md)
 - [Model.CreateWebhookBody](docs/CreateWebhookBody.md)
 - [Model.CreditCard](docs/CreditCard.md)
 - [Model.CreditRequest](docs/CreditRequest.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerCollection](docs/CustomerCollection.md)
 - [Model.CustomerLinks](docs/CustomerLinks.md)
 - [Model.CustomerList](docs/CustomerList.md)
 - [Model.CustomerPayment](docs/CustomerPayment.md)
 - [Model.ErrorDetails](docs/ErrorDetails.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.EventType](docs/EventType.md)
 - [Model.ExtendedAmount](docs/ExtendedAmount.md)
 - [Model.FluidData](docs/FluidData.md)
 - [Model.ForcedCaptureRequest](docs/ForcedCaptureRequest.md)
 - [Model.FraudFilter](docs/FraudFilter.md)
 - [Model.FraudInformation](docs/FraudInformation.md)
 - [Model.GetNotificationsResponse](docs/GetNotificationsResponse.md)
 - [Model.GetWebhookResponse](docs/GetWebhookResponse.md)
 - [Model.Identifier](docs/Identifier.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.InvoiceAction](docs/InvoiceAction.md)
 - [Model.InvoiceListInfo](docs/InvoiceListInfo.md)
 - [Model.InvoicesCollection](docs/InvoicesCollection.md)
 - [Model.LineItem](docs/LineItem.md)
 - [Model.Link](docs/Link.md)
 - [Model.Log](docs/Log.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.Order](docs/Order.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentCollection](docs/PaymentCollection.md)
 - [Model.PaymentInstrument](docs/PaymentInstrument.md)
 - [Model.PaymentLinks](docs/PaymentLinks.md)
 - [Model.PaymentMethod](docs/PaymentMethod.md)
 - [Model.PaymentMethodCollection](docs/PaymentMethodCollection.md)
 - [Model.PaymentMethodLinks](docs/PaymentMethodLinks.md)
 - [Model.PaymentMethodList](docs/PaymentMethodList.md)
 - [Model.PaymentMethods](docs/PaymentMethods.md)
 - [Model.PaymentRequest](docs/PaymentRequest.md)
 - [Model.Payments](docs/Payments.md)
 - [Model.PaymentsList](docs/PaymentsList.md)
 - [Model.Processor](docs/Processor.md)
 - [Model.RefundRequest](docs/RefundRequest.md)
 - [Model.RetryLog](docs/RetryLog.md)
 - [Model.SelfLink](docs/SelfLink.md)
 - [Model.Solution](docs/Solution.md)
 - [Model.Tax](docs/Tax.md)
 - [Model.UpdateInvoice](docs/UpdateInvoice.md)
 - [Model.Address](docs/Address.md)
 - [Model.GetNotificationResponse](docs/GetNotificationResponse.md)


## Documentation for Authorization

 All endpoints do not require authorization.

