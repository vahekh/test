FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore 
COPY . ./
RUN dotnet build "WebAppCoreL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebAppCoreL.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebAppCoreL.dll"]

#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
#WORKDIR /src
#COPY ["WebAppCoreL/WebAppCoreL.csproj", "WebAppCoreL/"]
#RUN dotnet restore "WebAppCoreL/WebAppCoreL.csproj"
#COPY . .
#WORKDIR "/src/WebAppCoreL"
#RUN dotnet build "WebAppCoreL.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "WebAppCoreL.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "WebAppCoreL.dll"]