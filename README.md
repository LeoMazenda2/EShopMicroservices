# 🛒 EShopMicroservices

Este repositório contém a implementação prática do curso **“.NET 8 Microservices: DDD, CQRS, Vertical/Clean Architecture”** (Udemy), que concluí com sucesso — e que marca a **terceira vez** que estudo microserviços, agora com ainda mais profundidade.

## ✅ O que foi construído

Um sistema de e-commerce modular baseado em arquitetura de microserviços, usando:

- **.NET 8 Web API & Minimal APIs**
- **CQRS com MediatR** e validações com **FluentValidation**
- **DDD (Domain-Driven Design)**
- **Arquitetura Vertical Slice e Clean Architecture**
- **Comunicação assíncrona com RabbitMQ + MassTransit**
- **Comunicação síncrona com gRPC**
- **Redis como cache distribuído**
- **PostgreSQL, SQL Server, Marten e SQLite para persistência**
- **API Gateway com YARP Reverse Proxy**
- **Containerização e orquestração com Docker & Docker Compose**
- **Frontend ASP.NET Razor Pages consumindo APIs via Refit**

---


---

## 🎯 Objectivo do Projeto

Consolidar boas práticas de desenvolvimento com .NET 8 em ambientes distribuídos e cloud-native, com foco em escalabilidade, modularidade e comunicação eficiente entre serviços.

---

## 🧠 O que aprendi

- Como estruturar uma solução real de microserviços do zero
- Aplicar DDD com CQRS de forma eficiente e desacoplada
- Integrar serviços usando **eventos assíncronos com RabbitMQ**
- Implementar **Gateways com YARP** e aplicar padrões como BFF e Rate Limiting
- Criar pipelines com validação, logging, exception handling e health checks
- Gerir múltiplas bases de dados (SQL + NoSQL) com EF Core e Marten

---

## 🐳 Docker & Orquestração

Este projeto é 100% containerizado e pronto para ser orquestrado via `docker-compose`. Basta executar:

```bash
docker-compose up --build
