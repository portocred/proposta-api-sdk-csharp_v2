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
    /// Entidade representando uma referência pessoal
    /// </summary>
    [DataContract]
    public partial class ReferenciaPessoal :  IEquatable<ReferenciaPessoal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenciaPessoal" /> class.
        /// </summary>
        /// <param name="Nome">Nome da referência pessoal..</param>
        /// <param name="Relacionamento">Relacionamento com a referência pessoal..</param>
        /// <param name="Telefone">Telefone.</param>
        public ReferenciaPessoal(string Nome = default(string), string Relacionamento = default(string), Telefone Telefone = default(Telefone))
        {
            this.Nome = Nome;
            this.Relacionamento = Relacionamento;
            this.Telefone = Telefone;
        }
        
        /// <summary>
        /// Nome da referência pessoal.
        /// </summary>
        /// <value>Nome da referência pessoal.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Relacionamento com a referência pessoal.
        /// </summary>
        /// <value>Relacionamento com a referência pessoal.</value>
        [DataMember(Name="relacionamento", EmitDefaultValue=false)]
        public string Relacionamento { get; set; }

        /// <summary>
        /// Gets or Sets Telefone
        /// </summary>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public Telefone Telefone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferenciaPessoal {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Relacionamento: ").Append(Relacionamento).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
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
            return this.Equals(input as ReferenciaPessoal);
        }

        /// <summary>
        /// Returns true if ReferenciaPessoal instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferenciaPessoal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferenciaPessoal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
                ) && 
                (
                    this.Relacionamento == input.Relacionamento ||
                    (this.Relacionamento != null &&
                    this.Relacionamento.Equals(input.Relacionamento))
                ) && 
                (
                    this.Telefone == input.Telefone ||
                    (this.Telefone != null &&
                    this.Telefone.Equals(input.Telefone))
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
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
                if (this.Relacionamento != null)
                    hashCode = hashCode * 59 + this.Relacionamento.GetHashCode();
                if (this.Telefone != null)
                    hashCode = hashCode * 59 + this.Telefone.GetHashCode();
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
