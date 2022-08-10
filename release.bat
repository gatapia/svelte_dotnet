rmdir /S /Q release &&^
rmdir /S /Q srv\bin\Release\net6.0\publish\ &&^
if not exist "release" mkdir release &&^
if not exist "release\wwwroot" mkdir release\wwwroot &&^
dotnet publish --configuration Release srv\srv.csproj &&^
xcopy /S /Y /C /E /Q srv\bin\Release\net6.0\publish\*.* release\ &&^
pushd web &&^
npx vite build &&^
xcopy /S /Y build\*.* ..\release\wwwroot\ &&^
popd
