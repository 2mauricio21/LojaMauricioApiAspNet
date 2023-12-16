# API de Loja em ASP.NET Core

Este projeto � uma API de loja desenvolvida em ASP.NET Core que gerencia tr�s entidades principais: Fornecedor, Contrato e Produto.

## Funcionalidades

- **Autentica��o com JWT Token:** A API possui um sistema de autentica��o utilizando JWT Token.
- **Autentica��o Necess�ria para Opera��es Espec�ficas:** Para deletar um fornecedor, realizar um GET em contratos ou deletar um contrato, � necess�rio estar autenticado.
- **Cadastro de Usu�rios Mocado:**
  - **Usu�rio Admin:**
    - **ID:** 1
    - **Username:** admin
    - **Senha:** admin
    - **Roles:** manager
  - **Usu�rio Empregado:**
    - **ID:** 2
    - **Username:** empregado
    - **Senha:** empregado
    - **Roles:** employee

## Autentica��o na API

- Para se autenticar, utilize o Swagger.
- O login no Swagger retornar� um token.
- Para autenticar, v� para a se��o de autentica��o no Swagger e insira o token obtido anteriormente com a palavra Bearer antes(sem aspas) no campo "Bearer Token". Ap�s isso, ser� poss�vel fazer consultas.

## Endpoints Principais

### CRUD Fornecedor

- **Criar Fornecedor:** M�todo POST `/api/fornecedor`
- **Atualizar Fornecedor:** M�todo PUT `/api/fornecedor`
- **Deletar Fornecedor:** M�todo DELETE `/api/fornecedor/{id}`
- **Consultar Fornecedores:** M�todo GET `/api/fornecedor`
- **Consultar Fornecedor por ID:** M�todo GET `/api/fornecedor/{id}`
- Autentica��o necess�ria para deletar, criar e atualizar: Sim

### CRUD Contrato

- **Criar Contrato:** M�todo POST `/api/contrato`
- **Atualizar Contrato:** M�todo PUT `/api/contrato`
- **Deletar Contrato:** M�todo DELETE `/api/contrato/{id}`
- **Consultar Contratos:** M�todo GET `/api/contrato`
- **Consultar Contrato por ID:** M�todo GET `/api/contrato/{id}`
- Autentica��o necess�ria para deletar, criar e atualizar: Sim

### CRUD Produto

- **Criar Produto:** M�todo POST `/api/produto`
- **Atualizar Produto:** M�todo PUT `/api/produto`
- **Deletar Produto:** M�todo DELETE `/api/produto/{id}`
- **Consultar Produtos:** M�todo GET `/api/produto`
- **Consultar Produto por ID:** M�todo GET `/api/produto/{id}`
- Autentica��o necess�ria para deletar, criar e atualizar: Sim

## Configura��o do Banco de Dados

- O sistema � feito em Firestore. Para executar a solu��o, siga os passos abaixo:
  1. Crie o banco de dados no Firestore (gratuito).
  2. Baixe o arquivo de configura��o gerado pelo Firestore.
  3. Coloque o arquivo de configura��o na pasta raiz do projeto.
  4. No diret�rio "Utils", acesse o arquivo "Settings.cs".
  5. Para a vari�vel "arquivoApikey", defina o nome do arquivo gerado pelo Firestore (algo como db-projeto-797d7-firebase-adminsdk-31mk9-bba77c5048).
  6. Para a vari�vel "projectId", defina o nome do projeto criado no Firestore (algo como db-projeto-797d7).

## Como Executar o Projeto

- Clone este reposit�rio.
- Abra o projeto em um ambiente de desenvolvimento (Visual Studio, Visual Studio Code, etc.).
- Execute a aplica��o.

## Depend�ncias

- ASP.NET Core
- JWT Authentication
- Firestore
- Swagger

## Contribui��o

Contribui��es s�o bem-vindas! Sinta-se � vontade para propor melhorias, novas funcionalidades ou corre��es de bugs.
