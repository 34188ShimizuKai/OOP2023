using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();//点数データを格納する
            var lines = File.ReadAllLines(filePath);//ファイルからすべてのデータを読み込む


            foreach (var line in lines)
            {//すべての行から１行ずつ取り出す
                var items = line.Split(',');//区切りで項目別に分ける


                var student = new Student
                {//Saleインスタンスを生成　
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student);//Studentインスタンスをコレクションに追加
            }

            return scores;







        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (Student score in _score)
            {
                if (dict.ContainsKey(score.Subject))
                    dict[score.Subject] += score.Score;//生徒が既に存在する（点数加算）
                else
                    dict[score.Subject] = score.Score; //生徒が存在しない（新規格納）
            }
            return dict;
        }
    }
}
