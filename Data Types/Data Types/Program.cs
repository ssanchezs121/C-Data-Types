using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        enum Days { Dom, Lun, Mar, Mier, Vier, Sab }; // Siempre se declara en la clase

        static void Main(string[] args)
        {
            // int: Tipo entero es un valor numerico que va desde -dos mil millones a dos mil millones. Es de 32bits
            // Bool: Valor tipo Booleano, almacena true or false
            // Byte: Numero de 0 a 255 y de 8bits
            // Char: Caracter que va desde U+0000 a U+FFFF, unicode de 16 bits
            //Decimal: Va desde -7.9x106^28 a 7.9x10^28, tiene precision de 29 numero despues del punto (.)
            //Double: Va desde -5x10^-324 a 5x10^-308, 16 digitos
            //enum : Declarar enumeraciones, variables estaticas
            //Float: Numero Flotante que va desde -3.4x10^38 a 3.4x10^38, 7 digitos de largo y se usa para situaciones matematicas
            //Long: Va desde -9 000 000 000 000 000 000 a 9 000 000 000 000 000 000 en 64bits. Encriptacion de numero
            //sbyte : Va desde -127 a 127 y de 8bits
            //Short: Va desde -32,000 a 32000 y de 16bits
            //uint: Va del 0 a 4 000 000 000 y de 32 bits unsigned
            //uLong: Va desde -9 000 000 000 000 000 000 a 9 000 000 000 000 000 000 en 64bits unsigned
            //uShort: Va desde -32,000 a 32000 y de 16bits unsigned

            int age; //Declarar Variable
            age = 18; //Iniciar
            int year = 2017; //Iniciar y declarar
            bool active = false;
            byte posicion = 1;
            char type = 'a';
            decimal pi = 3.14m;
            double distance = 100.5;
            float x = 3.5f;
            long code = 64736328737463;
            sbyte status = -127;
            short pbi = 327;
            uint myUnit = 7677777888;
            
            

        }
    }

    struct Book
    {

        decimal price;
        string name;
        int code;
    }
}
