using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.TestTools;

namespace Tests
{
    public class MyTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestFailureCase()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void TestLoopCompletes()
        {
            var count = 0;
            for (var i = 0;i < 5; i++)
            {
                count = i;
            }

            Assert.IsTrue(count == 4);
        }

        [UnityTest]
        public IEnumerator WebRequest()
        {
            var web = UnityWebRequest.Get("http://www.google.com/intl/en/privacy");
            web.method = "GET";
        
            yield return web.SendWebRequest();

            if (web.result == UnityWebRequest.Result.ConnectionError || web.responseCode != 200)
            {
                Assert.That(web.result == UnityWebRequest.Result.ConnectionError);
                Debug.Log($"Connection Error: {web.result}");
            }
            else
            {
                Assert.That(web.result == UnityWebRequest.Result.Success);
                Debug.Log($"Web Request: Success : {web.result}");
            }
        
            web.Dispose();
        }
    }
}
