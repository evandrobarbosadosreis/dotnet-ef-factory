# Exemplo: EF Design Time Factory

Em uma arquitetura multicamadas é normal que a classe `DbContext` e os arquivos de migrations do EntityFramework acabem ficando em um projeto separado da Webapi. 

Nesses casos, é necessário fornecer uma implementação da interface `IDesignTimeDbContextFactory`, que será responsável por instanciar o `DbContext` em tempo de design, permitindo a geração e aplicação das migrations. 

## Gerando as migrations em um projeto separado

Para gerar as migrations basta navegar até o projeto onde a implementação da factory e os arquivos de configuração com as connection strings se encontram:

    cd .\WebapiProject\

E executar a geração das migrations informando o projeto destino:

    dotnet ef migrations add migracao_inicial --project ..\MigrationsProject\

## Aplicando as migrations em bancos de homologação e produção

Primeiramente, defina as strings de conexão de produção e homologação nos arquivos appsettings.Development.json e appsettings.json, respectivamente.

Para aplicar as migrations nos bancos de produção e homologação, basta definir o cenário desejado em uma variável de ambiente chamada "ASPNETCORE_ENVIRONMENT".

### Homologação

Definindo o ambiente:

    $Env:ASPNETCORE_ENVIRONMENT='Development'

Aplicando as migrations no banco configurado no arquivo appsettings.Development.json:

    dotnet ef database update

### Produção

Definindo o ambiente:

    $Env:ASPNETCORE_ENVIRONMENT='Production'

Aplicando as migrations no banco configurado no arquivo appsettings.json:

    dotnet ef database update
    



