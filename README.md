
#### Install IlSpyCmd
 - You have to have ilspycmd installed to use the script below.
 -  Install via: `dotnet tool install --global ilspycmd`
### disassemble target dll <br>
following cmd will disassemble the target dll into IL & store in out.il <br>
`ilspycmd bin/Debug/net10.0/GetValue.dll -il > out.il`
