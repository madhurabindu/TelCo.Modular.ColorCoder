echo 1
set /a errorlevel=0
echo 2
for %%i in (*.cs) do (set /a file=%%i
  echo 3
  set /a cnt=0
  echo %%i
  echo File name: %%~ni
  for /f %%a in ('type "%file%"^|find "" /v /c') do set /a cnt=%%a
	echo %file% has %cnt% lines
	if (cnt GEQ 100) exit 300 
   
)
