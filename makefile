
open.exe: open.cs
	csc /out:open.exe open.cs

clean:
	@rm -f open.exe
