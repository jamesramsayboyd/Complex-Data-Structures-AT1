namespace DataProcessing
{
    partial class DataProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.listBoxB = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonBinaryIterativeA = new System.Windows.Forms.Button();
            this.buttonBinaryRecursiveA = new System.Windows.Forms.Button();
            this.buttonSelectionSortA = new System.Windows.Forms.Button();
            this.buttonInsertionSortA = new System.Windows.Forms.Button();
            this.buttonBinaryIterativeB = new System.Windows.Forms.Button();
            this.buttonBinaryRecursiveB = new System.Windows.Forms.Button();
            this.buttonSelectionSortB = new System.Windows.Forms.Button();
            this.buttonInsertionSortB = new System.Windows.Forms.Button();
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMu = new System.Windows.Forms.NumericUpDown();
            this.textBoxSearchA = new System.Windows.Forms.TextBox();
            this.textBoxSearchB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIterativeA = new System.Windows.Forms.TextBox();
            this.textBoxRecursiveA = new System.Windows.Forms.TextBox();
            this.textBoxSelectionA = new System.Windows.Forms.TextBox();
            this.textBoxInsertionA = new System.Windows.Forms.TextBox();
            this.textBoxIterativeB = new System.Windows.Forms.TextBox();
            this.textBoxRecursiveB = new System.Windows.Forms.TextBox();
            this.textBoxSelectionB = new System.Windows.Forms.TextBox();
            this.textBoxInsertionB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(53, 113);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(121, 264);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.Location = new System.Drawing.Point(307, 50);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.Size = new System.Drawing.Size(101, 329);
            this.listBoxA.TabIndex = 1;
            // 
            // listBoxB
            // 
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.Location = new System.Drawing.Point(521, 50);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.Size = new System.Drawing.Size(128, 329);
            this.listBoxB.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(53, 84);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(121, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load Sensor Data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonBinaryIterativeA
            // 
            this.buttonBinaryIterativeA.Location = new System.Drawing.Point(196, 84);
            this.buttonBinaryIterativeA.Name = "buttonBinaryIterativeA";
            this.buttonBinaryIterativeA.Size = new System.Drawing.Size(88, 37);
            this.buttonBinaryIterativeA.TabIndex = 4;
            this.buttonBinaryIterativeA.Text = "Binary Search (Iterative)";
            this.buttonBinaryIterativeA.UseVisualStyleBackColor = true;
            this.buttonBinaryIterativeA.Click += new System.EventHandler(this.buttonBinaryIterativeA_Click);
            // 
            // buttonBinaryRecursiveA
            // 
            this.buttonBinaryRecursiveA.Location = new System.Drawing.Point(196, 161);
            this.buttonBinaryRecursiveA.Name = "buttonBinaryRecursiveA";
            this.buttonBinaryRecursiveA.Size = new System.Drawing.Size(88, 38);
            this.buttonBinaryRecursiveA.TabIndex = 5;
            this.buttonBinaryRecursiveA.Text = "Binary Search (Recursive)";
            this.buttonBinaryRecursiveA.UseVisualStyleBackColor = true;
            this.buttonBinaryRecursiveA.Click += new System.EventHandler(this.buttonBinaryRecursiveA_Click);
            // 
            // buttonSelectionSortA
            // 
            this.buttonSelectionSortA.Location = new System.Drawing.Point(196, 239);
            this.buttonSelectionSortA.Name = "buttonSelectionSortA";
            this.buttonSelectionSortA.Size = new System.Drawing.Size(88, 39);
            this.buttonSelectionSortA.TabIndex = 6;
            this.buttonSelectionSortA.Text = "Sort (Selection)";
            this.buttonSelectionSortA.UseVisualStyleBackColor = true;
            this.buttonSelectionSortA.Click += new System.EventHandler(this.buttonSelectionSortA_Click);
            // 
            // buttonInsertionSortA
            // 
            this.buttonInsertionSortA.Location = new System.Drawing.Point(196, 318);
            this.buttonInsertionSortA.Name = "buttonInsertionSortA";
            this.buttonInsertionSortA.Size = new System.Drawing.Size(88, 32);
            this.buttonInsertionSortA.TabIndex = 7;
            this.buttonInsertionSortA.Text = "Sort (Insertion)";
            this.buttonInsertionSortA.UseVisualStyleBackColor = true;
            this.buttonInsertionSortA.Click += new System.EventHandler(this.buttonInsertionSortA_Click);
            // 
            // buttonBinaryIterativeB
            // 
            this.buttonBinaryIterativeB.Location = new System.Drawing.Point(424, 84);
            this.buttonBinaryIterativeB.Name = "buttonBinaryIterativeB";
            this.buttonBinaryIterativeB.Size = new System.Drawing.Size(85, 37);
            this.buttonBinaryIterativeB.TabIndex = 8;
            this.buttonBinaryIterativeB.Text = "Binary Search (Iterative)";
            this.buttonBinaryIterativeB.UseVisualStyleBackColor = true;
            this.buttonBinaryIterativeB.Click += new System.EventHandler(this.buttonBinaryIterativeB_Click);
            // 
            // buttonBinaryRecursiveB
            // 
            this.buttonBinaryRecursiveB.Location = new System.Drawing.Point(424, 161);
            this.buttonBinaryRecursiveB.Name = "buttonBinaryRecursiveB";
            this.buttonBinaryRecursiveB.Size = new System.Drawing.Size(85, 38);
            this.buttonBinaryRecursiveB.TabIndex = 9;
            this.buttonBinaryRecursiveB.Text = "Binary Search (Recursive)";
            this.buttonBinaryRecursiveB.UseVisualStyleBackColor = true;
            this.buttonBinaryRecursiveB.Click += new System.EventHandler(this.buttonBinaryRecursiveB_Click);
            // 
            // buttonSelectionSortB
            // 
            this.buttonSelectionSortB.Location = new System.Drawing.Point(421, 239);
            this.buttonSelectionSortB.Name = "buttonSelectionSortB";
            this.buttonSelectionSortB.Size = new System.Drawing.Size(85, 39);
            this.buttonSelectionSortB.TabIndex = 10;
            this.buttonSelectionSortB.Text = "Sort (Selection)";
            this.buttonSelectionSortB.UseVisualStyleBackColor = true;
            this.buttonSelectionSortB.Click += new System.EventHandler(this.buttonSelectionSortB_Click);
            // 
            // buttonInsertionSortB
            // 
            this.buttonInsertionSortB.Location = new System.Drawing.Point(421, 318);
            this.buttonInsertionSortB.Name = "buttonInsertionSortB";
            this.buttonInsertionSortB.Size = new System.Drawing.Size(85, 32);
            this.buttonInsertionSortB.TabIndex = 11;
            this.buttonInsertionSortB.Text = "Sort (Insertion)";
            this.buttonInsertionSortB.UseVisualStyleBackColor = true;
            this.buttonInsertionSortB.Click += new System.EventHandler(this.buttonInsertionSortB_Click);
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.Location = new System.Drawing.Point(53, 22);
            this.numericUpDownSigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownSigma.TabIndex = 12;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMu
            // 
            this.numericUpDownMu.Location = new System.Drawing.Point(125, 22);
            this.numericUpDownMu.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownMu.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownMu.Name = "numericUpDownMu";
            this.numericUpDownMu.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownMu.TabIndex = 13;
            this.numericUpDownMu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // textBoxSearchA
            // 
            this.textBoxSearchA.Location = new System.Drawing.Point(196, 50);
            this.textBoxSearchA.Name = "textBoxSearchA";
            this.textBoxSearchA.Size = new System.Drawing.Size(88, 20);
            this.textBoxSearchA.TabIndex = 14;
            // 
            // textBoxSearchB
            // 
            this.textBoxSearchB.Location = new System.Drawing.Point(424, 50);
            this.textBoxSearchB.Name = "textBoxSearchB";
            this.textBoxSearchB.Size = new System.Drawing.Size(85, 20);
            this.textBoxSearchB.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Target:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search Target:";
            // 
            // textBoxIterativeA
            // 
            this.textBoxIterativeA.Location = new System.Drawing.Point(196, 128);
            this.textBoxIterativeA.Name = "textBoxIterativeA";
            this.textBoxIterativeA.Size = new System.Drawing.Size(88, 20);
            this.textBoxIterativeA.TabIndex = 18;
            // 
            // textBoxRecursiveA
            // 
            this.textBoxRecursiveA.Location = new System.Drawing.Point(196, 206);
            this.textBoxRecursiveA.Name = "textBoxRecursiveA";
            this.textBoxRecursiveA.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecursiveA.TabIndex = 19;
            // 
            // textBoxSelectionA
            // 
            this.textBoxSelectionA.Location = new System.Drawing.Point(196, 285);
            this.textBoxSelectionA.Name = "textBoxSelectionA";
            this.textBoxSelectionA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectionA.TabIndex = 20;
            // 
            // textBoxInsertionA
            // 
            this.textBoxInsertionA.Location = new System.Drawing.Point(196, 358);
            this.textBoxInsertionA.Name = "textBoxInsertionA";
            this.textBoxInsertionA.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsertionA.TabIndex = 21;
            // 
            // textBoxIterativeB
            // 
            this.textBoxIterativeB.Location = new System.Drawing.Point(424, 128);
            this.textBoxIterativeB.Name = "textBoxIterativeB";
            this.textBoxIterativeB.Size = new System.Drawing.Size(85, 20);
            this.textBoxIterativeB.TabIndex = 22;
            // 
            // textBoxRecursiveB
            // 
            this.textBoxRecursiveB.Location = new System.Drawing.Point(424, 206);
            this.textBoxRecursiveB.Name = "textBoxRecursiveB";
            this.textBoxRecursiveB.Size = new System.Drawing.Size(82, 20);
            this.textBoxRecursiveB.TabIndex = 23;
            // 
            // textBoxSelectionB
            // 
            this.textBoxSelectionB.Location = new System.Drawing.Point(421, 285);
            this.textBoxSelectionB.Name = "textBoxSelectionB";
            this.textBoxSelectionB.Size = new System.Drawing.Size(85, 20);
            this.textBoxSelectionB.TabIndex = 24;
            // 
            // textBoxInsertionB
            // 
            this.textBoxInsertionB.Location = new System.Drawing.Point(421, 358);
            this.textBoxInsertionB.Name = "textBoxInsertionB";
            this.textBoxInsertionB.Size = new System.Drawing.Size(85, 20);
            this.textBoxInsertionB.TabIndex = 25;
            // 
            // DataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInsertionB);
            this.Controls.Add(this.textBoxSelectionB);
            this.Controls.Add(this.textBoxRecursiveB);
            this.Controls.Add(this.textBoxIterativeB);
            this.Controls.Add(this.textBoxInsertionA);
            this.Controls.Add(this.textBoxSelectionA);
            this.Controls.Add(this.textBoxRecursiveA);
            this.Controls.Add(this.textBoxIterativeA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchB);
            this.Controls.Add(this.textBoxSearchA);
            this.Controls.Add(this.numericUpDownMu);
            this.Controls.Add(this.numericUpDownSigma);
            this.Controls.Add(this.buttonInsertionSortB);
            this.Controls.Add(this.buttonSelectionSortB);
            this.Controls.Add(this.buttonBinaryRecursiveB);
            this.Controls.Add(this.buttonBinaryIterativeB);
            this.Controls.Add(this.buttonInsertionSortA);
            this.Controls.Add(this.buttonSelectionSortA);
            this.Controls.Add(this.buttonBinaryRecursiveA);
            this.Controls.Add(this.buttonBinaryIterativeA);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listBoxB);
            this.Controls.Add(this.listBoxA);
            this.Controls.Add(this.listView);
            this.Name = "DataProcessing";
            this.Text = "Data Processing";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.ListBox listBoxB;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonBinaryIterativeA;
        private System.Windows.Forms.Button buttonBinaryRecursiveA;
        private System.Windows.Forms.Button buttonSelectionSortA;
        private System.Windows.Forms.Button buttonInsertionSortA;
        private System.Windows.Forms.Button buttonBinaryIterativeB;
        private System.Windows.Forms.Button buttonBinaryRecursiveB;
        private System.Windows.Forms.Button buttonSelectionSortB;
        private System.Windows.Forms.Button buttonInsertionSortB;
        private System.Windows.Forms.NumericUpDown numericUpDownSigma;
        private System.Windows.Forms.NumericUpDown numericUpDownMu;
        private System.Windows.Forms.TextBox textBoxSearchA;
        private System.Windows.Forms.TextBox textBoxSearchB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIterativeA;
        private System.Windows.Forms.TextBox textBoxRecursiveA;
        private System.Windows.Forms.TextBox textBoxSelectionA;
        private System.Windows.Forms.TextBox textBoxInsertionA;
        private System.Windows.Forms.TextBox textBoxIterativeB;
        private System.Windows.Forms.TextBox textBoxRecursiveB;
        private System.Windows.Forms.TextBox textBoxSelectionB;
        private System.Windows.Forms.TextBox textBoxInsertionB;
    }
}

