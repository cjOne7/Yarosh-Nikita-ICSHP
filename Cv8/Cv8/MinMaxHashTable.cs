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

      private int GetPosition(K key) {
         var hash = key.GetHashCode();
         var pos = Math.Abs(hash % _initialSize);
         return pos;
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
         if (!Contains(key)){
            throw new KeyNotFoundException($"Key {key} is not found."); 
         }
         var pos = GetPosition(key);
         var temp = Array[pos];
         
         
         Node<K, V> prev = null;
         
         while (temp != null && !Equals(temp.Next.Key, key)){
            temp = temp.Next;
         }
         
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

         public Node(K key, V value, Node<K, V> next) {
            Key = key;
            Value = value;
            Next = next;
         }

         public Node(int hash, K key, V value, Node<K, V> next) {
            Hash = hash;
            Key = key;
            Value = value;
            Next = next;
         }
      }

      private void CheckKeyForNull(object value) {
         if (value == null){
            throw new ArgumentException("Value is null");
         }
      }
   }
}