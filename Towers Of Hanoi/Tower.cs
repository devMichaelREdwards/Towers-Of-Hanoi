using System;
using System.Collections.Generic;

namespace Towers_Of_Hanoi {
	class Tower {
		public const int NUM_OF_TOWERS = 3;
		public int NumOfDisks { get; set; }
		private Pole[] Poles = new Pole[3];
		private int Direction;
		private Disk LastSuccMove = new Disk();
		private Disk CurrentDisk;
		private int CurrentPole;
		private int DestPole;
		private int LoopPole;
		private static Pole EmptyPole = new Pole();
		public bool Solved {
			get => Poles[2].Count == NumOfDisks;
		}

		public Tower(int numOfDisks) {
			NumOfDisks = numOfDisks;
			Direction = (NumOfDisks % 2) == 0 ? 1 : -1;
			LoopPole = Direction == 1 ? 0 : 2;
			Poles[0] = new Pole();
			Poles[1] = new Pole();
			Poles[2] = new Pole();
			Poles[0].GameSetup(NumOfDisks);
		}

		public int MovesToSolve() {
			return (int)(Math.Pow(2, NumOfDisks) - 1);
		}

		public Pole GetPole(int index) {
			return index >= 0 && index <= 2 ? Poles[index] : EmptyPole;
		}

		public override string ToString() {
			String retString = "";
			foreach(Pole p in Poles) {
				retString += p.ToString() + Environment.NewLine;
			}
			return retString;
		}

		public void Move() {
			FindNextValidMove();
			Poles[CurrentPole].Pop();
			Poles[DestPole].Push(CurrentDisk);
			LastSuccMove = CurrentDisk;
		}

		private void FindNextValidMove() {
			while(notValidMove()) {
				int next = GoToNextPole();
				CurrentPole = next == 1 && OutOfBounds(CurrentPole) ? LoopPole : CurrentPole + Direction * next;
				int checkPole = next == 1 ? CurrentPole : DestPole;
				DestPole = OutOfBounds(checkPole) ? LoopPole : checkPole + Direction;
			}
		}

		private int GoToNextPole() {
			return LastSuccMove.Size == CurrentDisk.Size || DestPole == CurrentPole || CurrentDisk.Size == 0 ? 1 : 0;
		}

		private bool OutOfBounds(int Pole) {
			return (Pole + Direction > 2) || (Pole + Direction < 0);
		}

		private bool notValidMove() {
			return !Poles[DestPole].CanPush(CurrentDisk = Poles[CurrentPole].Peek()) || LastSuccMove.Size == CurrentDisk.Size;
		}
	}
}
