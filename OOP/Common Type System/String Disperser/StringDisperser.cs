using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Disperser
{
    class StringDisperser:ICloneable,IComparable<StringDisperser>,IEnumerable
    {
        public StringDisperser(params string[] values)
        {
            this.Words = values;
        }
        public string[] Words { get; set; }
       public override bool Equals(object other)
        {
            if (other != null && other is StringDisperser)
            {
                var otherWord = (StringDisperser)other;
                if (this.Words == otherWord.Words)
                {
                    return true;
                }
            }

            return false;
        }
        public override int GetHashCode()
        {
            return this.Words.GetHashCode();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var word in this.Words)
            {
                foreach (var letter in word)
                {
                    yield return letter;
                }
            }
        }

        public object Clone()
        {
            return new StringDisperser(new List<string>(this.Words).ToArray());
        }
        public int CompareTo(StringDisperser other)
        {

            if (Words.Length >= other.Words.Length)
            {

                return -1;
            }

            if (Words.Length <= other.Words.Length)
            {
                return 1;
            }
            return 0;
        }
        public override string ToString()
        {
            return string.Join(", ", this.Words);
        }
        public static bool operator ==(StringDisperser word1, StringDisperser word2)
        {
            return word1.Equals(word2);
        }
        public static bool operator !=(StringDisperser word1, StringDisperser word2)
        {
            return !word1.Equals(word2);
        }
    }
}
