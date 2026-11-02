namespace SimpleCalculator
{
    partial class frmSimpleCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOpnd1 = new Label();
            lblOprtr = new Label();
            lblOpnd2 = new Label();
            lblRslt = new Label();
            btnCalc = new Button();
            txtOpnd1 = new TextBox();
            txtOpnd2 = new TextBox();
            txtOprtr = new TextBox();
            txtRslt = new TextBox();
            SuspendLayout();
            // 
            // lblOpnd1
            // 
            lblOpnd1.AutoSize = true;
            lblOpnd1.Location = new Point(63, 44);
            lblOpnd1.Name = "lblOpnd1";
            lblOpnd1.Size = new Size(65, 15);
            lblOpnd1.TabIndex = 0;
            lblOpnd1.Text = "Operand 1:";
            // 
            // lblOprtr
            // 
            lblOprtr.AutoSize = true;
            lblOprtr.Location = new Point(68, 102);
            lblOprtr.Name = "lblOprtr";
            lblOprtr.Size = new Size(54, 15);
            lblOprtr.TabIndex = 1;
            lblOprtr.Text = "Operator";
            // 
            // lblOpnd2
            // 
            lblOpnd2.AutoSize = true;
            lblOpnd2.Location = new Point(63, 152);
            lblOpnd2.Name = "lblOpnd2";
            lblOpnd2.Size = new Size(65, 15);
            lblOpnd2.TabIndex = 2;
            lblOpnd2.Text = "Operand 2:";
            // 
            // lblRslt
            // 
            lblRslt.AutoSize = true;
            lblRslt.Location = new Point(76, 208);
            lblRslt.Name = "lblRslt";
            lblRslt.Size = new Size(39, 15);
            lblRslt.TabIndex = 3;
            lblRslt.Text = "Result";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(107, 259);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(93, 31);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // txtOpnd1
            // 
            txtOpnd1.Location = new Point(176, 40);
            txtOpnd1.Name = "txtOpnd1";
            txtOpnd1.Size = new Size(75, 23);
            txtOpnd1.TabIndex = 6;
            // 
            // txtOpnd2
            // 
            txtOpnd2.Location = new Point(176, 148);
            txtOpnd2.Name = "txtOpnd2";
            txtOpnd2.Size = new Size(75, 23);
            txtOpnd2.TabIndex = 7;
            // 
            // txtOprtr
            // 
            txtOprtr.Location = new Point(176, 98);
            txtOprtr.Name = "txtOprtr";
            txtOprtr.Size = new Size(39, 23);
            txtOprtr.TabIndex = 8;
            // 
            // txtRslt
            // 
            txtRslt.Location = new Point(176, 204);
            txtRslt.Name = "txtRslt";
            txtRslt.ReadOnly = true;
            txtRslt.Size = new Size(75, 23);
            txtRslt.TabIndex = 9;
            // 
            // frmSimpleCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 319);
            Controls.Add(txtRslt);
            Controls.Add(txtOprtr);
            Controls.Add(txtOpnd2);
            Controls.Add(txtOpnd1);
            Controls.Add(btnCalc);
            Controls.Add(lblRslt);
            Controls.Add(lblOpnd2);
            Controls.Add(lblOprtr);
            Controls.Add(lblOpnd1);
            Name = "frmSimpleCalc";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpnd1;
        private Label lblOprtr;
        private Label lblOpnd2;
        private Label lblRslt;
        private Button btnCalc;
        private TextBox txtOpnd1;
        private TextBox txtOpnd2;
        private TextBox txtOprtr;
        private TextBox txtRslt;


    }
}
