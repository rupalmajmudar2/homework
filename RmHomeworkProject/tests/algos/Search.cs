using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using NUnit.Framework;

namespace RmHomeworkProject.tests.algos {
    class Search_Binary {
        int[] int_arr;

        [Test]
        public void TestBinarySearch() {
            Search_Binary search = new Search_Binary();
            search.int_arr = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 }; //sorted!
            int toFind = 4;
            int location = search.binarySearch(0, search.int_arr.Length, toFind);
            Debug.WriteLine("Element " + toFind + " is at position#" + location);
            Assert.AreEqual(location, 3);
        }

        int binarySearch(int low, int high, int key) {
            while (low <= high) {
                int mid = (low + high) / 2;
                if (int_arr[mid] < key) {
                    low = mid + 1;
                }
                else if (int_arr[mid] > key) {
                    high = mid - 1;
                }
                else {
                    return mid;
                }
            }
            return -1;                //key not found
        }
    }
}
