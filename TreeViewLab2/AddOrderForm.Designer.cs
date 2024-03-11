namespace TreeViewLab2
{
    partial class AddOrderForm
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
            btnAdd = new Button();
            label1 = new Label();
            dtpOrderDate = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(262, 59);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 148);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(284, 59);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 8;
            label1.Text = "Дата заказа";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(199, 45);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(400, 43);
            dtpOrderDate.TabIndex = 9;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 262);
            Controls.Add(dtpOrderDate);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label1;
        private DateTimePicker dtpOrderDate;
        private ErrorProvider errorProvider;
    }
}