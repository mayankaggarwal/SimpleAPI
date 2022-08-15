# SimpleAPI

mkdir SimpleAPI
cd SimpleAPI
mkdir src
mkdir test
cd src
dotnet new webapi -n SimpleAPI.Api
cd test
dotnet new xunit -n SimpleAPI.Tests
dotnet new sln -n SimpleAPI
dotnet sln SimpleAPI.sln add src\SimpleAPI.Api\SimpleAPI.Api.csproj
dotnet sln SimpleAPI.sln add test\SimpleAPI.Tests\SimpleAPI.Tests.csproj
dotnet add test\SimpleAPI.Tests\SimpleAPI.Tests.csproj reference src\SimpleAPI.Api\SimpleAPI.Api.csproj
dotnet run --project src\SimpleAPI.Api\SimpleAPI.Api.csproj

git init
git add .
git commit -m "Initial Commit"
git remote add origin https://github.com/mayankaggarwal/SimpleAPI.git
git merge main --allow-unrelated-histories
git push --set-upstream origin master
