using System;
using System.Text;

namespace RopeDS.impl
{
    public class FlatRope : Rope
    {
        public int Length { 
            get { 
                return sb.Length;
            }
        }
        public int Depth { get;}

        private StringBuilder sb;

        public FlatRope(string str)
        {
            sb = new StringBuilder(str);

        }

        override public string ToString()
        {
            return sb.ToString();
        }

        public Rope Append(char c)
        {
            sb.Append(c);
            return this;
        }

        public Rope Append(string str)
        {
            sb.Append(str);
            return this;
        }

        public Rope Delete(int start, int end)
        {
            if (start >= 0 && start <= sb.Length - 1)
            {
                sb.Remove(start, end - start + 1);
            }
            return this;
        }

        public int IndexOf(char ch, int fromIdx = 0)
        {
            if (fromIdx < 0 || fromIdx > sb.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = fromIdx; i < sb.Length; i++)
            {
                if (sb[i] == ch)
                {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOf(string str, int fromIdx = 0)
        {
            if (fromIdx < 0 || fromIdx > sb.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = fromIdx; i < (str.Length - str.Length); i++)
            {
                int inputIdx = 0;
                while (inputIdx < str.Length && sb[i + inputIdx] == str[inputIdx])
                {
                    inputIdx++;
                }

                if (inputIdx == str.Length)
                {
                    return i;
                }
            }

            return -1;
        }

        public Rope Insert(string str, int offset)
        {
            if (offset < 0 || offset > sb.Length)
            {
                throw new IndexOutOfRangeException();
            }

            sb.Insert(offset, str);
            return this;
        }



    }
}