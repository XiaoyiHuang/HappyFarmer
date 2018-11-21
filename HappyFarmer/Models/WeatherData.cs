// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickTypeDeviceData;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace QuickTypeDeviceData
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("macAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }

        [JsonProperty("lastData", NullValueHandling = NullValueHandling.Ignore)]
        public LastData LastData { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }
    }

    public partial class LastData
    {
        [JsonProperty("dateutc", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dateutc { get; set; }

        [JsonProperty("winddir", NullValueHandling = NullValueHandling.Ignore)]
        public long? Winddir { get; set; }

        [JsonProperty("windspeedmph", NullValueHandling = NullValueHandling.Ignore)]
        public long? Windspeedmph { get; set; }

        [JsonProperty("windgustmph", NullValueHandling = NullValueHandling.Ignore)]
        public long? Windgustmph { get; set; }

        [JsonProperty("maxdailygust", NullValueHandling = NullValueHandling.Ignore)]
        public long? Maxdailygust { get; set; }

        [JsonProperty("tempf", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tempf { get; set; }

        [JsonProperty("hourlyrainin", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hourlyrainin { get; set; }

        [JsonProperty("eventrainin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Eventrainin { get; set; }

        [JsonProperty("dailyrainin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dailyrainin { get; set; }

        [JsonProperty("weeklyrainin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weeklyrainin { get; set; }

        [JsonProperty("monthlyrainin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Monthlyrainin { get; set; }

        [JsonProperty("totalrainin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Totalrainin { get; set; }

        [JsonProperty("baromrelin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Baromrelin { get; set; }

        [JsonProperty("baromabsin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Baromabsin { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Humidity { get; set; }

        [JsonProperty("tempinf", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tempinf { get; set; }

        [JsonProperty("humidityin", NullValueHandling = NullValueHandling.Ignore)]
        public long? Humidityin { get; set; }

        [JsonProperty("uv", NullValueHandling = NullValueHandling.Ignore)]
        public long? Uv { get; set; }

        [JsonProperty("solarradiation", NullValueHandling = NullValueHandling.Ignore)]
        public double? Solarradiation { get; set; }

        [JsonProperty("feelsLike", NullValueHandling = NullValueHandling.Ignore)]
        public double? FeelsLike { get; set; }

        [JsonProperty("dewPoint", NullValueHandling = NullValueHandling.Ignore)]
        public double? DewPoint { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }
    }

    public partial class Welcome
    {
        public static List<Welcome> FromJson(string json) => JsonConvert.DeserializeObject<List<Welcome>>(json, QuickTypeDeviceData.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Welcome> self) => JsonConvert.SerializeObject(self, QuickTypeDeviceData.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}