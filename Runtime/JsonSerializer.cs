#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global

public static class JsonSerializer
{
    public static JsonSerializerOptions DefaultOptions { get; set; } = new();

    public static TValue? Deserialize<TValue>( this JsonDocument document, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( document, options ?? DefaultOptions );
    }

    public static object? Deserialize( this JsonDocument document, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( document, returnType, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( this JsonDocument document, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( document, jsonTypeInfo );
    }

    public static object? Deserialize( this JsonDocument document, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( document, returnType, context );
    }

    public static TValue? Deserialize<TValue>( this JsonElement element, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( element, options ?? DefaultOptions );
    }

    public static object? Deserialize( this JsonElement element, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( element, returnType, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( this JsonElement element, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( element, jsonTypeInfo );
    }

    public static object? Deserialize( this JsonElement element, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( element, returnType, context );
    }

    public static TValue? Deserialize<TValue>( this JsonNode node, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( node, options ?? DefaultOptions );
    }

    public static object? Deserialize( this JsonNode node, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( node, returnType, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( this JsonNode node, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( node, jsonTypeInfo );
    }

    public static object? Deserialize( this JsonNode node, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( node, returnType, context );
    }

    public static JsonDocument SerializeToDocument<TValue>( TValue value, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToDocument( value, options ?? DefaultOptions );
    }

    public static JsonDocument SerializeToDocument( object value, Type inputType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToDocument( value, inputType, options ?? DefaultOptions );
    }

    public static JsonDocument SerializeToDocument<TValue>( TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.SerializeToDocument( value, jsonTypeInfo );
    }

    public static JsonDocument SerializeToDocument( object value, Type inputType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.SerializeToDocument( value, inputType, context );
    }

    public static JsonElement? SerializeToElement<TValue>( TValue value, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToElement( value, options ?? DefaultOptions );
    }

    public static JsonElement? SerializeToElement( object value, Type inputType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToElement( value, inputType, options ?? DefaultOptions );
    }

    public static JsonElement? SerializeToElement<TValue>( TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.SerializeToElement( value, jsonTypeInfo );
    }

    public static JsonElement? SerializeToElement( object value, Type inputType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.SerializeToElement( value, inputType, context );
    }

    public static JsonNode? SerializeToNode<TValue>( TValue value, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToNode( value, options ?? DefaultOptions );
    }

    public static JsonNode? SerializeToNode( object value, Type inputType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToNode( value, inputType, options ?? DefaultOptions );
    }

    public static JsonNode? SerializeToNode<TValue>( TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.SerializeToNode( value, jsonTypeInfo );
    }

    public static JsonNode? SerializeToNode( object value, Type inputType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.SerializeToNode( value, inputType, context );
    }

    public static TValue? Deserialize<TValue>( ReadOnlySpan<byte> utf8Json, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( utf8Json, options ?? DefaultOptions );
    }

    public static object? Deserialize( ReadOnlySpan<byte> utf8Json, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( utf8Json, returnType, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( ReadOnlySpan<byte> utf8Json, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( utf8Json, jsonTypeInfo );
    }

    public static object? Deserialize( ReadOnlySpan<byte> utf8Json, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( utf8Json, returnType, context );
    }

    public static ValueTask<TValue?> DeserializeAsync<TValue>( Stream utf8Json, JsonSerializerOptions? options = default, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.DeserializeAsync<TValue>( utf8Json, options ?? DefaultOptions, cancellationToken );
    }

    public static TValue? Deserialize<TValue>( Stream utf8Json, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( utf8Json, options ?? DefaultOptions );
    }

    public static ValueTask<object?> DeserializeAsync( Stream utf8Json, Type returnType, JsonSerializerOptions? options = default, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.DeserializeAsync( utf8Json, returnType, options ?? DefaultOptions, cancellationToken );
    }

    public static object? Deserialize( Stream utf8Json, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( utf8Json, returnType, options ?? DefaultOptions );
    }

    public static ValueTask<TValue?> DeserializeAsync<TValue>( Stream utf8Json, JsonTypeInfo<TValue> jsonTypeInfo, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.DeserializeAsync( utf8Json, jsonTypeInfo, cancellationToken );
    }

    public static TValue? Deserialize<TValue>( Stream utf8Json, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( utf8Json, jsonTypeInfo );
    }

    public static ValueTask<object?> DeserializeAsync( Stream utf8Json, Type returnType, JsonSerializerContext context, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.DeserializeAsync( utf8Json, returnType, context, cancellationToken );
    }

    public static object? Deserialize( Stream utf8Json, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( utf8Json, returnType, context );
    }

    public static IAsyncEnumerable<TValue?> DeserializeAsyncEnumerable<TValue>( Stream utf8Json, JsonSerializerOptions? options = default, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.DeserializeAsyncEnumerable<TValue>( utf8Json, options ?? DefaultOptions, cancellationToken );
    }

    public static TValue? Deserialize<TValue>( string json, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( json, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( ReadOnlySpan<char> json, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( json, options ?? DefaultOptions );
    }

    public static object? Deserialize( string json, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( json, returnType, options ?? DefaultOptions );
    }

    public static object? Deserialize( ReadOnlySpan<char> json, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( json, returnType, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( string json, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( json, jsonTypeInfo );
    }

    public static TValue? Deserialize<TValue>( ReadOnlySpan<char> json, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( json, jsonTypeInfo );
    }

    public static object? Deserialize( string json, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( json, returnType, context );
    }

    public static object? Deserialize( ReadOnlySpan<char> json, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( json, returnType, context );
    }

    public static TValue? Deserialize<TValue>( ref Utf8JsonReader reader, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize<TValue>( ref reader, options ?? DefaultOptions );
    }

    public static object? Deserialize( ref Utf8JsonReader reader, Type returnType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Deserialize( ref reader, returnType, options ?? DefaultOptions );
    }

    public static TValue? Deserialize<TValue>( ref Utf8JsonReader reader, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Deserialize( ref reader, jsonTypeInfo );
    }

    public static object? Deserialize( ref Utf8JsonReader reader, Type returnType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Deserialize( ref reader, returnType, context );
    }

    public static byte[] SerializeToUtf8Bytes<TValue>( TValue value, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes( value, options ?? DefaultOptions );
    }

    public static byte[] SerializeToUtf8Bytes( object value, Type inputType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes( value, inputType, options ?? DefaultOptions );
    }

    public static byte[] SerializeToUtf8Bytes<TValue>( TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes( value, jsonTypeInfo );
    }

    public static byte[] SerializeToUtf8Bytes( object value, Type inputType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes( value, inputType, context );
    }

    public static Task SerializeAsync<TValue>( Stream utf8Json, TValue value, JsonSerializerOptions? options = default, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.SerializeAsync( utf8Json, value, options ?? DefaultOptions, cancellationToken );
    }

    public static void Serialize<TValue>( Stream utf8Json, TValue value, JsonSerializerOptions? options = default )
    {
        System.Text.Json.JsonSerializer.Serialize( utf8Json, value, options ?? DefaultOptions );
    }

    public static Task SerializeAsync
    (
        Stream                 utf8Json,
        object                 value,
        Type                   inputType,
        JsonSerializerOptions? options           = default,
        CancellationToken      cancellationToken = default
    )
    {
        return System.Text.Json.JsonSerializer.SerializeAsync( utf8Json, value, inputType, options ?? DefaultOptions, cancellationToken );
    }

    public static void Serialize( Stream utf8Json, object value, Type inputType, JsonSerializerOptions? options = default )
    {
        System.Text.Json.JsonSerializer.Serialize( utf8Json, value, inputType, options ?? DefaultOptions );
    }

    public static Task SerializeAsync<TValue>( Stream utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo, CancellationToken cancellationToken = default )
    {
        return System.Text.Json.JsonSerializer.SerializeAsync( utf8Json, value, jsonTypeInfo, cancellationToken );
    }

    public static void Serialize<TValue>( Stream utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        System.Text.Json.JsonSerializer.Serialize( utf8Json, value, jsonTypeInfo );
    }

    public static Task SerializeAsync
    (
        Stream                utf8Json,
        object                value,
        Type                  inputType,
        JsonSerializerContext context,
        CancellationToken     cancellationToken = default
    )
    {
        return System.Text.Json.JsonSerializer.SerializeAsync( utf8Json, value, inputType, context, cancellationToken );
    }

    public static void Serialize( Stream utf8Json, object value, Type inputType, JsonSerializerContext context )
    {
        System.Text.Json.JsonSerializer.Serialize( utf8Json, value, inputType, context );
    }

    public static string Serialize<TValue>( TValue value, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Serialize( value, options ?? DefaultOptions );
    }

    public static string Serialize( object value, Type inputType, JsonSerializerOptions? options = default )
    {
        return System.Text.Json.JsonSerializer.Serialize( value, inputType, options ?? DefaultOptions );
    }

    public static string Serialize<TValue>( TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        return System.Text.Json.JsonSerializer.Serialize( value, jsonTypeInfo );
    }

    public static string Serialize( object value, Type inputType, JsonSerializerContext context )
    {
        return System.Text.Json.JsonSerializer.Serialize( value, inputType, context );
    }

    public static void Serialize<TValue>( Utf8JsonWriter writer, TValue value, JsonSerializerOptions? options = default )
    {
        System.Text.Json.JsonSerializer.Serialize( writer, value, options ?? DefaultOptions );
    }

    public static void Serialize( Utf8JsonWriter writer, object value, Type inputType, JsonSerializerOptions? options = default )
    {
        System.Text.Json.JsonSerializer.Serialize( writer, value, inputType, options ?? DefaultOptions );
    }

    public static void Serialize<TValue>( Utf8JsonWriter writer, TValue value, JsonTypeInfo<TValue> jsonTypeInfo )
    {
        System.Text.Json.JsonSerializer.Serialize( writer, value, jsonTypeInfo );
    }

    public static void Serialize( Utf8JsonWriter writer, object value, Type inputType, JsonSerializerContext context )
    {
        System.Text.Json.JsonSerializer.Serialize( writer, value, inputType, context );
    }
}