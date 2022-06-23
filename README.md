# WinverCLI
Basic printing of the current Windows Version

Logic taken from [JDU2600's code](https://github.com/jdu2600/Windows10EtwEvents), it collects
version names from these registry values under `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion`:
- ProductName
- ReleaseId
- BuildLabEx

Winvercli will print the combinded string to the console, and if you pass in a filename as
an argument it will also write it to that file.
