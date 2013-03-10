using System;

namespace RangeExceptionDemo
{
    public class InvalidRangeException<T> : Exception
    {
        public T Start { get; set; }
        public T End { get; set; }
        public T InputData { get; set; }

        public InvalidRangeException(string message) 
			: this(message,default(T))
		{
		}

        public InvalidRangeException(string message, T inputData) 
			: this(message, inputData, default(T), default(T))
		{
		}

        public InvalidRangeException(string text,T start, T end, T data):base(text)
        {
            Start = start;
            End = end;
            InputData = data;
        }       
    }
}
