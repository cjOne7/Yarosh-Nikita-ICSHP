using System;

namespace Exercise04 {
    public class Stats {
        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public double Accuracy { get; private set; }
        public event UpdateStatsEventHandler UpdatedStats;

        public Stats() {
            Correct = 0;
            Missed = 0;
            Accuracy = 0;
        }

        private void OnUpdatedStats() {
            UpdatedStats?.Invoke(this, new EventArgs());
        }

        public void Update(bool correctKey) {
            if (correctKey) {
                ++Correct;
            }
            else {
                ++Missed;
            }

            if (Correct != 0) {
                Accuracy = Math.Round( ((double) Correct / (Missed + Correct)) * 100, 2);
            }
            
            OnUpdatedStats();
        }

        public delegate void UpdateStatsEventHandler(object sender, EventArgs e);
    }
}