namespace TreeViewLab2
{
    partial class AddClientForm
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
            label1 = new Label();
            tbSurname = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(200, 35);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(350, 43);
            tbSurname.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(200, 114);
            tbName.Name = "tbName";
            tbName.Size = new Size(350, 43);
            tbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 114);
            label2.Name = "label2";
            label2.Size = new Size(76, 37);
            label2.TabIndex = 2;
            label2.Text = "Имя:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(236, 59);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(314, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(236, 59);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 294);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbSurname);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddClientForm";
            Text = "AddClientForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSurname;
        private TextBox tbName;
        private Label label2;
        private Button btnAdd;
        private Button btnCancel;
        private ErrorProvider errorProvider;
    }
}