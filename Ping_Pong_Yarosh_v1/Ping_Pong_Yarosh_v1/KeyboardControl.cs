namespace Ping_Pong_Yarosh_v1 {
   public class KeyboardControl {
      public string Left { get; set; }
      public string Right { get; set; }

      public KeyboardControl(string left, string right) {
         Left = left;
         Right = right;
      }

      public override string ToString() {
         return $"Left: {Left}, Right: {Right}";
      }
   }
}