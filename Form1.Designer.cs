namespace ToDo
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
            this.lstvMainView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToDoCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Piority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpcFill = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblPiority = new System.Windows.Forms.Label();
            this.cmbPiority = new System.Windows.Forms.ComboBox();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.lblToDo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbGroup = new System.Windows.Forms.RadioButton();
            this.rnbDate = new System.Windows.Forms.RadioButton();
            this.rdbPiority = new System.Windows.Forms.RadioButton();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnTaskFinish = new System.Windows.Forms.Button();
            this.btnDetailAdd = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstToDoDetails = new System.Windows.Forms.ListView();
            this.DetailsLp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpcFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvMainView
            // 
            this.lstvMainView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Lp,
            this.ToDoCol,
            this.Piority,
            this.Group,
            this.Date});
            this.lstvMainView.FullRowSelect = true;
            this.lstvMainView.Location = new System.Drawing.Point(12, 12);
            this.lstvMainView.MultiSelect = false;
            this.lstvMainView.Name = "lstvMainView";
            this.lstvMainView.Size = new System.Drawing.Size(724, 253);
            this.lstvMainView.TabIndex = 0;
            this.lstvMainView.UseCompatibleStateImageBehavior = false;
            this.lstvMainView.View = System.Windows.Forms.View.Details;
            this.lstvMainView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstvMainView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // Lp
            // 
            this.Lp.Text = "Lp";
            this.Lp.Width = 30;
            // 
            // ToDoCol
            // 
            this.ToDoCol.Text = "Zrób to";
            this.ToDoCol.Width = 250;
            // 
            // Piority
            // 
            this.Piority.Text = "Piorytet";
            // 
            // Group
            // 
            this.Group.Text = "Grupa";
            this.Group.Width = 70;
            // 
            // Date
            // 
            this.Date.Text = "Data zakończenia";
            this.Date.Width = 131;
            // 
            // gpcFill
            // 
            this.gpcFill.Controls.Add(this.btnDelete);
            this.gpcFill.Controls.Add(this.btnAdd);
            this.gpcFill.Controls.Add(this.lblDate);
            this.gpcFill.Controls.Add(this.dateFinish);
            this.gpcFill.Controls.Add(this.cmbGroup);
            this.gpcFill.Controls.Add(this.lblGroup);
            this.gpcFill.Controls.Add(this.lblPiority);
            this.gpcFill.Controls.Add(this.cmbPiority);
            this.gpcFill.Controls.Add(this.txtToDo);
            this.gpcFill.Controls.Add(this.lblToDo);
            this.gpcFill.Location = new System.Drawing.Point(12, 271);
            this.gpcFill.Name = "gpcFill";
            this.gpcFill.Size = new System.Drawing.Size(329, 201);
            this.gpcFill.TabIndex = 1;
            this.gpcFill.TabStop = false;
            this.gpcFill.Text = "Dodaj rzecz do zrobienia";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Data:";
            // 
            // dateFinish
            // 
            this.dateFinish.Location = new System.Drawing.Point(118, 127);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(200, 22);
            this.dateFinish.TabIndex = 6;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(118, 97);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(121, 24);
            this.cmbGroup.TabIndex = 5;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(20, 100);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(52, 17);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Grupa:";
            // 
            // lblPiority
            // 
            this.lblPiority.AutoSize = true;
            this.lblPiority.Location = new System.Drawing.Point(20, 70);
            this.lblPiority.Name = "lblPiority";
            this.lblPiority.Size = new System.Drawing.Size(60, 17);
            this.lblPiority.TabIndex = 3;
            this.lblPiority.Text = "Piorytet:";
            // 
            // cmbPiority
            // 
            this.cmbPiority.FormattingEnabled = true;
            this.cmbPiority.Location = new System.Drawing.Point(118, 67);
            this.cmbPiority.Name = "cmbPiority";
            this.cmbPiority.Size = new System.Drawing.Size(121, 24);
            this.cmbPiority.TabIndex = 2;
            // 
            // txtToDo
            // 
            this.txtToDo.Location = new System.Drawing.Point(118, 37);
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(200, 22);
            this.txtToDo.TabIndex = 1;
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(20, 40);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(92, 17);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "Do zrobienia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGroup);
            this.groupBox1.Controls.Add(this.rnbDate);
            this.groupBox1.Controls.Add(this.rdbPiority);
            this.groupBox1.Location = new System.Drawing.Point(347, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtry";
            // 
            // rdbGroup
            // 
            this.rdbGroup.AutoSize = true;
            this.rdbGroup.Location = new System.Drawing.Point(20, 100);
            this.rdbGroup.Name = "rdbGroup";
            this.rdbGroup.Size = new System.Drawing.Size(69, 21);
            this.rdbGroup.TabIndex = 2;
            this.rdbGroup.TabStop = true;
            this.rdbGroup.Text = "Grupa";
            this.rdbGroup.UseVisualStyleBackColor = true;
            this.rdbGroup.Click += new System.EventHandler(this.rdbGroup_Click);
            // 
            // rnbDate
            // 
            this.rnbDate.AutoSize = true;
            this.rnbDate.Location = new System.Drawing.Point(20, 70);
            this.rnbDate.Name = "rnbDate";
            this.rnbDate.Size = new System.Drawing.Size(59, 21);
            this.rnbDate.TabIndex = 1;
            this.rnbDate.TabStop = true;
            this.rnbDate.Text = "Data";
            this.rnbDate.UseVisualStyleBackColor = true;
            this.rnbDate.Click += new System.EventHandler(this.rnbDate_Click);
            // 
            // rdbPiority
            // 
            this.rdbPiority.AutoSize = true;
            this.rdbPiority.Location = new System.Drawing.Point(20, 40);
            this.rdbPiority.Name = "rdbPiority";
            this.rdbPiority.Size = new System.Drawing.Size(76, 21);
            this.rdbPiority.TabIndex = 0;
            this.rdbPiority.TabStop = true;
            this.rdbPiority.Text = "piorytet";
            this.rdbPiority.UseVisualStyleBackColor = true;
            this.rdbPiority.Click += new System.EventHandler(this.rdbPiority_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtTask);
            this.grpDetails.Controls.Add(this.btnTaskFinish);
            this.grpDetails.Controls.Add(this.btnDetailAdd);
            this.grpDetails.Controls.Add(this.progressBar1);
            this.grpDetails.Controls.Add(this.lstToDoDetails);
            this.grpDetails.Location = new System.Drawing.Point(451, 271);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(285, 204);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Szczegóły";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(174, 22);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(100, 22);
            this.txtTask.TabIndex = 4;
            // 
            // btnTaskFinish
            // 
            this.btnTaskFinish.Location = new System.Drawing.Point(174, 79);
            this.btnTaskFinish.Name = "btnTaskFinish";
            this.btnTaskFinish.Size = new System.Drawing.Size(91, 23);
            this.btnTaskFinish.TabIndex = 3;
            this.btnTaskFinish.Text = "Wykonane";
            this.btnTaskFinish.UseVisualStyleBackColor = true;
            this.btnTaskFinish.Click += new System.EventHandler(this.btnTaskFinish_Click);
            // 
            // btnDetailAdd
            // 
            this.btnDetailAdd.Location = new System.Drawing.Point(174, 50);
            this.btnDetailAdd.Name = "btnDetailAdd";
            this.btnDetailAdd.Size = new System.Drawing.Size(91, 23);
            this.btnDetailAdd.TabIndex = 2;
            this.btnDetailAdd.Text = "Dodaj";
            this.btnDetailAdd.UseVisualStyleBackColor = true;
            this.btnDetailAdd.Click += new System.EventHandler(this.btnDetailAdd_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 172);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lstToDoDetails
            // 
            this.lstToDoDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DetailsLp,
            this.Task});
            this.lstToDoDetails.FullRowSelect = true;
            this.lstToDoDetails.Location = new System.Drawing.Point(7, 22);
            this.lstToDoDetails.MultiSelect = false;
            this.lstToDoDetails.Name = "lstToDoDetails";
            this.lstToDoDetails.Size = new System.Drawing.Size(161, 144);
            this.lstToDoDetails.TabIndex = 0;
            this.lstToDoDetails.UseCompatibleStateImageBehavior = false;
            this.lstToDoDetails.View = System.Windows.Forms.View.Details;
            // 
            // DetailsLp
            // 
            this.DetailsLp.Text = "Lp";
            this.DetailsLp.Width = 29;
            // 
            // Task
            // 
            this.Task.Text = "Zadania";
            this.Task.Width = 127;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 482);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpcFill);
            this.Controls.Add(this.lstvMainView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpcFill.ResumeLayout(false);
            this.gpcFill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvMainView;
        private System.Windows.Forms.ColumnHeader Lp;
        private System.Windows.Forms.ColumnHeader ToDoCol;
        private System.Windows.Forms.ColumnHeader Piority;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.GroupBox gpcFill;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.TextBox txtToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblPiority;
        private System.Windows.Forms.ComboBox cmbPiority;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RadioButton rdbGroup;
        private System.Windows.Forms.RadioButton rnbDate;
        private System.Windows.Forms.RadioButton rdbPiority;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView lstToDoDetails;
        private System.Windows.Forms.ColumnHeader DetailsLp;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnTaskFinish;
        private System.Windows.Forms.Button btnDetailAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

