
namespace notep
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllText1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopySelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.FormatToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.SaveAsToolStripMenuItem.Text = "Сохранить Как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllTextToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // SelectAllTextToolStripMenuItem
            // 
            this.SelectAllTextToolStripMenuItem.Name = "SelectAllTextToolStripMenuItem";
            this.SelectAllTextToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.SelectAllTextToolStripMenuItem.Text = "Выбрать весь текст";
            this.SelectAllTextToolStripMenuItem.Click += new System.EventHandler(this.SelectAllText);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.Cut);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.CopyToolStripMenuItem.Text = "Копировать";
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.PasteToolStripMenuItem.Text = "Вставка";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.Paste);
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem});
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.FormatToolStripMenuItem.Text = "Формат";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.FontToolStripMenuItem.Text = "Шрифт";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.SelectFontAllText);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetColorToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // SetColorToolStripMenuItem
            // 
            this.SetColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contastToolStripMenuItem,
            this.WindowsToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.SetColorToolStripMenuItem.Name = "SetColorToolStripMenuItem";
            this.SetColorToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.SetColorToolStripMenuItem.Text = "Изменить цветовую схему";
            // 
            // contastToolStripMenuItem
            // 
            this.contastToolStripMenuItem.Name = "contastToolStripMenuItem";
            this.contastToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.contastToolStripMenuItem.Text = "Контрастная";
            this.contastToolStripMenuItem.Click += new System.EventHandler(this.ContrastColorScheme);
            // 
            // WindowsToolStripMenuItem
            // 
            this.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem";
            this.WindowsToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.WindowsToolStripMenuItem.Text = "Windows blue screen";
            this.WindowsToolStripMenuItem.Click += new System.EventHandler(this.WindowsColorScheme);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.defaultToolStripMenuItem.Text = "Обычная";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultColorScheme);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(744, 713);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllText1ToolStripMenuItem,
            this.CutSelectedTextToolStripMenuItem,
            this.CopySelectedTextToolStripMenuItem,
            this.PasteContextToolStripMenuItem,
            this.FormatSelectedTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(369, 164);
            // 
            // SelectAllText1ToolStripMenuItem
            // 
            this.SelectAllText1ToolStripMenuItem.Name = "SelectAllText1ToolStripMenuItem";
            this.SelectAllText1ToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.SelectAllText1ToolStripMenuItem.Text = "Выбрать весь текст";
            this.SelectAllText1ToolStripMenuItem.Click += new System.EventHandler(this.SelectAllText);
            // 
            // CutSelectedTextToolStripMenuItem
            // 
            this.CutSelectedTextToolStripMenuItem.Name = "CutSelectedTextToolStripMenuItem";
            this.CutSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.CutSelectedTextToolStripMenuItem.Text = "Вырезать";
            this.CutSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.Cut);
            // 
            // CopySelectedTextToolStripMenuItem
            // 
            this.CopySelectedTextToolStripMenuItem.Name = "CopySelectedTextToolStripMenuItem";
            this.CopySelectedTextToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.CopySelectedTextToolStripMenuItem.Text = "Копировать";
            this.CopySelectedTextToolStripMenuItem.Click += new System.EventHandler(this.Copy);
            // 
            // PasteContextToolStripMenuItem
            // 
            this.PasteContextToolStripMenuItem.Name = "PasteContextToolStripMenuItem";
            this.PasteContextToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.PasteContextToolStripMenuItem.Text = "Вставить";
            this.PasteContextToolStripMenuItem.Click += new System.EventHandler(this.Paste);
            // 
            // FormatSelectedTextToolStripMenuItem
            // 
            this.FormatSelectedTextToolStripMenuItem.Name = "FormatSelectedTextToolStripMenuItem";
            this.FormatSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.FormatSelectedTextToolStripMenuItem.Text = "Форматировать выделенный текст";
            this.FormatSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.SetSelectedAreaFont);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 746);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelectAllText1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutSelectedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopySelectedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatSelectedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}

