namespace Ping_Pong_Yarosh_v1 {
   public class Options {
      public bool IsMouse { get; set; }
      public bool IsKeyboard { get; set; }
      public KeyboardControl KeyboardControl { get; set; }

      public Options(bool isMouse, bool isKeyboard, KeyboardControl keyboardControl) {
         IsMouse = isMouse;
         IsKeyboard = isKeyboard;
         KeyboardControl = keyboardControl;
      }

      public override string ToString() {
         return $"IsMouse: {IsMouse}, IsKeyboard: {IsKeyboard}, KeyboardControl: {KeyboardControl}";
      }
   }
}