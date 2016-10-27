using System;

namespace Tasks
{
    /// <summary>
    /// Represents storing and calculating bits array of number of Int32
    /// </summary>
    public class BynaryNumber
    {
        private int _number;

        /// <summary>
        /// Array of bits represented a number
        /// </summary>
        public byte[] Bits { get; } = new byte[32];

        /// <summary>
        /// Creates store of bits array of value
        /// </summary>
        /// <param name="value"></param>
        public BynaryNumber(int value)
        {
            _number = value;
            CalculateBits();
        }

        /// <summary>
        /// Insert number num from i bit to j bit
        /// </summary>
        /// <param name="num">Number to insert</param>
        /// <param name="i">Bit index</param>
        /// <param name="j">Bit index</param>
        /// <returns>New number</returns>
        public int Insertion(BynaryNumber num, int i, int j)
        {
            for (int k = i; k <= j; k++)
            {
                Bits[k] = num.Bits[k - i];
            }
            CalculateNumber();
            return _number;
        }

        #region Private Methods
        private static int BitsCount(int value)
        {
            int i = 0;
            while (value != 0)
            {
                value /= 2;
                i++;
            }
            return i;
        }

        private void CalculateBits()
        {
            int bufNumber = _number;
            int bitsCount = BitsCount(_number);
            int startBit = 0;
            if (_number < 0)
            {
                bufNumber *= -1;
                Bits[0] = 1;
                startBit = 1;
                bitsCount++;
            }
            for (int i = startBit; i < bitsCount; i++)
            {
                Bits[i] = (byte)(bufNumber % 2);
                bufNumber /= 2;
            }
        }

        private void CalculateNumber()
        {
            _number = 0;
            for (int i = 0; i < 32; i++)
            {
                _number += Bits[i] * (int)Math.Pow(2, i);
            }
        }
        #endregion
    }
}
