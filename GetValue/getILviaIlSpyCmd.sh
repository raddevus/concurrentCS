# following cmd will disassemble the target dll into IL & store in out.il
# You have to have ilspycmd installed to use it.  Install via: dotnet tool install --global ilspycmd
ilspycmd bin/Debug/net10.0/GetValue.dll -il > out.il
