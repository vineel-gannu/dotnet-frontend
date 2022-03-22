FROM mcr.microsoft.com/dotnet/sdk:5.0 AS buildStage
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /deploy
COPY --from=buildStage /app/out .
ENTRYPOINT ["dotnet", "FirstAPI.dll"]