using System;
using System.Linq;
using System.Collections.Generic;

namespace Cv8 {
   public class MinMaxHashTable<K, V> {
      private int _initialSize = 20;
      public K Min { get; set; }
      public K Max { get; set; }
      public int Count { get; set; }
      private Node<K, V>[] Array { get; set; }

      public MinMaxHashTable() {
         Array = new Node<K, V>[_initialSize];
      }

      public MinMaxHashTable(int newSize) {
         _initialSize = newSize;
         Array = new Node<K, V>[_initialSize];
      }

      private int GetPosition(K key) {
         var hash = key.GetHashCode();
         return Math.Abs(hash % _initialSize);
      }

      public void Add(K key, V value) {
         CheckKeyForNull(key);
         CheckKeyForNull(value);
         if (Contains(key)){
            throw new ArgumentException($"Key '{key}' exists");
         }

         var valueNode = new Node<K, V>(key, value, null);
         var pos = GetPosition(key);
         var node = Array[pos];
         if (node == null){
            Array[pos] = valueNode;
         }
         else{
            while (node.Next != null){
               node = node.Next;
            }

            node.Next = valueNode;
         }

         Count++;
      }

      public bool Contains(K key) {
         try{
            Get(key);
            return true;
         }
         catch (KeyNotFoundException){
            return false;
         }
      }

      public V Get(K key) {
         CheckKeyForNull(key);
         var pos = GetPosition(key);
         var node = Array[pos];
         while (node != null){
            if (node.Key.Equals(key)){
               return node.Value;
            }

            node = node.Next;
         }

         throw new KeyNotFoundException($"Key {key} is not found.");
      }

      public V Remove(K key) {
         CheckKeyForNull(key);
         var pos = GetPosition(key);
         var temp = Array[pos];
         if (temp.Key.Equals(key)){
            Array[pos] = temp.Next;
            Count--;
            return temp.Value;
         }

         Node<K, V> prev = null;

         while (temp != null && !Equals(temp.Key, key)){
            prev = temp;
            temp = temp.Next;
         }

         if (temp == null){
            throw new KeyNotFoundException($"Key {key} is not found.");
         }

         prev.Next = temp.Next;
         Count--;
         return temp.Value;
      }

      public IEnumerator<KeyValuePair<K, V>> Range(K min, K max) {
         return GetListRangeKeyValuePair(min, max).GetEnumerator();
      }

      public IEnumerator<KeyValuePair<K, V>> SortedRange(K min, K max) {
         return GetListRangeKeyValuePair(min, max).OrderBy(pair => pair.Key).GetEnumerator();
      }

      public IEnumerator<KeyValuePair<K, V>> this[K min, K max] => Range(min, max);

      private IEnumerable<KeyValuePair<K, V>> GetListRangeKeyValuePair(K min, K max) {
         var pairs = new List<KeyValuePair<K, V>>();
         for (var i = 0; i < _initialSize; i++){
            var node = Array[i];
            while (node != null){
               if (node.CompareTo(min) >= 0 && node.CompareTo(max) <= 0){
                  pairs.Add(new KeyValuePair<K, V>(node.Key, node.Value));
               }

               node = node.Next;
            }
         }

         return pairs;
      }

      private class Node<K, V> : IComparable<K> {
         public K Key { get; }
         public V Value { get; }
         public Node<K, V> Next { get; set; }

         public Node(K key, V value, Node<K, V> next) {
            Key = key;
            Value = value;
            Next = next;
         }

         public int CompareTo(K other) {
            return Comparer<K>.Default.Compare(Key, other);
         }
      }

      private static void CheckKeyForNull(object value) {
         if (value == null){
            throw new ArgumentException("Value is null");
         }
      }
   }
}