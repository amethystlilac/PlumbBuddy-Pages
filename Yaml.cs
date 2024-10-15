namespace PlumbBuddyPages;

public static class Yaml
{
    static TBuilder ConfigureBuilder<TBuilder>(TBuilder builder)
        where TBuilder : BuilderSkeleton<TBuilder> => builder
            .WithTypeConverter(new YamlUriConverter())
            .WithNamingConvention(UnderscoredNamingConvention.Instance);

    public static IDeserializer CreateYamlDeserializer() =>
        ConfigureBuilder(new DeserializerBuilder()).Build();

    public static ISerializer CreateYamlSerializer() =>
        ConfigureBuilder(new SerializerBuilder()).Build();

    public static async Task<TValue> GetFromYamlAsync<TValue>(this HttpClient client, [StringSyntax(StringSyntaxAttribute.Uri)] string? requestUri)
    {
        var responseMessage = await client.GetAsync(requestUri).ConfigureAwait(false);
        responseMessage.EnsureSuccessStatusCode();
        return CreateYamlDeserializer().Deserialize<TValue>(await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
    }
}
