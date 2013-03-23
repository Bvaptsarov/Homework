using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BitArray64Task
{
    public class BitArray64 : IEnumerable<int>
    {
        private const byte Size = 64;

        public ulong Number { get; private set; }

        public BitArray64()
        {
            Number = 0;
        }

        public BitArray64(ulong number)
        {
            Number = number;
        }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new ArgumentOutOfRangeException("Index must be value between 0 .. 63");
                }
                else
                {
                    string tmp = Convert.ToString((long)Number,2).PadLeft(64,'0');
                    return byte.Parse(tmp[Size-1-index].ToString());
                }
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new ArgumentOutOfRangeException("Index must be value between 0 .. 63");
                }
                else
                {
                    if (value != 0 && value != 1)
                    {
                        throw new ArgumentOutOfRangeException("Value should be 1 or 0 only!");
                    }
                    else
                    {
                        if (value == 0)
                        {
                            ulong mask = (ulong)1 << index;
                            Number &= ~mask;
                        }
                        else
                        {
                            ulong mask = (ulong)1 << index;
                            Number |= mask;
                        }
                    }
                }
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 second = obj as BitArray64;
            if (second == null)
            {
                return false;
            }
            return Number == second.Number;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.Number.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(BitArray64.Equals(first, second));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            byte[] arr = new byte[64];

            GetArray(arr);

            for (int i = 0; i < Size; i++)
            {
                yield return arr[i];
            }
        }

        private void GetArray(byte[] arr)
        {
            string tmp = Convert.ToString((long)Number, 2).PadLeft(64, '0');
            for (int i = 0; i < Size; i++)
            {
                arr[i] = byte.Parse(tmp[i].ToString());
            }
        }

        public override string ToString()
        {
            return String.Format(Convert.ToString((long)Number, 2).PadLeft(64, '0'));
        }
    }
}