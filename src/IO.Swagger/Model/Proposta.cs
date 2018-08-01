/* 
 * Gestão de Propostas
 *
 * API de Gestão de Propostas.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Entidade representando uma proposta.
    /// </summary>
    [DataContract]
    public partial class Proposta :  IEquatable<Proposta>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TipoContrato
        /// </summary>
        [DataMember(Name="tipoContrato", EmitDefaultValue=false)]
        public TipoContrato? TipoContrato { get; set; }
        /// <summary>
        /// Gets or Sets TipoSeguro
        /// </summary>
        [DataMember(Name="tipoSeguro", EmitDefaultValue=false)]
        public TipoSeguro? TipoSeguro { get; set; }
        /// <summary>
        /// Gets or Sets TipoEfetivacao
        /// </summary>
        [DataMember(Name="tipoEfetivacao", EmitDefaultValue=false)]
        public TipoEfetivacao? TipoEfetivacao { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Proposta" /> class.
        /// </summary>
        /// <param name="Numero">Número da proposta..</param>
        /// <param name="DataEmissao">Data de emissão da Proposta. Não pode ser inferior a data que vai ser liberado o dinheiro. Data base do cálculo do financiamento (dd-mm-aaaa)..</param>
        /// <param name="DataVencimentoPrimeiraParcela">Data de vencimento da 1ª parcela. Verificar se está coerente com a  Carência mínima e máxima combinada com a financeira (dd-mm-aaaa)..</param>
        /// <param name="CodigoProduto">Código do produto. Pelo Produto se descobre também a família de produto..</param>
        /// <param name="CodigoPlanoPagamento">Código do plano de pagamentos..</param>
        /// <param name="PrazoPagamento">Prazo de pagamento..</param>
        /// <param name="CodigoMidia">Informar a origem da proposta..</param>
        /// <param name="TipoContrato">TipoContrato.</param>
        /// <param name="ValorCompra">Valor da compra sem entrada (neste caso valor da prestação &#x3D; zero)..</param>
        /// <param name="ValorEntrada">Valor da entrada (neste caso valor da prestação &#x3D; zero/ Valor da Compra &lt;&gt; zero)..</param>
        /// <param name="ValorPrestacao">Valor da PMT a (neste caso valor da compra &#x3D; zero/ valor da entrada &#x3D; 0)..</param>
        /// <param name="ValorLiberado">Valor liberado da proposta..</param>
        /// <param name="DadosAdicionais">DadosAdicionais.</param>
        /// <param name="TipoSeguro">TipoSeguro.</param>
        /// <param name="Clientes">Clientes.</param>
        /// <param name="Cheques">Cheques.</param>
        /// <param name="FormaEnvio">FormaEnvio.</param>
        /// <param name="DadosLiberacao">DadosLiberacao.</param>
        /// <param name="TipoEfetivacao">TipoEfetivacao.</param>
        public Proposta(string Numero = default(string), DateTime? DataEmissao = default(DateTime?), DateTime? DataVencimentoPrimeiraParcela = default(DateTime?), string CodigoProduto = default(string), string CodigoPlanoPagamento = default(string), string PrazoPagamento = default(string), string CodigoMidia = default(string), TipoContrato? TipoContrato = default(TipoContrato?), double? ValorCompra = default(double?), double? ValorEntrada = default(double?), double? ValorPrestacao = default(double?), double? ValorLiberado = default(double?), List<DadoAdicional> DadosAdicionais = default(List<DadoAdicional>), TipoSeguro? TipoSeguro = default(TipoSeguro?), List<Cliente> Clientes = default(List<Cliente>), List<Cheque> Cheques = default(List<Cheque>), FormaEnvio FormaEnvio = default(FormaEnvio), DadosLiberacao DadosLiberacao = default(DadosLiberacao), TipoEfetivacao? TipoEfetivacao = default(TipoEfetivacao?))
        {
            this.Numero = Numero;
            this.DataEmissao = DataEmissao;
            this.DataVencimentoPrimeiraParcela = DataVencimentoPrimeiraParcela;
            this.CodigoProduto = CodigoProduto;
            this.CodigoPlanoPagamento = CodigoPlanoPagamento;
            this.PrazoPagamento = PrazoPagamento;
            this.CodigoMidia = CodigoMidia;
            this.TipoContrato = TipoContrato;
            this.ValorCompra = ValorCompra;
            this.ValorEntrada = ValorEntrada;
            this.ValorPrestacao = ValorPrestacao;
            this.ValorLiberado = ValorLiberado;
            this.DadosAdicionais = DadosAdicionais;
            this.TipoSeguro = TipoSeguro;
            this.Clientes = Clientes;
            this.Cheques = Cheques;
            this.FormaEnvio = FormaEnvio;
            this.DadosLiberacao = DadosLiberacao;
            this.TipoEfetivacao = TipoEfetivacao;
        }
        
        /// <summary>
        /// Número da proposta.
        /// </summary>
        /// <value>Número da proposta.</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public string Numero { get; set; }

        /// <summary>
        /// Data de emissão da Proposta. Não pode ser inferior a data que vai ser liberado o dinheiro. Data base do cálculo do financiamento (dd-mm-aaaa).
        /// </summary>
        /// <value>Data de emissão da Proposta. Não pode ser inferior a data que vai ser liberado o dinheiro. Data base do cálculo do financiamento (dd-mm-aaaa).</value>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DataEmissao { get; set; }

        /// <summary>
        /// Data de vencimento da 1ª parcela. Verificar se está coerente com a  Carência mínima e máxima combinada com a financeira (dd-mm-aaaa).
        /// </summary>
        /// <value>Data de vencimento da 1ª parcela. Verificar se está coerente com a  Carência mínima e máxima combinada com a financeira (dd-mm-aaaa).</value>
        [DataMember(Name="dataVencimentoPrimeiraParcela", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DataVencimentoPrimeiraParcela { get; set; }

        /// <summary>
        /// Código do produto. Pelo Produto se descobre também a família de produto.
        /// </summary>
        /// <value>Código do produto. Pelo Produto se descobre também a família de produto.</value>
        [DataMember(Name="codigoProduto", EmitDefaultValue=false)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código do plano de pagamentos.
        /// </summary>
        /// <value>Código do plano de pagamentos.</value>
        [DataMember(Name="codigoPlanoPagamento", EmitDefaultValue=false)]
        public string CodigoPlanoPagamento { get; set; }

        /// <summary>
        /// Prazo de pagamento.
        /// </summary>
        /// <value>Prazo de pagamento.</value>
        [DataMember(Name="prazoPagamento", EmitDefaultValue=false)]
        public string PrazoPagamento { get; set; }

        /// <summary>
        /// Informar a origem da proposta.
        /// </summary>
        /// <value>Informar a origem da proposta.</value>
        [DataMember(Name="codigoMidia", EmitDefaultValue=false)]
        public string CodigoMidia { get; set; }


        /// <summary>
        /// Valor da compra sem entrada (neste caso valor da prestação &#x3D; zero).
        /// </summary>
        /// <value>Valor da compra sem entrada (neste caso valor da prestação &#x3D; zero).</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }

        /// <summary>
        /// Valor da entrada (neste caso valor da prestação &#x3D; zero/ Valor da Compra &lt;&gt; zero).
        /// </summary>
        /// <value>Valor da entrada (neste caso valor da prestação &#x3D; zero/ Valor da Compra &lt;&gt; zero).</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }

        /// <summary>
        /// Valor da PMT a (neste caso valor da compra &#x3D; zero/ valor da entrada &#x3D; 0).
        /// </summary>
        /// <value>Valor da PMT a (neste caso valor da compra &#x3D; zero/ valor da entrada &#x3D; 0).</value>
        [DataMember(Name="valorPrestacao", EmitDefaultValue=false)]
        public double? ValorPrestacao { get; set; }

        /// <summary>
        /// Valor liberado da proposta.
        /// </summary>
        /// <value>Valor liberado da proposta.</value>
        [DataMember(Name="valorLiberado", EmitDefaultValue=false)]
        public double? ValorLiberado { get; set; }

        /// <summary>
        /// Gets or Sets DadosAdicionais
        /// </summary>
        [DataMember(Name="dadosAdicionais", EmitDefaultValue=false)]
        public List<DadoAdicional> DadosAdicionais { get; set; }


        /// <summary>
        /// Gets or Sets Clientes
        /// </summary>
        [DataMember(Name="clientes", EmitDefaultValue=false)]
        public List<Cliente> Clientes { get; set; }

        /// <summary>
        /// Gets or Sets Cheques
        /// </summary>
        [DataMember(Name="cheques", EmitDefaultValue=false)]
        public List<Cheque> Cheques { get; set; }

        /// <summary>
        /// Gets or Sets FormaEnvio
        /// </summary>
        [DataMember(Name="formaEnvio", EmitDefaultValue=false)]
        public FormaEnvio FormaEnvio { get; set; }

        /// <summary>
        /// Gets or Sets DadosLiberacao
        /// </summary>
        [DataMember(Name="dadosLiberacao", EmitDefaultValue=false)]
        public DadosLiberacao DadosLiberacao { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Proposta {\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  DataEmissao: ").Append(DataEmissao).Append("\n");
            sb.Append("  DataVencimentoPrimeiraParcela: ").Append(DataVencimentoPrimeiraParcela).Append("\n");
            sb.Append("  CodigoProduto: ").Append(CodigoProduto).Append("\n");
            sb.Append("  CodigoPlanoPagamento: ").Append(CodigoPlanoPagamento).Append("\n");
            sb.Append("  PrazoPagamento: ").Append(PrazoPagamento).Append("\n");
            sb.Append("  CodigoMidia: ").Append(CodigoMidia).Append("\n");
            sb.Append("  TipoContrato: ").Append(TipoContrato).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorPrestacao: ").Append(ValorPrestacao).Append("\n");
            sb.Append("  ValorLiberado: ").Append(ValorLiberado).Append("\n");
            sb.Append("  DadosAdicionais: ").Append(DadosAdicionais).Append("\n");
            sb.Append("  TipoSeguro: ").Append(TipoSeguro).Append("\n");
            sb.Append("  Clientes: ").Append(Clientes).Append("\n");
            sb.Append("  Cheques: ").Append(Cheques).Append("\n");
            sb.Append("  FormaEnvio: ").Append(FormaEnvio).Append("\n");
            sb.Append("  DadosLiberacao: ").Append(DadosLiberacao).Append("\n");
            sb.Append("  TipoEfetivacao: ").Append(TipoEfetivacao).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Proposta);
        }

        /// <summary>
        /// Returns true if Proposta instances are equal
        /// </summary>
        /// <param name="input">Instance of Proposta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Proposta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Numero == input.Numero ||
                    (this.Numero != null &&
                    this.Numero.Equals(input.Numero))
                ) && 
                (
                    this.DataEmissao == input.DataEmissao ||
                    (this.DataEmissao != null &&
                    this.DataEmissao.Equals(input.DataEmissao))
                ) && 
                (
                    this.DataVencimentoPrimeiraParcela == input.DataVencimentoPrimeiraParcela ||
                    (this.DataVencimentoPrimeiraParcela != null &&
                    this.DataVencimentoPrimeiraParcela.Equals(input.DataVencimentoPrimeiraParcela))
                ) && 
                (
                    this.CodigoProduto == input.CodigoProduto ||
                    (this.CodigoProduto != null &&
                    this.CodigoProduto.Equals(input.CodigoProduto))
                ) && 
                (
                    this.CodigoPlanoPagamento == input.CodigoPlanoPagamento ||
                    (this.CodigoPlanoPagamento != null &&
                    this.CodigoPlanoPagamento.Equals(input.CodigoPlanoPagamento))
                ) && 
                (
                    this.PrazoPagamento == input.PrazoPagamento ||
                    (this.PrazoPagamento != null &&
                    this.PrazoPagamento.Equals(input.PrazoPagamento))
                ) && 
                (
                    this.CodigoMidia == input.CodigoMidia ||
                    (this.CodigoMidia != null &&
                    this.CodigoMidia.Equals(input.CodigoMidia))
                ) && 
                (
                    this.TipoContrato == input.TipoContrato ||
                    (this.TipoContrato != null &&
                    this.TipoContrato.Equals(input.TipoContrato))
                ) && 
                (
                    this.ValorCompra == input.ValorCompra ||
                    (this.ValorCompra != null &&
                    this.ValorCompra.Equals(input.ValorCompra))
                ) && 
                (
                    this.ValorEntrada == input.ValorEntrada ||
                    (this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(input.ValorEntrada))
                ) && 
                (
                    this.ValorPrestacao == input.ValorPrestacao ||
                    (this.ValorPrestacao != null &&
                    this.ValorPrestacao.Equals(input.ValorPrestacao))
                ) && 
                (
                    this.ValorLiberado == input.ValorLiberado ||
                    (this.ValorLiberado != null &&
                    this.ValorLiberado.Equals(input.ValorLiberado))
                ) && 
                (
                    this.DadosAdicionais == input.DadosAdicionais ||
                    this.DadosAdicionais != null &&
                    this.DadosAdicionais.SequenceEqual(input.DadosAdicionais)
                ) && 
                (
                    this.TipoSeguro == input.TipoSeguro ||
                    (this.TipoSeguro != null &&
                    this.TipoSeguro.Equals(input.TipoSeguro))
                ) && 
                (
                    this.Clientes == input.Clientes ||
                    this.Clientes != null &&
                    this.Clientes.SequenceEqual(input.Clientes)
                ) && 
                (
                    this.Cheques == input.Cheques ||
                    this.Cheques != null &&
                    this.Cheques.SequenceEqual(input.Cheques)
                ) && 
                (
                    this.FormaEnvio == input.FormaEnvio ||
                    (this.FormaEnvio != null &&
                    this.FormaEnvio.Equals(input.FormaEnvio))
                ) && 
                (
                    this.DadosLiberacao == input.DadosLiberacao ||
                    (this.DadosLiberacao != null &&
                    this.DadosLiberacao.Equals(input.DadosLiberacao))
                ) && 
                (
                    this.TipoEfetivacao == input.TipoEfetivacao ||
                    (this.TipoEfetivacao != null &&
                    this.TipoEfetivacao.Equals(input.TipoEfetivacao))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Numero != null)
                    hashCode = hashCode * 59 + this.Numero.GetHashCode();
                if (this.DataEmissao != null)
                    hashCode = hashCode * 59 + this.DataEmissao.GetHashCode();
                if (this.DataVencimentoPrimeiraParcela != null)
                    hashCode = hashCode * 59 + this.DataVencimentoPrimeiraParcela.GetHashCode();
                if (this.CodigoProduto != null)
                    hashCode = hashCode * 59 + this.CodigoProduto.GetHashCode();
                if (this.CodigoPlanoPagamento != null)
                    hashCode = hashCode * 59 + this.CodigoPlanoPagamento.GetHashCode();
                if (this.PrazoPagamento != null)
                    hashCode = hashCode * 59 + this.PrazoPagamento.GetHashCode();
                if (this.CodigoMidia != null)
                    hashCode = hashCode * 59 + this.CodigoMidia.GetHashCode();
                if (this.TipoContrato != null)
                    hashCode = hashCode * 59 + this.TipoContrato.GetHashCode();
                if (this.ValorCompra != null)
                    hashCode = hashCode * 59 + this.ValorCompra.GetHashCode();
                if (this.ValorEntrada != null)
                    hashCode = hashCode * 59 + this.ValorEntrada.GetHashCode();
                if (this.ValorPrestacao != null)
                    hashCode = hashCode * 59 + this.ValorPrestacao.GetHashCode();
                if (this.ValorLiberado != null)
                    hashCode = hashCode * 59 + this.ValorLiberado.GetHashCode();
                if (this.DadosAdicionais != null)
                    hashCode = hashCode * 59 + this.DadosAdicionais.GetHashCode();
                if (this.TipoSeguro != null)
                    hashCode = hashCode * 59 + this.TipoSeguro.GetHashCode();
                if (this.Clientes != null)
                    hashCode = hashCode * 59 + this.Clientes.GetHashCode();
                if (this.Cheques != null)
                    hashCode = hashCode * 59 + this.Cheques.GetHashCode();
                if (this.FormaEnvio != null)
                    hashCode = hashCode * 59 + this.FormaEnvio.GetHashCode();
                if (this.DadosLiberacao != null)
                    hashCode = hashCode * 59 + this.DadosLiberacao.GetHashCode();
                if (this.TipoEfetivacao != null)
                    hashCode = hashCode * 59 + this.TipoEfetivacao.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
