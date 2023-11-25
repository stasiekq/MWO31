@echo off
setlocal enabledelayedexpansion

set "file=version"

if not exist %file% (
    cd MWO3.1
    if not exist %file% (
        echo File %file% does not exist.
        exit /b 1
    )
)

for /f %%a in (%file%) do (
    set /a "new_version=%%a + 1"
)

echo Incrementing version to %new_version%...

echo %new_version% > %file%

echo Version incremented and saved as %new_version%.

endlocal