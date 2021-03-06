﻿using System;

namespace UpdateManpowerKOUsers
{
    class DataInExcel
    {
        double data;
        string userName;
        int month;

        public double Data { get => data; set => data = value; }
        public string UserName { get => userName; set => userName = value; }
        public int Month { get => month; set => month = value; }

        public DataInExcel(double data, int month, string userName)
        {
            Data = data;
            Month = month;
            UserName = userName;
            Console.WriteLine("{0} | {1} | {2}", Data, Month, UserName);
        }
    }

    class DataExcel
    {
        double data;
        string userName;
        string month;
        int numberMonth;

        public string UserName { get => userName; set => userName = value; }
        public string Month { get => month; set => month = value; }
        public double Data { get => data; set => data = value; }
        public int NumberMonth { get => numberMonth; set => numberMonth = value; }
    }
}
