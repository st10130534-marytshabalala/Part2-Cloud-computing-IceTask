# Specify the base image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

# Set the working directory
WORKDIR /app

# Copy the csproj file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Set the command to run the app
CMD ["dotnet", "out/YourApp.dll"]

# Specify the base image
FROM mcr.microsoft.com/mssql/server:2019-latest

# Set the environment variables
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=YourStrongPassword

# Copy the SQL scripts
COPY init.sql /docker-entrypoint-initdb.d/

# Expose the database port
EXPOSE 1433