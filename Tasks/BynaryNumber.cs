using System;

namespace Tasks
{
    /// <summary>
    /// Represents storing and calculating bits array of number of Int32
    /// </summary>
    public class BynaryNumber
    {
        private byte[] _bits = new byte[32];
        private int _number;

        public byte[] Bits
        {
            get
            {
                return _bits;
            }
        }
        /// <summary>
        /// Create store of bits array of value
        /// </summary>
        /// <param name="value"></param>
        public BynaryNumber(int value)
        {
            _number = value;
            CalculateBits();
        }

        private int BitsCount(int value)
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
                _bits[0] = 1;
                startBit = 1;
                bitsCount++;
            }
            for(int i = startBit; i < bitsCount; i++)
            { 
                _bits[i] = (byte)(bufNumber % 2);
                bufNumber /= 2;
            }
        }

        private void CalculateNumber()
        {
            _number = 0;
            for (int i = 0; i < 32; i++)
            {
                _number += _bits[i] * (int)Math.Pow(2, i);
            }
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
                _bits[k] = num.Bits[k - i];
            }
            CalculateNumber();
            return _number;
        }
    }
}
