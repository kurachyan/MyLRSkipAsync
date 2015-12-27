using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LRSkipAsync;


namespace UnitTest
{
    [TestClass]
    public class LRSkipAsync_UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region 対象：削除対象なし
            String KeyWord = @"This is a Pen.";
            String Result;
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし
            CS_LskipAsync lskip = new CS_LskipAsync();
            lskip.ClearAsync();
            lskip.Wbuf = KeyWord;
            lskip.ExecAsync();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし２
            lskip.ClearAsync();
            lskip.ExecAsync(KeyWord);
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし
            CS_RskipAsync rskip = new CS_RskipAsync();
            rskip.ClearAsync();
            rskip.Wbuf = KeyWord;
            rskip.ExecAsync();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし２
            rskip.ClearAsync();
            rskip.ExecAsync(KeyWord);
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion
        }

        [TestMethod]
        public void TestMethod2()
        {
            #region 対象：削除対象なし
            String KeyWord = @"     This is a Pen.     ";
            String Result;
            #endregion

            #region Ｌｓｋｉｐ：スキップ５
            CS_LskipAsync lskip = new CS_LskipAsync();

            lskip.ClearAsync();
            lskip.Wbuf = KeyWord;
            lskip.ExecAsync();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.     ", Result, @"lskip[     This is a Pen.     ] = [This is a Pen.     ]");
            #endregion

            #region Ｌｓｋｉｐ：スキップ５
            lskip.ClearAsync();
            lskip.ExecAsync(KeyWord);
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.     ", Result, @"lskip[     This is a Pen.     ] = [This is a Pen.     ]");
            #endregion

            #region Ｒｓｋｉｐ：スキップ５
            CS_RskipAsync rskip = new CS_RskipAsync();
            rskip.ClearAsync();
            rskip.Wbuf = KeyWord;
            rskip.ExecAsync();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"     This is a Pen.", Result, @"rskip[     This is a Pen.     ] = [     This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：スキップ５
            rskip.ClearAsync();
            rskip.ExecAsync(KeyWord);
            Result = rskip.Wbuf;

            Assert.AreEqual(@"     This is a Pen.", Result, @"rskip[     This is a Pen.     ] = [     This is a Pen.]");
            #endregion
        }

        [TestMethod]
        public async void TestMethod3()
        {
            #region 対象：削除対象なし
            String KeyWord = @"This is a Pen.";
            String Result;
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし
            CS_LskipAsync lskip = new CS_LskipAsync();
            await lskip.ClearAsync();
            lskip.Wbuf = KeyWord;
            await lskip.ExecAsync();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし２
            await lskip.ClearAsync();
            await lskip.ExecAsync(KeyWord);
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし
            CS_RskipAsync rskip = new CS_RskipAsync();
            await rskip.ClearAsync();
            rskip.Wbuf = KeyWord;
            await rskip.ExecAsync();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし２
            await rskip.ClearAsync();
            await rskip.ExecAsync(KeyWord);
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion
        }
    }
}
