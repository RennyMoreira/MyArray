

using MyArray.Logic;
Console.WriteLine("==============Array=========");
try
{
    var array = new Arreglos(20);
    array.Fill(1, 20);
    array.Sort();
    Console.WriteLine(array);
    Console.WriteLine("===============Repetidos===============");
    var siRepetidos = array.Repetidos();
    siRepetidos.Sort();
    Console.WriteLine(siRepetidos);





    //Console.WriteLine("===============NoRepetidos===============");
    //var nonRepet = array.NotRepetidos();
    //nonRepet.Sort();
    //Console.WriteLine(nonRepet);



    /*Console.WriteLine("=============Primos============");
    var getPrimos = array.Primo();
    Console.WriteLine(getPrimos.N);*/




    //int[,] myMatriz = new int[5, 2];
    //var array = new Arreglos(10);
    //array.Fill(10, 100);
    //Console.WriteLine(array);
    //Console.WriteLine("===========Pares==========");
    //var getPares = array.Pares();
    //Console.WriteLine(getPares);
    //Console.WriteLine(array);

    /*array.Fill(200, 300);
    Console.WriteLine(array);

    Console.WriteLine("==============Sort Ascendente=========");
    array.Sort();
    Console.WriteLine(array);

    Console.WriteLine("==============Sort Descendente=========");
    array.Sort(true);
    Console.WriteLine(array);*/


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}






