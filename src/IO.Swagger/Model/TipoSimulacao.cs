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
    /// Enumeration dos tipos de simulações.
    /// </summary>
    /// <value>Enumeration dos tipos de simulações.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TipoSimulacao
    {
        
        /// <summary>
        /// Enum VALORCREDITO for value: VALOR_CREDITO
        /// </summary>
        [EnumMember(Value = "VALOR_CREDITO")]
        VALORCREDITO = 1,
        
        /// <summary>
        /// Enum PRESTACAOAPROXIMADA for value: PRESTACAO_APROXIMADA
        /// </summary>
        [EnumMember(Value = "PRESTACAO_APROXIMADA")]
        PRESTACAOAPROXIMADA = 2
    }

}