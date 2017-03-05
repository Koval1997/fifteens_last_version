using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fifteens
{
    class Game2 : Game
    {

        public Game2(params int[] values)
            : base(values)
        {

        }

        public static Game2 Randomize(Game field)
        {
            int[] values = new int[field.Side * field.Side];
            int count = 0;

            for (int i = 0; i < field.Side; i++)
            {
                for (int j = 0; j < field.Side; j++)
                {
                    values[count] = field[i, j].Number;
                    count++;
                }
            }
            field = null;
            var random = new Random(DateTime.Now.Millisecond);
            values = values.OrderBy(x => random.Next()).ToArray();
            return new Game2(values);            
        }

        public static bool WinCheck(Game field)
        {
            int[] massive = new int[field.Side * field.Side];

            for (int i = 0; i < field.Side; i++)
            {
                for (int j = 0; j < field.Side - 1; j++)
                {
                    if (field[i, j].Number != field[i, j + 1].Number - 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }



    }
}