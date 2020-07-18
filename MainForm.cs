using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AngleCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static class TileLib
        {
            public static string[] AllTileTypes = { "L", "Q", "U", "E", "R", "C", "D", "Z", "H", "G", "T", "J", "M", "B", "F", "N", "5", "6", "7", "8" };
            public static class TileCode // This is only for reading, it won't do anything functional in this app.
            {
                public static string Up = "U";
                public static string Right = "R";
                public static string Left = "L";
                public static string Down = "D";
                public static string RightUp = "E";
                public static string RightDown = "C";
                public static string LeftUp = "Q";
                public static string LeftDown = "Z";
                public static string T1LeftUp = "H";
                public static string T2LeftUp = "G";
                public static string T1RightUp = "T";
                public static string T2RightUp = "J";
                public static string T1RightDown = "M";
                public static string T2RightDown = "B";
                public static string T1LeftDown = "F";
                public static string T2LeftDown = "N";
                public static string S5 = "S5"; // 108 | i. a. 540 (540/5)
                public static string S6 = "S6"; // 360 - x
                public static string S7 = "S7"; // 900/7 | i. a. 900 (900/7)
                public static string S8 = "S8"; // 360 - x
            }
            public static class TileAngle
            {
                public static decimal Up = 90M;
                public static decimal Right = 180M;
                public static decimal Left = 360M;
                public static decimal Down = 270M;
                public static decimal RightUp = 135M;
                public static decimal RightDown = 225M;
                public static decimal LeftUp = 45M;
                public static decimal LeftDown = 315M;
                public static decimal T1LeftUp = 30M;
                public static decimal T2LeftUp = 60M;
                public static decimal T1RightUp = 120M;
                public static decimal T2RightUp = 150M;
                public static decimal T1RightDown = 210M;
                public static decimal T2RightDown = 240M;
                public static decimal T1LeftDown = 300M;
                public static decimal T2LeftDown = 330M;
                public static decimal S5 = 108M;
                public static decimal S6 = 252M;
                public static decimal S7 = 900M / 7M;
                public static decimal S8 = 1620M / 7M;
            }
            public static decimal GetAngleByCode(string code)
            {
                if(Regex.Replace(code, @"[^5-8]", "").Equals(code)) // special tile types
                {
                    int stack5 = code.Length - Regex.Replace(code, @"[5]", "").Length % 5;
                    int stack6 = code.Length - Regex.Replace(code, @"[6]", "").Length % 5;
                    int stack7 = code.Length - Regex.Replace(code, @"[7]", "").Length % 5;
                    int stack8 = code.Length - Regex.Replace(code, @"[8]", "").Length % 5;
                    return ((72M * stack5) + (288M * stack6) + (900M / 7M * stack7) + (1620M / 7M * stack8)) % 360M;

                } else // normal tile types
                {
                    if (code.Equals("L")) return TileAngle.Left;
                    if (code.Equals("Q")) return TileAngle.LeftUp;
                    if (code.Equals("U")) return TileAngle.Up;
                    if (code.Equals("E")) return TileAngle.RightUp;
                    if (code.Equals("R")) return TileAngle.Right;
                    if (code.Equals("C")) return TileAngle.RightDown;
                    if (code.Equals("D")) return TileAngle.Down;
                    if (code.Equals("Z")) return TileAngle.LeftDown;
                    if (code.Equals("H")) return TileAngle.T1LeftUp;
                    if (code.Equals("G")) return TileAngle.T2LeftUp;
                    if (code.Equals("T")) return TileAngle.T1RightUp;
                    if (code.Equals("J")) return TileAngle.T2RightUp;
                    if (code.Equals("M")) return TileAngle.T1RightDown;
                    if (code.Equals("B")) return TileAngle.T2RightDown;
                    if (code.Equals("F")) return TileAngle.T1LeftDown;
                    if (code.Equals("N")) return TileAngle.T2LeftDown;
                    if (code.Equals("S5")) return TileAngle.S5; // You can't type S, and you should not have access to these because
                    if (code.Equals("S6")) return TileAngle.S6; // it may cause conflicts and result in wrong calculation.
                    if (code.Equals("S7")) return TileAngle.S7; // These are only for NextTile, doing this on ThisTile will
                    if (code.Equals("S8")) return TileAngle.S8; // result with angles that doesn't even exist ingame.
                }
                return 0;
            }
            public static decimal GetRelativeAngle(decimal ThisTile, decimal NextTile, bool Twirled)
            {
                decimal result = (NextTile - ThisTile + 540) % 360;
                if (Twirled) result = 360 - result;
                if (result == 0) result = 360;

                return result;
            }
            public static string GetRelativeAngleFormula(decimal ThisTile, decimal NextTile, bool Twirled)
            {
                decimal result = (NextTile - ThisTile + 540) % 360;
                string str = $"( {NextTile} - {ThisTile} + 540 ) % 360 ";
                if (Twirled)
                {
                    str = $"360 - ( {str}) ";
                    result = 360 - result;
                }
                if (result == 0) result = 360;

                str += $"= [{Math.Round(result)}]";

                return str;
            }

            public static decimal GetMillisecondsBetween(decimal BPM, decimal Angle)
            {
                decimal result = (1000 * Angle) / (3 * BPM);
                return result;
            }

            public static string GetMillisecondsBetweenFormula(decimal BPM, decimal Angle)
            {
                return $"( 1000 * {Angle} ) / ( 3 * {BPM} ) = [{Math.Round(60000 / BPM * Angle / 180)}]";
            }
        }

        void UpdateResult()
        {
            if (textBoxBpm.Text.Length == 0)
            {
                textBoxResultMs.Text = "";
                textBoxResultMsFormula.Text = "";
            }
            if (TileLib.AllTileTypes.Contains(textBoxThis.Text.Length > 0 ? textBoxThis.Text[0].ToString() : String.Empty) && TileLib.AllTileTypes.Contains(textBoxNext.Text.Length > 0 ? textBoxNext.Text[0].ToString() : String.Empty))
            {
                string specialTileType = "none"; // only used when 'next' tile is 5 ~ 8

                for (var i = 5; i < 9; i++)
                {
                    if (textBoxNext.Text.Equals($"{i}")) specialTileType = $"S{i}";
                }

                decimal result = 0;

                if (specialTileType.Equals("none"))
                {
                    decimal ThisTile = TileLib.GetAngleByCode(textBoxThis.Text);
                    decimal NextTile = TileLib.GetAngleByCode(textBoxNext.Text);

                    if (textBoxNext.Text.Length > 1)
                    {
                        textBoxResultAngle.Text = $"That tile type cannot be next in actual game.";
                        textBoxResultAngleFormula.Text = "";
                    }
                    else
                    {
                        result = TileLib.GetRelativeAngle(ThisTile, NextTile, checkBoxTwirl.Checked);

                        textBoxResultAngle.Text = $"{result} [{Math.Round(result)}]";
                        textBoxResultAngleFormula.Text = TileLib.GetRelativeAngleFormula(ThisTile, NextTile, checkBoxTwirl.Checked);
                    }
                }
                else
                {
                    result = TileLib.GetAngleByCode(specialTileType);
                    if (checkBoxTwirl.Checked) result = 360 - result;

                    textBoxResultAngle.Text = $"{result} [{Math.Round(result)}]";
                    textBoxResultAngleFormula.Text = "There is no formula for this.";
                }

                bool tp = decimal.TryParse(textBoxBpm.Text, out decimal bpm);
                if (tp && bpm != 0 && textBoxNext.Text.Length < 2)
                {
                    decimal ms = TileLib.GetMillisecondsBetween(bpm, result);

                    textBoxResultMs.Text = $"{ms} [{Math.Round(ms)}]";
                    textBoxResultMsFormula.Text = TileLib.GetMillisecondsBetweenFormula(bpm, result);
                }
                else if (tp && textBoxNext.Text.Length < 2)
                {
                    textBoxResultMs.Text = "Cannot divide by 0, try other number.";
                    textBoxResultMsFormula.Text = TileLib.GetMillisecondsBetweenFormula(bpm, result);
                }
                else if (textBoxNext.Text.Length > 1)
                {
                    textBoxResultMs.Text = "";
                    textBoxResultMsFormula.Text = "";
                }
            }
            else
            {
                textBoxResultAngle.Text = "";
                textBoxResultAngleFormula.Text = "";
            }
            textBoxBpm.Text = FetchNumber(textBoxBpm.Text);
        }

        string FetchText(string str)
        {
            return Regex.Replace(str.ToUpper(), @"[^LQUERCDZHGTJMBFN5678]", String.Empty);
        }

        string FetchNumber(string num)
        {
            return Regex.Replace(num, @"[^0-9.-]", String.Empty);
        }

        private void textBoxThis_TextChanged(object sender, EventArgs e)
        {
            textBoxThis.Text = FetchText(textBoxThis.Text);
            UpdateResult();
        }

        private void textBoxNext_TextChanged(object sender, EventArgs e)
        {
            textBoxNext.Text = FetchText(textBoxNext.Text);
            UpdateResult();
        }

        private void checkBoxTwirl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void textBoxBpm_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }
    }
}
