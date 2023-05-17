﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2.1.1
    class Song {
        //歌タイトル
        public string Title{ get; set; }
        //アーティスト名
        public string ArtistName { get; set; }
        //演奏時間（秒）
        public int Length { get; set; }
        //2.1.2
        public Song(string title,string artistname,int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
