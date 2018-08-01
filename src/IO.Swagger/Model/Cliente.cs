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
    /// Entidade representando um cliente da proposta.
    /// </summary>
    [DataContract]
    public partial class Cliente :  IEquatable<Cliente>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public TipoCliente? Tipo { get; set; }
        /// <summary>
        /// Gets or Sets EstadoCivil
        /// </summary>
        [DataMember(Name="estadoCivil", EmitDefaultValue=false)]
        public EstadoCivil? EstadoCivil { get; set; }
        /// <summary>
        /// Gets or Sets Nacionalidade
        /// </summary>
        [DataMember(Name="nacionalidade", EmitDefaultValue=false)]
        public Nacionalidade? Nacionalidade { get; set; }
        /// <summary>
        /// Gets or Sets Sexo
        /// </summary>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public Sexo? Sexo { get; set; }
        /// <summary>
        /// Gets or Sets Negativado
        /// </summary>
        [DataMember(Name="negativado", EmitDefaultValue=false)]
        public IndicativoSimNao? Negativado { get; set; }
        /// <summary>
        /// Gets or Sets PossuiCheque
        /// </summary>
        [DataMember(Name="possuiCheque", EmitDefaultValue=false)]
        public IndicativoSimNao? PossuiCheque { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cliente" /> class.
        /// </summary>
        /// <param name="Nome">Nome do Cliente..</param>
        /// <param name="Cpf">Cpf do Cliente - Formatar com zeros a esquerda..</param>
        /// <param name="DataNascimento">Data de nascimento do cliente. (aaaa-mm-dd)..</param>
        /// <param name="NumeroDependentes">Número de dependentes do cliente..</param>
        /// <param name="Email">E-mail do cliente..</param>
        /// <param name="CodigoEscolaridade">Código de escolaridade do cliente..</param>
        /// <param name="NomeMae">Nome da mãe do cliente..</param>
        /// <param name="NomePai">Nome do pai do cliente..</param>
        /// <param name="Cidade">Cidade do cliente..</param>
        /// <param name="Uf">Unidade federativa do endereço..</param>
        /// <param name="Tipo">Tipo.</param>
        /// <param name="Documentos">Documentos.</param>
        /// <param name="EstadoCivil">EstadoCivil.</param>
        /// <param name="Nacionalidade">Nacionalidade.</param>
        /// <param name="Sexo">Sexo.</param>
        /// <param name="Telefones">Telefones.</param>
        /// <param name="Conjuge">Conjuge.</param>
        /// <param name="Emprego">Emprego.</param>
        /// <param name="Enderecos">Enderecos.</param>
        /// <param name="RendasAdicionais">RendasAdicionais.</param>
        /// <param name="Negativado">Negativado.</param>
        /// <param name="PossuiCheque">PossuiCheque.</param>
        /// <param name="ContasBancarias">ContasBancarias.</param>
        /// <param name="CartoesCredito">CartoesCredito.</param>
        /// <param name="ReferenciasPessoais">ReferenciasPessoais.</param>
        public Cliente(string Nome = default(string), string Cpf = default(string), DateTime? DataNascimento = default(DateTime?), string NumeroDependentes = default(string), string Email = default(string), string CodigoEscolaridade = default(string), string NomeMae = default(string), string NomePai = default(string), string Cidade = default(string), string Uf = default(string), TipoCliente? Tipo = default(TipoCliente?), List<Documento> Documentos = default(List<Documento>), EstadoCivil? EstadoCivil = default(EstadoCivil?), Nacionalidade? Nacionalidade = default(Nacionalidade?), Sexo? Sexo = default(Sexo?), List<Telefone> Telefones = default(List<Telefone>), Conjuge Conjuge = default(Conjuge), Emprego Emprego = default(Emprego), List<Endereco> Enderecos = default(List<Endereco>), List<RendaAdicional> RendasAdicionais = default(List<RendaAdicional>), IndicativoSimNao? Negativado = default(IndicativoSimNao?), IndicativoSimNao? PossuiCheque = default(IndicativoSimNao?), List<ContaBancaria> ContasBancarias = default(List<ContaBancaria>), List<CartaoCredito> CartoesCredito = default(List<CartaoCredito>), List<ReferenciaPessoal> ReferenciasPessoais = default(List<ReferenciaPessoal>))
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
            this.NumeroDependentes = NumeroDependentes;
            this.Email = Email;
            this.CodigoEscolaridade = CodigoEscolaridade;
            this.NomeMae = NomeMae;
            this.NomePai = NomePai;
            this.Cidade = Cidade;
            this.Uf = Uf;
            this.Tipo = Tipo;
            this.Documentos = Documentos;
            this.EstadoCivil = EstadoCivil;
            this.Nacionalidade = Nacionalidade;
            this.Sexo = Sexo;
            this.Telefones = Telefones;
            this.Conjuge = Conjuge;
            this.Emprego = Emprego;
            this.Enderecos = Enderecos;
            this.RendasAdicionais = RendasAdicionais;
            this.Negativado = Negativado;
            this.PossuiCheque = PossuiCheque;
            this.ContasBancarias = ContasBancarias;
            this.CartoesCredito = CartoesCredito;
            this.ReferenciasPessoais = ReferenciasPessoais;
        }
        
        /// <summary>
        /// Nome do Cliente.
        /// </summary>
        /// <value>Nome do Cliente.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Cpf do Cliente - Formatar com zeros a esquerda.
        /// </summary>
        /// <value>Cpf do Cliente - Formatar com zeros a esquerda.</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }

        /// <summary>
        /// Data de nascimento do cliente. (aaaa-mm-dd).
        /// </summary>
        /// <value>Data de nascimento do cliente. (aaaa-mm-dd).</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// Número de dependentes do cliente.
        /// </summary>
        /// <value>Número de dependentes do cliente.</value>
        [DataMember(Name="numeroDependentes", EmitDefaultValue=false)]
        public string NumeroDependentes { get; set; }

        /// <summary>
        /// E-mail do cliente.
        /// </summary>
        /// <value>E-mail do cliente.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Código de escolaridade do cliente.
        /// </summary>
        /// <value>Código de escolaridade do cliente.</value>
        [DataMember(Name="codigoEscolaridade", EmitDefaultValue=false)]
        public string CodigoEscolaridade { get; set; }

        /// <summary>
        /// Nome da mãe do cliente.
        /// </summary>
        /// <value>Nome da mãe do cliente.</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }

        /// <summary>
        /// Nome do pai do cliente.
        /// </summary>
        /// <value>Nome do pai do cliente.</value>
        [DataMember(Name="nomePai", EmitDefaultValue=false)]
        public string NomePai { get; set; }

        /// <summary>
        /// Cidade do cliente.
        /// </summary>
        /// <value>Cidade do cliente.</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }

        /// <summary>
        /// Unidade federativa do endereço.
        /// </summary>
        /// <value>Unidade federativa do endereço.</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }


        /// <summary>
        /// Gets or Sets Documentos
        /// </summary>
        [DataMember(Name="documentos", EmitDefaultValue=false)]
        public List<Documento> Documentos { get; set; }




        /// <summary>
        /// Gets or Sets Telefones
        /// </summary>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<Telefone> Telefones { get; set; }

        /// <summary>
        /// Gets or Sets Conjuge
        /// </summary>
        [DataMember(Name="conjuge", EmitDefaultValue=false)]
        public Conjuge Conjuge { get; set; }

        /// <summary>
        /// Gets or Sets Emprego
        /// </summary>
        [DataMember(Name="emprego", EmitDefaultValue=false)]
        public Emprego Emprego { get; set; }

        /// <summary>
        /// Gets or Sets Enderecos
        /// </summary>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<Endereco> Enderecos { get; set; }

        /// <summary>
        /// Gets or Sets RendasAdicionais
        /// </summary>
        [DataMember(Name="rendasAdicionais", EmitDefaultValue=false)]
        public List<RendaAdicional> RendasAdicionais { get; set; }



        /// <summary>
        /// Gets or Sets ContasBancarias
        /// </summary>
        [DataMember(Name="contasBancarias", EmitDefaultValue=false)]
        public List<ContaBancaria> ContasBancarias { get; set; }

        /// <summary>
        /// Gets or Sets CartoesCredito
        /// </summary>
        [DataMember(Name="cartoesCredito", EmitDefaultValue=false)]
        public List<CartaoCredito> CartoesCredito { get; set; }

        /// <summary>
        /// Gets or Sets ReferenciasPessoais
        /// </summary>
        [DataMember(Name="referenciasPessoais", EmitDefaultValue=false)]
        public List<ReferenciaPessoal> ReferenciasPessoais { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cliente {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  NumeroDependentes: ").Append(NumeroDependentes).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CodigoEscolaridade: ").Append(CodigoEscolaridade).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  NomePai: ").Append(NomePai).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Documentos: ").Append(Documentos).Append("\n");
            sb.Append("  EstadoCivil: ").Append(EstadoCivil).Append("\n");
            sb.Append("  Nacionalidade: ").Append(Nacionalidade).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Conjuge: ").Append(Conjuge).Append("\n");
            sb.Append("  Emprego: ").Append(Emprego).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  RendasAdicionais: ").Append(RendasAdicionais).Append("\n");
            sb.Append("  Negativado: ").Append(Negativado).Append("\n");
            sb.Append("  PossuiCheque: ").Append(PossuiCheque).Append("\n");
            sb.Append("  ContasBancarias: ").Append(ContasBancarias).Append("\n");
            sb.Append("  CartoesCredito: ").Append(CartoesCredito).Append("\n");
            sb.Append("  ReferenciasPessoais: ").Append(ReferenciasPessoais).Append("\n");
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
            return this.Equals(input as Cliente);
        }

        /// <summary>
        /// Returns true if Cliente instances are equal
        /// </summary>
        /// <param name="input">Instance of Cliente to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cliente input)
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
                    this.Cpf == input.Cpf ||
                    (this.Cpf != null &&
                    this.Cpf.Equals(input.Cpf))
                ) && 
                (
                    this.DataNascimento == input.DataNascimento ||
                    (this.DataNascimento != null &&
                    this.DataNascimento.Equals(input.DataNascimento))
                ) && 
                (
                    this.NumeroDependentes == input.NumeroDependentes ||
                    (this.NumeroDependentes != null &&
                    this.NumeroDependentes.Equals(input.NumeroDependentes))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CodigoEscolaridade == input.CodigoEscolaridade ||
                    (this.CodigoEscolaridade != null &&
                    this.CodigoEscolaridade.Equals(input.CodigoEscolaridade))
                ) && 
                (
                    this.NomeMae == input.NomeMae ||
                    (this.NomeMae != null &&
                    this.NomeMae.Equals(input.NomeMae))
                ) && 
                (
                    this.NomePai == input.NomePai ||
                    (this.NomePai != null &&
                    this.NomePai.Equals(input.NomePai))
                ) && 
                (
                    this.Cidade == input.Cidade ||
                    (this.Cidade != null &&
                    this.Cidade.Equals(input.Cidade))
                ) && 
                (
                    this.Uf == input.Uf ||
                    (this.Uf != null &&
                    this.Uf.Equals(input.Uf))
                ) && 
                (
                    this.Tipo == input.Tipo ||
                    (this.Tipo != null &&
                    this.Tipo.Equals(input.Tipo))
                ) && 
                (
                    this.Documentos == input.Documentos ||
                    this.Documentos != null &&
                    this.Documentos.SequenceEqual(input.Documentos)
                ) && 
                (
                    this.EstadoCivil == input.EstadoCivil ||
                    (this.EstadoCivil != null &&
                    this.EstadoCivil.Equals(input.EstadoCivil))
                ) && 
                (
                    this.Nacionalidade == input.Nacionalidade ||
                    (this.Nacionalidade != null &&
                    this.Nacionalidade.Equals(input.Nacionalidade))
                ) && 
                (
                    this.Sexo == input.Sexo ||
                    (this.Sexo != null &&
                    this.Sexo.Equals(input.Sexo))
                ) && 
                (
                    this.Telefones == input.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(input.Telefones)
                ) && 
                (
                    this.Conjuge == input.Conjuge ||
                    (this.Conjuge != null &&
                    this.Conjuge.Equals(input.Conjuge))
                ) && 
                (
                    this.Emprego == input.Emprego ||
                    (this.Emprego != null &&
                    this.Emprego.Equals(input.Emprego))
                ) && 
                (
                    this.Enderecos == input.Enderecos ||
                    this.Enderecos != null &&
                    this.Enderecos.SequenceEqual(input.Enderecos)
                ) && 
                (
                    this.RendasAdicionais == input.RendasAdicionais ||
                    this.RendasAdicionais != null &&
                    this.RendasAdicionais.SequenceEqual(input.RendasAdicionais)
                ) && 
                (
                    this.Negativado == input.Negativado ||
                    (this.Negativado != null &&
                    this.Negativado.Equals(input.Negativado))
                ) && 
                (
                    this.PossuiCheque == input.PossuiCheque ||
                    (this.PossuiCheque != null &&
                    this.PossuiCheque.Equals(input.PossuiCheque))
                ) && 
                (
                    this.ContasBancarias == input.ContasBancarias ||
                    this.ContasBancarias != null &&
                    this.ContasBancarias.SequenceEqual(input.ContasBancarias)
                ) && 
                (
                    this.CartoesCredito == input.CartoesCredito ||
                    this.CartoesCredito != null &&
                    this.CartoesCredito.SequenceEqual(input.CartoesCredito)
                ) && 
                (
                    this.ReferenciasPessoais == input.ReferenciasPessoais ||
                    this.ReferenciasPessoais != null &&
                    this.ReferenciasPessoais.SequenceEqual(input.ReferenciasPessoais)
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
                if (this.Cpf != null)
                    hashCode = hashCode * 59 + this.Cpf.GetHashCode();
                if (this.DataNascimento != null)
                    hashCode = hashCode * 59 + this.DataNascimento.GetHashCode();
                if (this.NumeroDependentes != null)
                    hashCode = hashCode * 59 + this.NumeroDependentes.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CodigoEscolaridade != null)
                    hashCode = hashCode * 59 + this.CodigoEscolaridade.GetHashCode();
                if (this.NomeMae != null)
                    hashCode = hashCode * 59 + this.NomeMae.GetHashCode();
                if (this.NomePai != null)
                    hashCode = hashCode * 59 + this.NomePai.GetHashCode();
                if (this.Cidade != null)
                    hashCode = hashCode * 59 + this.Cidade.GetHashCode();
                if (this.Uf != null)
                    hashCode = hashCode * 59 + this.Uf.GetHashCode();
                if (this.Tipo != null)
                    hashCode = hashCode * 59 + this.Tipo.GetHashCode();
                if (this.Documentos != null)
                    hashCode = hashCode * 59 + this.Documentos.GetHashCode();
                if (this.EstadoCivil != null)
                    hashCode = hashCode * 59 + this.EstadoCivil.GetHashCode();
                if (this.Nacionalidade != null)
                    hashCode = hashCode * 59 + this.Nacionalidade.GetHashCode();
                if (this.Sexo != null)
                    hashCode = hashCode * 59 + this.Sexo.GetHashCode();
                if (this.Telefones != null)
                    hashCode = hashCode * 59 + this.Telefones.GetHashCode();
                if (this.Conjuge != null)
                    hashCode = hashCode * 59 + this.Conjuge.GetHashCode();
                if (this.Emprego != null)
                    hashCode = hashCode * 59 + this.Emprego.GetHashCode();
                if (this.Enderecos != null)
                    hashCode = hashCode * 59 + this.Enderecos.GetHashCode();
                if (this.RendasAdicionais != null)
                    hashCode = hashCode * 59 + this.RendasAdicionais.GetHashCode();
                if (this.Negativado != null)
                    hashCode = hashCode * 59 + this.Negativado.GetHashCode();
                if (this.PossuiCheque != null)
                    hashCode = hashCode * 59 + this.PossuiCheque.GetHashCode();
                if (this.ContasBancarias != null)
                    hashCode = hashCode * 59 + this.ContasBancarias.GetHashCode();
                if (this.CartoesCredito != null)
                    hashCode = hashCode * 59 + this.CartoesCredito.GetHashCode();
                if (this.ReferenciasPessoais != null)
                    hashCode = hashCode * 59 + this.ReferenciasPessoais.GetHashCode();
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