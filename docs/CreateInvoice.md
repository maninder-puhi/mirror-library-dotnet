# AuthorizeNet.Rest.Model.CreateInvoice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceNumber** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Customer** | [**Customer**](Customer.md) |  | 
**PayerName** | **string** |  | 
**PaymentDueDate** | **string** |  | 
**SubAmount** | **decimal?** |  | [optional] 
**DiscountPercent** | **decimal?** |  | [optional] 
**DiscountAmount** | **decimal?** |  | [optional] 
**TotalAmount** | **decimal?** |  | 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**Tax** | [**Tax**](Tax.md) |  | [optional] 
**SendEmailImmediately** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

