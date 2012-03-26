namespace McDonaldConsulting.Utility.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class QueryStringTests
    {
        [TestMethod]
        public void Indexer()
        {
            var queryString = new QueryString();
            queryString["a"] = "b";
            Assert.AreEqual("b", queryString["a"]);
        }

        [TestMethod]
        public void Enumerator()
        {
            var queryString = new QueryString();
            queryString["a"] = "b";
            queryString["c"] = "d";

            var enumerator = queryString.GetEnumerator();
            enumerator.MoveNext();
            dynamic item1 = enumerator.Current;
            Assert.AreEqual("a", item1.Key);
            Assert.AreEqual("b", item1.Value);
            enumerator.MoveNext();
            dynamic item2 = enumerator.Current;
            Assert.AreEqual("c", item2.Key);
            Assert.AreEqual("d", item2.Value);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var queryString = new QueryString();

            queryString.Add("q", "mcdonald");

            Assert.AreEqual("q=mcdonald", queryString.ToString());
        }
    }
}
