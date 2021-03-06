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
    /// Enumeration dos tipos de contrato da proposta.
    /// </summary>
    /// <value>Enumeration dos tipos de contrato da proposta.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TipoContrato
    {
        
        /// <summary>
        /// Enum CCB for value: CCB
        /// </summary>
        [EnumMember(Value = "CCB")]
        CCB = 1,
        
        /// <summary>
        /// Enum MUTUO for value: MUTUO
        /// </summary>
        [EnumMember(Value = "MUTUO")]
        MUTUO = 2,
        
        /// <summary>
        /// Enum ACEITE for value: ACEITE
        /// </summary>
        [EnumMember(Value = "ACEITE")]
        ACEITE = 3
    }

}
