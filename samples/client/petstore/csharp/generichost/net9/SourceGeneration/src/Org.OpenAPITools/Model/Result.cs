// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Result
    /// </summary>
    public partial class Result : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result" /> class.
        /// </summary>
        /// <param name="code">Result code</param>
        /// <param name="data">list of named parameters for current message</param>
        /// <param name="uuid">Result unique identifier</param>
        [JsonConstructor]
        public Result(Option<string?> code = default, Option<Dictionary<string, string>?> data = default, Option<string?> uuid = default)
        {
            CodeOption = code;
            DataOption = data;
            UuidOption = uuid;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CodeOption { get; private set; }

        /// <summary>
        /// Result code
        /// </summary>
        /// <value>Result code</value>
        [JsonPropertyName("code")]
        public string? Code { get { return this.CodeOption; } set { this.CodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, string>?> DataOption { get; private set; }

        /// <summary>
        /// list of named parameters for current message
        /// </summary>
        /// <value>list of named parameters for current message</value>
        [JsonPropertyName("data")]
        public Dictionary<string, string>? Data { get { return this.DataOption; } set { this.DataOption = new(value); } }

        /// <summary>
        /// Used to track the state of Uuid
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UuidOption { get; private set; }

        /// <summary>
        /// Result unique identifier
        /// </summary>
        /// <value>Result unique identifier</value>
        [JsonPropertyName("uuid")]
        public string? Uuid { get { return this.UuidOption; } set { this.UuidOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Result {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Result" />
    /// </summary>
    public class ResultJsonConverter : JsonConverter<Result>
    {
        /// <summary>
        /// Deserializes json to <see cref="Result" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Result Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> code = default;
            Option<Dictionary<string, string>?> data = default;
            Option<string?> uuid = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "data":
                            data = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "uuid":
                            uuid = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class Result.");

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class Result.");

            if (uuid.IsSet && uuid.Value == null)
                throw new ArgumentNullException(nameof(uuid), "Property is not nullable for class Result.");

            return new Result(code, data, uuid);
        }

        /// <summary>
        /// Serializes a <see cref="Result" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="result"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Result result, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, result, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Result" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="result"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Result result, JsonSerializerOptions jsonSerializerOptions)
        {
            if (result.CodeOption.IsSet && result.Code == null)
                throw new ArgumentNullException(nameof(result.Code), "Property is required for class Result.");

            if (result.DataOption.IsSet && result.Data == null)
                throw new ArgumentNullException(nameof(result.Data), "Property is required for class Result.");

            if (result.UuidOption.IsSet && result.Uuid == null)
                throw new ArgumentNullException(nameof(result.Uuid), "Property is required for class Result.");

            if (result.CodeOption.IsSet)
                writer.WriteString("code", result.Code);

            if (result.DataOption.IsSet)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, result.Data, jsonSerializerOptions);
            }
            if (result.UuidOption.IsSet)
                writer.WriteString("uuid", result.Uuid);
        }
    }

    /// <summary>
    /// The ResultSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Result))]
    public partial class ResultSerializationContext : JsonSerializerContext { }
}
