using Autofac;
using EstoqueApp.Database;
using EstoqueApp.Interfaces;
using EstoqueApp.Repositories;
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
            builder.RegisterType<LocalEstoqueRepository>().As<ILocalEstoqueRepository>();
            builder.RegisterType<TipoCadastroRepository>().As<ITipoCadastroRepository>();
            builder.RegisterType<CepRepository>().As<ICepService>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<CadastroRepository>().As<ICadastroRepository>();
            builder.RegisterType<MovtoEntradaRepository>().As<IMovtoEntradaRepository>();
            builder.RegisterType<MovtoEntradaItemRepository>().As<IMovtoEntradaItemRepository>();
            builder.RegisterType<ProdutoSaldoRepository>().As<IProdutoSaldoRepository>();
            builder.RegisterType<MovtoSaidaRepository>().As<IMovtoSaidaRepository>();
            builder.RegisterType<MovtoSaidaItemRepository>().As<IMovtoSaidaItemRepository>();
            Container = builder.Build();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_inicio());
        }
    }
}
