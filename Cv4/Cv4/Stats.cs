using System;

namespace Cv4 {
   public class Stats {
      public int Correct { get; private set; }
      public int Missed { get; private set; }
      public double Accuracy { get; private set; }

      public Stats() {
         Correct = Missed = 0;
         Accuracy = 0.0;
      }

      public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);

      public event UpdatedStatsEventHandler UpdatedStats;

      private void OnUpdatedStats() {
         UpdatedStatsEventHandler handler = UpdatedStats;
         if (handler != null)
            handler(this, new EventArgs());
      }

      public void Update(bool correctKey) {
         if (correctKey){
            Correct++;
         }
         else{
            Missed++;
         }

         if (Correct != 0){
            Accuracy = Math.Round((double) Correct / (Missed + Correct), 1) * 100;
         }
      }
   }
}