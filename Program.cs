﻿using Autofac;
using EstoqueApp.Database;
using EstoqueApp.Interfaces;
using EstoqueApp.Repositories;
using System;
using System.Windows.Forms;

namespace EstoqueApp
{
    internal static class Program
    {
        public static IContainer Container;
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Connection>().As<IConnectionService>();
            builder.RegisterType<UnidadeRepository>().As<IUnidadeRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
            Container = builder.Build();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_inicio());
        }
    }
}
