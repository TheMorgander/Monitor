Dim objShell, commandlineString
Set objShell = CreateObject( "WScript.Shell" )
objShell.run "schtasks /CREATE /F /SC ONLOGON /RL HIGHEST /TN ""Monitor"" /TR ""C:\Program Files (x86)\TheMorgander\Monitor\Monitor.exe""" ,1,False