using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Ping_Pong_Yarosh_v1 {
   public class LinkedList<T> : IList<T> {
      private Node _head;
      private Node _tail;

      private bool IsEmpty() {
         return Count == 0 && _head == null && _tail == null;
      }

      public IEnumerator<T> GetEnumerator() {
         return new Enumerator(this);
      }

      IEnumerator IEnumerable.GetEnumerator() {
         return GetEnumerator();
      }

      public void Add(T item) {
         CheckForNull(item);
         var node = new Node(item, null, _tail);
         if (IsEmpty()){
            _head = node;
            _tail = _head;
         }
         else{
            _tail.Next = node;
            _tail = node;
         }

         Count++;
      }

      public void Clear() {
         _head = _tail = null;
         Count = 0;
      }

      public bool Contains(T item) {
         return IndexOf(item) != -1;
      }

      public void CopyTo(T[] array, int arrayIndex) {
         CheckForNull(array);
         CheckIndex(arrayIndex);
         for (var i = 0; i < Count; i++){
            array.SetValue(this[arrayIndex], arrayIndex++);
         }
      }

      public bool Remove(T item) {
         var index = IndexOf(item);
         if (index < 0){
            return false;
         }

         RemoveAt(index);
         return true;
      }

      public int IndexOf(T item) {
         CheckForNull(item);
         var node = _head;
         var i = 0;
         while (node != null){
            if (node.Data.Equals(item)){
               return i;
            }

            node = node.Next;
            i++;
         }

         return i == Count ? -1 : i;
      }

      public void Insert(int index, T item) {
         CheckForNull(item);
         CheckIndex(index);
         if (index == Count - 1){
            Add(item);
         }
         else{
            var i = 0;
            var node = _head;
            while (i++ != index - 1){
               node = node.Next;
            }

            var newNode = new Node(item, node.Next, node);
            var nextNode = node.Next;
            nextNode.Prev = newNode;
            node.Next = newNode;
            Count++;
         }
      }

      public void RemoveAt(int index) {
         CheckIndex(index);
         if (IsEmpty()){
            throw new EvaluateException("Empty list.");
         }

         if (Count == 1){
            Clear();
            return;
         }

         if (index == 0){
            RemoveFirst();
         }
         else if (index == Count - 1){
            RemoveLast();
         }
         else{
            var node = _head;
            var i = 0;
            while (i++ != index){
               node = node.Next;
            }

            ReassignNodes(node);
         }

         Count--;
      }

      private static void ReassignNodes(Node node) {
         var deletedNode = node;
         node.Prev.Next = deletedNode.Next;
         deletedNode.Next.Prev = node.Prev;
      }

      private void RemoveFirst() {
         _head = _head.Next;
         _head.Prev = null;
      }

      private void RemoveLast() {
         _tail = _tail.Prev;
         _tail.Next = null;
      }

      public T this[int index] {
         get {
            if (IsEmpty()){
               throw new EvaluateException("Empty list.");
            }

            CheckIndex(index);
            var node = _head;
            var i = 0;
            while (i++ != index){
               node = node.Next;
            }

            return node.Data;
         }
         set => Insert(index, value);
      }

      public int Count { get; private set; }
      public bool IsReadOnly { get; }

      private class Node {
         public T Data { get; }
         public Node Next { get; set; }
         public Node Prev { get; set; }

         public Node(T data, Node next, Node prev) {
            Data = data;
            Next = next;
            Prev = prev;
         }
      }

      private static void CheckForNull(object value) {
         if (value == null){
            throw new ArgumentNullException(nameof(value));
         }
      }

      private void CheckIndex(int index) {
         if (index < 0 || index >= Count){
            throw new IndexOutOfRangeException("Your index < 0 or >= " + Count);
         }
      }

      private class Enumerator : IEnumerator<T> {
         private readonly LinkedList<T> _list;
         private int _index;

         T IEnumerator<T>.Current => (T) Current;

         public object Current { get; private set; }

         public Enumerator(LinkedList<T> list) {
            _list = list;
            _index = 0;
            Current = list[_index];
         }

         public bool MoveNext() {
            if (_index >= _list.Count){
               return false;
            }

            Current = _list[_index++];
            return _index <= _list.Count;
         }

         public void Reset() {
            _index = 0;
            Current = _list[_index];
         }

         public void Dispose() { }
      }
   }
}