
# Smart Finance
Sistema de Controle Financeiro

Sistema de Controle Financeiro desenvolvido para tornar o gerenciamento das finanças pessoais mais simples, prático e acessível.


# Tecnologias Usadas
[![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?logo=dotnet&logoColor=white)](https://learn.microsoft.com/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![Git](https://img.shields.io/badge/Git-F05032?logo=git&logoColor=white)](https://git-scm.com/)
[![GitHub](https://img.shields.io/badge/GitHub-181717?logo=github&logoColor=white)](https://github.com/)

## 📚Documentação

📌 Sobre o projeto
  
  O Smart Finance(Sistema de Controle Financeiro) surgiu a partir da percepção de que,na nossa sociedade cada vez mais tecnológica e dinamico, 
a nossa sociedade nescessita de solucoes que sejam praticas,rapidas e faceis de se utilizar.Nesse contexto surgiu a ideia de desenvolver uma 
ferramenta voltada pra esse controle financeiro

 💡 Justificativa

O avanço tecnológico transformou a forma como as pessoas realizam suas atividades no cotidiano, tornando a praticidade e a rapidez cada vez mais presentes na sociedade. No século XXI, principalmente entre os jovens, o acesso imediato à informação e às ferramentas digitais aumentou a busca por soluções simples e fáceis de utilizar. Nesse contexto, surgiu a ideia do Sistema de Controle Financeiro (SCF), com o propósito de facilitar a organização das finanças pessoais. A necessidade de controlar receitas, despesas e movimentações financeiras de maneira prática motivou o desenvolvimento da aplicação. Além disso, o projeto faz parte do Projeto Integrador do SENAC, permitindo aplicar na prática os conhecimentos adquiridos durante o curso. Dessa forma, o SCF busca unir tecnologia, praticidade e organização financeira em uma única solução.


  🎯 Objetivo

- 💰 Facilitar o registro de receitas e despesas;
- 📊 Permitir o acompanhamento das movimentações financeiras;
- 📅 Organizar as informações financeiras;
- 🔎 Facilitar a consulta dos registros;
- 📱 Desenvolver uma solução simples e acessível;
- 💻 Aplicar na prática os conhecimentos adquiridos durante a formação;
- 🚀 Desenvolver uma solução que possa evoluir futuramente para uma aplicação completa.



🎓 Habilidades desenvolvidas

O desenvolvimento do **Sistema de Controle Financeiro (SCF)** também tem como objetivo demonstrar, na prática, as habilidades e conhecimentos desenvolvidos durante o curso do **SENAC**.

Entre as principais habilidades aplicadas no projeto estão:

- 💻 Lógica de programação e desenvolvimento de sistemas;
- 🧩 Desenvolvimento e organização de aplicações;
- 🌐 Desenvolvimento de APIs;
- 🗄️ Modelagem e gerenciamento de banco de dados;
- 🔗 Integração entre aplicação e banco de dados;
- 🏗️ Organização e estruturação de projetos de software;
- 🔧 Utilização de ferramentas de desenvolvimento;
- 🐙 Utilização do Git e GitHub para controle de versão;
- 🔍 Identificação e correção de erros;
- 🧠 Resolução de problemas;
- 📋 Planejamento e organização de um projeto;


O projeto busca reunir esses conhecimentos em uma aplicação prática, demonstrando a evolução técnica adquirida durante a formação.

## ⚙️ Features

### 🟢 Versão 1.0 - Implementadas

#### 👤 Gestão de Usuários

- [x] Cadastro de novos usuários através de requisição HTTP POST
- [x] Geração de ID único
- [x] Salvamento no banco de dados

#### 💰 Movimentações Financeiras

- [x] Registro de receitas e despesas
- [x] Vinculação da transação a um usuário específico
- [x] Validação da existência do usuário
- [x] Utilização do tipo `decimal(18,2)` para valores monetários

#### 📋 Histórico de Transações

- [x] Listagem das transações por usuário
- [x] Retorno dos dados em formato JSON

#### 📊 Resumo Financeiro

- [x] Cálculo automático do saldo atual
- [x] Total de receitas
- [x] Total de despesas

#### 🖥️ Interface Web

- [x] Interface Dark Glassmorphism
- [x] Identidade visual da Morais Soluções em Tecnologia
- [x] Gráfico de rosca dinâmico com Chart.js
- [x] Atualização dos indicadores financeiros em tempo real

---

### 🔵 Versão 2.0 - Planejadas

#### 🏦 Contas Financeiras

- [ ] Cadastro de contas bancárias
- [ ] Cadastro de carteiras digitais
- [ ] Definição de saldo inicial
- [ ] Controle individual por conta

#### 🏷️ Categorias

- [ ] Categorias para receitas e despesas
- [ ] Organização por categoria

#### 📅 Contas Recorrentes

- [ ] Cadastro de contas mensais
- [ ] Controle de contas pendentes
- [ ] Controle de contas pagas
- [ ] Controle de contas vencidas

#### 💳 Contas a Pagar e Receber

- [ ] Controle de vencimentos
- [ ] Visualização de prazos
- [ ] Indicadores de contas próximas do vencimento

#### 🔐 Autenticação e Segurança
- [ ] Tela De Cadastro e Login De Usuario
- [ ] Hash de senhas com BCrypt
- [ ] Autenticação JWT
- [ ] Proteção das rotas da API
- [ ] Controle de acesso aos dados de cada usuário


#### 📈 Relatórios

- [ ] Filtros por período
- [ ] Relatórios mensais e anuais
- [ ] Filtros por categoria
- [ ] Exportação de dados


## 🛠️ Tecnologias utilizadas

### Backend
- C#
- .NET
- ASP.NET Core Web API
- Entity Framework Core

### Banco de Dados
- SQL Server

### Frontend
- HTML
- CSS
- JavaScript
- Chart.js
### Pré-requisitos

Antes de iniciar, certifique-se de ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Git](https://git-scm.com/)
- [Visual Studio Code](https://code.visualstudio.com/) - ou outra IDE compatível



## 📥 Installation
Clone o projeto e instale as dependências:

```bash
git init 
git clone https://github.com/moraisemaill-del/SistemaControleFinanceiro.git

#
```

Instalação e Configuração do Backend

Navegue até a pasta do backend:

```bash
cd backend
```

Restaure todas as dependências e pacotes NuGet do .NET:

```bash
dotnet restore
```

Verifique o arquivo de configuração da API em:

```text
backend/SRC/SCF.API/appsettings.json
```

Certifique-se de que a string de conexão esteja configurada para o seu SQL Server local:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SCF_FinanceiroDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

Instale a ferramenta de linha de comando do Entity Framework, caso ainda não esteja instalada:

```bash
dotnet tool install --global dotnet-ef
```

Execute as migrações para criar o banco de dados `SCF_FinanceiroDB` e suas respectivas tabelas:

```bash
dotnet ef database update --project SRC/SCF.Infrastructure/SCF.Infrastructure.csproj --startup-project SRC/SCF.API/SCF.API.csproj
```

Verifique se o projeto está compilando corretamente:

```bash
dotnet build
```

Inicie a execução da API:

```bash
dotnet run --project SRC/SCF.API/SCF.API.csproj
```

O terminal indicará a porta em que a API está sendo executada.

Exemplo:

```text
http://localhost:5039
```

### 4. Executando o Frontend

Abra a pasta `frontend` do projeto.

Certifique-se de que a constante `API_BASE` no arquivo `index.html` esteja apontando para a porta correta da API.

Exemplo:

```javascript
const API_BASE = "http://localhost:5039/api/transacoes";
```

Depois, abra o arquivo `index.html` diretamente no navegador ou utilize uma extensão como **Live Server** no Visual Studio Code.

### 🔌 Endpoints Principais da API

| Método | Endpoint | Descrição |
|---|---|---|
| `POST` | `/api/usuarios` | Cadastra um novo usuário |
| `POST` | `/api/transacoes` | Registra uma nova receita ou despesa |
| `GET` | `/api/transacoes/usuario/{id}` | Lista todas as movimentações do usuário |
| `GET` | `/api/transacoes/resumo/{id}` | Retorna o resumo financeiro com receitas, despesas e saldo atual |

### ⚠️ Observações

- O SQL Server deve estar em execução para que a aplicação consiga acessar o banco de dados.
- A porta da API pode variar de acordo com a configuração do ambiente.
- As dependências do backend são restauradas automaticamente pelo comando `dotnet restore`.
- O projeto está em desenvolvimento e novas funcionalidades serão adicionadas futuramente.## 📥 Installation

### 1. Pré-requisitos

Antes de iniciar o projeto, certifique-se de ter instalado:

- [Git](https://git-scm.com/)
- [.NET SDK](https://dotnet.microsoft.com/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms)
- [Visual Studio Code](https://code.visualstudio.com/) ou Visual Studio
- Navegador web atualizado

---

### 2. Clonar o Repositório

Abra o terminal (PowerShell, CMD ou Git Bash) e execute:

```bash
git clone URL_DO_REPOSITORIO
cd SistemaControleFinanceiro
```

---

### 3. Pacotes NuGet do Backend (.NET)

Os pacotes do backend são gerenciados automaticamente pelos arquivos `.csproj` de cada projeto.

Caso seja necessário instalá-los manualmente, utilize as dependências correspondentes a cada camada.

#### 🗄️ SCF.Infrastructure

Responsável pela persistência e comunicação com o banco de dados.

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Design`

**Comandos:**

```bash
dotnet add SRC/SCF.Infrastructure/SCF.Infrastructure.csproj package Microsoft.EntityFrameworkCore
dotnet add SRC/SCF.Infrastructure/SCF.Infrastructure.csproj package Microsoft.EntityFrameworkCore.SqlServer
dotnet add SRC/SCF.Infrastructure/SCF.Infrastructure.csproj package Microsoft.EntityFrameworkCore.Design
```

> Utilize versões compatíveis com a versão do .NET utilizada no projeto.

#### 🌐 SCF.API

Responsável pela API Web, controllers e inicialização da aplicação.

- `Microsoft.EntityFrameworkCore.Design`

**Comando:**

```bash
dotnet add SRC/SCF.API/SCF.API.csproj package Microsoft.EntityFrameworkCore.Design
```

---

### 4. Configuração do Backend

Navegue até a pasta do backend:

```bash
cd backend
```

Restaure todas as dependências e pacotes NuGet:

```bash
dotnet restore
```

Verifique o arquivo de configuração da API:

```text
backend/SRC/SCF.API/appsettings.json
```

Configure a string de conexão com o SQL Server:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SCF_FinanceiroDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

> A string de conexão deve ser ajustada de acordo com a configuração do SQL Server utilizada no ambiente.

---

### 5. Entity Framework Core

Caso a ferramenta `dotnet-ef` ainda não esteja instalada, execute:

```bash
dotnet tool install --global dotnet-ef
```

Para verificar se a ferramenta está instalada:

```bash
dotnet ef --version
```

---

### 6. Criar o Banco de Dados

Execute as migrations do Entity Framework Core para criar o banco de dados e suas respectivas tabelas:

```bash
dotnet ef database update --project SRC/SCF.Infrastructure/SCF.Infrastructure.csproj --startup-project SRC/SCF.API/SCF.API.csproj
```

Após a execução, o banco de dados `SCF_FinanceiroDB` deverá estar disponível no SQL Server.

---

### 7. Compilar o Backend

Verifique se o projeto está compilando corretamente:

```bash
dotnet build
```

Se não houver erros de compilação, o backend estará pronto para execução.

---

### 8. Executar o Backend

Inicie a API utilizando:

```bash
dotnet run --project SRC/SCF.API/SCF.API.csproj
```

O terminal exibirá o endereço em que a API está sendo executada.

Exemplo:

```text
http://localhost:5039
```

> A porta pode variar de acordo com a configuração do ambiente.

---

### 9. Configuração do Frontend

Abra a pasta:

```text
frontend
```

Localize o arquivo:

```text
index.html
```

Verifique a constante responsável pela URL da API:

```javascript
const API_BASE = "http://localhost:5039/api/transacoes";
```

Caso a API esteja utilizando outra porta, altere a URL de acordo com o endereço exibido no terminal.

---
---

## 🧪 Como Testar a API (.http)

Para testar os endpoints da API de forma rápida, você pode utilizar o arquivo **`SCF.API.http`** localizado na pasta `backend/SRC/SCF.API/SCF.API.http` utilizando extensões do VS Code (como *REST Client*) ou o próprio Visual Studio.

Cole o código abaixo dentro do seu arquivo `.http` para realizar os testes:

```http
@SCF_HostAddress = http://localhost:5039

### 1. Cadastrar um novo Usuário (POST)
POST {{SCF_HostAddress}}/api/usuarios
Content-Type: application/json

{
  "nome": "Carlos Teste",
  "email": "carlos@email.com",
  "senha": "123456"
}

###

### 2. Cadastrar uma Receita (POST)
POST {{SCF_HostAddress}}/api/transacoes
Content-Type: application/json

{
  "descricao": "Salário",
  "valor": 3000.00,
  "data": "2026-09-01T00:00:00",
  "tipo": "Receita",
  "usuarioId": 2
}

###

### 3. Cadastrar uma Despesa (POST)
POST {{SCF_HostAddress}}/api/transacoes
Content-Type: application/json

{
  "descricao": "Supermercado",
  "valor": 150.50,
  "data": "2026-09-28T00:00:00",
  "tipo": "Despesa",
  "usuarioId": 2
}

###

Clique em Send Request e ele retornara 200 ou 201 comfirmando que sua API esta funcionando


### 11. Executar o Frontend

O frontend pode ser executado diretamente pelo navegador abrindo o arquivo:

```text
frontend/index.html
```

Também é possível utilizar uma extensão como **Live Server** no Visual Studio Code para executar a aplicação localmente.

---

### 12. Verificação da Instalação

Com o backend e frontend configurados, verifique se o sistema consegue:

- [x] Iniciar a API
- [x] Conectar ao banco de dados
- [x] Cadastrar usuários
- [x] Registrar receitas e despesas
- [x] Consultar movimentações financeiras
- [x] Exibir o resumo financeiro

Após concluir essas etapas, o **Sistema de Controle Financeiro (SCF)** estará configurado para execução local.