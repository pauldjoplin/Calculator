namespace Module10Project
{
    partial class frmStarOfTheRadio
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rgtOp = new System.Windows.Forms.TextBox();
            this.lftOp = new System.Windows.Forms.TextBox();
            this.lblLft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.functionGrp = new System.Windows.Forms.GroupBox();
            this.chkVerbose = new System.Windows.Forms.CheckBox();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.radioMod = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.functionGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(284, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 31);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(390, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rgtOp
            // 
            this.rgtOp.Location = new System.Drawing.Point(361, 22);
            this.rgtOp.Name = "rgtOp";
            this.rgtOp.Size = new System.Drawing.Size(100, 20);
            this.rgtOp.TabIndex = 2;
            this.rgtOp.TextChanged += new System.EventHandler(this.rgtOp_TextChanged);
            // 
            // lftOp
            // 
            this.lftOp.Location = new System.Drawing.Point(123, 23);
            this.lftOp.Name = "lftOp";
            this.lftOp.Size = new System.Drawing.Size(100, 20);
            this.lftOp.TabIndex = 1;
            this.lftOp.TextChanged += new System.EventHandler(this.lftOp_TextChanged);
            // 
            // lblLft
            // 
            this.lblLft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLft.Location = new System.Drawing.Point(25, 22);
            this.lblLft.Name = "lblLft";
            this.lblLft.Size = new System.Drawing.Size(96, 32);
            this.lblLft.TabIndex = 4;
            this.lblLft.Text = "Left Operand:";
            // 
            // lblRight
            // 
            this.lblRight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(253, 21);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(105, 32);
            this.lblRight.TabIndex = 5;
            this.lblRight.Text = "Right Operand:";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCompute.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(109, 168);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(100, 31);
            this.btnCompute.TabIndex = 9;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Silver;
            this.lblMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(29, 217);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(432, 140);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // functionGrp
            // 
            this.functionGrp.Controls.Add(this.chkVerbose);
            this.functionGrp.Controls.Add(this.radioDivide);
            this.functionGrp.Controls.Add(this.radioMultiply);
            this.functionGrp.Controls.Add(this.radioMod);
            this.functionGrp.Controls.Add(this.radioSubtract);
            this.functionGrp.Controls.Add(this.radioAdd);
            this.functionGrp.Location = new System.Drawing.Point(132, 62);
            this.functionGrp.Name = "functionGrp";
            this.functionGrp.Size = new System.Drawing.Size(236, 100);
            this.functionGrp.TabIndex = 8;
            this.functionGrp.TabStop = false;
            // 
            // chkVerbose
            // 
            this.chkVerbose.AutoSize = true;
            this.chkVerbose.Location = new System.Drawing.Point(131, 66);
            this.chkVerbose.Name = "chkVerbose";
            this.chkVerbose.Size = new System.Drawing.Size(95, 17);
            this.chkVerbose.TabIndex = 8;
            this.chkVerbose.Text = "Verbose Mode";
            this.chkVerbose.UseVisualStyleBackColor = true;
            this.chkVerbose.CheckedChanged += new System.EventHandler(this.chkVerbose_CheckedChanged);
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Location = new System.Drawing.Point(131, 19);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(75, 17);
            this.radioDivide.TabIndex = 6;
            this.radioDivide.TabStop = true;
            this.radioDivide.Text = "Divide ( / )";
            this.radioDivide.UseVisualStyleBackColor = true;
            this.radioDivide.CheckedChanged += new System.EventHandler(this.radioDivide_CheckedChanged);
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.Location = new System.Drawing.Point(15, 65);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(79, 17);
            this.radioMultiply.TabIndex = 5;
            this.radioMultiply.TabStop = true;
            this.radioMultiply.Text = "Multiply ( * )";
            this.radioMultiply.UseVisualStyleBackColor = true;
            this.radioMultiply.CheckedChanged += new System.EventHandler(this.radioMultiply_CheckedChanged);
            // 
            // radioMod
            // 
            this.radioMod.AutoSize = true;
            this.radioMod.Location = new System.Drawing.Point(131, 42);
            this.radioMod.Name = "radioMod";
            this.radioMod.Size = new System.Drawing.Size(88, 17);
            this.radioMod.TabIndex = 7;
            this.radioMod.TabStop = true;
            this.radioMod.Text = "Modulus ( % )";
            this.radioMod.UseVisualStyleBackColor = true;
            this.radioMod.CheckedChanged += new System.EventHandler(this.radioMod_CheckedChanged);
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Location = new System.Drawing.Point(14, 42);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(83, 17);
            this.radioSubtract.TabIndex = 4;
            this.radioSubtract.TabStop = true;
            this.radioSubtract.Text = "Subtract ( - )";
            this.radioSubtract.UseVisualStyleBackColor = true;
            this.radioSubtract.CheckedChanged += new System.EventHandler(this.radioSubtract_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(14, 19);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(84, 17);
            this.radioAdd.TabIndex = 3;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Addition ( + )";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // frmStarOfTheRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(492, 403);
            this.Controls.Add(this.functionGrp);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLft);
            this.Controls.Add(this.lftOp);
            this.Controls.Add(this.rgtOp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Name = "frmStarOfTheRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStarOfTheRadio";
            this.functionGrp.ResumeLayout(false);
            this.functionGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox rgtOp;
        private System.Windows.Forms.TextBox lftOp;
        private System.Windows.Forms.Label lblLft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox functionGrp;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.RadioButton radioMod;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.CheckBox chkVerbose;
    }
}

