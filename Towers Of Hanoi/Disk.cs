using System;

namespace Towers_Of_Hanoi {
	class Disk {
		public int Size { get; set; }

		public Disk() {
		}

		public Disk(int size) {
			Size = size;
		}

		public override string ToString() {
			return $"{Size}({new String('_', Size)})";
		}
	}
}
