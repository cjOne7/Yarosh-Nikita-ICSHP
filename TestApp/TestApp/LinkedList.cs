using System;
using System.Collections;
using System.Data;

namespace TestApp {
   public class LinkedList : IList {
      private Node _head;
      private Node _tail;

      private bool IsEmpty() {
         return Count == 0 && _head == null && _tail == null;
      }

      public IEnumerator GetEnumerator() {
         return new Enumerator(this);
      }

      public int Add(object value) {
         if (value == null){
            return -1;
         }

         var node = new Node(value, null, _tail);
         if (IsEmpty()){
            _head = node;
            _tail = _head;
         }
         else{
            _tail.Next = node;
            _tail = node;
         }

         return Count++;
      }

      public bool Contains(object value) {
         CheckForNull(value);
         var node = _head;
         while (node != null){
            if (node.Data.Equals(value)){
               return true;
            }

            node = node.Next;
         }

         return false;
      }

      public void Clear() {
         _head = _tail = null;
         Count = 0;
      }

      public int IndexOf(object value) {
         CheckForNull(value);
         var node = _head;
         var i = 0;
         while (node != null){
            if (node.Data.Equals(value)){
               return i;
            }

            node = node.Next;
            i++;
         }

         return i == Count ? -1 : i;
      }

      public void Insert(int index, object value) {
         CheckForNull(value);
         CheckIndex(index);
         if (index == Count - 1){
            Add(value);
         }
         else{
            var i = 0;
            var node = _head;
            while (i++ != index - 1){
               node = node.Next;
            }

            var newNode = new Node(value, node.Next, node);
            var nextNode = node.Next;
            nextNode.Prev = newNode;
            node.Next = newNode;
            Count++;
         }
      }

      public void Remove(object value) {
         CheckForNull(value);
         RemoveAt(IndexOf(value));
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

      public void CopyTo(Array array, int index) {
         CheckForNull(array);
         CheckIndex(index);
         for (var i = 0; i < Count; i++){
            array.SetValue(this[index], index++);
         }
      }

      public object this[int index] {
         get {
            if (IsEmpty()){
               return null;
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

      private class Node {
         public object Data { get; }
         public Node Next { get; set; }
         public Node Prev { get; set; }

         public Node(object data, Node next, Node prev) {
            Data = data;
            Next = next;
            Prev = prev;
         }
      }

      public int Count { get; private set; }

      public object SyncRoot => this;
      public bool IsReadOnly { get; } = false;
      public bool IsFixedSize { get; } = false;
      public bool IsSynchronized { get; } = false;

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

      private class Enumerator : IEnumerator {
         private readonly LinkedList _list;
         private int _index;

         public Enumerator(LinkedList list) {
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

         public object Current { get; private set; }
      }
   }
}