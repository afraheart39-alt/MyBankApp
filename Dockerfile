# Use the official ASP.NET Core runtime image from Microsoft
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
WORKDIR /app
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out EXPOSE.
ENTRYPOINT ["dotnet", "MyBankApp.dll","--urls","http://0.0.0.0:10000"]