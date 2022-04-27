create database EstoqueDB


create table Unidade(
    CodigoUnidade int not null identity,
    Sigla char(2) not null,
    Descricao varchar(60),
    Status int not null
)

alter table Unidade
add constraint PK_CodigoUnidade
primary key (CodigoUnidade)

create table Produto(
    CodigoProduto int not null identity,
    Nome varchar(60) not null,
    Descricao varchar(80),
    [Status] int not null,
    CodigoUnidade int not null,
    PrecoVenda money,
    PrecoCompra money
)

alter table Produto
add constraint PK_CodigoProduto
primary key (CodigoProduto)

alter table Produto
add constraint FK_Produto_Unidade
foreign key (CodigoUnidade) references Unidade(CodigoUnidade)



create table LocalEstoque(
    Id int not null identity,
    Codigo int not null,
    Nome varchar(60) not null,
    Descricao varchar(80)
)

alter table LocalEstoque
add constraint PK_LocalEstoque
primary key(Id)

create table Endereco(
    Id int not null identity,
    Cep varchar(10) not null,
    Logradouro nvarchar(200) not null,
    Complemento text,
    Bairro nvarchar(200) not null,
    Localidade nvarchar(200) not null,
    Uf char(2) not null,
    CodIbge varchar(20),
    CodDdd char(2)
)

alter table Endereco
add constraint PK_Endereco
primary key(Id)

create table CadastroGeral(
    Codigo int not null,
    TipoCadastro char(1) not null,
    [Status] tinyint not null,
    RazaoSocial varchar(80) not null,
    NomeFantasia varchar(80) not null,
    Cnpj_cpf varchar(15) not null,
    Telefone varchar(20) not null,
    Email varchar(60) not null,
    CodEndereco int
)

alter table CadastroGeral
add constraint PK_CadastroGeral
primary key(Codigo)

create table MovtoEntradaItem (
    Id int not null identity,
    CodigoProduto int not null,
    LocalEstoque int not null,
    QtdEntrada bigint not null,
    CodigoUnidade int not null
)

alter table MovtoEntradaItem
add constraint PK_MovtoEntradaItem
primary key(Id)

alter table MovtoEntradaItem
add constraint FK_EntradaItem_Produto
foreign key(CodigoProduto) references Produto(CodigoProduto)

alter table MovtoEntradaItem
add constraint FK_EntradaItem_LocalEstoque
foreign key(LocalEstoque) references LocalEstoque(Id)

alter table MovtoEntradaItem
add constraint FK_EntradaItem_CodigoUnidade
foreign key(CodigoUnidade) references Unidade(CodigoUnidade)

create table ProdutoSaldo(
    Id int not null identity,
    SaldoAnterior bigint,
    SaldoAtual bigint,
    CodigoProduto int not null,
    DataAtualizacao Datetime not null,
    LocalEstoque int not null
)

alter table ProdutoSaldo
add constraint PK_ProdutoSaldo
primary key(Id)

alter table ProdutoSaldo
add constraint FK_ProdutoSaldo_CodigoProduto
foreign key(CodigoProduto) references Produto(CodigoProduto)

alter table ProdutoSaldo
add constraint FK_ProdutoSaldo_LocalEstoque
foreign key(LocalEstoque) references LocalEstoque(Id)


create table MovtoEntrada(
    MovtoNumero int not null,
    DataEmissao Datetime not null,
    CodigoParticipante int not null
)

alter table MovtoEntrada
add constraint PK_MovtoEntrada
primary key(MovtoNumero)

alter table MovtoEntrada
add constraint FK_MovtoEntrada_CodigoParticipante
foreign key(CodigoParticipante) references CadastroGeral(Codigo)

alter table MovtoEntradaItem
add MovtoNumero int not null

alter table MovtoEntradaItem
add constraint FK_MovtoEntradaItem_MovtoEntrada
foreign key(MovtoNumero) references MovtoEntrada(MovtoNumero)

