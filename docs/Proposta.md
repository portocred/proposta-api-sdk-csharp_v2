# IO.Swagger.Model.Proposta
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Numero** | **string** | Número da proposta. | [optional] 
**DataEmissao** | **DateTime?** | Data de emissão da Proposta. Não pode ser inferior a data que vai ser liberado o dinheiro. Data base do cálculo do financiamento (dd-mm-aaaa). | [optional] 
**DataVencimentoPrimeiraParcela** | **DateTime?** | Data de vencimento da 1ª parcela. Verificar se está coerente com a  Carência mínima e máxima combinada com a financeira (dd-mm-aaaa). | [optional] 
**CodigoProduto** | **string** | Código do produto. Pelo Produto se descobre também a família de produto. | [optional] 
**CodigoPlanoPagamento** | **string** | Código do plano de pagamentos. | [optional] 
**PrazoPagamento** | **string** | Prazo de pagamento. | [optional] 
**CodigoMidia** | **string** | Informar a origem da proposta. | [optional] 
**TipoContrato** | **TipoContrato** |  | [optional] 
**ValorCompra** | **double?** | Valor da compra sem entrada (neste caso valor da prestação &#x3D; zero). | [optional] 
**ValorEntrada** | **double?** | Valor da entrada (neste caso valor da prestação &#x3D; zero/ Valor da Compra &lt;&gt; zero). | [optional] 
**ValorPrestacao** | **double?** | Valor da PMT a (neste caso valor da compra &#x3D; zero/ valor da entrada &#x3D; 0). | [optional] 
**ValorLiberado** | **double?** | Valor liberado da proposta. | [optional] 
**DadosAdicionais** | [**List&lt;DadoAdicional&gt;**](DadoAdicional.md) |  | [optional] 
**TipoSeguro** | **TipoSeguro** |  | [optional] 
**Clientes** | [**List&lt;Cliente&gt;**](Cliente.md) |  | [optional] 
**Cheques** | [**List&lt;Cheque&gt;**](Cheque.md) |  | [optional] 
**FormaEnvio** | [**FormaEnvio**](FormaEnvio.md) |  | [optional] 
**DadosLiberacao** | [**DadosLiberacao**](DadosLiberacao.md) |  | [optional] 
**TipoEfetivacao** | **TipoEfetivacao** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

