using System;

namespace Towers_Of_Hanoi {
	class Disk {
		public readonly int Size;

		public Disk() {
		}

		public Disk(int size) {
			Size = size;
		}

		public override string ToString() {
			return $"{Size}({new string('_', Size)})";
		}
	}
}
