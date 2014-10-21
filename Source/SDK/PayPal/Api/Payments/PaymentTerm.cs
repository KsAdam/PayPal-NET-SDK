using Newtonsoft.Json;

namespace PayPal.Api.Payments
{
    public class PaymentTerm
    {
        /// <summary>
        /// Terms by which the invoice payment is due.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "term_type")]
        public string term_type { get; set; }

        /// <summary>
        /// Date on which invoice payment is due. It must be always a future date. Date format: yyyy-MM-dd z. For example, 2014-02-27 PST
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "due_date")]
        public string due_date { get; set; }

        /// <summary>
        /// Converts the object to JSON string
        /// </summary>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}