﻿using carFixMgr0611.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.handler
{
    class OraHandler
    {
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=sqlDB;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;

        public OraHandler()
        {
            Console.WriteLine("객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        // 소멸자
        ~OraHandler()
        {
            Console.WriteLine("객체소멸");
            dbClose();
        }
        
        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오라클 접속 에러!");
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 해제 에러!");
            }
        }

        public void insertDb()
        {
            string model = "그랜저";
            string cc = "2500cc이하";
            string number = "23가 2345";
            string caryear = "2020년식";

            string query =
                string.Format("insert into car_t values " +
                "(CAR_T_SEQ.NEXTVAL,'{0}','{1}','{2}','{3}')",
                model, number, cc, caryear);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

        public void insertDb(Receipt receipt)
        {
            string query =
                string.Format("insert all" +
                "into car_t values (CAR_T_SEQ.NEXTVAL,'그랜저','13가1234','2500cc이하','2019년식')");
            
                query += string.Format("into CUSTOMER_T values " +
                    "(CUSTOMER_T_SEQ.NEXTVAL,'홍길동', " +
                    "'01023334333','19810520',CAR_T_SEQ.currval)");

            query += "select * from dual";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }
    }
}
