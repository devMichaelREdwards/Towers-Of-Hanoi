using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_Of_Hanoi {
	public partial class Form1 : Form {
		private int NumOfDisks, MoveCount;
		Tower tower;

		public Form1() {
			InitializeComponent();
			poleBox0.SelectionAlignment = HorizontalAlignment.Center;
			poleBox1.SelectionAlignment = HorizontalAlignment.Center;
			poleBox2.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void ConfirmInput_Click(object sender, EventArgs e) {
			MoveCount = 0;
			NumOfDisks = Int32.Parse(NumInput.Text);
			SetButtons(true);
			tower = new Tower(NumOfDisks);
			reqMoveCount.Text = tower.MovesToSolve().ToString();
			numMovesCount.Text = MoveCount.ToString();
			SetPoles();
		}

		private void Movebtn_Click(object sender, EventArgs e) {
			tower.Move();
			SetPoles();
			MoveCount++;
			numMovesCount.Text = MoveCount.ToString();
			if(tower.Solved) {
				MessageBox.Show("New Solved!8");
				SetButtons(false);
			}
		}

		private void LazyButton_Click(object sender, EventArgs e) {
			Task.Factory.StartNew(() => {
				while(!tower.Solved) {
					Movebtn_Click(sender, e);
					Thread.Sleep(0);
				}
			});
		}

		private void SetPoles() {
			poleBox0.Text = tower.GetPole(0).ToString();
			poleBox1.Text = tower.GetPole(1).ToString();
			poleBox2.Text = tower.GetPole(2).ToString();
		}

		private void SetButtons(bool state) {
			movebtn.Enabled = state;
			lazyButton.Enabled = state;
		}
	}
}
