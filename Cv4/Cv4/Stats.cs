using System;

namespace Cv4 {
   public class Stats {
      public double Correct { get; private set; }
      public double Missed { get; private set; }
      public double Accuracy { get; private set; }
      
      public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);
      
      public event UpdatedStatsEventHandler UpdatedStats;
      
      private void OnUpdatedStats()
      {
         UpdatedStatsEventHandler handler = UpdatedStats;
         if (handler != null)
            handler(this, new EventArgs());
      }

      void Update(bool correctKey) {
         
      }
   }
}