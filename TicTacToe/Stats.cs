using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace TicTacToe
{
    class Stats
    {
        public int PlacedSquares { get; set; }
        public int PlayedGames { get; set; }
        public int WonGames { get; set; }
        public int LostGames { get; set; }
        public int DrewGames { get; set; }
        public int TimeSpentPlaying { get; set; }

        public void UpdatePlacedSquares()
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            string Line = lines[0];

            int value;
            value = int.Parse(Line.Substring(0, 5));

            value++;

            lines[0] = value.ToString().PadLeft(5, '0') + Line.Substring(5);

            File.WriteAllLines(filePath, lines);
        }
        public void UpdatePlayedGames() 
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            string Line = lines[1];

            int value;
            value = int.Parse(Line.Substring(0, 5));

            value++;

            lines[1] = value.ToString().PadLeft(5, '0') + Line.Substring(5);

            File.WriteAllLines(filePath, lines);
        }
        public void UpdateWonGames()
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            string Line = lines[2];

            int value;
            value = int.Parse(Line.Substring(0, 5));

            value++;

            lines[2] = value.ToString().PadLeft(5, '0') + Line.Substring(5);

            File.WriteAllLines(filePath, lines);
        }
        public void UpdateLostGames()
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            string Line = lines[3];

            int value;
            value = int.Parse(Line.Substring(0, 5));

            value++;

            lines[3] = value.ToString().PadLeft(5, '0') + Line.Substring(5);

            File.WriteAllLines(filePath, lines);
        }
        public void UpdateDrewGames()
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            string Line = lines[4];

            int value;
            value = int.Parse(Line.Substring(0, 5));

            value++;

            lines[4] = value.ToString().PadLeft(5, '0') + Line.Substring(5);

            File.WriteAllLines(filePath, lines);
        }
        public void UpdateTimeSpentPlaying(int TimeSpentPlaying)
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            string Line = lines[5];

            int value;
            value = int.Parse(Line.Substring(0, 5));

            value += TimeSpentPlaying; 

            lines[5] = value.ToString().PadLeft(5, '0') + Line.Substring(5);

            File.WriteAllLines(filePath, lines);
        }
    }
}
