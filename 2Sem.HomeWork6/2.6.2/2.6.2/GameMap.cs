﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _2._6._2
{
    public class GameMap
    {
        public int x { get; private set; } = -1;
        public int y { get; private set; } = -1;
        public bool[,] map { get; private set; }

        public GameMap(string file)
        {
            string line;
            using (StreamReader sr = new StreamReader(file))
            {
                line = sr.ReadToEnd();
            }
            CreateTheMap(line);
        }

        public void CreateTheMap(string line)
        {
            int columnCounter = 0;
            int columnCounterMax = 0;
            int stringCounter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != '\n' && line[i] != '\r')
                {
                    columnCounter++;
                }
                if (line[i] == '\n' || i == line.Length - 1)
                {
                    stringCounter++;
                    if (columnCounter > columnCounterMax)
                    {
                        columnCounterMax = columnCounter;
                    }
                    columnCounter = 0;
                }
            }

            map = new bool[stringCounter, columnCounterMax];

            int k = 0;
            int l = 0;
            for (int count = 0; count < line.Length; count++)
            {
                if (line[count] == '@')
                {
                    y = k;
                    x = l;
                }
                if (line[count] == 'A')
                {
                    map[k, l] = true;
                }
                if (line[count] == '\r')
                {
                    count++;
                    k++;
                    l = -1;
                }
                l++;
            }
            if (x == -1 && y == -1)
            {
                throw new InvalidMapException("No player on the map");
            }
        }

        public void MoveTo(int x, int y)
        {
            if (this.x + x < 0 || this.y + y < 0 || this.x + x >= map.GetLength(1) || this.y + y >= map.GetLength(0))
            {
                Console.WriteLine("You cannot go beyond the map");
            }
            else if (map[this.y + y, this.x + x])
            {
                Console.WriteLine("You cannot stand on the wall");
            }
            else
            {
                this.x += x;
                this.y += y;
            }
        }

        public void Print()
        {

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (j == this.x && i == this.y)
                    {
                        Console.Write('@');
                    }
                    else if (map[i, j])
                    {
                        Console.Write('A');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
