using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Dapper;
using BenchmarkDotNet.Running;
using EFDay15.Context;
using EFDay15.Entities;

namespace Benchmark
{
    class Program
    {

        static void Main()
        {

            var Summary = BenchmarkRunner.Run<Benchmarker>();

        }


    }

    public class Benchmarker
    {
        public static FrontEnd_ReservationContext Context = new();
        public static IDbConnection DapperCN = Context.Database.GetDbConnection();

        [Benchmark]
        public void DapperFun()
        {
            var results = DapperCN.Query<Reservation>("select * from Reservations");
        }

        [Benchmark]
        public void EFFun()
        {
            var results = Context.Reservations.AsNoTracking().ToList();
        }
    }
}