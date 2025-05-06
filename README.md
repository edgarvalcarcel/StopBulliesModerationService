# 🛡️ StopBullies Moderation Service

**StopBulliesModerationService** is an AI-powered microservice responsible for real-time content moderation and cyberbullying detection. It forms a core part of the Stop-Bullies SaaS platform—designed to protect minors from online harassment through smart, scalable, and secure interventions.

## 🔍 Overview

This microservice leverages **Azure NLP** and optionally a **Python-based FastAPI module** for detecting emotional tone, offensive language, and high-risk content. Built using **.NET 8 and Clean Architecture**, it provides reliable, maintainable, and testable components that align with enterprise-grade standards.

## 🧩 Key Features

- 🔬 AI-driven analysis of text messages using Azure Text Analytics
- 🚨 Risk-level classification and moderation decision engine
- 📤 Integration with AlertService for escalation workflows
- 📜 Logs moderation results for audits and analytics
- 🔄 Extensible pipeline (supports external Python-based NLP)

## 🏗️ Architecture

This service is designed using **Clean Architecture** principles and organized into the following layers:

ModerationService/
├── Domain/ # Core business models and interfaces
├── Application/ # Use cases and DTOs
├── Infrastructure/ # Integration with Azure NLP and databases
├── Presentation/ # Web API interface
└── NLP/ # Python microservice (FastAPI)


> View full architecture and class diagrams in the `docs/` directory.

## 📦 Tech Stack

- **.NET 8**
- **Azure Cognitive Services (Text Analytics)**
- **FastAPI (Python NLP engine)**
- **PostgreSQL / Redis**
- **Azure Kubernetes Service (AKS)** for deployment

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Python 3.10+
- Azure subscription with Text Analytics enabled

### Run the API
```bash
dotnet build
dotnet run --project ModerationService.API
 
cd ModerationService.NLP

uvicorn analyzer:app --reload --port 8001
| Folder            | Description                             |
| ----------------- | --------------------------------------- |
| `Domain/`         | Core domain models and enums            |
| `Application/`    | Use cases, ports, and DTOs              |
| `Infrastructure/` | External services, repositories         |
| `Presentation/`   | ASP.NET Core Web API                    |
| `NLP/`            | Python-based sentiment/emotion analysis |

dotnet test

