# Alpha Shop Microservices
[![GitHub license](https://img.shields.io/github/license/ricardocardoso-dev/AlphaShopMicroservices?color=brightgreen)](https://github.com/ricardocardoso-dev/AlphaShopMicroservices/blob/main/LICENSE)
[![GitHub issues](https://img.shields.io/github/issues/ricardocardoso-dev/AlphaShopMicroservices?color=brightgreen)](https://github.com/ricardocardoso-dev/AlphaShopMicroservices/issues)
[![GitHub stars](https://img.shields.io/github/stars/ricardocardoso-dev/AlphaShopMicroservices?color=brightgreen)](https://github.com/ricardocardoso-dev/AlphaShopMicroservices/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/ricardocardoso-dev/AlphaShopMicroservices?color=brightgreen)](https://github.com/ricardocardoso-dev/AlphaShopMicroservices/network)
[![GitHub last commit](https://img.shields.io/github/last-commit/ricardocardoso-dev/AlphaShopMicroservices?color=brightgreen)](https://github.com/ricardocardoso-dev/AlphaShopMicroservices/commits/main)
![Lines of code](https://tokei.rs/b1/github/ricardocardoso-dev/AlphaShopMicroservices?category=code)
![Files](https://tokei.rs/b1/github/ricardocardoso-dev/AlphaShopMicroservices?category=files)
[![wakatime](https://wakatime.com/badge/user/957be417-f277-4ae4-a449-e6bc5785d785/project/7c0b4c2b-fd48-4ca6-b2db-ec9aefef7da0.svg)](https://wakatime.com/badge/user/957be417-f277-4ae4-a449-e6bc5785d785/project/7c0b4c2b-fd48-4ca6-b2db-ec9aefef7da0)


## Introduction
This project is a study-oriented microservices-based architecture built with ASP.NET Core 8. It includes a variety of modern technologies and design patterns, often incorporating overengineering intentionally to experiment with best practices, architectural concepts, and cutting-edge features. The goal is to provide hands-on experience with Minimal APIs, CQRS, MediatR, DDD, event-driven communication, and more.

<h3>Roadmap</h3>  

![.NET Version](https://img.shields.io/badge/Catalog.API-Done-mediumgreen)
![.NET Version](https://img.shields.io/badge/Basket.API-Done-mediumgreen)
![.NET Version](https://img.shields.io/badge/Discount.gRPC-Done-mediumgreen)
![.NET Version](https://img.shields.io/badge/Ordering.API-Developing-blue)
![.NET Version](https://img.shields.io/badge/API_Gateway-Pending-purple)
![.NET Version](https://img.shields.io/badge/Client-Pending-purple)


## Microservices Overview
### 1. **Catalog.API**
The Catalog.API is an independent service responsible for managing the product catalog. It follows a microservices architecture with Vertical Slice Architecture and CQRS, ensuring modularity, scalability, and system flexibility.

- **Technologies & Features:**
  - ASP.NET Core 8 Web API
  - Carter Library for Minimal APIs implementations
  - MediatR for Command Query Responsibility Segregation (CQRS)
  - Marten for handling event sourcing, document storage, and complex data models in PostgreSQL.
  - Mapster for object mapping and transformation between DTOs and entities.
 
### 2. **Basket.API**
The Basket.API is an independent service designed to manage shopping basket data for users. It follows REST API principles and integrates with other services to provide a smooth and scalable checkout experience.

- **Technologies & Features:**
  - ASP.NET Core 8 Web API
  - Redis as a distributed cache (basketdb) for storing user baskets efficiently
  - Implements Proxy, Decorator, and Cache-aside design patterns
  - Consumes the Discount gRPC Service for inter-service communication to calculate the final price of products
  <!-- - Publishes checkout events using MassTransit and RabbitMQ to enable event-driven workflows -->

### 3. **Discount.gRPC**
The Discount.gRPC is a dedicated microservice that provides discount-related data via a high-performance gRPC server. It is primarily consumed by the Basket.API service to retrieve up-to-date discount information in a fast and reliable manner.

- **Technologies & Features:**
  - ASP.NET Core 8 gRPC Server application
  - Exposes gRPC services using Protobuf message definitions
  - Enables high-performance inter-service communication with Basket.API
  - Entity Framework Core with SQLite provider for data access and persistence
  - Database containerization with SQLite for lightweight deployment and integration
    
## Installation
### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [PostgreSQL](https://www.postgresql.org/download/)
<!-- - [RabbitMQ](https://www.rabbitmq.com/download.html) -->
<!-- - [Redis](https://redis.io/download/) -->

