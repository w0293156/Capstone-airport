namespace Cap_Airport
{
    partial class MainArea
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpGateControl = new System.Windows.Forms.FlowLayoutPanel();
            this.lbGateControl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.listDepart = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listArrQ = new System.Windows.Forms.ListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGate1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpGateControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.53446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.46554F));
            this.tableLayoutPanel1.Controls.Add(this.flpGateControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flpMain, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.23396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.76605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 483);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flpGateControl
            // 
            this.flpGateControl.Controls.Add(this.lbGateControl);
            this.flpGateControl.Controls.Add(this.checkedListBox1);
            this.flpGateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGateControl.Location = new System.Drawing.Point(3, 433);
            this.flpGateControl.Name = "flpGateControl";
            this.flpGateControl.Size = new System.Drawing.Size(630, 47);
            this.flpGateControl.TabIndex = 1;
            // 
            // lbGateControl
            // 
            this.lbGateControl.AutoSize = true;
            this.lbGateControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbGateControl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGateControl.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbGateControl.Location = new System.Drawing.Point(3, 0);
            this.lbGateControl.Name = "lbGateControl";
            this.lbGateControl.Size = new System.Drawing.Size(32, 32);
            this.lbGateControl.TabIndex = 0;
            this.lbGateControl.Text = "Gate";
            this.lbGateControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbGateControl.UseCompatibleTextRendering = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 55;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.checkedListBox1.Location = new System.Drawing.Point(39, 1);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(586, 30);
            this.checkedListBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(639, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listDepart);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.listArrQ);
            this.splitContainer1.Size = new System.Drawing.Size(139, 424);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "  Departure Queue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listDepart
            // 
            this.listDepart.BackColor = System.Drawing.SystemColors.InfoText;
            this.listDepart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDepart.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listDepart.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.listDepart.Location = new System.Drawing.Point(0, 0);
            this.listDepart.Name = "listDepart";
            this.listDepart.Size = new System.Drawing.Size(139, 221);
            this.listDepart.TabIndex = 1;
            this.listDepart.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "  Arrival Queue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listArrQ
            // 
            this.listArrQ.BackColor = System.Drawing.SystemColors.InfoText;
            this.listArrQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listArrQ.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listArrQ.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.listArrQ.Location = new System.Drawing.Point(0, 0);
            this.listArrQ.Name = "listArrQ";
            this.listArrQ.Size = new System.Drawing.Size(139, 199);
            this.listArrQ.TabIndex = 2;
            this.listArrQ.UseCompatibleStateImageBehavior = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(639, 433);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtWeather);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtTime);
            this.splitContainer2.Size = new System.Drawing.Size(139, 47);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 3;
            // 
            // txtWeather
            // 
            this.txtWeather.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtWeather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeather.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtWeather.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeather.Location = new System.Drawing.Point(0, 0);
            this.txtWeather.Multiline = true;
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(139, 25);
            this.txtWeather.TabIndex = 0;
            this.txtWeather.Text = "wind, speed";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTime.Location = new System.Drawing.Point(0, 0);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(139, 13);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "current time";
            // 
            // flpMain
            // 
            this.flpMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpMain.Controls.Add(this.pnlGate1);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(3, 3);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(630, 424);
            this.flpMain.TabIndex = 4;
            // 
            // pnlGate1
            // 
            this.pnlGate1.BackColor = System.Drawing.Color.Gray;
            this.pnlGate1.Location = new System.Drawing.Point(3, 3);
            this.pnlGate1.Name = "pnlGate1";
            this.pnlGate1.Size = new System.Drawing.Size(28, 200);
            this.pnlGate1.TabIndex = 1;
            // 
            // MainArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(781, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainArea";
            this.Text = "AirportControlSystem";
            this.Load += new System.EventHandler(this.MainArea_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flpGateControl.ResumeLayout(false);
            this.flpGateControl.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpGateControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listDepart;
        private System.Windows.Forms.ListView listArrQ;
        private System.Windows.Forms.Label lbGateControl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGate1;
    }
}

