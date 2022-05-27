using System;
using System.Collections.Generic;

namespace Towers_Of_Hanoi {
	class Pole {
		private readonly Stack<Disk> Disks;
		private readonly static Disk NullDisk = new Disk();
		public int Count { get => Disks.Count; }
		public Disk Peek { get => Count > 0 ? Disks.Peek() : NullDisk; }
		public string String { get => ToString(); }

		public Pole() {
			Disks = new Stack<Disk>();
		}

		public void Push(Disk disk) {
			Disks.Push(disk);
		}

		public bool CanPush(Disk disk) {
			return Count == 0 || (disk.Size < Peek.Size && disk.Size != 0);
		}

		public Disk Pop() {
			return Disks.Pop();
		}

		public void GameSetup(int numOfDisks) {
			Disks.Clear();
			while(numOfDisks > 0) {
				Disks.Push(new Disk(numOfDisks--));
			}
		}

		public override string ToString() {
			return string.Join(Environment.NewLine, Disks);
		}
	}
}
