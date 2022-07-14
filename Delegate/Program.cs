using Delegates;
int[] m = new int[] { 1, -2, 3, -4, 5 };
var arr = new MyCollection(m);
var newarr=arr.ReturnCollection(Methods.per);
newarr.Print();

newarr.Biek(Methods.ChoiseMethod);


