using System;

namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int \t {typeof(int)} \t {sizeof(int) * 8} \t {int.MinValue} - {int.MaxValue}");
            Console.WriteLine($"uint \t {typeof(uint)} \t {sizeof(uint) * 8} \t {uint.MinValue} - {uint.MaxValue}");
            Console.WriteLine($"int \t {typeof(byte)} \t {sizeof(byte) * 8} \t {byte.MinValue} - {byte.MaxValue}");
            Console.WriteLine($"int \t {typeof(sbyte)} \t {sizeof(sbyte) * 8} \t {sbyte.MinValue} - {sbyte.MaxValue}");
            Console.WriteLine($"int \t {typeof(long)} \t {sizeof(long) * 8} \t {long.MinValue} - {long.MaxValue}");
            Console.WriteLine($"int \t {typeof(ulong)} \t {sizeof(ulong) * 8} \t {ulong.MinValue} - {ulong.MaxValue}");
            Console.WriteLine($"int \t {typeof(short)} \t {sizeof(short) * 8} \t {short.MinValue} - {short.MaxValue}");
            Console.WriteLine($"int \t {typeof(ushort)} \t {sizeof(ushort) * 8} \t {ushort.MinValue} - {ushort.MaxValue}");

            Console.WriteLine($"int \t {typeof(float)} \t {sizeof(float) * 8} \t {float.MinValue} - {float.MaxValue}");
            Console.WriteLine($"int \t {typeof(double)} \t {sizeof(double) * 8} \t {double.MinValue} - {double.MaxValue}");
            Console.WriteLine($"int \t {typeof(decimal)} \t {sizeof(decimal) * 8} \t {decimal.MinValue} - {decimal.MaxValue}");


        }
    }
}
