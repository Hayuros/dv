output: mcs.e mono.e clean
 
mcs.e:
	mcs Program.cs View/Cadastro/* View/Listagem/* View/Atualizacao/* View/Exclusao/* View/Biblio/* Model/* Controller/* Repository/*.cs -r:System.Windows.Forms.dll,System.Drawing.dll 
mono.e:
	mono Program.exe
 
clean:
	rm *.exe 