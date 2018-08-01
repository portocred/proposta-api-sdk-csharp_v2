# IO.Swagger.Api.PropostaApi

All URIs are relative to *https://dev-api.portocred.com.br/gestao-proposta/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PropostasGet**](PropostaApi.md#propostasget) | **GET** /propostas | 
[**PropostasIdClientesDocumentosPost**](PropostaApi.md#propostasidclientesdocumentospost) | **POST** /propostas/{id}/clientes/documentos | 
[**PropostasIdDocUploadUrlGet**](PropostaApi.md#propostasiddocuploadurlget) | **GET** /propostas/{id}/doc-upload-url | 
[**PropostasIdDocumentosGet**](PropostaApi.md#propostasiddocumentosget) | **GET** /propostas/{id}/documentos | 
[**PropostasIdGet**](PropostaApi.md#propostasidget) | **GET** /propostas/{id} | 
[**PropostasIdHistoricosGet**](PropostaApi.md#propostasidhistoricosget) | **GET** /propostas/{id}/historicos | 
[**PropostasIdMensagensPost**](PropostaApi.md#propostasidmensagenspost) | **POST** /propostas/{id}/mensagens | 
[**PropostasIdOfertasGet**](PropostaApi.md#propostasidofertasget) | **GET** /propostas/{id}/ofertas | 
[**PropostasIdOfertasPost**](PropostaApi.md#propostasidofertaspost) | **POST** /propostas/{id}/ofertas | 
[**PropostasIdPendenciasGet**](PropostaApi.md#propostasidpendenciasget) | **GET** /propostas/{id}/pendencias | 
[**PropostasIdPut**](PropostaApi.md#propostasidput) | **PUT** /propostas/{id} | 
[**PropostasIdStatusGet**](PropostaApi.md#propostasidstatusget) | **GET** /propostas/{id}/status | 
[**PropostasPost**](PropostaApi.md#propostaspost) | **POST** /propostas | 


<a name="propostasget"></a>
# **PropostasGet**
> List<PropostaResponse> PropostasGet (string clientId, string accessToken, byte[] xAuthorization, string cpf)



Recuperação da lista de propostas vinculadas a um CPF.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var cpf = cpf_example;  // string | Cpf utilizado na proposta.

            try
            {
                List&lt;PropostaResponse&gt; result = apiInstance.PropostasGet(clientId, accessToken, xAuthorization, cpf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **cpf** | **string**| Cpf utilizado na proposta. | 

### Return type

[**List<PropostaResponse>**](PropostaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidclientesdocumentospost"></a>
# **PropostasIdClientesDocumentosPost**
> void PropostasIdClientesDocumentosPost (string id, string clientId, string accessToken, CpfDocumentoProposta documentacao)



Inclusão de documentos a uma proposta. Obs. A obrigatoriedade dos campos não está definida na interface da API. Consulte a documentação técnica para conhecer a cardinalidade real do conjunto de campos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdClientesDocumentosPostExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var documentacao = new CpfDocumentoProposta(); // CpfDocumentoProposta | CPF do operador, documento convertido em base64 (limitado a 2MB) e extensão do documento (EX. PDF).

            try
            {
                apiInstance.PropostasIdClientesDocumentosPost(id, clientId, accessToken, documentacao);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdClientesDocumentosPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **documentacao** | [**CpfDocumentoProposta**](CpfDocumentoProposta.md)| CPF do operador, documento convertido em base64 (limitado a 2MB) e extensão do documento (EX. PDF). | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasiddocuploadurlget"></a>
# **PropostasIdDocUploadUrlGet**
> InlineResponse200 PropostasIdDocUploadUrlGet (string id, string clientId, string accessToken)



Recuperação do link SAFEDOC para inclusão de documentos a uma proposta.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdDocUploadUrlGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.

            try
            {
                InlineResponse200 result = apiInstance.PropostasIdDocUploadUrlGet(id, clientId, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdDocUploadUrlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasiddocumentosget"></a>
# **PropostasIdDocumentosGet**
> DocumentoProposta PropostasIdDocumentosGet (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista, string tipoDocumento)



Recuperação de documentos a serem assinados e anexados a uma proposta. O tipo de documento deverá ser passado PLANILHA_CET (Pode ser gerado a partir da seleção de uma oferta). / CHECKLIST (Pode ser gerado a partir da seleção de uma oferta). / TODOS_DOCUMENTOS_PROPOSTA para todos os documentos relacionados a proposta de acordo com o produto e a opção do seguro (Podem ser gerados nos status de proposta “pré efetivada” e também “contrato efetivado”). Como retorno, serão informados os nomes dos arquivos PDF e seus conteúdos no formato byte array. Quando acionada a opção DOCUMENTOS_PDV, serão retornados os conteúdos finais dos arquivos a serem impressos em formato texto. Nessa lista de retorno, poderão ser devolvidos os arquivos ccb.txt e seguro.txt.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdDocumentosGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var tipoDocumento = tipoDocumento_example;  // string | Tipo do documento.

            try
            {
                DocumentoProposta result = apiInstance.PropostasIdDocumentosGet(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista, tipoDocumento);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdDocumentosGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **tipoDocumento** | **string**| Tipo do documento. | 

### Return type

[**DocumentoProposta**](DocumentoProposta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidget"></a>
# **PropostasIdGet**
> Proposta PropostasIdGet (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista)



Recupera os dados da proposta de acordo com o ID proposta. Esta API pode ser utilizada desde a criação até a efetivação da proposta. Obs. A obrigatoriedade dos campos não está definida na interface da API. Consulte a documentação técnica para conhecer a cardinalidade real do conjunto de campos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).

            try
            {
                Proposta result = apiInstance.PropostasIdGet(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 

### Return type

[**Proposta**](Proposta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidhistoricosget"></a>
# **PropostasIdHistoricosGet**
> List<Historico> PropostasIdHistoricosGet (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista)



Recuperação do histórico de atividades realizadas em uma proposta.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdHistoricosGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).

            try
            {
                List&lt;Historico&gt; result = apiInstance.PropostasIdHistoricosGet(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdHistoricosGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 

### Return type

[**List<Historico>**](Historico.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidmensagenspost"></a>
# **PropostasIdMensagensPost**
> void PropostasIdMensagensPost (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista, string mensagem)



Envio de mensagens para a mesa sobre a proposta em análise.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdMensagensPostExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var mensagem = mensagem_example;  // string | Mensagem.

            try
            {
                apiInstance.PropostasIdMensagensPost(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista, mensagem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdMensagensPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **mensagem** | **string**| Mensagem. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidofertasget"></a>
# **PropostasIdOfertasGet**
> Oferta PropostasIdOfertasGet (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista)



Consulta de ofertas disponíveis para associar a uma proposta. Obs. A obrigatoriedade dos campos não está definida na interface da API. Consulte a documentação técnica para conhecer a cardinalidade real do conjunto de campos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdOfertasGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).

            try
            {
                Oferta result = apiInstance.PropostasIdOfertasGet(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdOfertasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 

### Return type

[**Oferta**](Oferta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidofertaspost"></a>
# **PropostasIdOfertasPost**
> void PropostasIdOfertasPost (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista, string idOferta)



Associa uma oferta a uma proposta.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdOfertasPostExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var idOferta = idOferta_example;  // string | Identificador da oferta.

            try
            {
                apiInstance.PropostasIdOfertasPost(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista, idOferta);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdOfertasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **idOferta** | **string**| Identificador da oferta. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidpendenciasget"></a>
# **PropostasIdPendenciasGet**
> Pendencia PropostasIdPendenciasGet (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista)



Recuperação da lista de pendências de uma proposta.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdPendenciasGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).

            try
            {
                Pendencia result = apiInstance.PropostasIdPendenciasGet(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdPendenciasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 

### Return type

[**Pendencia**](Pendencia.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidput"></a>
# **PropostasIdPut**
> void PropostasIdPut (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista, AlteracaoPropostaRequest alteracaoPropostaRequest)



Altera uma proposta conforme alterações feitas pelo usuário. Esta API pode ser utilizada a partir da criação até a conclusão da análise de crédito. Para cancelar a proposta use a opção 'CANCELAMENTO' no atributo acaoAlteracao.tipoAlteracaoProposta; para efetivar a proposta para pagamento use a opção 'EFETIVACAO' no atributo acaoAlteracao.tipoAlteracaoProposta e preencha o atributo uploadConfirmado; para pré-efetivar a proposta use a opção 'PRE_EFETIVACAO' no atributo acaoAlteracao.tipoAlteracaoProposta; para alterar a proposta use a opção 'ATUALIZACAO' no atributo acaoAlteracao.tipoAlteracaoProposta.  Obs. A obrigatoriedade dos campos e a relação de domínios a serem respeitadas pelos parceiros não estão definidas na interfaces das APIs. Consulte a documentação técnica para conhecer a cardinalidade real do conjunto de campos e domínios.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdPutExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var alteracaoPropostaRequest = new AlteracaoPropostaRequest(); // AlteracaoPropostaRequest | Proposta a ser alterada.

            try
            {
                apiInstance.PropostasIdPut(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista, alteracaoPropostaRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **alteracaoPropostaRequest** | [**AlteracaoPropostaRequest**](AlteracaoPropostaRequest.md)| Proposta a ser alterada. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostasidstatusget"></a>
# **PropostasIdStatusGet**
> StatusPropostaResponse PropostasIdStatusGet (string id, string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista)



Consulta status da proposta. A partir da criação da proposta, a qualquer momento pode ser utilizada a API para consulta de status. Essa API possui um cache de 5 segundos. Obs. A obrigatoriedade dos campos não está definida na interface da API. Consulte a documentação técnica para conhecer a cardinalidade real do conjunto de campos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasIdStatusGetExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var id = id_example;  // string | Identificador da proposta.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).

            try
            {
                StatusPropostaResponse result = apiInstance.PropostasIdStatusGet(id, clientId, accessToken, xAuthorization, codigoLoja, codigoLojista);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasIdStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador da proposta. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 

### Return type

[**StatusPropostaResponse**](StatusPropostaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propostaspost"></a>
# **PropostasPost**
> InclusaoPropostaResponse PropostasPost (string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista, Proposta proposta)



Esta API tem o objetivo de incluir uma proposta de crédito. Caso o cliente já possua uma proposta em andamento, ou qualquer outra inconsistência na inclusão, o sistema irá retornar um código de erro informando o motivo.  Obs. A obrigatoriedade dos campos e a relação de domínios a serem respeitadas pelos parceiros não estão definidas na interfaces das APIs. Consulte a documentação técnica para conhecer a cardinalidade real do conjunto de campos e domínios.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PropostasPostExample
    {
        public void main()
        {
            var apiInstance = new PropostaApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var proposta = new Proposta(); // Proposta | Proposta a ser criada.

            try
            {
                InclusaoPropostaResponse result = apiInstance.PropostasPost(clientId, accessToken, xAuthorization, codigoLoja, codigoLojista, proposta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **proposta** | [**Proposta**](Proposta.md)| Proposta a ser criada. | 

### Return type

[**InclusaoPropostaResponse**](InclusaoPropostaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

