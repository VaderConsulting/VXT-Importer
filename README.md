# VXT Importer

C# VS 2008 WinForms that reads a bang-separated VXT phone.dat, lists unique divisions/departments, then imports the directory records. Form1 runs GetOUs then Import on load. phone.dat is not in the tree.

**Source last updated:** 2008-05-26 · **Language:** C# · **Target:** .NET Framework 2.0 · **Output:** WinForms exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Importer` | C# | WinForms exe (`AssemblyName` Importer, `RootNamespace` VXT_Importer) | Parses `!`-separated phone.dat. `GetOUs` collects unique Division and Department values (fields 7 and 8); `Import` walks more fields and prints directory records. |

## How to open

Open `VXT Importer.sln` in Visual Studio 2008 (solution format 10.00). Copy `Importer/Form1.cs.example` to `Importer/Form1.cs` and point at your phone.dat. The original Form1 path is gitignored because it contained a local username.

## Requirements

- Visual Studio 2008, .NET Framework 2.0

## Attribution and provenance

Working copy from my Historical Dev folder `VXT Importer`. Assembly title VXT Importer; assembly copyright 2008.

## License

MIT © 2026 VaderConsulting. See `LICENSE`.
