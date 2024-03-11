namespace TreeViewLab2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLoad = new Button();
            treeView = new TreeView();
            cmsClient = new ContextMenuStrip(components);
            добавитьCarToolStripMenuItem = new ToolStripMenuItem();
            изменитьClientToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            удалитьClientToolStripMenuItem = new ToolStripMenuItem();
            btnAddClient = new Button();
            cmsCar = new ContextMenuStrip(components);
            добавитьЗаказToolStripMenuItem = new ToolStripMenuItem();
            изменитьCarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            удалитьCarToolStripMenuItem = new ToolStripMenuItem();
            cmsOrder = new ContextMenuStrip(components);
            изменитьOrderToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            удалитьOrderToolStripMenuItem = new ToolStripMenuItem();
            cmsClient.SuspendLayout();
            cmsCar.SuspendLayout();
            cmsOrder.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(625, 1010);
            btnLoad.Margin = new Padding(4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(236, 102);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Обновить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // treeView
            // 
            treeView.AllowDrop = true;
            treeView.Indent = 30;
            treeView.ItemHeight = 50;
            treeView.Location = new Point(15, 18);
            treeView.Margin = new Padding(4);
            treeView.Name = "treeView";
            treeView.Size = new Size(846, 970);
            treeView.TabIndex = 1;
            treeView.ItemDrag += treeView_ItemDrag;
            treeView.DragDrop += treeView_DragDrop;
            treeView.DragEnter += treeView_DragEnter;
            treeView.MouseClick += treeView_MouseClick;
            // 
            // cmsClient
            // 
            cmsClient.ImageScalingSize = new Size(32, 32);
            cmsClient.Items.AddRange(new ToolStripItem[] { добавитьCarToolStripMenuItem, изменитьClientToolStripMenuItem, toolStripMenuItem1, удалитьClientToolStripMenuItem });
            cmsClient.Name = "cmsClient";
            cmsClient.Size = new Size(350, 124);
            // 
            // добавитьCarToolStripMenuItem
            // 
            добавитьCarToolStripMenuItem.Name = "добавитьCarToolStripMenuItem";
            добавитьCarToolStripMenuItem.Size = new Size(349, 38);
            добавитьCarToolStripMenuItem.Text = "Добавить автомобиль...";
            добавитьCarToolStripMenuItem.Click += добавитьCarToolStripMenuItem_Click;
            // 
            // изменитьClientToolStripMenuItem
            // 
            изменитьClientToolStripMenuItem.Name = "изменитьClientToolStripMenuItem";
            изменитьClientToolStripMenuItem.Size = new Size(349, 38);
            изменитьClientToolStripMenuItem.Text = "Изменить...";
            изменитьClientToolStripMenuItem.Click += изменитьClientToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(346, 6);
            // 
            // удалитьClientToolStripMenuItem
            // 
            удалитьClientToolStripMenuItem.Name = "удалитьClientToolStripMenuItem";
            удалитьClientToolStripMenuItem.Size = new Size(349, 38);
            удалитьClientToolStripMenuItem.Text = "Удалить";
            удалитьClientToolStripMenuItem.Click += удалитьClientToolStripMenuItem_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(12, 1010);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(399, 102);
            btnAddClient.TabIndex = 2;
            btnAddClient.Text = "Добавить клиента";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // cmsCar
            // 
            cmsCar.ImageScalingSize = new Size(32, 32);
            cmsCar.Items.AddRange(new ToolStripItem[] { добавитьЗаказToolStripMenuItem, изменитьCarToolStripMenuItem, toolStripMenuItem2, удалитьCarToolStripMenuItem });
            cmsCar.Name = "cmsCar";
            cmsCar.Size = new Size(275, 124);
            // 
            // добавитьЗаказToolStripMenuItem
            // 
            добавитьЗаказToolStripMenuItem.Name = "добавитьЗаказToolStripMenuItem";
            добавитьЗаказToolStripMenuItem.Size = new Size(274, 38);
            добавитьЗаказToolStripMenuItem.Text = "Добавить заказ...";
            добавитьЗаказToolStripMenuItem.Click += добавитьЗаказToolStripMenuItem_Click;
            // 
            // изменитьCarToolStripMenuItem
            // 
            изменитьCarToolStripMenuItem.Name = "изменитьCarToolStripMenuItem";
            изменитьCarToolStripMenuItem.Size = new Size(274, 38);
            изменитьCarToolStripMenuItem.Text = "Изменить...";
            изменитьCarToolStripMenuItem.Click += изменитьCarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(271, 6);
            // 
            // удалитьCarToolStripMenuItem
            // 
            удалитьCarToolStripMenuItem.Name = "удалитьCarToolStripMenuItem";
            удалитьCarToolStripMenuItem.Size = new Size(274, 38);
            удалитьCarToolStripMenuItem.Text = "Удалить";
            удалитьCarToolStripMenuItem.Click += удалитьCarToolStripMenuItem_Click;
            // 
            // cmsOrder
            // 
            cmsOrder.ImageScalingSize = new Size(32, 32);
            cmsOrder.Items.AddRange(new ToolStripItem[] { изменитьOrderToolStripMenuItem, toolStripMenuItem3, удалитьOrderToolStripMenuItem });
            cmsOrder.Name = "cmsOrder";
            cmsOrder.Size = new Size(213, 86);
            // 
            // изменитьOrderToolStripMenuItem
            // 
            изменитьOrderToolStripMenuItem.Name = "изменитьOrderToolStripMenuItem";
            изменитьOrderToolStripMenuItem.Size = new Size(212, 38);
            изменитьOrderToolStripMenuItem.Text = "Изменить...";
            изменитьOrderToolStripMenuItem.Click += изменитьOrderToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(209, 6);
            // 
            // удалитьOrderToolStripMenuItem
            // 
            удалитьOrderToolStripMenuItem.Name = "удалитьOrderToolStripMenuItem";
            удалитьOrderToolStripMenuItem.Size = new Size(212, 38);
            удалитьOrderToolStripMenuItem.Text = "Удалить";
            удалитьOrderToolStripMenuItem.Click += удалитьOrderToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(874, 1131);
            Controls.Add(btnAddClient);
            Controls.Add(treeView);
            Controls.Add(btnLoad);
            Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Form1";
            cmsClient.ResumeLayout(false);
            cmsCar.ResumeLayout(false);
            cmsOrder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private TreeView treeView;
        private ContextMenuStrip cmsClient;
        private ToolStripMenuItem изменитьClientToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem удалитьClientToolStripMenuItem;
        private Button btnAddClient;
        private ToolStripMenuItem добавитьCarToolStripMenuItem;
        private ContextMenuStrip cmsCar;
        private ToolStripMenuItem добавитьЗаказToolStripMenuItem;
        private ToolStripMenuItem изменитьCarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem удалитьCarToolStripMenuItem;
        private ContextMenuStrip cmsOrder;
        private ToolStripMenuItem изменитьOrderToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem удалитьOrderToolStripMenuItem;
    }
}