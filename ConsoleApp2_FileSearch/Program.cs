using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_FileSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //メッセージ出力用
            StringBuilder infoMsg = new StringBuilder(100);

            //検索条件
            // string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //デスクトップフォルダ
            string targetDir = "." + "\\test\\";
            string fileExtension = "*.csv";
            string fileKeyword = "テスト";

            string errMsg = "";

            //説明文を作成
            infoMsg.AppendLine("以下の条件で、ファイルを検索します。");
            infoMsg.AppendLine(" １）対象フォルダ：" + targetDir);
            infoMsg.AppendLine(" ２）ファイル名のあいまい検索：" + fileKeyword);
            infoMsg.AppendLine(" ３）ファイル拡張子：" + fileExtension);

            //説明文を表示
            Console.WriteLine(infoMsg.ToString());

            Console.WriteLine("実行するには何かキーを押してください．．．");
            Console.ReadKey();

            //ファイルを検索
            string getCsvPath = ClassLinqManager.SearchFilePath(targetDir, fileExtension, fileKeyword, out errMsg);

            //検索結果を表示
            Console.WriteLine("");
            if (getCsvPath.Length > 0)
            {
                Console.WriteLine("検索結果：" + getCsvPath);
            }
            else if (errMsg.Length > 0)
            {
                Console.WriteLine("検索結果（エラー）：" + errMsg);
            }
            else
            {
                Console.WriteLine("検索結果：ヒットしませんでした。");
            }

            Console.WriteLine("");
            Console.WriteLine("終了するには何かキーを押してください．．．");
            Console.ReadKey();

        }
    }
}
