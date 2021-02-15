namespace Handlarz_4a
{
    partial class Form2
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
            this.name_ = new System.Windows.Forms.Label();
            this.cash_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.moje_pojazdy_ = new System.Windows.Forms.DataGridView();
            this.wszystkie_pojazdy_ = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Handlarz_4a.Database1DataSet();
            this.showMyCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showMyCarsTableAdapter = new Handlarz_4a.Database1DataSetTableAdapters.showMyCarsTableAdapter();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet1 = new Handlarz_4a.Database1DataSet1();
            this.showAllCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showAllCarsTableAdapter = new Handlarz_4a.Database1DataSet1TableAdapters.showAllCarsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moje_pojazdy_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wszystkie_pojazdy_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showMyCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAllCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name_
            // 
            this.name_.AutoSize = true;
            this.name_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name_.Location = new System.Drawing.Point(12, 9);
            this.name_.Name = "name_";
            this.name_.Size = new System.Drawing.Size(87, 31);
            this.name_.TabIndex = 0;
            this.name_.Text = "Witaj ";
            // 
            // cash_
            // 
            this.cash_.Location = new System.Drawing.Point(72, 54);
            this.cash_.Name = "cash_";
            this.cash_.ReadOnly = true;
            this.cash_.Size = new System.Drawing.Size(100, 20);
            this.cash_.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stan Konta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wpłać Gotówkę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(8, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wyloguj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(8, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Wyjdź";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // moje_pojazdy_
            // 
            this.moje_pojazdy_.AllowUserToAddRows = false;
            this.moje_pojazdy_.AllowUserToDeleteRows = false;
            this.moje_pojazdy_.AutoGenerateColumns = false;
            this.moje_pojazdy_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moje_pojazdy_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.silnikDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.moje_pojazdy_.DataSource = this.showMyCarsBindingSource;
            this.moje_pojazdy_.Location = new System.Drawing.Point(193, 16);
            this.moje_pojazdy_.Name = "moje_pojazdy_";
            this.moje_pojazdy_.Size = new System.Drawing.Size(589, 165);
            this.moje_pojazdy_.TabIndex = 6;
            // 
            // wszystkie_pojazdy_
            // 
            this.wszystkie_pojazdy_.AllowUserToAddRows = false;
            this.wszystkie_pojazdy_.AllowUserToDeleteRows = false;
            this.wszystkie_pojazdy_.AllowUserToResizeColumns = false;
            this.wszystkie_pojazdy_.AllowUserToResizeRows = false;
            this.wszystkie_pojazdy_.AutoGenerateColumns = false;
            this.wszystkie_pojazdy_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wszystkie_pojazdy_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.silnikDataGridViewTextBoxColumn1,
            this.cenaDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn});
            this.wszystkie_pojazdy_.DataSource = this.showAllCarsBindingSource;
            this.wszystkie_pojazdy_.Location = new System.Drawing.Point(193, 188);
            this.wszystkie_pojazdy_.Name = "wszystkie_pojazdy_";
            this.wszystkie_pojazdy_.ReadOnly = true;
            this.wszystkie_pojazdy_.Size = new System.Drawing.Size(589, 256);
            this.wszystkie_pojazdy_.TabIndex = 7;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showMyCarsBindingSource
            // 
            this.showMyCarsBindingSource.DataMember = "showMyCars";
            this.showMyCarsBindingSource.DataSource = this.database1DataSet;
            // 
            // showMyCarsTableAdapter
            // 
            this.showMyCarsTableAdapter.ClearBeforeFill = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // silnikDataGridViewTextBoxColumn
            // 
            this.silnikDataGridViewTextBoxColumn.DataPropertyName = "silnik";
            this.silnikDataGridViewTextBoxColumn.HeaderText = "silnik";
            this.silnikDataGridViewTextBoxColumn.Name = "silnikDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showAllCarsBindingSource
            // 
            this.showAllCarsBindingSource.DataMember = "showAllCars";
            this.showAllCarsBindingSource.DataSource = this.database1DataSet1;
            // 
            // showAllCarsTableAdapter
            // 
            this.showAllCarsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // markaDataGridViewTextBoxColumn1
            // 
            this.markaDataGridViewTextBoxColumn1.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn1.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn1.Name = "markaDataGridViewTextBoxColumn1";
            this.markaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // silnikDataGridViewTextBoxColumn1
            // 
            this.silnikDataGridViewTextBoxColumn1.DataPropertyName = "silnik";
            this.silnikDataGridViewTextBoxColumn1.HeaderText = "silnik";
            this.silnikDataGridViewTextBoxColumn1.Name = "silnikDataGridViewTextBoxColumn1";
            this.silnikDataGridViewTextBoxColumn1.ReadOnly = true;
            this.silnikDataGridViewTextBoxColumn1.Width = 50;
            // 
            // cenaDataGridViewTextBoxColumn1
            // 
            this.cenaDataGridViewTextBoxColumn1.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn1.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn1.Name = "cenaDataGridViewTextBoxColumn1";
            this.cenaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "właściciel";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dodaj Pojazd";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.wszystkie_pojazdy_);
            this.Controls.Add(this.moje_pojazdy_);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cash_);
            this.Controls.Add(this.name_);
            this.Name = "Form2";
            this.Text = "Panel użytkownika";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moje_pojazdy_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wszystkie_pojazdy_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showMyCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAllCarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_;
        private System.Windows.Forms.TextBox cash_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView moje_pojazdy_;
        private System.Windows.Forms.DataGridView wszystkie_pojazdy_;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource showMyCarsBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.showMyCarsTableAdapter showMyCarsTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource showAllCarsBindingSource;
        private Database1DataSet1TableAdapters.showAllCarsTableAdapter showAllCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn silnikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}