using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectLibs
{
    public static class Generator
    {
        public enum CommentType { Type1  }

        /// <summary>
        /// Generating Comment Method
        /// </summary>
        /// <param name="inputString">String needs to be turned into comment</param>
        /// <param name="maxRange">Widest range of the comment</param>
        /// <returns>Comment string</returns>
        public static string GenComment(string inputString, int maxRange, CommentType type)
        {
            string _outString = string.Empty;

            if (!string.IsNullOrEmpty(inputString))
            {
                string _textClone = inputString;

                // Careful with this split, it depends on the order of \r and \n chars.
                List<string> _stringList = _textClone.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

                _outString = "+" + string.Join(string.Empty, Enumerable.Repeat("-", maxRange - 2)) + "+\n";
                _outString += string.Join("\n", _stringList.Select(str => "|"
                + str
                + string.Join(string.Empty, Enumerable.Repeat(" ", maxRange - str.Length - 2))
                + "|")) + "\n";
                _outString += "+" + string.Join(string.Empty, Enumerable.Repeat("-", maxRange - 2)) + "+\n";
            }
            return _outString;
        }
    }
}
