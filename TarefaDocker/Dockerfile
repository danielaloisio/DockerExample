#define a imagem
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
#define nosso diret�rio de trabalho na pasta do aplicativo dentro do cont�iner
WORKDIR /app

# Copia csproj do seu ambiente para o cont�iner
COPY *.csproj ./
#Executa os comandos dentro do container
RUN dotnet restore

#Copia arquivos do seu ambiente para o container
COPY . ./
#Executa os comandos dentro do container
RUN dotnet publish -c Release -o out

#define a imagem runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
#define nosso diret�rio de trabalho na pasta do aplicativo dentro do cont�iner
WORKDIR /app
#Copia arquivo ambiente para o cont�iner
COPY --from=build-env /app/out .
#Define o aplicativo padr�o usado toda vez que um cont�iner � criado a partir da imagem
ENTRYPOINT ["dotnet", "TarefaDocker.dll"]