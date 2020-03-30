using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    // 索引器
    class Indexer
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();
        public int? this[string subject]
        {
            get
            {
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue == false)
                {
                    throw new Exception("Score connot be null");
                }
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
