#define a imagem
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
#define nosso diretório de trabalho na pasta do aplicativo dentro do contâiner
WORKDIR /app

# Copia csproj do seu ambiente para o contâiner
COPY *.csproj ./
#Executa comando
RUN dotnet restore

# Copia arquivos do seu ambiente para o contâiner
COPY . ./
#Executa comando
RUN dotnet publish -c Release -o out

#define a imagem runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
#define nosso diretório de trabalho na pasta do aplicativo dentro do contâiner
WORKDIR /app
#Copia arquivo ambiente para o contâiner
COPY --from=build-env /app/out .
#Define o aplicativo padrão usado toda vez que um contêiner é criado a partir da imagem
ENTRYPOINT ["dotnet", "TarefaDocker.dll"]