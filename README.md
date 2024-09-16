# API de Cadastro e Consulta de Regiões de Plantio
Integrantes do Grupo
- Caio Boris RM552496
- Denner Duarte RM
- Matheus Paulo Lima Delgado RM
- Nathaly Oliveira RM
- Lucas Petroni

**Descrição do Projeto**
Esta API foi desenvolvida para gerenciar o cadastro e a busca de regiões de plantio. Ela segue uma arquitetura de microsserviços utilizando o padrão Onion Architecture para garantir uma separação clara entre as camadas da aplicação e facilitar a manutenção e escalabilidade do sistema.

**Arquitetura Utilizada**
A API foi construída utilizando a Onion Architecture, que promove a separação de responsabilidades através de camadas bem definidas:

**Domínio:** Contém as regras de negócios, entidades e contratos que são agnósticos às tecnologias.
**Aplicação:** Responsável pela implementação dos casos de uso e orquestração das operações.
**Infraestrutura:** Trata das dependências externas, como bancos de dados, provedores de serviços e APIs externas.
**Apresentação:** O ponto de entrada da aplicação (controllers e endpoints).

**Microsserviços**
Cada funcionalidade da aplicação está distribuída em microsserviços independentes, permitindo que cada um seja escalado de forma autônoma, conforme a demanda.
Essa escolha traz escabalidade, segurança e maior modularidade para nosso sistema e permite que um trabalho com maior número de desenvolvedores possa ocorrer sem maiores dores de cabeça, quando comparamos com a arquitetura monolítica.

**Design Patterns Utilizados**
- **Singleton**

**Gerenciador de Configurações:** 
Utilizamos o padrão Singleton para garantir que apenas uma instância do gerenciador de configurações seja criada durante o ciclo de vida da aplicação. Isso permite um gerenciamento centralizado de configurações, como strings de conexão e outras variáveis de ambiente.

## Instruções para Rodar a API

**Pré-requisitos**
.NET SDK 8.0 ou superior
Banco de Dados Oracle

**1- Clone o repositório**

```console

git clone https://github.com/caioboris/dotnet_agroplus_sprint3.git
cd dotnet_agroplus_sprint3

```

**2- Adicione as credenciais do Oracle**

Dentro do appsettings.Development.json, adicione o UserId e o PasswordId;

**3- Restaurar dependências:**

```console

dotnet restore

```
**4- Executar as migrações do banco de dados**

```console

dotnet ef database update

```

**5- Rodar a aplicação**

```console

dotnet run

```

### Observações
O Objeto região possui o campo Enum RegiaoBR e deve ser preenchido com um dos seguintes valores:

```json
{
    "CENTRO_OESTE",
    "NORDESTE",
    "NORTE",
    "SUDESTE",
    "SUL"
}
```