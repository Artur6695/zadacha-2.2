using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Sentance
    {
        protected string[] _wordsCount = {};                  // Количество слов в предложении
        protected string _sentance = "";                // Предложение
        protected int _maxChar = 0;                     // Максимальное кол-во символов

        public Sentance(int maxChar, string sentance)
        {
            _sentance = sentance;
            _maxChar = maxChar;
            _wordsCount = _sentance.Split(' ');
        }

        public int WordsCount
        {
            get { return _wordsCount.Length; }
        }
        public string SentanceThis
        {
            get { return _sentance; }
            set { _sentance = value; }
        }
        public int MaxChar
        {
            get { return _maxChar; }
            set { _maxChar = value; }
        }
    }
}
