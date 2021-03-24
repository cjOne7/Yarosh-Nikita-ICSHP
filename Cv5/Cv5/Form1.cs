using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv5 {
   public partial class Form1 : Form {
      public Gamers Gamers { get; }

      private Form2 form2;
      public Form1() {
         Gamers = new Gamers(10);
         InitializeComponent();
      }

      private void AddBtn_Click(object sender, EventArgs e) {
         form2 = new Form2(this);
         form2.Show();
      }
   }
}