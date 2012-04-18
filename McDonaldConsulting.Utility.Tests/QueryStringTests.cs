namespace McDonaldConsulting.Utility.Tests
{
    using Xunit;

    public class QueryStringTests
    {
        [Fact]
        public void Indexer()
        {
            var queryString = new QueryString();
            queryString["a"] = "b";
            Assert.Equal("b", queryString["a"]);
        }

        [Fact]
        public void Enumerator()
        {
            var queryString = new QueryString();
            queryString["a"] = "b";
            queryString["c"] = "d";

            var enumerator = queryString.GetEnumerator();
            enumerator.MoveNext();
            dynamic item1 = enumerator.Current;
            Assert.Equal("a", item1.Key);
            Assert.Equal("b", item1.Value);
            enumerator.MoveNext();
            dynamic item2 = enumerator.Current;
            Assert.Equal("c", item2.Key);
            Assert.Equal("d", item2.Value);
        }

        [Fact]
        public void MyFact()
        {
            var queryString = new QueryString();

            queryString.Add("q", "mcdonald");

            Assert.Equal("q=mcdonald", queryString.ToString());
        }
    }
}
