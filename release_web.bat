pushd web &&^
npx vite build &&^
xcopy /S /Y build\*.* ..\release\wwwroot\ &&^
popd