﻿using System.Collections.Generic;
using System.Linq;

namespace RmHomeworkProject.problems {

    //https://www.bing.com/videos/search?q=DiscIntersections+problem+solution&cvid=4464dac180414df7836c4e98abdfe87d&aqs=edge..69i57.7144j0j1&pglt=299&PC=HCTS&ru=%2fsearch%3fq%3dDiscIntersections%2bproblem%2bsolution%26cvid%3d4464dac180414df7836c4e98abdfe87d%26aqs%3dedge..69i57.7144j0j1%26pglt%3d299%26FORM%3dANNTA1%26PC%3dHCTS&view=detail&mmscn=vwrc&mid=7A70D69E2D97C185AA097A70D69E2D97C185AA09&FORM=WRVORC
    class DiscIntersections {
        private ListWithDuplicates _IntersectionsDict;
        private List<Intersection> _PreviousXns;

        public int solution(int[] A) {
            int totalNumIntersections = 0;
            _PreviousXns = new List<Intersection>();

            if (totalNumIntersections > 10000000) return -1;

            //(1) Convert into a Dict of name and Intersections
            _IntersectionsDict = GetIntersectionsDictFrom(A);

            //(2) Sort by LeftXns
            _IntersectionsDict = _IntersectionsDict.SortByKey();

            if (_IntersectionsDict.Count == 0) return 0;

            //First (extreme left) value
            int leftXn = _IntersectionsDict.ElementAt(0).Key;
            Intersection intersection = _IntersectionsDict.ElementAt(0).Value;
            _PreviousXns.Add(intersection);

            //(2) Now loop left thru right
            for (int i = 1; i < _IntersectionsDict.Count; i++) {

                int nextLeftXn = _IntersectionsDict.ElementAt(i).Key;
                Intersection nextIntersection = _IntersectionsDict.ElementAt(i).Value;

                //Cases for intersections: Need to check against <wort-case> ALL previous Xns!
                foreach (Intersection prevIntersection in _PreviousXns) {
                    string prn0 = "Comparing " + prevIntersection.name + " with " + nextIntersection.name;
                    if (prevIntersection.DoesIntersect(nextIntersection)) {
                        prevIntersection.AddIntersectingXn(nextIntersection); //being added to the Xn on the left, as convention
                        totalNumIntersections++;
                    }
                }

                _PreviousXns.Add(nextIntersection);
            }

            //(3) Print Results
            string prn = "";
            List<Intersection> xns = _IntersectionsDict.GetAllValues();
            foreach (Intersection xn in xns) {
                prn += xn.name + " Intersects : ";
                foreach (Intersection xn2 in xn._IntersectingXns) {
                    prn += xn2.name + " , ";
                }
            }

            return totalNumIntersections;
        }

        private ListWithDuplicates GetIntersectionsDictFrom(int[] A) {
            ListWithDuplicates dict = new ListWithDuplicates();

            for (int i = 0; i < A.Length; i++) {
                int center = i;
                int radius = A[i];
                Intersection Xn = new Intersection(center, radius);
                dict.Add(Xn.leftXn, Xn);
            }

            return dict;
        }
    }

    public class Intersection {
        public string name;
        public int leftXn;
        public int rightXn;
        public List<Intersection> _IntersectingXns;

        public Intersection(int center, int radius) {
            name = "C" + center;
            leftXn = center - radius;
            rightXn = center + radius;
            _IntersectingXns = new List<Intersection>();
        }

        public void AddIntersectingXn(Intersection Xn) {
            _IntersectingXns.Add(Xn);
        }

        public bool DoesIntersect(Intersection nextIntersection) {
            //Cases for intersections:
            //(i) //both circles at same left-Xn 
            if (nextIntersection.leftXn == this.leftXn) return true;

            //(ii) //Left-Xn of 2nd is to come before (or equal) to the Right-Xn of the first
            if (nextIntersection.leftXn <= this.rightXn) return true;

            return false;
        }
    }

    public class ListWithDuplicates : List<KeyValuePair<int, Intersection>> {
        //https://stackoverflow.com/questions/31414429/c-sharp-get-keys-and-values-from-listkeyvaluepairstring-string

        public void Add(int key, Intersection value) {
            var element = new KeyValuePair<int, Intersection>(key, value);
            this.Add(element);
        }

        public ListWithDuplicates SortByKey() {
            this.Sort((x, y) => x.Key.CompareTo(y.Key));
            return this;
        }

        public List<int> AllKeys() {
            List<int> allKeys = (from kvp in this select kvp.Key).ToList();
            return allKeys;
        }
        public List<Intersection> GetAllValues() {
            List<Intersection> allValues = (from kvp in this select kvp.Value).ToList();
            return allValues;
        }

        public List<Intersection> AllValuesFor(int key) {
            List<Intersection> values = (from kvp in this where kvp.Key == key select kvp.Value).ToList();
            return values;
        }

        public List<Intersection> AllKeysFor(int key) {
            List<Intersection> values = (from kvp in this where kvp.Key == key select kvp.Value).ToList();
            return values;
        }
    }

    //===================================================

    class DiscIntersectionsCorrectSolution {
        class Interval {
            public long Left;
            public long Right;
        }

        public int solution(int[] A) {
            if (A == null || A.Length < 1) {
                return 0;
            }
            var itervals = new Interval[A.Length];
            for (int i = 0; i < A.Length; i++) {
                // use long to avoid data overflow (eg. int.MaxValue + 1)
                long radius = A[i];
                itervals[i] = new Interval() {
                    Left = i - radius,
                    Right = i + radius
                };
            }
            itervals = itervals.OrderBy(i => i.Left).ToArray();

            int result = 0;
            for (int i = 0; i < itervals.Length; i++) {
                var right = itervals[i].Right;
                for (int j = i + 1; j < itervals.Length && itervals[j].Left <= right; j++) {
                    result++;
                    if (result > 10000000) {
                        return -1;
                    }
                }
            }
            return result;
        }
    }
}
