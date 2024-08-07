using System;
using System.Diagnostics.CodeAnalysis;
class JACKED
{
    public void Jagging()
    {
        int[][] JaggedArray = [[1, 2, 3, 4, 5, 6, 7], [55, 69, 96], [5, 9, 6]];
        int size = JaggedArray.Length;
        for(int i=0;i<size;i++){
            int sizeOfInnerArray = JaggedArray[i].Length;
            int SUM=0;
            for(int j=0;j<sizeOfInnerArray;j++){
                SUM+=JaggedArray[i][j];
            }
            Console.Write($" {SUM} ");
        }
    }
}

class Supe{
    static void Main(string[] args){
        JACKED j= new();
        j.Jagging();
    }
}