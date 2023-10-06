using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Join_Example
{
    public class User
    {
        public Guid Id { get; }
        public List<Point> Points { get; }

        public User(Guid id, List<Point> points)
        {
            Id = id;
            Points = points ?? new List<Point>();
        }
    }
    public class Point
    {
        public int ChapterPoint { get; set; }
        public int ChapterTime { get; set; }
    }
}
