namespace TreeViewLab2
{
    partial class EditClientForm
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
            tbName = new TextBox();
            label2 = new Label();
            tbSurname = new TextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(272, 68);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(30, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(272, 68);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(210, 125);
            tbName.Name = "tbName";
            tbName.Size = new Size(403, 43);
            tbName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(76, 37);
            label2.TabIndex = 8;
            label2.Text = "Имя:";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(210, 34);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(403, 43);
            tbSurname.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 6;
            label1.Text = "Фамилия:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EditClientForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 324);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbSurname);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "EditClientForm";
            Text = "EditClientForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnEdit;
        private TextBox tbName;
        private Label label2;
        private TextBox tbSurname;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}