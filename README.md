# Alpha Shop Microservices

## Introduction
This project is a study-oriented microservices-based architecture built with ASP.NET Core 8. It includes a variety of modern technologies and design patterns, often incorporating overengineering intentionally to experiment with best practices, architectural concepts, and cutting-edge features. The goal is to provide hands-on experience with Minimal APIs, CQRS, MediatR, DDD, event-driven communication, and more.

<h3>Roadmap</h3>  

![.NET Version](https://img.shields.io/badge/Catalog.API-Done-mediumgreen)
![.NET Version](https://img.shields.io/badge/Basket.API-Developing-blue)
![.NET Version](https://img.shields.io/badge/Discount.API-Pending-purple)
![.NET Version](https://img.shields.io/badge/Ordering.API-Pending-purple)
![.NET Version](https://img.shields.io/badge/API_Gateway-Pending-purple)
![.NET Version](https://img.shields.io/badge/Client-Pending-purple)


## Microservices Overview
### 1. **Catalog.API**
The Catalog.API is an independent service responsible for managing the product catalog. It follows a microservices architecture with Vertical Slice Architecture and CQRS, ensuring modularity, scalability, and system flexibility.

- **Technologies & Features:**
  - ASP.NET Core 8 Web API
  - PostgreSQL with Marten as Transactional Document DB
  - Minimal APIs with Carter Library
  - Redis for Distributed Caching
  - CQRS implementation with MediatR
  - Marten – ORM for PostgreSQL, enabling Event Sourcing and CQRS.

## Installation
### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [PostgreSQL](https://www.postgresql.org/download/)
<!-- - [RabbitMQ](https://www.rabbitmq.com/download.html) -->
<!-- - [Redis](https://redis.io/download/) -->

