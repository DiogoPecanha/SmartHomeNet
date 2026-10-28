# Desafio técnico — Backend Pleno .NET (1 hora)

## Objetivo
Evoluir uma API inicial para gerenciamento de casas inteligentes. O ambiente já está preparado para execução em Docker; use o tempo do desafio para implementar uma regra de negócio, demonstrar qualidade de código e explicar suas decisões.

## Cenário
A plataforma oferece três planos:
- **Freemium:** 1 casa e até 10 dispositivos por casa; não permite automações.
- **Básico:** até 5 casas, até 50 dispositivos por casa e até 10 automações simples.
- **Avançado:** casas e dispositivos sem limite definido e permite automações simples ou condicionais.

## Tarefa principal (priorize esta)
Implemente a regra de cadastro de dispositivos, garantindo que:
1. O dispositivo pertença a uma casa existente.
2. A casa pertença à conta/usuário informado na requisição.
3. O limite de dispositivos por casa seja respeitado de acordo com o plano.
4. A API retorne status HTTP e mensagens de erro apropriados.

Se concluir antes do fim, implemente **uma** melhoria adicional:
- validar o limite de casas ao criar uma casa; ou
- impedir automações em contas Freemium; ou
- adicionar testes automatizados para cenários de limite e erro.

Não é esperado implementar toda a plataforma. Priorizamos a correção da regra escolhida, clareza, testes e capacidade de explicar trade-offs.

## Regras para a sessão
- Duração: **60 minutos**.
- Você pode consultar a documentação oficial e usar ferramentas de desenvolvimento disponíveis conforme orientação do entrevistador.
- Explique brevemente suas decisões e o que faria diferente com mais tempo.
- Se algo ficar incompleto, registre o que faltou e como terminaria.

## Stack
- C# / ASP.NET Core 7 Web API
- Entity Framework Core 7
- PostgreSQL
- xUnit
- Docker Compose

> Nota: .NET 7 está fora do período de suporte oficial. Ele é usado aqui para manter o desafio alinhado à stack solicitada. Para projetos novos, prefira uma versão suportada do .NET.

## Executar com Docker

Pré-requisitos: Docker Desktop ou Docker Engine com Docker Compose.

Na raiz do repositório:

```bash
docker compose up --build
```

API: http://localhost:8080  
Swagger: http://localhost:8080/swagger  
Health check: http://localhost:8080/health  
PostgreSQL: `localhost:5432` (banco `smarthome`, usuário `postgres`, senha `postgres` — somente para uso local no desafio).

Parar os containers:

```bash
docker compose down
```

Remover também os dados locais do banco:

```bash
docker compose down -v
```

## Estrutura

```text
src/SmartHome.Api/
  Data/SmartHomeDbContext.cs
  Models/
  Program.cs
  SmartHome.Api.csproj
tests/SmartHome.Api.Tests/
docker-compose.yml
Dockerfile
```

## Pontos de partida
- Os modelos e o `DbContext` são um esqueleto inicial, não uma solução completa.
- O banco é disponibilizado pelo Compose; configure e execute migrações se forem necessárias para sua implementação.
- A API inclui `/health` e Swagger para facilitar a verificação do ambiente.
- Adicione testes para a regra que implementar.
