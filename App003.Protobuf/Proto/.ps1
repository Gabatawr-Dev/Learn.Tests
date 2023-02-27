param ($soldir, $prjdir)

Remove-Item -Path ./Generated -Filter *.cs -Recurse

Get-ChildItem -Path ./ -Filter *.proto -Recurse | ForEach-Object {
    protoc --proto_path=$soldir --csharp_out=$prjdir\Proto\Generated\ $_.FullName
}