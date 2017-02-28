namespace HousingAndDiningApp
{
    partial class FurnitureView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurnitureView));
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFloor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.housingTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housing = new HousingAndDiningApp.Housing();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.housingTableTableAdapter = new HousingAndDiningApp.HousingTableAdapters.HousingTableTableAdapter();
            this.RequisitionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.housingTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Items.AddRange(new object[] {
            "Ford",
            "Haymaker",
            "Moore",
            "West",
            "Goodnow",
            "Marlatt",
            "Boyd",
            "Putnam",
            "Van Zile"});
            this.comboBoxBuilding.Location = new System.Drawing.Point(129, 58);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuilding.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Floor:";
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.FormattingEnabled = true;
            this.comboBoxFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxFloor.Location = new System.Drawing.Point(129, 115);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFloor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Building:";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
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
            "12"});
            this.comboBoxRoom.Location = new System.Drawing.Point(129, 170);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room:";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(147, 247);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // housingTableBindingSource
            // 
            this.housingTableBindingSource.DataMember = "HousingTable";
            this.housingTableBindingSource.DataSource = this.housing;
            // 
            // housing
            // 
            this.housing.DataSetName = "Housing";
            this.housing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(312, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 143);
            this.dataGridView2.TabIndex = 8;
            // 
            // housingTableTableAdapter
            // 
            this.housingTableTableAdapter.ClearBeforeFill = true;
            // 
            // RequisitionBtn
            // 
            this.RequisitionBtn.Location = new System.Drawing.Point(413, 247);
            this.RequisitionBtn.Name = "RequisitionBtn";
            this.RequisitionBtn.Size = new System.Drawing.Size(164, 23);
            this.RequisitionBtn.TabIndex = 9;
            this.RequisitionBtn.Text = "Create Requisition Form";
            this.RequisitionBtn.UseVisualStyleBackColor = true;
            this.RequisitionBtn.Click += new System.EventHandler(this.RequisitionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter the required information to view the desired room";
            // 
            // FurnitureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RequisitionBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFloor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuilding);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FurnitureView";
            this.Text = "FurnitureView";
            this.Load += new System.EventHandler(this.FurnitureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.housingTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBtn;
        private Housing housing;
        private System.Windows.Forms.BindingSource housingTableBindingSource;
        private HousingTableAdapters.HousingTableTableAdapter housingTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button RequisitionBtn;
        private System.Windows.Forms.Label label4;
    }
}