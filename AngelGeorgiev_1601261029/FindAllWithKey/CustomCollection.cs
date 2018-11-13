using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllWithKey {
    class CustomCollection<T, G> {

        protected List<KeyValuePair<T, G>> elements = new List<KeyValuePair<T, G>>();

        public int Count { get { return elements.Count; } }

        public virtual void AddElement(T key, G value) { 
            elements.Add(new KeyValuePair<T, G>(key, value));
        }

        public void Clear() { elements.Clear(); }

        public void Print() {
            foreach (var element in elements) {
                Console.WriteLine(element.Key + " : " + element.Value);
            }
        }

        public IReadOnlyList<G> SequentialSearch(T key) {
            List<G> foundValues = new List<G>();

            foreach(var pair in elements) {
                if (pair.Key.Equals(key)) {
                    foundValues.Add(pair.Value);
                }
            }

            return foundValues;
        }
    }
}
