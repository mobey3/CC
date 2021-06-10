﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.RandData
{
    class Rand
    {
        string[] name = {"홍길동","김길동","박길동",
            "최길동","이길동"};
        string[] tel = {"010-1234-5678","010-4422-2222",
            "010-3321-5111","010-5000-1004","010-1110-4444"};
        string[] address = {"대구시 동구 신암4동",
                "서울시 동구 신암4동","부산시 동구 신암4동",
            "인천시 동구 신암4동","광주시 동구 신암4동"};
        string[] model = { "SM6", "K7", "그랜져", "쏘나타", "GV80" };
        string[] color = { "검정", "흰생", "파랑", "빨강", "쥐색" };
        int[] year = { 2015, 2016, 2017, 2018, 2020 };
        string[] company = { "르노", "기아", "현대", "현대", "현대" };
        
        Random t = new Random();

        public string getName()
        {
            return name[t.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[t.Next(0, 5)];
        }

        public string getAddress()
        {
            return address[t.Next(0, 5)];
        }

        public string getModel()
        {
            return model[t.Next(0, 5)];
        }

        public string getColor()
        {
            return color[t.Next(0, 5)];
        }
        
        public int getYear()
        {
            return year[t.Next(0, 5)];
        }

        public string getCompany()
        {
            return company[t.Next(0, 5)];
        }
    }
}
