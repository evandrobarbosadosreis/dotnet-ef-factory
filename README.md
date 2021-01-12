# Exemplo: EF Design Time Factory

Em uma arquitetura multicamadas é normal que a classe DbContext e os arquivos de migrations do EntityFramework acabem ficando em um projeto separado da Webapi. Nesses casos, é necessário fornecer uma implementação da interface `IDesignTimeDbContextFactory`, que será responsável por instanciar o DbContext em tempo de design durante a geração e aplicação das migrations no banco de dados. 

Este projeto consiste na implementação desta interface, mostrando como é possível gerar e aplicar as migrations em bases de homologação e produção.
