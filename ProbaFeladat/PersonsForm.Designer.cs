namespace ProbaFeladat
{
    partial class PersonsForm
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
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PersonsDataGridView = new System.Windows.Forms.DataGridView();
            this.aZONOSITODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDOAZONOSITOJELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELJESNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bELEPESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kILEPESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEGNEVEZES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.probaFeladatDataSet = new ProbaFeladat.ProbaFeladatDataSet();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ModositasGroupBox = new System.Windows.Forms.GroupBox();
            this.NemGroupBox = new System.Windows.Forms.GroupBox();
            this.NemTextBox = new System.Windows.Forms.TextBox();
            this.FerfiRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.KilepesLabel = new System.Windows.Forms.Label();
            this.BelepesLabel = new System.Windows.Forms.Label();
            this.Adoazonositojelabel = new System.Windows.Forms.Label();
            this.TeljesNevLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.OutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AdoazonositoTextBox = new System.Windows.Forms.TextBox();
            this.AdoazonositojelTextBox = new System.Windows.Forms.TextBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new ProbaFeladat.ProbaFeladatDataSetTableAdapters.personsTableAdapter();
            this.genderTableAdapter = new ProbaFeladat.ProbaFeladatDataSetTableAdapters.genderTableAdapter();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.PersonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probaFeladatDataSet)).BeginInit();
            this.ModositasGroupBox.SuspendLayout();
            this.NemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonsDataGridView
            // 
            this.PersonsDataGridView.AllowUserToAddRows = false;
            this.PersonsDataGridView.AutoGenerateColumns = false;
            this.PersonsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PersonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aZONOSITODataGridViewTextBoxColumn,
            this.aDOAZONOSITOJELDataGridViewTextBoxColumn,
            this.tELJESNEVDataGridViewTextBoxColumn,
            this.bELEPESDataGridViewTextBoxColumn,
            this.kILEPESDataGridViewTextBoxColumn,
            this.eMAILCIMDataGridViewTextBoxColumn,
            this.MEGNEVEZES});
            this.PersonsDataGridView.DataSource = this.personsBindingSource;
            this.PersonsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PersonsDataGridView.Location = new System.Drawing.Point(12, 25);
            this.PersonsDataGridView.MultiSelect = false;
            this.PersonsDataGridView.Name = "PersonsDataGridView";
            this.PersonsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonsDataGridView.Size = new System.Drawing.Size(748, 363);
            this.PersonsDataGridView.TabIndex = 0;
            this.PersonsDataGridView.SelectionChanged += new System.EventHandler(this.PersonsDataGridView_SelectionChanged);
            // 
            // aZONOSITODataGridViewTextBoxColumn
            // 
            this.aZONOSITODataGridViewTextBoxColumn.DataPropertyName = "AZONOSITO";
            this.aZONOSITODataGridViewTextBoxColumn.HeaderText = "Azonosító";
            this.aZONOSITODataGridViewTextBoxColumn.Name = "aZONOSITODataGridViewTextBoxColumn";
            this.aZONOSITODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDOAZONOSITOJELDataGridViewTextBoxColumn
            // 
            this.aDOAZONOSITOJELDataGridViewTextBoxColumn.DataPropertyName = "ADOAZONOSITOJEL";
            this.aDOAZONOSITOJELDataGridViewTextBoxColumn.HeaderText = "Adóazonosítójel";
            this.aDOAZONOSITOJELDataGridViewTextBoxColumn.Name = "aDOAZONOSITOJELDataGridViewTextBoxColumn";
            // 
            // tELJESNEVDataGridViewTextBoxColumn
            // 
            this.tELJESNEVDataGridViewTextBoxColumn.DataPropertyName = "TELJESNEV";
            this.tELJESNEVDataGridViewTextBoxColumn.HeaderText = "Név";
            this.tELJESNEVDataGridViewTextBoxColumn.Name = "tELJESNEVDataGridViewTextBoxColumn";
            // 
            // bELEPESDataGridViewTextBoxColumn
            // 
            this.bELEPESDataGridViewTextBoxColumn.DataPropertyName = "BELEPES";
            this.bELEPESDataGridViewTextBoxColumn.HeaderText = "Belépés";
            this.bELEPESDataGridViewTextBoxColumn.Name = "bELEPESDataGridViewTextBoxColumn";
            // 
            // kILEPESDataGridViewTextBoxColumn
            // 
            this.kILEPESDataGridViewTextBoxColumn.DataPropertyName = "KILEPES";
            this.kILEPESDataGridViewTextBoxColumn.HeaderText = "Kilépés";
            this.kILEPESDataGridViewTextBoxColumn.Name = "kILEPESDataGridViewTextBoxColumn";
            // 
            // eMAILCIMDataGridViewTextBoxColumn
            // 
            this.eMAILCIMDataGridViewTextBoxColumn.DataPropertyName = "EMAILCIM";
            this.eMAILCIMDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.eMAILCIMDataGridViewTextBoxColumn.Name = "eMAILCIMDataGridViewTextBoxColumn";
            // 
            // MEGNEVEZES
            // 
            this.MEGNEVEZES.DataPropertyName = "MEGNEVEZES";
            this.MEGNEVEZES.HeaderText = "Nem";
            this.MEGNEVEZES.Name = "MEGNEVEZES";
            this.MEGNEVEZES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            this.personsBindingSource.DataSource = this.probaFeladatDataSet;
            // 
            // probaFeladatDataSet
            // 
            this.probaFeladatDataSet.DataSetName = "ProbaFeladatDataSet";
            this.probaFeladatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(38, 27);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "Új";
            this.PersonsToolTip.SetToolTip(this.NewButton, "Új személy felvitele");
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(337, 27);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Módosítás";
            this.PersonsToolTip.SetToolTip(this.EditButton, "Kiválasztott személy adatainak módosítása");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(631, 27);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Törlés";
            this.PersonsToolTip.SetToolTip(this.DeleteButton, "Kiválasztott személy adatainak törlése");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(17, 405);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Mentés";
            this.PersonsToolTip.SetToolTip(this.SaveButton, "Módosítások mentése");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(212, 405);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Mégse";
            this.PersonsToolTip.SetToolTip(this.CancelButton, "Módosítások visszavonása");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ModositasGroupBox
            // 
            this.ModositasGroupBox.Controls.Add(this.NemGroupBox);
            this.ModositasGroupBox.Controls.Add(this.CancelButton);
            this.ModositasGroupBox.Controls.Add(this.EmailLabel);
            this.ModositasGroupBox.Controls.Add(this.SaveButton);
            this.ModositasGroupBox.Controls.Add(this.KilepesLabel);
            this.ModositasGroupBox.Controls.Add(this.BelepesLabel);
            this.ModositasGroupBox.Controls.Add(this.Adoazonositojelabel);
            this.ModositasGroupBox.Controls.Add(this.TeljesNevLabel);
            this.ModositasGroupBox.Controls.Add(this.textBox3);
            this.ModositasGroupBox.Controls.Add(this.OutDateTimePicker);
            this.ModositasGroupBox.Controls.Add(this.InDateTimePicker);
            this.ModositasGroupBox.Controls.Add(this.AdoazonositoTextBox);
            this.ModositasGroupBox.Controls.Add(this.AdoazonositojelTextBox);
            this.ModositasGroupBox.Controls.Add(this.NemTextBox);
            this.ModositasGroupBox.Location = new System.Drawing.Point(782, 25);
            this.ModositasGroupBox.Name = "ModositasGroupBox";
            this.ModositasGroupBox.Size = new System.Drawing.Size(308, 450);
            this.ModositasGroupBox.TabIndex = 7;
            this.ModositasGroupBox.TabStop = false;
            this.ModositasGroupBox.Text = "Módosítás";
            // 
            // NemGroupBox
            // 
            this.NemGroupBox.Controls.Add(this.FerfiRadioButton);
            this.NemGroupBox.Controls.Add(this.NoRadioButton);
            this.NemGroupBox.Location = new System.Drawing.Point(17, 315);
            this.NemGroupBox.Name = "NemGroupBox";
            this.NemGroupBox.Size = new System.Drawing.Size(270, 65);
            this.NemGroupBox.TabIndex = 12;
            this.NemGroupBox.TabStop = false;
            this.NemGroupBox.Text = "Nem";
            // 
            // NemTextBox
            // 
            this.NemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "NEM", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.NemTextBox.Location = new System.Drawing.Point(127, 343);
            this.NemTextBox.Name = "NemTextBox";
            this.NemTextBox.Size = new System.Drawing.Size(50, 20);
            this.NemTextBox.TabIndex = 7;
            // 
            // FerfiRadioButton
            // 
            this.FerfiRadioButton.AutoSize = true;
            this.FerfiRadioButton.Location = new System.Drawing.Point(19, 32);
            this.FerfiRadioButton.Name = "FerfiRadioButton";
            this.FerfiRadioButton.Size = new System.Drawing.Size(42, 17);
            this.FerfiRadioButton.TabIndex = 5;
            this.FerfiRadioButton.TabStop = true;
            this.FerfiRadioButton.Tag = "1";
            this.FerfiRadioButton.Text = "férfi";
            this.PersonsToolTip.SetToolTip(this.FerfiRadioButton, "Személy neme");
            this.FerfiRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(211, 32);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(37, 17);
            this.NoRadioButton.TabIndex = 6;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Tag = "2";
            this.NoRadioButton.Text = "nő";
            this.PersonsToolTip.SetToolTip(this.NoRadioButton, "Személy neme");
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(14, 256);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "E-mail";
            // 
            // KilepesLabel
            // 
            this.KilepesLabel.AutoSize = true;
            this.KilepesLabel.Location = new System.Drawing.Point(14, 196);
            this.KilepesLabel.Name = "KilepesLabel";
            this.KilepesLabel.Size = new System.Drawing.Size(41, 13);
            this.KilepesLabel.TabIndex = 10;
            this.KilepesLabel.Text = "Kilépés";
            // 
            // BelepesLabel
            // 
            this.BelepesLabel.AutoSize = true;
            this.BelepesLabel.Location = new System.Drawing.Point(14, 145);
            this.BelepesLabel.Name = "BelepesLabel";
            this.BelepesLabel.Size = new System.Drawing.Size(45, 13);
            this.BelepesLabel.TabIndex = 9;
            this.BelepesLabel.Text = "Belépés";
            // 
            // Adoazonositojelabel
            // 
            this.Adoazonositojelabel.AutoSize = true;
            this.Adoazonositojelabel.Location = new System.Drawing.Point(14, 86);
            this.Adoazonositojelabel.Name = "Adoazonositojelabel";
            this.Adoazonositojelabel.Size = new System.Drawing.Size(73, 13);
            this.Adoazonositojelabel.TabIndex = 8;
            this.Adoazonositojelabel.Text = "Adóazonosító";
            // 
            // TeljesNevLabel
            // 
            this.TeljesNevLabel.AutoSize = true;
            this.TeljesNevLabel.Location = new System.Drawing.Point(14, 29);
            this.TeljesNevLabel.Name = "TeljesNevLabel";
            this.TeljesNevLabel.Size = new System.Drawing.Size(27, 13);
            this.TeljesNevLabel.TabIndex = 7;
            this.TeljesNevLabel.Text = "Név";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "EMAILCIM", true));
            this.textBox3.Location = new System.Drawing.Point(17, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 20);
            this.textBox3.TabIndex = 4;
            this.PersonsToolTip.SetToolTip(this.textBox3, "E-mail cím");
            // 
            // OutDateTimePicker
            // 
            this.OutDateTimePicker.Checked = false;
            this.OutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OutDateTimePicker.Location = new System.Drawing.Point(17, 214);
            this.OutDateTimePicker.Name = "OutDateTimePicker";
            this.OutDateTimePicker.ShowCheckBox = true;
            this.OutDateTimePicker.Size = new System.Drawing.Size(270, 20);
            this.OutDateTimePicker.TabIndex = 3;
            this.PersonsToolTip.SetToolTip(this.OutDateTimePicker, "Kilépés dátuma");
            // 
            // InDateTimePicker
            // 
            this.InDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "BELEPES", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.InDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InDateTimePicker.Location = new System.Drawing.Point(17, 161);
            this.InDateTimePicker.Name = "InDateTimePicker";
            this.InDateTimePicker.Size = new System.Drawing.Size(270, 20);
            this.InDateTimePicker.TabIndex = 2;
            this.PersonsToolTip.SetToolTip(this.InDateTimePicker, "Belépés dátuma");
            // 
            // AdoazonositoTextBox
            // 
            this.AdoazonositoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "ADOAZONOSITOJEL", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.AdoazonositoTextBox.Location = new System.Drawing.Point(17, 102);
            this.AdoazonositoTextBox.Name = "AdoazonositoTextBox";
            this.AdoazonositoTextBox.Size = new System.Drawing.Size(270, 20);
            this.AdoazonositoTextBox.TabIndex = 1;
            this.PersonsToolTip.SetToolTip(this.AdoazonositoTextBox, "Adóazonosító jel (9 számjegy)");
            // 
            // AdoazonositojelTextBox
            // 
            this.AdoazonositojelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "TELJESNEV", true));
            this.AdoazonositojelTextBox.Location = new System.Drawing.Point(17, 45);
            this.AdoazonositojelTextBox.Name = "AdoazonositojelTextBox";
            this.AdoazonositojelTextBox.Size = new System.Drawing.Size(270, 20);
            this.AdoazonositojelTextBox.TabIndex = 0;
            this.PersonsToolTip.SetToolTip(this.AdoazonositojelTextBox, "Személy neve");
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.NewButton);
            this.ButtonPanel.Controls.Add(this.EditButton);
            this.ButtonPanel.Controls.Add(this.DeleteButton);
            this.ButtonPanel.Location = new System.Drawing.Point(12, 403);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(748, 72);
            this.ButtonPanel.TabIndex = 8;
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 487);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.ModositasGroupBox);
            this.Controls.Add(this.PersonsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Személyek";
            this.Load += new System.EventHandler(this.PersonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probaFeladatDataSet)).EndInit();
            this.ModositasGroupBox.ResumeLayout(false);
            this.ModositasGroupBox.PerformLayout();
            this.NemGroupBox.ResumeLayout(false);
            this.NemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonsDataGridView;
        private ProbaFeladatDataSetTableAdapters.personsTableAdapter personsTableAdapter;
        private ProbaFeladatDataSet probaFeladatDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private ProbaFeladatDataSetTableAdapters.genderTableAdapter genderTableAdapter;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox ModositasGroupBox;
        private System.Windows.Forms.DateTimePicker OutDateTimePicker;
        private System.Windows.Forms.DateTimePicker InDateTimePicker;
        private System.Windows.Forms.TextBox AdoazonositoTextBox;
        private System.Windows.Forms.TextBox AdoazonositojelTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aZONOSITODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDOAZONOSITOJELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELJESNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bELEPESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kILEPESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEGNEVEZES;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.RadioButton FerfiRadioButton;
        private System.Windows.Forms.GroupBox NemGroupBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label KilepesLabel;
        private System.Windows.Forms.Label BelepesLabel;
        private System.Windows.Forms.Label Adoazonositojelabel;
        private System.Windows.Forms.Label TeljesNevLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.TextBox NemTextBox;
        private System.Windows.Forms.ToolTip PersonsToolTip;
    }
}

