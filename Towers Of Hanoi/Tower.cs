using System;

namespace Towers_Of_Hanoi {
	class Tower {
		private static readonly Pole EmptyPole = new Pole();
		public int NumOfDisks { get; set; }
		private readonly Pole[] Poles = new Pole[3];
		private Disk LastSuccMove = new Disk();
		private Disk CurrentDisk;
		private readonly int Direction;
		private int CurrentPole;
		private int DestPole;
		private readonly int LoopPole;
		public bool Solved { get => Poles[2].Count == NumOfDisks; }
		private int GoToNextPole { get => LastSuccMove.Size == CurrentDisk.Size || DestPole == CurrentPole || CurrentDisk.Size == 0 ? 1 : 0; }
		private bool NotValidMove { get => !Poles[DestPole].CanPush(CurrentDisk = Poles[CurrentPole].Peek) || LastSuccMove.Size == CurrentDisk.Size; }
		public string MovesToSolve { get => ((int)(Math.Pow(2, NumOfDisks) - 1)).ToString(); }

		public Tower(int numOfDisks) {
			NumOfDisks = numOfDisks;
			Direction = (NumOfDisks % 2) == 0 ? 1 : -1;
			LoopPole = Direction == 1 ? 0 : 2;
			Poles[0] = new Pole();
			Poles[1] = new Pole();
			Poles[2] = new Pole();
			Poles[0].GameSetup(NumOfDisks);
		}

		public string GetPole(int index) {
			return index >= 0 && index <= 2 ? Poles[index].String : EmptyPole.String;
		}

		public void Move() {
			FindNextValidMove();
			Poles[CurrentPole].Pop();
			Poles[DestPole].Push(CurrentDisk);
			LastSuccMove = CurrentDisk;
		}

		private void FindNextValidMove() {
			while(NotValidMove) {
				int next = GoToNextPole;
				CurrentPole = next == 1 && OutOfBounds(CurrentPole) ? LoopPole : CurrentPole + Direction * next;
				int checkPole = next == 1 ? CurrentPole : DestPole;
				DestPole = OutOfBounds(checkPole) ? LoopPole : checkPole + Direction;
			}
		}

		private bool OutOfBounds(int pole) {
			return (pole + Direction > 2) || (pole + Direction < 0);
		}

		public override string ToString() {
			return string.Join<Pole>(Environment.NewLine, Poles);
		}
	}
}
