using System;
using System.Collections;
using System.Data;

namespace Cv5 {
   public class LinkedList : IList {
      private Node head;
      private Node tail;
      private int size;

      public bool IsEmpty() {
         return size == 0 && head == null && tail == null;
      }

      public IEnumerator GetEnumerator() {
         throw new NotImplementedException();
      }

      public int Add(object value) {
         if (value == null){
            return -1;
         }

         var node = new Node(value, null, tail);
         if (IsEmpty()){
            head = node;
            tail = head;
         }
         else{
            tail.next = node;
            tail = node;
         }

         return size++;
      }

      public bool Contains(object value) {
         CheckForNull(value);
         var node = head;
         while (node != null){
            if (node.data.Equals(value)){
               return true;
            }

            node = node.next;
         }

         return false;
      }

      public void Clear() {
         head = tail = null;
         size = 0;
      }

      public int IndexOf(object value) {
         CheckForNull(value);
         var node = head;
         var i = 0;
         while (node != null){
            if (node.data.Equals(value)){
               return i;
            }

            node = node.next;
            i++;
         }

         return i == size ? -1 : i;
      }

      public void Insert(int index, object value) {
         CheckForNull(value);
         CheckIndex(index);
         var i = 0;
         var node = head;
         while (i++ != index - 1){
            node = node.next;
         }

         var newNode = new Node(value, node.next, node);
         var nextNode = node.next;
         nextNode.prev = newNode;
         node.next = newNode;
         size++;
      }

      public void Remove(object value) {
         CheckForNull(value);
         if (IsEmpty()){
            throw new EvaluateException("Empty list.");
         }

         if (size == 1){
            Clear();
            return;
         }

         if (value.Equals(head.data)){
            RemoveFirst();
         }
         else if (value.Equals(tail.data)){
            RemoveLast();
         }
         else{
            var node = head;
            while (!node.data.Equals(value)){
               node = node.next;
            }

            ReassignNodes(node);
         }

         size--;
      }

      public void RemoveAt(int index) {
         CheckIndex(index);
         if (IsEmpty()){
            throw new EvaluateException("Empty list.");
         }

         if (size == 1){
            Clear();
            return;
         }

         if (index == 0){
            RemoveFirst();
         }
         else if (index == size - 1){
            RemoveLast();
         }
         else{
            var node = head;
            var i = 0;
            while (i++ != index){
               node = node.next;
            }

            ReassignNodes(node);
         }
      }

      private static void ReassignNodes(Node node) {
         var deletedNode = node;
         node.prev.next = deletedNode.next;
         deletedNode.next.prev = node.prev;
      }

      private void RemoveFirst() {
         head = head.next;
         head.prev = null;
      }

      private void RemoveLast() {
         tail = tail.prev;
         tail.next = null;
      }

      public void CopyTo(Array array, int index) {
         throw new NotImplementedException();
      }

      public object this[int index] {
         get {
            if (IsEmpty()){
               return null;
            }

            CheckIndex(index);
            var node = head;
            var i = 0;
            while (i++ != index){
               node = node.next;
            }

            return node.data;
         }
         set => this[index] = value ?? throw new ArgumentNullException(nameof(value));
      }

      private class Node {
         public object data { get; set; }
         public Node next { get; set; }
         public Node prev { get; set; }

         public Node(object data, Node next, Node prev) {
            this.data = data;
            this.next = next;
            this.prev = prev;
         }

         public Node(object data) {
            this.data = data;
         }
      }

      public int Count => size;
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
         if (index < 0 || index >= size){
            throw new IndexOutOfRangeException("Your index < 0 or >= " + size);
         }
      }
   }
}