#!/bin/bash
# Run all test projects
#
EXIT_STATUS=0
for f in $(find . -iname '*Tests.csproj'); do
    dotnet test $f || EXIT_STATUS=1
done
exit $EXIT_STATUS