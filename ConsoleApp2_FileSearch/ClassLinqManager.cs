
using System;
//using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Text;

namespace ConsoleApp2_FileSearch
{
    class ClassLinqManager
    {

        /// <summary>
        /// 対象フォルダ配下にある特定ファイルを検索
        /// </summary>
        /// <param name="dirPath">対象フォルダのパス</param>
        /// <param name="extension">ファイル拡張子</param>
        /// <param name="keyword">ファイル名に含まれる検索キーワード</param>
        /// <param name="errMsg">エラーメッセージ</param>
        /// <returns></returns>
        public static string SearchFilePath(string dirPath , string extension, string keyword, out string errMsg)
        {
            string getPath = "";

            errMsg = "";
            try
            {
                // LINQ query for all .txt files containing the word ＜keyword＞.
                var targetFile = (from file in Directory.EnumerateFiles(@dirPath, extension)
                                  where file.Contains(keyword)
                                  select file).FirstOrDefault();
                if (targetFile != null)
                {
                    getPath = targetFile.ToString();
                }

            }catch(Exception ex)
            {
                getPath = "";
                errMsg = ex.Message;
            }

            return getPath;

        }

    }
}
