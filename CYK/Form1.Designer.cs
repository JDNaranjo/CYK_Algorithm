namespace CYK
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.variablesTxt = new System.Windows.Forms.TextBox();
            this.variablesBtn = new System.Windows.Forms.Button();
            this.terminalsBtn = new System.Windows.Forms.Button();
            this.terminalsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.symbolsBtn = new System.Windows.Forms.Button();
            this.productionsTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productionsBox = new System.Windows.Forms.ComboBox();
            this.stringBtn = new System.Windows.Forms.Button();
            this.stringTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.variableBox = new System.Windows.Forms.ComboBox();
            this.productionBtn = new System.Windows.Forms.Button();
            this.createGramaticBtn = new System.Windows.Forms.Button();
            this.variableLbl = new System.Windows.Forms.Label();
            this.terminalLbl = new System.Windows.Forms.Label();
            this.productionLbl = new System.Windows.Forms.Label();
            this.gramaticBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.gramaticBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritmo CYK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variables:";
            // 
            // variablesTxt
            // 
            this.variablesTxt.Location = new System.Drawing.Point(96, 24);
            this.variablesTxt.Name = "variablesTxt";
            this.variablesTxt.Size = new System.Drawing.Size(100, 22);
            this.variablesTxt.TabIndex = 3;
            // 
            // variablesBtn
            // 
            this.variablesBtn.Location = new System.Drawing.Point(202, 24);
            this.variablesBtn.Name = "variablesBtn";
            this.variablesBtn.Size = new System.Drawing.Size(75, 23);
            this.variablesBtn.TabIndex = 4;
            this.variablesBtn.Text = "Add";
            this.variablesBtn.UseVisualStyleBackColor = true;
            this.variablesBtn.Click += new System.EventHandler(this.variablesBtn_Click);
            // 
            // terminalsBtn
            // 
            this.terminalsBtn.Location = new System.Drawing.Point(202, 52);
            this.terminalsBtn.Name = "terminalsBtn";
            this.terminalsBtn.Size = new System.Drawing.Size(75, 23);
            this.terminalsBtn.TabIndex = 7;
            this.terminalsBtn.Text = "Add";
            this.terminalsBtn.UseVisualStyleBackColor = true;
            this.terminalsBtn.Click += new System.EventHandler(this.terminalsBtn_Click);
            // 
            // terminalsTxt
            // 
            this.terminalsTxt.Location = new System.Drawing.Point(96, 52);
            this.terminalsTxt.Name = "terminalsTxt";
            this.terminalsTxt.Size = new System.Drawing.Size(100, 22);
            this.terminalsTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Terminals:";
            // 
            // symbolsBtn
            // 
            this.symbolsBtn.Location = new System.Drawing.Point(350, 103);
            this.symbolsBtn.Name = "symbolsBtn";
            this.symbolsBtn.Size = new System.Drawing.Size(100, 26);
            this.symbolsBtn.TabIndex = 10;
            this.symbolsBtn.Text = "Add symbol";
            this.symbolsBtn.UseVisualStyleBackColor = true;
            this.symbolsBtn.Click += new System.EventHandler(this.symbolsBtn_Click);
            // 
            // productionsTxt
            // 
            this.productionsTxt.Enabled = false;
            this.productionsTxt.Location = new System.Drawing.Point(96, 138);
            this.productionsTxt.Name = "productionsTxt";
            this.productionsTxt.Size = new System.Drawing.Size(121, 22);
            this.productionsTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Productions:";
            // 
            // productionsBox
            // 
            this.productionsBox.FormattingEnabled = true;
            this.productionsBox.Location = new System.Drawing.Point(223, 104);
            this.productionsBox.Name = "productionsBox";
            this.productionsBox.Size = new System.Drawing.Size(121, 24);
            this.productionsBox.TabIndex = 11;
            // 
            // stringBtn
            // 
            this.stringBtn.Location = new System.Drawing.Point(206, 33);
            this.stringBtn.Name = "stringBtn";
            this.stringBtn.Size = new System.Drawing.Size(75, 23);
            this.stringBtn.TabIndex = 14;
            this.stringBtn.Text = "Check";
            this.stringBtn.UseVisualStyleBackColor = true;
            this.stringBtn.Click += new System.EventHandler(this.stringBtn_Click);
            // 
            // stringTxt
            // 
            this.stringTxt.Location = new System.Drawing.Point(100, 33);
            this.stringTxt.Name = "stringTxt";
            this.stringTxt.Size = new System.Drawing.Size(100, 22);
            this.stringTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "String:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(118, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Variable -->";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(220, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Production symbols";
            // 
            // variableBox
            // 
            this.variableBox.FormattingEnabled = true;
            this.variableBox.Location = new System.Drawing.Point(96, 104);
            this.variableBox.Name = "variableBox";
            this.variableBox.Size = new System.Drawing.Size(121, 24);
            this.variableBox.TabIndex = 19;
            // 
            // productionBtn
            // 
            this.productionBtn.Location = new System.Drawing.Point(223, 136);
            this.productionBtn.Name = "productionBtn";
            this.productionBtn.Size = new System.Drawing.Size(121, 26);
            this.productionBtn.TabIndex = 20;
            this.productionBtn.Text = "Add production";
            this.productionBtn.UseVisualStyleBackColor = true;
            this.productionBtn.Click += new System.EventHandler(this.productionBtn_Click);
            // 
            // createGramaticBtn
            // 
            this.createGramaticBtn.Location = new System.Drawing.Point(11, 227);
            this.createGramaticBtn.Name = "createGramaticBtn";
            this.createGramaticBtn.Size = new System.Drawing.Size(439, 26);
            this.createGramaticBtn.TabIndex = 21;
            this.createGramaticBtn.Text = "Create Gramatic";
            this.createGramaticBtn.UseVisualStyleBackColor = true;
            this.createGramaticBtn.Click += new System.EventHandler(this.createGramaticBtn_Click);
            // 
            // variableLbl
            // 
            this.variableLbl.AutoSize = true;
            this.variableLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variableLbl.Location = new System.Drawing.Point(283, 27);
            this.variableLbl.Name = "variableLbl";
            this.variableLbl.Size = new System.Drawing.Size(20, 17);
            this.variableLbl.TabIndex = 22;
            this.variableLbl.Text = "...";
            // 
            // terminalLbl
            // 
            this.terminalLbl.AutoSize = true;
            this.terminalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminalLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.terminalLbl.Location = new System.Drawing.Point(283, 55);
            this.terminalLbl.Name = "terminalLbl";
            this.terminalLbl.Size = new System.Drawing.Size(20, 17);
            this.terminalLbl.TabIndex = 23;
            this.terminalLbl.Text = "...";
            // 
            // productionLbl
            // 
            this.productionLbl.AutoSize = true;
            this.productionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productionLbl.Location = new System.Drawing.Point(347, 141);
            this.productionLbl.Name = "productionLbl";
            this.productionLbl.Size = new System.Drawing.Size(20, 17);
            this.productionLbl.TabIndex = 24;
            this.productionLbl.Text = "...";
            // 
            // gramaticBox
            // 
            this.gramaticBox.Controls.Add(this.terminalsTxt);
            this.gramaticBox.Controls.Add(this.productionLbl);
            this.gramaticBox.Controls.Add(this.label2);
            this.gramaticBox.Controls.Add(this.terminalLbl);
            this.gramaticBox.Controls.Add(this.variablesTxt);
            this.gramaticBox.Controls.Add(this.variableLbl);
            this.gramaticBox.Controls.Add(this.variablesBtn);
            this.gramaticBox.Controls.Add(this.createGramaticBtn);
            this.gramaticBox.Controls.Add(this.label3);
            this.gramaticBox.Controls.Add(this.productionBtn);
            this.gramaticBox.Controls.Add(this.terminalsBtn);
            this.gramaticBox.Controls.Add(this.variableBox);
            this.gramaticBox.Controls.Add(this.label4);
            this.gramaticBox.Controls.Add(this.label9);
            this.gramaticBox.Controls.Add(this.productionsTxt);
            this.gramaticBox.Controls.Add(this.label8);
            this.gramaticBox.Controls.Add(this.symbolsBtn);
            this.gramaticBox.Controls.Add(this.productionsBox);
            this.gramaticBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramaticBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gramaticBox.Location = new System.Drawing.Point(12, 69);
            this.gramaticBox.Name = "gramaticBox";
            this.gramaticBox.Size = new System.Drawing.Size(765, 272);
            this.gramaticBox.TabIndex = 25;
            this.gramaticBox.TabStop = false;
            this.gramaticBox.Text = "Gramatic CNF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputLbl);
            this.groupBox2.Controls.Add(this.stringTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.stringBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 76);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input string";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputLbl.Location = new System.Drawing.Point(287, 36);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(20, 17);
            this.outputLbl.TabIndex = 25;
            this.outputLbl.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gramaticBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gramaticBox.ResumeLayout(false);
            this.gramaticBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox variablesTxt;
        private System.Windows.Forms.Button variablesBtn;
        private System.Windows.Forms.Button terminalsBtn;
        private System.Windows.Forms.TextBox terminalsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button symbolsBtn;
        private System.Windows.Forms.TextBox productionsTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productionsBox;
        private System.Windows.Forms.Button stringBtn;
        private System.Windows.Forms.TextBox stringTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox variableBox;
        private System.Windows.Forms.Button productionBtn;
        private System.Windows.Forms.Button createGramaticBtn;
        private System.Windows.Forms.Label variableLbl;
        private System.Windows.Forms.Label terminalLbl;
        private System.Windows.Forms.Label productionLbl;
        private System.Windows.Forms.GroupBox gramaticBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label outputLbl;
    }
}

