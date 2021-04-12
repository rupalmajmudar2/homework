﻿using System.Collections.Generic;
using System.Linq;

namespace RmHomeworkProject.problems {
    class DiscIntersections {
        private ListWithDuplicates _IntersectionsDict;
        public int solution(int[] A) {
            int totalNumIntersections = 0;

            if (totalNumIntersections > 10000000) return -1;

            //(1) Convert into a Dict of name and Intersections
            _IntersectionsDict = GetIntersectionsDictFrom(A);

            //(2) Sort by LeftXns
            _IntersectionsDict = _IntersectionsDict.SortByKey();

            //First (extreme left) value
            int leftXn = _IntersectionsDict.ElementAt(0).Key;
            Intersection intersection = _IntersectionsDict.ElementAt(0).Value;

            //(2) Now loop left thru right
            for (int i = 1; i < _IntersectionsDict.Count; i++) {

                int nextLeftXn = _IntersectionsDict.ElementAt(i).Key;
                Intersection nextIntersection = _IntersectionsDict.ElementAt(i).Value;

                //Cases for intersections:
                if (intersection.DoesIntersect(nextIntersection)) {
                    intersection.AddIntersectingXn(nextIntersection); //being added to the Xn on the left, as convention
                    totalNumIntersections++;
                }

                //Update vars for the loop
                intersection = nextIntersection;
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

            //(ii) //Right-Xn of 2nd is to the right (or equal) of Right-Xn of the first [remember the first has a more-left Xn]
            if (nextIntersection.rightXn >= this.rightXn) return true;

            return false;
        }
    }

    public class ListWithDuplicates : List<KeyValuePair<int, Intersection>> {
        public void Add(int key, Intersection value) {
            var element = new KeyValuePair<int, Intersection>(key, value);
            this.Add(element);
        }

        public ListWithDuplicates SortByKey() {
            this.Sort((x, y) => x.Key.CompareTo(y.Key));
            return this;
        }
    }
}
