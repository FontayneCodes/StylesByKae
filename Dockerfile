# ---------------------
# BUILD STAGE
# ---------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy all files to container
COPY . .

# Restore and publish the app
RUN dotnet publish -c Release -o /app/publish

# ---------------------
# RUNTIME STAGE
# ---------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy published files from build stage
COPY --from=build /app/publish .

# Open port 80
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "DemoHairSite.dll"]
