namespace Towers_Of_Hanoi {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.NumInput = new System.Windows.Forms.TextBox();
			this.ConfirmInput = new System.Windows.Forms.Button();
			this.movebtn = new System.Windows.Forms.Button();
			this.poleBox0 = new System.Windows.Forms.RichTextBox();
			this.poleBox1 = new System.Windows.Forms.RichTextBox();
			this.poleBox2 = new System.Windows.Forms.RichTextBox();
			this.reqMoves = new System.Windows.Forms.Label();
			this.numOfMoves = new System.Windows.Forms.Label();
			this.reqMoveCount = new System.Windows.Forms.Label();
			this.numMovesCount = new System.Windows.Forms.Label();
			this.lazyButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NumInput
			// 
			this.NumInput.Location = new System.Drawing.Point(12, 12);
			this.NumInput.Name = "NumInput";
			this.NumInput.Size = new System.Drawing.Size(100, 20);
			this.NumInput.TabIndex = 0;
			// 
			// ConfirmInput
			// 
			this.ConfirmInput.Location = new System.Drawing.Point(118, 9);
			this.ConfirmInput.Name = "ConfirmInput";
			this.ConfirmInput.Size = new System.Drawing.Size(75, 23);
			this.ConfirmInput.TabIndex = 1;
			this.ConfirmInput.Text = "Confirm";
			this.ConfirmInput.UseVisualStyleBackColor = true;
			this.ConfirmInput.Click += new System.EventHandler(this.ConfirmInput_Click);
			// 
			// movebtn
			// 
			this.movebtn.Enabled = false;
			this.movebtn.Location = new System.Drawing.Point(199, 10);
			this.movebtn.Name = "movebtn";
			this.movebtn.Size = new System.Drawing.Size(75, 23);
			this.movebtn.TabIndex = 5;
			this.movebtn.Text = "Move";
			this.movebtn.UseVisualStyleBackColor = true;
			this.movebtn.Click += new System.EventHandler(this.Movebtn_Click);
			// 
			// poleBox0
			// 
			this.poleBox0.Location = new System.Drawing.Point(13, 39);
			this.poleBox0.Name = "poleBox0";
			this.poleBox0.ReadOnly = true;
			this.poleBox0.Size = new System.Drawing.Size(100, 356);
			this.poleBox0.TabIndex = 6;
			this.poleBox0.Text = "";
			// 
			// poleBox1
			// 
			this.poleBox1.Location = new System.Drawing.Point(119, 39);
			this.poleBox1.Name = "poleBox1";
			this.poleBox1.ReadOnly = true;
			this.poleBox1.Size = new System.Drawing.Size(100, 356);
			this.poleBox1.TabIndex = 7;
			this.poleBox1.Text = "";
			// 
			// poleBox2
			// 
			this.poleBox2.Location = new System.Drawing.Point(225, 39);
			this.poleBox2.Name = "poleBox2";
			this.poleBox2.ReadOnly = true;
			this.poleBox2.Size = new System.Drawing.Size(100, 356);
			this.poleBox2.TabIndex = 8;
			this.poleBox2.Text = "";
			// 
			// reqMoves
			// 
			this.reqMoves.AutoSize = true;
			this.reqMoves.Location = new System.Drawing.Point(13, 415);
			this.reqMoves.Name = "reqMoves";
			this.reqMoves.Size = new System.Drawing.Size(91, 13);
			this.reqMoves.TabIndex = 9;
			this.reqMoves.Text = "Required Moves: ";
			// 
			// numOfMoves
			// 
			this.numOfMoves.AutoSize = true;
			this.numOfMoves.Location = new System.Drawing.Point(183, 415);
			this.numOfMoves.Name = "numOfMoves";
			this.numOfMoves.Size = new System.Drawing.Size(69, 13);
			this.numOfMoves.TabIndex = 10;
			this.numOfMoves.Text = "# Of Moves: ";
			// 
			// reqMoveCount
			// 
			this.reqMoveCount.AutoSize = true;
			this.reqMoveCount.Location = new System.Drawing.Point(102, 415);
			this.reqMoveCount.Name = "reqMoveCount";
			this.reqMoveCount.Size = new System.Drawing.Size(35, 13);
			this.reqMoveCount.TabIndex = 11;
			this.reqMoveCount.Text = "####";
			// 
			// numMovesCount
			// 
			this.numMovesCount.AutoSize = true;
			this.numMovesCount.Location = new System.Drawing.Point(248, 415);
			this.numMovesCount.Name = "numMovesCount";
			this.numMovesCount.Size = new System.Drawing.Size(35, 13);
			this.numMovesCount.TabIndex = 12;
			this.numMovesCount.Text = "####";
			// 
			// lazyButton
			// 
			this.lazyButton.Enabled = false;
			this.lazyButton.Location = new System.Drawing.Point(280, 10);
			this.lazyButton.Name = "lazyButton";
			this.lazyButton.Size = new System.Drawing.Size(75, 23);
			this.lazyButton.TabIndex = 13;
			this.lazyButton.Text = "Lazy Button";
			this.lazyButton.UseVisualStyleBackColor = true;
			this.lazyButton.Click += new System.EventHandler(this.LazyButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 452);
			this.Controls.Add(this.lazyButton);
			this.Controls.Add(this.numMovesCount);
			this.Controls.Add(this.reqMoveCount);
			this.Controls.Add(this.numOfMoves);
			this.Controls.Add(this.reqMoves);
			this.Controls.Add(this.poleBox2);
			this.Controls.Add(this.poleBox1);
			this.Controls.Add(this.poleBox0);
			this.Controls.Add(this.movebtn);
			this.Controls.Add(this.ConfirmInput);
			this.Controls.Add(this.NumInput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NumInput;
		private System.Windows.Forms.Button ConfirmInput;
		private System.Windows.Forms.Button movebtn;
		private System.Windows.Forms.RichTextBox poleBox0;
		private System.Windows.Forms.RichTextBox poleBox1;
		private System.Windows.Forms.RichTextBox poleBox2;
		private System.Windows.Forms.Label reqMoves;
		private System.Windows.Forms.Label numOfMoves;
		private System.Windows.Forms.Label reqMoveCount;
		private System.Windows.Forms.Label numMovesCount;
		private System.Windows.Forms.Button lazyButton;
	}
}

