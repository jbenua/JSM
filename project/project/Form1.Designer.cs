namespace project
{
    partial class Form1
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
            this.norrisbtn = new System.Windows.Forms.Button();
            this.norrisout = new System.Windows.Forms.Label();
            this.dsm_btn = new System.Windows.Forms.Button();
            this.hyp_out = new System.Windows.Forms.Label();
            this.In_Sets = new System.Windows.Forms.DataGridView();
            this.Out_Sets = new System.Windows.Forms.DataGridView();
            this.setSizeBtn_DSM = new System.Windows.Forms.Button();
            this.sizeCols_DSM = new System.Windows.Forms.TextBox();
            this.sizeRows_DSM = new System.Windows.Forms.TextBox();
            this.attributes = new System.Windows.Forms.DataGridView();
            this.objects = new System.Windows.Forms.DataGridView();
            this.objects1 = new System.Windows.Forms.DataGridView();
            this.attributes1 = new System.Windows.Forms.DataGridView();
            this.tau = new System.Windows.Forms.DataGridView();
            this.attributes2 = new System.Windows.Forms.DataGridView();
            this.objects2 = new System.Windows.Forms.DataGridView();
            this.setsizeBtn1 = new System.Windows.Forms.Button();
            this.setsizeBtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fill_default = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hypothesis = new System.Windows.Forms.TextBox();
            this.nerd_on = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.In_Sets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Out_Sets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objects1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objects2)).BeginInit();
            this.SuspendLayout();
            // 
            // norrisbtn
            // 
            this.norrisbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.norrisbtn.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold);
            this.norrisbtn.ForeColor = System.Drawing.Color.Aquamarine;
            this.norrisbtn.Location = new System.Drawing.Point(7, 201);
            this.norrisbtn.Name = "norrisbtn";
            this.norrisbtn.Size = new System.Drawing.Size(104, 49);
            this.norrisbtn.TabIndex = 35;
            this.norrisbtn.Text = "Norris it!";
            this.norrisbtn.UseVisualStyleBackColor = false;
            this.norrisbtn.Visible = false;
            this.norrisbtn.Click += new System.EventHandler(this.norrisbtn_Click);
            // 
            // norrisout
            // 
            this.norrisout.AutoSize = true;
            this.norrisout.Location = new System.Drawing.Point(67, 171);
            this.norrisout.Name = "norrisout";
            this.norrisout.Size = new System.Drawing.Size(10, 13);
            this.norrisout.TabIndex = 36;
            this.norrisout.Text = "-";
            // 
            // dsm_btn
            // 
            this.dsm_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dsm_btn.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold);
            this.dsm_btn.ForeColor = System.Drawing.Color.Aquamarine;
            this.dsm_btn.Location = new System.Drawing.Point(8, 118);
            this.dsm_btn.Name = "dsm_btn";
            this.dsm_btn.Size = new System.Drawing.Size(104, 44);
            this.dsm_btn.TabIndex = 39;
            this.dsm_btn.Text = "DSM IT!";
            this.dsm_btn.UseVisualStyleBackColor = false;
            this.dsm_btn.Click += new System.EventHandler(this.dsm_btn_Click);
            // 
            // hyp_out
            // 
            this.hyp_out.AutoSize = true;
            this.hyp_out.Location = new System.Drawing.Point(21, 641);
            this.hyp_out.Name = "hyp_out";
            this.hyp_out.Size = new System.Drawing.Size(74, 13);
            this.hyp_out.TabIndex = 40;
            this.hyp_out.Text = "hypothesises: ";
            this.hyp_out.Visible = false;
            // 
            // In_Sets
            // 
            this.In_Sets.AllowUserToAddRows = false;
            this.In_Sets.AllowUserToDeleteRows = false;
            this.In_Sets.AllowUserToOrderColumns = true;
            this.In_Sets.AllowUserToResizeColumns = false;
            this.In_Sets.AllowUserToResizeRows = false;
            this.In_Sets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.In_Sets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.In_Sets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.In_Sets.ColumnHeadersVisible = false;
            this.In_Sets.Location = new System.Drawing.Point(211, 53);
            this.In_Sets.Name = "In_Sets";
            this.In_Sets.RowHeadersVisible = false;
            this.In_Sets.Size = new System.Drawing.Size(984, 163);
            this.In_Sets.TabIndex = 0;
            // 
            // Out_Sets
            // 
            this.Out_Sets.AllowUserToAddRows = false;
            this.Out_Sets.AllowUserToDeleteRows = false;
            this.Out_Sets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Out_Sets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Out_Sets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Out_Sets.ColumnHeadersVisible = false;
            this.Out_Sets.Location = new System.Drawing.Point(211, 260);
            this.Out_Sets.Name = "Out_Sets";
            this.Out_Sets.RowHeadersVisible = false;
            this.Out_Sets.Size = new System.Drawing.Size(984, 163);
            this.Out_Sets.TabIndex = 1;
            // 
            // setSizeBtn_DSM
            // 
            this.setSizeBtn_DSM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.setSizeBtn_DSM.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setSizeBtn_DSM.ForeColor = System.Drawing.Color.Aquamarine;
            this.setSizeBtn_DSM.Location = new System.Drawing.Point(119, 15);
            this.setSizeBtn_DSM.Name = "setSizeBtn_DSM";
            this.setSizeBtn_DSM.Size = new System.Drawing.Size(86, 36);
            this.setSizeBtn_DSM.TabIndex = 3;
            this.setSizeBtn_DSM.Text = "set da size";
            this.setSizeBtn_DSM.UseVisualStyleBackColor = false;
            this.setSizeBtn_DSM.Click += new System.EventHandler(this.setSizeBtn_DSM_Click);
            // 
            // sizeCols_DSM
            // 
            this.sizeCols_DSM.HideSelection = false;
            this.sizeCols_DSM.Location = new System.Drawing.Point(54, 17);
            this.sizeCols_DSM.Name = "sizeCols_DSM";
            this.sizeCols_DSM.Size = new System.Drawing.Size(57, 20);
            this.sizeCols_DSM.TabIndex = 27;
            // 
            // sizeRows_DSM
            // 
            this.sizeRows_DSM.HideSelection = false;
            this.sizeRows_DSM.Location = new System.Drawing.Point(54, 41);
            this.sizeRows_DSM.Name = "sizeRows_DSM";
            this.sizeRows_DSM.Size = new System.Drawing.Size(57, 20);
            this.sizeRows_DSM.TabIndex = 28;
            // 
            // attributes
            // 
            this.attributes.AllowUserToAddRows = false;
            this.attributes.AllowUserToDeleteRows = false;
            this.attributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attributes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributes.ColumnHeadersVisible = false;
            this.attributes.Location = new System.Drawing.Point(211, 15);
            this.attributes.Name = "attributes";
            this.attributes.RowHeadersVisible = false;
            this.attributes.Size = new System.Drawing.Size(984, 36);
            this.attributes.TabIndex = 29;
            // 
            // objects
            // 
            this.objects.AllowUserToAddRows = false;
            this.objects.AllowUserToDeleteRows = false;
            this.objects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.objects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.objects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objects.ColumnHeadersVisible = false;
            this.objects.Location = new System.Drawing.Point(119, 53);
            this.objects.Name = "objects";
            this.objects.RowHeadersVisible = false;
            this.objects.Size = new System.Drawing.Size(86, 163);
            this.objects.TabIndex = 30;
            // 
            // objects1
            // 
            this.objects1.AllowUserToAddRows = false;
            this.objects1.AllowUserToDeleteRows = false;
            this.objects1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.objects1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.objects1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objects1.ColumnHeadersVisible = false;
            this.objects1.Location = new System.Drawing.Point(211, 222);
            this.objects1.Name = "objects1";
            this.objects1.RowHeadersVisible = false;
            this.objects1.Size = new System.Drawing.Size(984, 36);
            this.objects1.TabIndex = 31;
            // 
            // attributes1
            // 
            this.attributes1.AllowUserToAddRows = false;
            this.attributes1.AllowUserToDeleteRows = false;
            this.attributes1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attributes1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attributes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributes1.ColumnHeadersVisible = false;
            this.attributes1.Location = new System.Drawing.Point(119, 260);
            this.attributes1.Name = "attributes1";
            this.attributes1.RowHeadersVisible = false;
            this.attributes1.Size = new System.Drawing.Size(86, 163);
            this.attributes1.TabIndex = 32;
            // 
            // tau
            // 
            this.tau.AllowUserToAddRows = false;
            this.tau.AllowUserToDeleteRows = false;
            this.tau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tau.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tau.ColumnHeadersVisible = false;
            this.tau.Location = new System.Drawing.Point(211, 469);
            this.tau.Name = "tau";
            this.tau.RowHeadersVisible = false;
            this.tau.Size = new System.Drawing.Size(984, 163);
            this.tau.TabIndex = 33;
            // 
            // attributes2
            // 
            this.attributes2.AllowUserToAddRows = false;
            this.attributes2.AllowUserToDeleteRows = false;
            this.attributes2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attributes2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attributes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributes2.ColumnHeadersVisible = false;
            this.attributes2.Location = new System.Drawing.Point(211, 431);
            this.attributes2.Name = "attributes2";
            this.attributes2.RowHeadersVisible = false;
            this.attributes2.Size = new System.Drawing.Size(984, 36);
            this.attributes2.TabIndex = 34;
            // 
            // objects2
            // 
            this.objects2.AllowUserToAddRows = false;
            this.objects2.AllowUserToDeleteRows = false;
            this.objects2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.objects2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.objects2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objects2.ColumnHeadersVisible = false;
            this.objects2.Location = new System.Drawing.Point(119, 469);
            this.objects2.Name = "objects2";
            this.objects2.RowHeadersVisible = false;
            this.objects2.Size = new System.Drawing.Size(86, 163);
            this.objects2.TabIndex = 35;
            // 
            // setsizeBtn1
            // 
            this.setsizeBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.setsizeBtn1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setsizeBtn1.ForeColor = System.Drawing.Color.Aquamarine;
            this.setsizeBtn1.Location = new System.Drawing.Point(119, 222);
            this.setsizeBtn1.Name = "setsizeBtn1";
            this.setsizeBtn1.Size = new System.Drawing.Size(86, 36);
            this.setsizeBtn1.TabIndex = 36;
            this.setsizeBtn1.Text = "set da size";
            this.setsizeBtn1.UseVisualStyleBackColor = false;
            this.setsizeBtn1.Click += new System.EventHandler(this.setsizeBtn1_Click);
            // 
            // setsizeBtn2
            // 
            this.setsizeBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.setsizeBtn2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setsizeBtn2.ForeColor = System.Drawing.Color.Aquamarine;
            this.setsizeBtn2.Location = new System.Drawing.Point(119, 431);
            this.setsizeBtn2.Name = "setsizeBtn2";
            this.setsizeBtn2.Size = new System.Drawing.Size(86, 36);
            this.setsizeBtn2.TabIndex = 37;
            this.setsizeBtn2.Text = "set da size";
            this.setsizeBtn2.UseVisualStyleBackColor = false;
            this.setsizeBtn2.Click += new System.EventHandler(this.setsizeBtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "height: ";
            // 
            // fill_default
            // 
            this.fill_default.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fill_default.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill_default.ForeColor = System.Drawing.Color.Aquamarine;
            this.fill_default.Location = new System.Drawing.Point(9, 67);
            this.fill_default.Name = "fill_default";
            this.fill_default.Size = new System.Drawing.Size(103, 45);
            this.fill_default.TabIndex = 43;
            this.fill_default.Text = "Fill with default data";
            this.fill_default.UseVisualStyleBackColor = false;
            this.fill_default.Click += new System.EventHandler(this.fill_default_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "iterations:";
            // 
            // hypothesis
            // 
            this.hypothesis.Location = new System.Drawing.Point(119, 638);
            this.hypothesis.Multiline = true;
            this.hypothesis.Name = "hypothesis";
            this.hypothesis.Size = new System.Drawing.Size(1076, 79);
            this.hypothesis.TabIndex = 45;
            this.hypothesis.Visible = false;
            // 
            // nerd_on
            // 
            this.nerd_on.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nerd_on.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nerd_on.ForeColor = System.Drawing.Color.Aquamarine;
            this.nerd_on.Location = new System.Drawing.Point(7, 563);
            this.nerd_on.Name = "nerd_on";
            this.nerd_on.Size = new System.Drawing.Size(106, 68);
            this.nerd_on.TabIndex = 46;
            this.nerd_on.Text = "show info for nerds";
            this.nerd_on.UseVisualStyleBackColor = false;
            this.nerd_on.Click += new System.EventHandler(this.nerd_on_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1207, 644);
            this.Controls.Add(this.nerd_on);
            this.Controls.Add(this.hypothesis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fill_default);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setsizeBtn2);
            this.Controls.Add(this.hyp_out);
            this.Controls.Add(this.setsizeBtn1);
            this.Controls.Add(this.dsm_btn);
            this.Controls.Add(this.objects2);
            this.Controls.Add(this.norrisout);
            this.Controls.Add(this.attributes2);
            this.Controls.Add(this.norrisbtn);
            this.Controls.Add(this.tau);
            this.Controls.Add(this.attributes1);
            this.Controls.Add(this.objects1);
            this.Controls.Add(this.In_Sets);
            this.Controls.Add(this.objects);
            this.Controls.Add(this.Out_Sets);
            this.Controls.Add(this.attributes);
            this.Controls.Add(this.sizeRows_DSM);
            this.Controls.Add(this.setSizeBtn_DSM);
            this.Controls.Add(this.sizeCols_DSM);
            this.Name = "Form1";
            this.Text = "DSM Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.In_Sets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Out_Sets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objects1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objects2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button norrisbtn;
        private System.Windows.Forms.Label norrisout;
        private System.Windows.Forms.Button dsm_btn;
        private System.Windows.Forms.Label hyp_out;
        private System.Windows.Forms.DataGridView In_Sets;
        private System.Windows.Forms.DataGridView Out_Sets;
        private System.Windows.Forms.Button setSizeBtn_DSM;
        private System.Windows.Forms.TextBox sizeCols_DSM;
        private System.Windows.Forms.TextBox sizeRows_DSM;
        private System.Windows.Forms.DataGridView attributes;
        private System.Windows.Forms.DataGridView objects;
        private System.Windows.Forms.DataGridView objects1;
        private System.Windows.Forms.DataGridView attributes1;
        private System.Windows.Forms.DataGridView tau;
        private System.Windows.Forms.DataGridView attributes2;
        private System.Windows.Forms.DataGridView objects2;
        private System.Windows.Forms.Button setsizeBtn1;
        private System.Windows.Forms.Button setsizeBtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fill_default;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hypothesis;
        private System.Windows.Forms.Button nerd_on;
    }
}

