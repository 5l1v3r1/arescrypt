echo off
cls
echo Cleaning project files
if exist "arescrypt/bin/Debug" (
	if exist "arescrypt\bin\Debug\arescrypt.exe" del /Q "arescrypt\bin\Debug\arescrypt.exe"
	if exist "arescrypt\bin\Debug\arescrypt.exe.config" del /Q "arescrypt\bin\Debug\arescrypt.exe.config"
	if exist "arescrypt\bin\Debug\arescrypt.pdb" del /Q "arescrypt\bin\Debug\arescrypt.pdb"
)
if exist "arescrypt/bin/Release" (
	if exist "arescrypt\bin\Release\arescrypt.exe" del /Q "arescrypt\bin\Release\arescrypt.exe"
	if exist "arescrypt\bin\Release\arescrypt.exe.config" del /Q "arescrypt\bin\Release\arescrypt.exe.config"
	if exist "arescrypt\bin\Release\arescrypt.pdb" del /Q "arescrypt\bin\Release\arescrypt.pdb"
)
echo All project files have been erased...