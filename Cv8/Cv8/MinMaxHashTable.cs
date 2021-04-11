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

      public MinMaxHashTable() { }

      public MinMaxHashTable(int newSize) {
         _initialSize = newSize;
      }

      public void Add(K key, V value) { }

      public bool Contains(K key) {
         return false;
      }

      public V Get(K key) {
         throw new NotImplementedException();
      }

      public V Remove(K key) {
         throw new NotImplementedException();
      }

      public IEnumerable<Node<K, V>> Range(K min, K max) {
         throw new NotImplementedException();
      }

      public IEnumerable<Node<K, V>> SortedRange(K min, K max) {
         throw new NotImplementedException();
      }

      public IEnumerator<Node<K, V>> this[K min, K max] {
         get => throw new NotImplementedException();
         set => throw new NotImplementedException();
      }

      public class Node<K, V> {
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