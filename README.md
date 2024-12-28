# DevFreela - Plataforma de Conexão entre Clientes e Freelancers

O **DevFreela** é uma plataforma criada para conectar **clientes** e **freelancers** da área de **tecnologia**. O projeto foi desenvolvido como parte da formação na **Mentoria .NET Start**, promovida pela **Next Wave Education**, utilizando **ASP.NET Core**.

Este repositório contém a API completa do projeto, com diversas funcionalidades para o gerenciamento de projetos de freelancers, incluindo cadastro de usuários, postagem de oportunidades de trabalho, troca de mensagens, entre outros.

## Funcionalidades

- **Cadastro de Usuários**: Permite cadastrar usuários, tanto como **clientes** quanto como **freelancers**.
- **Cadastro de Projetos**: Clientes podem criar e gerenciar oportunidades de projetos.
- **Mensagens e Comentários**: Freelancers e clientes podem interagir diretamente através de mensagens e comentários.
- **Gestão de Projetos**: Acompanhamento do status do projeto, incluindo início, progresso e conclusão.
- **Atualização de Saldo**: Freelancers têm seu saldo atualizado automaticamente após a conclusão de um projeto.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework principal para o desenvolvimento da API.
- **Entity Framework**: Utilizado para o acesso e gerenciamento dos dados no banco.
- **Arquitetura Limpa**: Implementação de boas práticas para uma arquitetura escalável e fácil de manter.
- **Padrão Repository**: Para abstração do acesso aos dados.
- **Fluent Validation**: Para validação de dados de entrada, garantindo que os dados sejam válidos antes de serem processados.
- **CQRS com MediatR**: Implementação do padrão CQRS para separar as operações de leitura e escrita na aplicação, utilizando MediatR para comunicação entre componentes.

## Como Rodar o Projeto

1. **Clonar o Repositório**:  
   Clone o repositório para o seu computador:

   ```bash
   git clone https://github.com/SeuUsuario/DevFreela.git

2. **Instalar Dependências**:
  Navegue até a pasta do projeto e instale as dependências necessárias:

  ```bash
cd DevFreela
dotnet restore
  ```
3. **Configurar Banco de Dados**:
  Para rodar o projeto localmente, é necessário configurar o banco de dados. Configure a string de conexão no arquivo appsettings.json.

4. **Rodar a API**:
  Após a configuração do banco de dados, rode a API localmente executando o seguinte comando no prompt de comando:

  ```bash
dotnet run
  ```
5. **Testar a API**:
  Agora você pode testar a API utilizando ferramentas como Postman ou Insomnia.

## Contribuições
  Se você quiser contribuir para o projeto, fique à vontade para abrir issues ou pull requests. Toda contribuição é bem-vinda!

## Licença
  Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.

## Agradecimentos
  Agradeço à Next Wave Education e ao professor Luis Felipe pela mentoria e apoio ao longo dessa jornada de aprendizado.

