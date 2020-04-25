#!/bin/bash

dotnet build
dotnet nuget push ./GameCoreLib/bin/Debug/*.nupkg -s /d/dev/nuget-repo