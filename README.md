# DotnetWatchBug

## How to reproduce the bug?

- Run `dotnet restore` in the solution root
- Run `dotnet watch run --project API` in the solution root and see that it exited with error code 134.
- Go inside `API` project folder: `cd API`
- Run `dotnet watch run` andd see that the API project starts without issue.
