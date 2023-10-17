# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /src
COPY . .
RUN dotnet restore "./internship-exercise-1/internship-exercise-1.csproj" --disable-parallel
RUN dotnet publish "./internship-exercise-1/internship-exercise-1.csproj" -c Release -o /app
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "internship-exercise-1.dll"]