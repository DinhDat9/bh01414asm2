namespace Asm2
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
            this.components = new System.ComponentModel.Container();
            this.txtname = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbphone = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.btdetele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpeople = new System.Windows.Forms.Label();
            this.btesc = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.lblthis = new System.Windows.Forms.Label();
            this.lbllast = new System.Windows.Forms.Label();
            this.txtthis = new System.Windows.Forms.MaskedTextBox();
            this.txtlast = new System.Windows.Forms.MaskedTextBox();
            this.cbbpeople = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.LVname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVcustomerFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVlastmonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVthismonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVwatermonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVmoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btedit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 27);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(116, 77);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 22);
            this.txtphone.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(6, 33);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 16);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Usename";
            // 
            // lblbphone
            // 
            this.lblbphone.AutoSize = true;
            this.lblbphone.Location = new System.Drawing.Point(6, 80);
            this.lblbphone.Name = "lblbphone";
            this.lblbphone.Size = new System.Drawing.Size(46, 16);
            this.lblbphone.TabIndex = 4;
            this.lblbphone.Text = "Phone";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(125, 252);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 5;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdetele
            // 
            this.btdetele.Location = new System.Drawing.Point(311, 252);
            this.btdetele.Name = "btdetele";
            this.btdetele.Size = new System.Drawing.Size(75, 23);
            this.btdetele.TabIndex = 6;
            this.btdetele.Text = "Delete";
            this.btdetele.UseVisualStyleBackColor = true;
            this.btdetele.Click += new System.EventHandler(this.btdetele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btedit);
            this.groupBox1.Controls.Add(this.lblpeople);
            this.groupBox1.Controls.Add(this.btesc);
            this.groupBox1.Controls.Add(this.btreset);
            this.groupBox1.Controls.Add(this.lblthis);
            this.groupBox1.Controls.Add(this.lbllast);
            this.groupBox1.Controls.Add(this.txtthis);
            this.groupBox1.Controls.Add(this.txtlast);
            this.groupBox1.Controls.Add(this.cbbpeople);
            this.groupBox1.Controls.Add(this.lblbphone);
            this.groupBox1.Controls.Add(this.btdetele);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 290);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblpeople
            // 
            this.lblpeople.AutoSize = true;
            this.lblpeople.Location = new System.Drawing.Point(6, 129);
            this.lblpeople.Name = "lblpeople";
            this.lblpeople.Size = new System.Drawing.Size(89, 16);
            this.lblpeople.TabIndex = 14;
            this.lblpeople.Text = "Customer File";
            this.lblpeople.Click += new System.EventHandler(this.label1_Click);
            // 
            // btesc
            // 
            this.btesc.Location = new System.Drawing.Point(827, 252);
            this.btesc.Name = "btesc";
            this.btesc.Size = new System.Drawing.Size(75, 23);
            this.btesc.TabIndex = 13;
            this.btesc.Text = "Esc";
            this.btesc.UseVisualStyleBackColor = true;
            this.btesc.Click += new System.EventHandler(this.btesc_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(655, 252);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 12;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // lblthis
            // 
            this.lblthis.AutoSize = true;
            this.lblthis.Location = new System.Drawing.Point(284, 86);
            this.lblthis.Name = "lblthis";
            this.lblthis.Size = new System.Drawing.Size(69, 16);
            this.lblthis.TabIndex = 11;
            this.lblthis.Text = "Thismonth";
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Location = new System.Drawing.Point(284, 33);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(68, 16);
            this.lbllast.TabIndex = 10;
            this.lbllast.Text = "Lastmonth";
            // 
            // txtthis
            // 
            this.txtthis.Location = new System.Drawing.Point(386, 86);
            this.txtthis.Name = "txtthis";
            this.txtthis.Size = new System.Drawing.Size(100, 22);
            this.txtthis.TabIndex = 9;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(386, 33);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 22);
            this.txtlast.TabIndex = 8;
            // 
            // cbbpeople
            // 
            this.cbbpeople.FormattingEnabled = true;
            this.cbbpeople.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.cbbpeople.Location = new System.Drawing.Point(116, 126);
            this.cbbpeople.Name = "cbbpeople";
            this.cbbpeople.Size = new System.Drawing.Size(126, 24);
            this.cbbpeople.TabIndex = 7;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVname,
            this.LVphone,
            this.LVcustomerFile,
            this.LVlastmonth,
            this.LVthismonth,
            this.LVwatermonth,
            this.LVmoney});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 358);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1075, 152);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LVname
            // 
            this.LVname.Text = "Usename";
            this.LVname.Width = 100;
            // 
            // LVphone
            // 
            this.LVphone.Text = "Phone";
            this.LVphone.Width = 100;
            // 
            // LVcustomerFile
            // 
            this.LVcustomerFile.Text = "Customer File";
            this.LVcustomerFile.Width = 146;
            // 
            // LVlastmonth
            // 
            this.LVlastmonth.Text = "Lastmonth";
            // 
            // LVthismonth
            // 
            this.LVthismonth.Text = "Thismonth";
            // 
            // LVwatermonth
            // 
            this.LVwatermonth.Text = "Amount of water month";
            this.LVwatermonth.Width = 188;
            // 
            // LVmoney
            // 
            this.LVmoney.Text = "Total money";
            this.LVmoney.Width = 100;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "CARCULATE WATER BILL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(500, 252);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 23);
            this.btedit.TabIndex = 15;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox txtphone;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbphone;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdetele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbpeople;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Label lblthis;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.MaskedTextBox txtthis;
        private System.Windows.Forms.MaskedTextBox txtlast;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btesc;
        private System.Windows.Forms.Label lblpeople;
        private System.Windows.Forms.ColumnHeader LVphone;
        private System.Windows.Forms.ColumnHeader LVcustomerFile;
        private System.Windows.Forms.ColumnHeader LVlastmonth;
        private System.Windows.Forms.ColumnHeader LVthismonth;
        private System.Windows.Forms.ColumnHeader LVwatermonth;
        private System.Windows.Forms.ColumnHeader LVmoney;
        private System.Windows.Forms.ColumnHeader LVname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btedit;
    }
}

