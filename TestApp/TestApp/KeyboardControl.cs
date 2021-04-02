namespace TestApp {
   public class KeyboardControl {
      public string Left { get; }
      public string Right { get; }

      public KeyboardControl(string left, string right) {
         Left = left;
         Right = right;
      }

      public override string ToString() {
         return $"Left: {Left}, Right: {Right}";
      }
   }
}