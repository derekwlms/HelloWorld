#!/bin/bash
rm -rf ../build-artifacts
dotnet clean
dotnet publish -o ../build-artifacts -r linux-x64 ./TnNext.Web/TnNext.Web.csproj
