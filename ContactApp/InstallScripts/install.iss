[Setup]
AppId={ae543de4-ba27-4cc7-98e2-678bcce7c247}
AppName={"ContactsApp"}
AppVersion={"1.0.0"}
AppPublisher={"Stanislav Isakov"}

OutputDir="setup"
OutputBaseFilename=Setup

Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl";
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

[Tasks]
Name: "desktopicon";
Description: "{cm:CreateDesktopIcon}";
GroupDescription: "{cm:AdditionalIcons}"; 
Flags: unchecked;    

[Files]
Source: "..\ContactAppUI\bin\Release\ContactAppUI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\ContactAppUI\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs