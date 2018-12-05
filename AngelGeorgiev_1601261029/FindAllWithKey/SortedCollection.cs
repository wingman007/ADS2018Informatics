using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllWithKey {
    class SortedCollection<T, G> : CustomCollection<T, G> where T : IComparable {

        public override void AddElement(T key, G value) {
            for (int i = 0; i < elements.Count; i++) {
                if (elements[i].Key.CompareTo(key) == 1) {
                    elements.Insert(i, new KeyValuePair<T, G>(key, value));
                    return;
                }
            }
            base.AddElement(key, value);
        }

        public IReadOnlyList<G> BinarySearch(T key) {
            List<G> foundElements = new List<G>();    

            int l = 0;
            int r = elements.Count - 1;
            int mid = 0;
            while (l <= r) {
                mid = (l + r) / 2;
                if (key.CompareTo(elements[mid].Key) == -1) {
                    r = mid - 1;
                }
                else if (key.CompareTo(elements[mid].Key) == 1) {
                    l = mid + 1;
                }
                else {
                    foundElements.Add(elements[mid].Value);

                    for (int i = mid - 1; i >= l; i--) {
                        if (!elements[i].Key.Equals(key)) {
                            break;
                        }
                        foundElements.Add(elements[i].Value);
                    }
                    
                    for (int j = mid + 1; j <= r; j++) {
                        if (!elements[j].Key.Equals(key)) {
                            break;
                        }
                        foundElements.Add(elements[j].Value);
                    }

                    break;
                }
            }

            return foundElements;
        }
    }
}
