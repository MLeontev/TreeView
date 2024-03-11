namespace TreeViewLab2
{
    partial class EditCarForm
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
            components = new System.ComponentModel.Container();
            btnCancel = new Button();
            btnEdit = new Button();
            tbModel = new TextBox();
            label2 = new Label();
            tbBrand = new TextBox();
            label1 = new Label();
            label3 = new Label();
            errorProvider = new ErrorProvider(components);
            tbPlate = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(344, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(272, 68);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(32, 316);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(272, 68);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(213, 123);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(403, 43);
            tbModel.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 123);
            label2.Name = "label2";
            label2.Size = new Size(120, 37);
            label2.TabIndex = 14;
            label2.Text = "Модель:";
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(213, 32);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(403, 43);
            tbBrand.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 12;
            label1.Text = "Марка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 218);
            label3.Name = "label3";
            label3.Size = new Size(107, 37);
            label3.TabIndex = 18;
            label3.Text = "Номер:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tbPlate
            // 
            tbPlate.Location = new Point(213, 212);
            tbPlate.Name = "tbPlate";
            tbPlate.Size = new Size(403, 43);
            tbPlate.TabIndex = 19;
            // 
            // EditCarForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 411);
            Controls.Add(tbPlate);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(tbModel);
            Controls.Add(label2);
            Controls.Add(tbBrand);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "EditCarForm";
            Text = "EditCarForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnEdit;
        private TextBox tbModel;
        private Label label2;
        private TextBox tbBrand;
        private Label label1;
        private Label label3;
        private ErrorProvider errorProvider;
        private MaskedTextBox tbPlate;
    }
}