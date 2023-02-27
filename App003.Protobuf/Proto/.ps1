param ($soldir, $prjdir)

Get-ChildItem -Path ./ -Filter *.proto -Recurse | ForEach-Object {
    protoc --proto_path=$soldir --csharp_out=$prjdir\Proto\Generated\ $_.FullName
}