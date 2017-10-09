using System;

namespace Task1
{
    class Die
    {
        private static Random random = new Random();
        private int size;

        public Die(int size)
        {
            this.size = size + 1;
        }

        public int Roll()
        {
            return random.Next(1, size);
        }

        public override string ToString()
        {
            return "D" + (size - 1);
        }

    }
}
