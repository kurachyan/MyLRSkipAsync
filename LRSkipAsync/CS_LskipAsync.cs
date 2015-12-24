﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRSkipAsync
{
    public class CS_LskipAsync
    {
        #region 共有領域
        private String _wbuf;
        private Boolean _empty;
        public String Wbuf
        {
            get
            {
                return (_wbuf);
            }
            set
            {
                _wbuf = value;
                if (_wbuf == null)
                {   // 設定情報は無し？
                    _empty = true;
                }
                else
                {
                    _empty = false;
                }
            }
        }
        private char[] _trim = { ' ', '\t', '\r', '\n' };
        #endregion

        #region コンストラクタ
        public CS_LskipAsync()
        {   // コンストラクタ
            this._wbuf = null;       // 設定情報無し
            this._empty = true;
        }
        #endregion

        #region モジュール
        public async Task Clear()
        {   // 作業領域の初期化
            this._wbuf = null;       // 設定情報無し
            this._empty = true;
        }

        // '14.01.07 : 評価対象に"￥ｒ"追加
        public async Task Exec()
        {   // 左側余白情報を削除
            if (!_empty)
            {   // バッファーに実装有り
                _wbuf = _wbuf.TrimStart(_trim);       // 左側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    await this.Clear();           // 作業領域の初期化
                }

            }
        }
        #endregion
    }
}
