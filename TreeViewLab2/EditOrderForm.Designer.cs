namespace TreeViewLab2
{
    partial class EditOrderForm
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
            dtpOrderDate = new DateTimePicker();
            label1 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(197, 35);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(400, 43);
            dtpOrderDate.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 12;
            label1.Text = "Дата заказа";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 138);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(262, 59);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(30, 138);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(284, 59);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 244);
            Controls.Add(dtpOrderDate);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "EditOrderForm";
            Text = "EditOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpOrderDate;
        private Label label1;
        private Button btnCancel;
        private Button btnEdit;
    }
}