using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace CovidTracking.Models
{
    public class CovidCase
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("positive")]
        public int? Positive { get; set; }

        [JsonProperty("negative")]
        public int? Negative { get; set; }

        [JsonProperty("totalTestResults")]
        public int TotalTestResults { get; set; }

        [JsonProperty("hospitalizedCurrently")]
        public int? HospitalizedCurrent { get; set; }

        [JsonProperty("date")]
        public int DateInt { get; set; }

        [JsonIgnore]
        public DateTime Date
        {
            get
            {
                DateTime date;
                DateTime.TryParseExact(this.DateInt.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
                return date;
            }
        }

        public static async Task<List<CovidCase>> GetCases()
        {
            var result = await ApiHelper.GetCases();
            List<CovidCase> caseList = JsonConvert.DeserializeObject<List<CovidCase>>(result);
            return caseList;
        }
    }
}