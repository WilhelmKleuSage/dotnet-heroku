#!/bin/bash
# Install .NET Core on Codeship - https://www.microsoft.com/net/download/linux
#

set -e

mkdir $HOME/dotnet
curl -o dotnet.tar.gz -sSL https://download.microsoft.com/download/1/B/4/1B4DE605-8378-47A5-B01B-2C79D6C55519/dotnet-sdk-2.0.0-linux-x64.tar.gz
tar -xvf dotnet.tar.gz -C $HOME/dotnet
ln -s $HOME/dotnet/dotnet $HOME/bin/dotnet

dotnet --version