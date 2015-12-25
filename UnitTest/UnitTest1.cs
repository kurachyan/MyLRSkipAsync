using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LRSkipAsync;


namespace UnitTest
{
    [TestClass]
    public class LRSkipAsync_UnitTest1
    {
        [TestMethod]
        public async void TestMethod1()
        {
            #region 対象：削除対象なし
            String KeyWord = @"This is a Pen.";
            String Result;
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし
            CS_LskipAsync lskip = new CS_LskipAsync();
            await lskip.Clear();
            lskip.Wbuf = KeyWord;
            await lskip.Exec();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし
            CS_RskipAsync rskip = new CS_RskipAsync();
            await rskip.Clear();
            rskip.Wbuf = KeyWord;
            await rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion
        }
    }
}
