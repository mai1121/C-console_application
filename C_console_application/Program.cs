using System;

namespace C_console_application
{
    class Program
    {
        static void Main(string[] args)
        {
            //文字列への変数展開
            var name1 = "いそべやん";
            var name2 = "オンタン";
            Console.WriteLine($"こんにちは、{name1}さん");
            //逐語的文字列リテラル。改行もそのまま表現できる
            Console.WriteLine($@"こんにちは、{name1}さん
            こんにちは、{name2}さん
            ");

            //入力値の受け取り。文字列で受け取られる
            Console.WriteLine("朝食に食べたパンの種類を入力してください");
            var a = Console.ReadLine();
            Console.WriteLine("食べた個数を入力してください");
            var b = Console.ReadLine();
            Console.WriteLine($"あなたは{a}を{b}個食べました");
            //文字列→数値への変換は数値型のクラスからParseメソッドを呼び出し
            var c = 1 + int.Parse(b);
            Console.WriteLine($"私とあなたで合わせて{c}個食べました");
            //数値→文字列変換はTostringメソッド呼び出し
            Console.WriteLine(c.ToString());


            //配列宣言方法①
            int[] data1 = { 1, 2, 3, 4, 5 };
            //配列宣言方法②
            var data2 = new[] { "りんご", "みかん", "ぶどう" };
            //多次元配列
            var data3 = new[,] { { 10, 20 }, { 30, 40 } };
            Console.WriteLine($"{data2[2]}を{data3[0,1]}個食べた");
        }
    }
}
