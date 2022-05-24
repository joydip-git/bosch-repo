using System;
using FirstLibrary;

namespace FirstApp
{
	class Sample
	{
		static void Main()
		{
			LibCls libClsObj = new LibCls();
			Console.WriteLine(libClsObj.GetMessage());
			Console.WriteLine("Hello everyone");
		}
	}
}

/*
mscorlib.dll <-- library --> LibCls.dll
System <-- namespace ---> FirstLibrary
Console <-- class ---> LibCls
namespace System{ class Console { public static void WriteLine(){} } }
*/