using System;
using System.Collections.Generic;

namespace Towers_Of_Hanoi {
	class Pole {
		private Stack<Disk> Disks;
		public int Count { get => Disks.Count; }
		private static Disk NullDisk = new Disk();
		public Pole() {
			Disks = new Stack<Disk>();
		}
		public void Push(Disk disk) {
			Disks.Push(disk);
		}
		public bool CanPush(Disk disk) {
			return Count == 0 || (disk.Size < Peek().Size && disk.Size != 0);
		}
		public Disk Pop() {
			return Disks.Pop();
		}
		public Disk Peek() {
			return Count > 0 ? Disks.Peek() : NullDisk;
		}
		public void GameSetup(int numOfDisks) {
			Disks.Clear();
			while(numOfDisks > 0) {
				Disks.Push(new Disk(numOfDisks--));
			}
		}
		public override string ToString() {
			String retString = "";
			foreach(Disk d in Disks){
				retString += d.ToString() + Environment.NewLine;
			}
			return retString;
		}
	}
}
