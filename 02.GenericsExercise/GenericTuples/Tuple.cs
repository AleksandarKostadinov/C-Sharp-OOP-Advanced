﻿using System.Security.AccessControl;

namespace GenericTuples
{
    public class Tuple<T, U>
    {
        private T item1;
        private U item2;

        public Tuple(T item1, U item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public U Item2
        {
            get { return this.item2; }
            private set { this.item2 = value; }
        }

        public T Item1
        {
            get { return this.item1; }
            private set { this.item1 = value; }
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
