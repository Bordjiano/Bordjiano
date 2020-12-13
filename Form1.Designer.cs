namespace Bordjiano
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокОзброєнняМаксКалібруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.Location = new System.Drawing.Point(163, 106);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(649, 273);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.BackgroundImage = global::Bordjiano.Properties.Resources._4545461;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Paper_icon1;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.viewToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.addToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Add_icon1;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.editToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Pencil_icon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.removeToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Close_icon1;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.closeToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Power_icon;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.updateToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updateToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Restore_Window_icon;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.projectToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem,
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem,
            this.списокОзброєнняМаксКалібруToolStripMenuItem,
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem});
            this.projectToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Address_Book_2_icon;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem
            // 
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.Image")));
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.Name = "списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem";
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.Text = "Список типів озброєння та їх кількості по алфавіту ";
            this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem.Click += new System.EventHandler(this.списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem_Click);
            // 
            // кількістьОзброєнняЗаданогоКалібруToolStripMenuItem
            // 
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.Image")));
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.Name = "кількістьОзброєнняЗаданогоКалібруToolStripMenuItem";
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.Text = "Кількість озброєння заданого калібру ";
            this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem.Click += new System.EventHandler(this.кількістьОзброєнняЗаданогоКалібруToolStripMenuItem_Click);
            // 
            // списокОзброєнняМаксКалібруToolStripMenuItem
            // 
            this.списокОзброєнняМаксКалібруToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.списокОзброєнняМаксКалібруToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокОзброєнняМаксКалібруToolStripMenuItem.Image")));
            this.списокОзброєнняМаксКалібруToolStripMenuItem.Name = "списокОзброєнняМаксКалібруToolStripMenuItem";
            this.списокОзброєнняМаксКалібруToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.списокОзброєнняМаксКалібруToolStripMenuItem.Text = "Список озброєння макс калібру ";
            this.списокОзброєнняМаксКалібруToolStripMenuItem.Click += new System.EventHandler(this.списокОзброєнняМаксКалібруToolStripMenuItem_Click);
            // 
            // списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem
            // 
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.Image")));
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.Name = "списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem";
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.Text = "Список середнього калібру по типах озброєння ";
            this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem.Click += new System.EventHandler(this.списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.infoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.infoToolStripMenuItem.Image = global::Bordjiano.Properties.Resources.Information_icon;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bordjiano.Properties.Resources._454546;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількістьОзброєнняЗаданогоКалібруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокОзброєнняМаксКалібруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private static System.Windows.Forms.DataGridView dataGridView1;
    }
}

