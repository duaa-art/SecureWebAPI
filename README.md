# Secure CI/CD Pipeline with Docker & Azure

This project demonstrates how to build a secure CI/CD pipeline for a containerized ASP.NET Web API using DevSecOps principles.

## Project Overview
The goal of this project is to:

- Automate build and deployment processes
- Use Docker for containerization
- Implement CI/CD using GitHub Actions
- Perform security scanning using Trivy
- Handle secrets securely using environment variables
- Deploy the application to Azure App Service

## CI/CD Pipeline
The pipeline performs the following steps:

1. Restore dependencies  
2. Build the project  
3. Build Docker image  
4. Push image to DockerHub  
5. Run security scan using Trivy  

## Docker
The application is containerized using Docker.

To run locally:

docker build -t securewebapi .
docker run -p 5001:8080 -e MY_SECRET=test securewebapi

 ## Secret Management
Sensitive data is NOT stored in the code.
Instead, environment variables are used:
MY_SECRET

Example endpoint:
/weatherforecast/secret

## Azure Deployment
The application is deployed to Azure App Service using Docker.

## Security Scanning
Trivy is used to scan the Docker image for vulnerabilities.