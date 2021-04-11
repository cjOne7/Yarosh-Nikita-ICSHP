using System;
using System.Collections.Generic;
using System.Collections;

namespace Cv8 {
   public class MinMaxHashTable<K, V> {
      private int _initialSize = 20;
      public K Min { get; set; }
      public K Max { get; set; }
      public int Count { get; set; }
      private Node<K, V>[] Array { get; set; }

      Hashtable _hashtable = new Hashtable();

      public MinMaxHashTable() {
         Array = new Node<K, V>[_initialSize];
      }

      public MinMaxHashTable(int newSize) {
         _initialSize = newSize;
         Array = new Node<K, V>[_initialSize];
      }

      private int GetPosition(K key, int length) {
         var hash = key.GetHashCode();
         var pos = Math.Abs(hash % length);
         return pos;
      }

      public void Add(K key, V value) {
         if (Contains(key)){
            throw new ArgumentException($"Key '{key}' exists");
         }

         Count++;
      }

      public bool Contains(K key) {
         return false;
      }

      public V Get(K key) {
         throw new NotImplementedException();
      }

      public V Remove(K key) {
         throw new NotImplementedException();
      }

      public IEnumerable<KeyValuePair<K, V>> Range(K min, K max) {
         throw new NotImplementedException();
      }

      public IEnumerable<KeyValuePair<K, V>> SortedRange(K min, K max) {
         throw new NotImplementedException();
      }

      public IEnumerator<KeyValuePair<K, V>> this[K min, K max] {
         get => throw new NotImplementedException();
         set => throw new NotImplementedException();
      }

      private class Node<K, V> {
         public int Hash { get; set; }
         public K Key { get; set; }
         public V Value { get; set; }
         public Node<K, V> Next { get; set; }

         public Node(int hash, K key, V value, Node<K, V> next) {
            Hash = hash;
            Key = key;
            Value = value;
            Next = next;
         }
      }
   }
}