ls -fi *.csproj -rec | % {  dotnet build $_.FullName }
ls -fi *.go -rec | % {  go build $_.FullName }
