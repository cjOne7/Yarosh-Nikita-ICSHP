namespace TestApp {
   public class Options {
      public bool IsMouse { get; }
      public bool IsKeyboard { get; }
      public KeyboardControl KeyboardControl { get; }

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