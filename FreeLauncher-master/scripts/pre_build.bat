@ECHO OFF
SETLOCAL ENABLEDELAYEDEXPANSION
SET VERSION=%~1
SET PROJECTDIR=%CD%

FOR /F "TOKENS=*" %%A IN ('git rev-parse --short HEAD') DO SET SHORTHASH=%%A

IF NOT DEFINED APPVEYOR_REPO_BRANCH GOTO APPVEYORNOTDEFINED
SET BRANCH=%APPVEYOR_REPO_BRANCH%
GOTO EXITAPPVEYOR
:APPVEYORNOTDEFINED
FOR /F "TOKENS=*" %%A IN ('git rev-parse --abbrev-ref HEAD') DO SET BRANCH=%%A
:EXITAPPVEYOR

FOR /F "TOKENS=4 DELIMS=." %%A IN ("%VERSION%") DO SET REVISION=%%A
CALL SET REVISION=.%REVISION%

CALL SET VERSION=%%VERSION:%REVISION%=%%

ECHO Step 1/1: Patching AssemblyInfo.cs
CD %PROJECTDIR%\Properties\
COPY AssemblyInfo.cs AssemblyInfo.cs.tmp
ECHO [assembly: AssemblyInformationalVersion("%VERSION%_%BRANCH%.%SHORTHASH%")] >> AssemblyInfo.cs

ECHO Finishing script...