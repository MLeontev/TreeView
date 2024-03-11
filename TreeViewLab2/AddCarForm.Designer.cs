namespace TreeViewLab2
{
    partial class AddCarForm
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
            tbPlate = new MaskedTextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            tbModel = new TextBox();
            label2 = new Label();
            tbBrand = new TextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tbPlate
            // 
            tbPlate.Location = new Point(211, 215);
            tbPlate.Name = "tbPlate";
            tbPlate.Size = new Size(403, 43);
            tbPlate.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 221);
            label3.Name = "label3";
            label3.Size = new Size(107, 37);
            label3.TabIndex = 26;
            label3.Text = "Номер:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(272, 68);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(272, 68);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(211, 126);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(403, 43);
            tbModel.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 126);
            label2.Name = "label2";
            label2.Size = new Size(120, 37);
            label2.TabIndex = 22;
            label2.Text = "Модель:";
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(211, 35);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(403, 43);
            tbBrand.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 20;
            label1.Text = "Марка:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 419);
            Controls.Add(tbPlate);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(tbModel);
            Controls.Add(label2);
            Controls.Add(tbBrand);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tbPlate;
        private Label label3;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbModel;
        private Label label2;
        private TextBox tbBrand;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}