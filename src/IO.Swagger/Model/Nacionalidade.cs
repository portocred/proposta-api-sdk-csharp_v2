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
    /// Enumeration das nacionalidades do cliente.
    /// </summary>
    /// <value>Enumeration das nacionalidades do cliente.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Nacionalidade
    {
        
        /// <summary>
        /// Enum BRASILEIRONATO for value: BRASILEIRO_NATO
        /// </summary>
        [EnumMember(Value = "BRASILEIRO_NATO")]
        BRASILEIRONATO = 1,
        
        /// <summary>
        /// Enum ESTRANGEIRO for value: ESTRANGEIRO
        /// </summary>
        [EnumMember(Value = "ESTRANGEIRO")]
        ESTRANGEIRO = 2,
        
        /// <summary>
        /// Enum ESTRANGEIRORESIDENTE for value: ESTRANGEIRO_RESIDENTE
        /// </summary>
        [EnumMember(Value = "ESTRANGEIRO_RESIDENTE")]
        ESTRANGEIRORESIDENTE = 3,
        
        /// <summary>
        /// Enum BRASILEIRONATURALIZADO for value: BRASILEIRO_NATURALIZADO
        /// </summary>
        [EnumMember(Value = "BRASILEIRO_NATURALIZADO")]
        BRASILEIRONATURALIZADO = 4
    }

}
