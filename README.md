# Issue [NuGet/Home#9716](https://github.com/NuGet/Home/issues/9716)

## Steps to reproduce

1. Open **Developer PowerShell for VS 2019**
2. Go to the directory that you want to extract e.g. `cd ~\source\local\202006251136` <kbd>ENTER</kbd>
3. Clone the repository via `git clone https://github.com/cilerler/issue_nuget-home-9716.git` <kbd>ENTER</kbd>
4. Build the package via `.\tools\restore-build-pack.ps1` <kbd>ENTER</kbd>
5. Ensure that `nupkg` file exists via `dir .\artifacts\packages\` <kbd>ENTER</kbd>
6. Review the output via `dir .\ConsoleApp1\bin\Debug\` <kbd>ENTER</kbd>

## Side notes

1. File appears if I directly reference the project file, instead of using NUPKG file
2. Use `Remove-Item -LiteralPath ".\artifacts\packages\" -Force -Recurse` to delete the package
