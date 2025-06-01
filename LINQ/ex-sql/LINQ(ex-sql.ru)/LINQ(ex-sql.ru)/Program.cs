using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;  //  For the StackTrace.
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Castle.Core.Resource;
using nwind;


using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Reflection;


namespace ex_sql
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Computer db = new Computer(@"Data Source=.\SQLEXPRESS;Initial Catalog=computer;Integrated Security=SSPI;TrustServerCertificate=True");

            ex_1(db);
            ex_2(db);
            ex_3(db);
            ex_6(db);
        }
        
        static void ex_1(Computer db)
        {

            var custs =
            from c in db.PCs
            where c.Price < Convert.ToDecimal(500.0000)
            select c;
           
            Console.WriteLine("{0}\t|\t{1}", "HD", "Price");

            var line = string.Join("", Enumerable.Repeat('-', 25));
            Console.WriteLine("{0}", line);
            foreach (var c in custs)
            {
                Console.WriteLine("{0}\t|\t{1} {2}", c.Hd, c.Price, "|");
                Console.WriteLine("{0} ", line);
            }
        }


        static void ex_2(Computer db)
        {

            var custs =
            (from c in db.Products
             where 
                c.Type == "printer"

             select(c.Maker)).Distinct();

            Console.WriteLine("{0}", "Maker");

            var line = string.Join("", Enumerable.Repeat('-', 25));
            Console.WriteLine("{0}", line);
            foreach (var c in custs)
            {
                Console.WriteLine("{0}", c);
                Console.WriteLine("{0} ", line);
            }
        }

        static void ex_3(Computer db)
        {

            var custs =
            (from c in db.Products
             where
                c.Type == "printer"

             select (c));

             //var properties = custs.GetType().GetProperties();

             //var result = properties.Select(p => p.GetValue(custs));

            var line = string.Join("", Enumerable.Repeat('-', 25));
            Console.WriteLine("{0}", line);


            //IEnumerable<Product> custs = (from c in db.Products
            //                               select c).AsEnumerable();
            //ObservableCollection<Product> obs = new ObservableCollection<Product>(custs);






            var properties = custs.GetType().GetProperties();

            var result = properties.Select(p => p.GetValue(custs));

            foreach (var value in result)
            {
                Console.WriteLine(value.ToString());
            }
        }

        static void ex_6(Computer db)
        {
            var custs =
            (from l in db.Laptops
             join p in db.Products on l.Model equals p.Model

             where
               l.Hd >= 10

             group l by new { p.Maker, l.Speed } into groups
             orderby groups.Key.Maker, groups.Key.Speed ascending
             select new { groups.Key.Maker, groups.Key.Speed }

             );

            var line = string.Join("", Enumerable.Repeat('-', 25));           
            Console.WriteLine("{0}", line);

            foreach (var c in custs)
            {
                Console.WriteLine("{0}", c);
                Console.WriteLine("{0} ", line);
            }

        }

    }
}