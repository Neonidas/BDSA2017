﻿namespace BDSA2017.Lecture03
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
