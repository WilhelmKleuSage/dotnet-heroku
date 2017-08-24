#!/bin/bash
# Run all test projects
#

find . -iname '*Tests.csproj' -exec dotnet test {} \;