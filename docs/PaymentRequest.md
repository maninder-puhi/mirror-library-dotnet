# AuthorizeNet.Rest.Model.PaymentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capture** | **bool?** |  | [optional] 
**AmountDetail** | [**AmountDetail**](AmountDetail.md) |  | 
**Solution** | [**Solution**](Solution.md) |  | [optional] 
**PaymentInstrument** | [**PaymentInstrument**](PaymentInstrument.md) |  | 
**BillTo** | [**BaseAddress**](BaseAddress.md) |  | [optional] 
**ShipTo** | [**BaseAddress**](BaseAddress.md) |  | [optional] 
**CustomerIp** | **string** |  | [optional] 
**Order** | [**Order**](Order.md) |  | [optional] 
**Tax** | [**ExtendedAmount**](ExtendedAmount.md) |  | [optional] 
**Duty** | [**ExtendedAmount**](ExtendedAmount.md) |  | [optional] 
**Shipping** | [**ExtendedAmount**](ExtendedAmount.md) |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

