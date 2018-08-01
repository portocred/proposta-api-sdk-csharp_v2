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
    /// Entidade representando os dados de liberação da proposta.
    /// </summary>
    [DataContract]
    public partial class DadosLiberacao :  IEquatable<DadosLiberacao>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TipoContaBancaria
        /// </summary>
        [DataMember(Name="tipoContaBancaria", EmitDefaultValue=false)]
        public TipoContaBancaria? TipoContaBancaria { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosLiberacao" /> class.
        /// </summary>
        /// <param name="Agencia">Agência para liberação..</param>
        /// <param name="Banco">Banco para liberação..</param>
        /// <param name="Beneficiario">Beneficiário para liberação..</param>
        /// <param name="Conta">Conta para liberação..</param>
        /// <param name="CpfCnpj">Cpf ou Cnpj para liberação..</param>
        /// <param name="TipoContaBancaria">TipoContaBancaria.</param>
        public DadosLiberacao(string Agencia = default(string), string Banco = default(string), string Beneficiario = default(string), string Conta = default(string), string CpfCnpj = default(string), TipoContaBancaria? TipoContaBancaria = default(TipoContaBancaria?))
        {
            this.Agencia = Agencia;
            this.Banco = Banco;
            this.Beneficiario = Beneficiario;
            this.Conta = Conta;
            this.CpfCnpj = CpfCnpj;
            this.TipoContaBancaria = TipoContaBancaria;
        }
        
        /// <summary>
        /// Agência para liberação.
        /// </summary>
        /// <value>Agência para liberação.</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public string Agencia { get; set; }

        /// <summary>
        /// Banco para liberação.
        /// </summary>
        /// <value>Banco para liberação.</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public string Banco { get; set; }

        /// <summary>
        /// Beneficiário para liberação.
        /// </summary>
        /// <value>Beneficiário para liberação.</value>
        [DataMember(Name="beneficiario", EmitDefaultValue=false)]
        public string Beneficiario { get; set; }

        /// <summary>
        /// Conta para liberação.
        /// </summary>
        /// <value>Conta para liberação.</value>
        [DataMember(Name="conta", EmitDefaultValue=false)]
        public string Conta { get; set; }

        /// <summary>
        /// Cpf ou Cnpj para liberação.
        /// </summary>
        /// <value>Cpf ou Cnpj para liberação.</value>
        [DataMember(Name="cpfCnpj", EmitDefaultValue=false)]
        public string CpfCnpj { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosLiberacao {\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Beneficiario: ").Append(Beneficiario).Append("\n");
            sb.Append("  Conta: ").Append(Conta).Append("\n");
            sb.Append("  CpfCnpj: ").Append(CpfCnpj).Append("\n");
            sb.Append("  TipoContaBancaria: ").Append(TipoContaBancaria).Append("\n");
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
            return this.Equals(input as DadosLiberacao);
        }

        /// <summary>
        /// Returns true if DadosLiberacao instances are equal
        /// </summary>
        /// <param name="input">Instance of DadosLiberacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosLiberacao input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agencia == input.Agencia ||
                    (this.Agencia != null &&
                    this.Agencia.Equals(input.Agencia))
                ) && 
                (
                    this.Banco == input.Banco ||
                    (this.Banco != null &&
                    this.Banco.Equals(input.Banco))
                ) && 
                (
                    this.Beneficiario == input.Beneficiario ||
                    (this.Beneficiario != null &&
                    this.Beneficiario.Equals(input.Beneficiario))
                ) && 
                (
                    this.Conta == input.Conta ||
                    (this.Conta != null &&
                    this.Conta.Equals(input.Conta))
                ) && 
                (
                    this.CpfCnpj == input.CpfCnpj ||
                    (this.CpfCnpj != null &&
                    this.CpfCnpj.Equals(input.CpfCnpj))
                ) && 
                (
                    this.TipoContaBancaria == input.TipoContaBancaria ||
                    (this.TipoContaBancaria != null &&
                    this.TipoContaBancaria.Equals(input.TipoContaBancaria))
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
                if (this.Agencia != null)
                    hashCode = hashCode * 59 + this.Agencia.GetHashCode();
                if (this.Banco != null)
                    hashCode = hashCode * 59 + this.Banco.GetHashCode();
                if (this.Beneficiario != null)
                    hashCode = hashCode * 59 + this.Beneficiario.GetHashCode();
                if (this.Conta != null)
                    hashCode = hashCode * 59 + this.Conta.GetHashCode();
                if (this.CpfCnpj != null)
                    hashCode = hashCode * 59 + this.CpfCnpj.GetHashCode();
                if (this.TipoContaBancaria != null)
                    hashCode = hashCode * 59 + this.TipoContaBancaria.GetHashCode();
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
