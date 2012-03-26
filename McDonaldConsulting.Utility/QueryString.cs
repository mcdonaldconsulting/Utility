namespace McDonaldConsulting
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class QueryString : IEnumerable
    {
        private readonly Dictionary<string, string> parms = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return this.parms[key]; }
            set { this.parms[key] = value; }
        }

        public void Add(string key, string value)
        {
            this.parms.Add(key, value);
        }

        public override string ToString()
        {
            var query = from item in this.parms
                        select "{0}={1}".FormatWith(
                            Uri.EscapeDataString(item.Key),
                            Uri.EscapeDataString(item.Value));

            return query.Join("&");
        }

        public IEnumerator GetEnumerator()
        {
            return this.parms.GetEnumerator();
        }
    }
}
