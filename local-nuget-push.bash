#!/bin/bash

dotnet build
dotnet nuget push ./GameCoreLib/bin/Debug/GameCoreLib.1.0.1.nupkg -s /d/dev/nuget-repo