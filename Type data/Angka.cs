int anInt = 10;

long aLong = 2000000000;

long luarBatas = 3000000000;

//3 milyar, melebihi batas int

 

anInt = (int)aLong;

Console.WriteLine(anInt);

//Akan tampil 2000000000

 

anInt = (int)luarBatas;

Console.WriteLine(anInt);

//Akan tampil -1294967296

 

Console.ReadKey();
