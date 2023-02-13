Microservices Architecture on .NET with applying CQRS, Clean Architecture and Event-Driven Communication
Building Microservices on .Net platforms which used Asp.Net Web API, Docker, RabbitMQ, gRPC, Ocelot API Gateway, MongoDB, Redis, PostgreSQL, SqlServer, Entity Framework Core, Dapper, CQRS and Clean Architecture implementation.

Introduction
Build microservices on .NET environments with using ASP.NET Core Web API applications, Docker for containerize and orchestrator, Microservices communications with gRPC and RabbitMQ and using API Gateways with Ocelot API Gateway, and using different databases platforms NoSQL(MongoDB, Redis) and Relational databases(PostgreSQL, SqlServer) and using Dapper, Entity Framework Core for ORM Tools, and using best practices CQRS with Clean Architecture implementation.

Implemented Apis with their details:

1.Catalog microservice which includes:
ASP.NET Core Web API application
REST API principles, CRUD operations
MongoDB NoSQL database connection on docker containerization
N-Layer implementation with Repository Pattern
Swagger Open API implementation
Dockerfile and docker-compose implementation

2.Basket microservice which includes:
ASP.NET Core Web API application
REST API principles, CRUD operations
Redis database connection on docker containerization
Consume Discount Grpc Service for inter-service sync communication to calculate product final price
Publish BasketCheckout Queue with using MassTransit and RabbitMQ
Swagger Open API implementation
Dockerfile and docker-compose implementation

3.Discount microservice which includes:
ASP.NET Grpc Server application
Build a Highly Performant inter-service gRPC Communication with Basket Microservice
Exposing Grpc Services with creating Protobuf messages
Using Dapper for micro-orm implementation to simplify data access and ensure high performance
PostgreSQL database connection and containerization
Dockerfile and docker-compose implementation

4.Microservices Communication
Sync inter-service gRPC Communication
Async Microservices Communication with RabbitMQ Message-Broker Service
Using RabbitMQ Publish/Subscribe Topic Exchange Model
Using MassTransit for abstraction over RabbitMQ Message-Broker system
Publishing BasketCheckout event queue from Basket microservices and Subscribing this event from Ordering microservices
Create RabbitMQ EventBus.Messages Common Class Library and add references Microservices

5.Ordering microservice which includes:
ASP.NET Core Web API application
Implementing DDD, CQRS and Clean Architecture with using Best Practices
Developing CQRS with using MediatR, FluentValidation and AutoMapper nuget packages
Consuming RabbitMQ BasketCheckout event queue with using MassTransit-RabbitMQ Configuration
SqlServer database connection and containerization
Using Entity Framework Core ORM and auto migrate to SqlServer when application Startup
Swagger Open API implementation
Dockerfile and docker-compose implementation

6.API Gateway Ocelot microservice which includes:
Implement API Gateways with Ocelot
Sample microservices/containers to reroute through the API Gateways
Run multiple different API Gateway/BFF container types
The Gateway aggregation pattern in Shopping.Aggregator
Dockerfile and docker-compose implementation
