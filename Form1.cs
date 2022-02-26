using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace notep
{
    public partial class Form1 : Form
    {
        private string fileName;
        // Проверяет были ли изменения в текущем файле.
        private bool isFileChanged;
        private bool cancelIndicator = false;
        public Form1()
        {
            InitializeComponent();

            Init();
            // Чтобы контекстное меню показывалось при запуске.
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        /// <summary>
        /// Метод , вызывающийся при инициализации нового документа(со стандартными настройками).
        /// </summary>
        public void Init()
        {
            fileName = "Безымянный";
            isFileChanged = false;
            richTextBox1.Font = Form1.DefaultFont;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            this.menuStrip1.ForeColor = Color.Black;
            this.menuStrip1.BackColor = Color.White;
            UpdateTitle();
        }

        /// <summary>
        /// Создаёт новый файл.
        /// </summary>
        public void CreateNewFile(object sender, EventArgs e)
        {
            KeepUnsavedFile();
            if (cancelIndicator)
            {
                cancelIndicator = false;
                return;
            }
            richTextBox1.Text = "";
            Init();
        }

        /// <summary>
        /// Открывает файл.
        /// </summary>
        public void OpenFile(object sender, EventArgs e)
        {
            KeepUnsavedFile();
            if (cancelIndicator)
            {
                cancelIndicator = false;
                return;
            }
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Открыть";
            openFileDialog1.Filter = "Текстовые файлы (*.txt) |*.txt| Расширенные текстовые файлы (*.rtf)|*.rtf| Все файлы (*.*)|*.*";
            openFileDialog1.FileName = fileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Попытка открыть файл .rtf
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                    fileName = openFileDialog1.FileName;
                    UpdateTitle();
                }
                catch
                {
                    try
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        richTextBox1.Text = sr.ReadToEnd();
                        fileName = openFileDialog1.FileName;
                        UpdateTitle();
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно открыть файл.");
                    }
                }
            }
            isFileChanged = false;
        }

        /// <summary>
        /// Общий метод сохранения файла.
        /// </summary>
        public void SaveFile(string _fileName)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Сохранить";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt) |*.txt| Расширенные текстовые файлы (*.rtf)|*.rtf| Все файлы (*.*)|*.*";
            saveFileDialog1.FileName = _fileName;
            if (_fileName == "" || isFileChanged)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _fileName = saveFileDialog1.FileName;
                }
                else
                {
                    cancelIndicator = true;
                    return;
                }
            }
            try
            {
                var sw = new StreamWriter(_fileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fileName = _fileName;
                isFileChanged = false;
                this.Text = _fileName;
                UpdateTitle();
            }
            catch (ArgumentException)
            {
            }
            catch (IOException)
            {
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить файл");
            }
        }

        /// <summary>
        /// Сохранить файл.
        /// </summary>
        public void Save(Object sender, EventArgs e)
        {
            SaveFile(fileName);
        }

        /// <summary>
        /// Сохранить Как.
        /// </summary>
        public void SaveAs(Object sender, EventArgs e)
        {
            SaveFile("");
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            // Это условие добавлено, чтобы к названию не прибавлялись звездочки после любого изменения.
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace("*", " ");
                // Если текст как-либо изменяется, то присавеваем isFileChanged значение true.
                isFileChanged = true;
                // А '*' прибавляем к названию, как индикатор того, что изменения не сохранены.
                this.Text = '*' + this.Text;
            }
        }

        /// <summary>
        /// Обновляет название формы на имя открытого файла.
        /// </summary>
        public void UpdateTitle()
        {
            if (fileName != "")
            {
                this.Text = fileName;
            }
            else
            {
                this.Text = "Безымянный";
            }
        }

        /// <summary>
        /// Предлагает возможностть сохранить несохраненный файл.
        /// </summary>
        public void KeepUnsavedFile()
        {
            // Если файл изменен и не сохранен, то вызываем диалоговое окно с вопросом.
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show($"Хотите сохранить изменения в файле {fileName}?", "Сохранение файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(fileName);
                }
                else if (result == DialogResult.Cancel)
                {
                    cancelIndicator = true;
                }
            }
        }

        /// <summary>
        /// При закрытии формы предлагает сохранить файл.
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFileChanged)
            {
                KeepUnsavedFile();
                if (cancelIndicator)
                {
                    isFileChanged = true;
                    cancelIndicator = false;
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Копирует выделенный текст.
        /// </summary>
        private void Copy(Object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Вырезает выделенный текст.
        /// </summary>
        private void Cut(Object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.SelectionLength));
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Вставка текста из буфера обмена.
        /// </summary>
        private void Paste(Object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        /// <summary>
        /// Выделяет весь текст в документе.
        /// </summary>
        private void SelectAllText(Object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }

        /// <summary>
        /// Выбирает шрифт для всего документа.
        /// </summary>
        private void SelectFontAllText(Object sender, EventArgs e)
        {
            var fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        /// <summary>
        /// Выбрать шрифт для выбранной области
        /// </summary>
        private void SetSelectedAreaFont(Object sender, EventArgs e)
        {
            var fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        /// <summary>
        /// Выбирает Контрастную схему.
        /// </summary>
        private void ContrastColorScheme(Object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.Orange;
            this.menuStrip1.ForeColor = Color.Orange;
            this.menuStrip1.BackColor = Color.DarkSlateGray;
        }

        /// <summary>
        /// Выбирает обычную схему.
        /// </summary>
        private void DefaultColorScheme(Object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            this.menuStrip1.ForeColor = Color.Black;
            this.menuStrip1.BackColor = Color.White;
        }

        /// <summary>
        /// Выбирает Windows blue screen схему.
        /// </summary>
        private void WindowsColorScheme(Object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.DarkBlue;
            richTextBox1.ForeColor = Color.White;
            this.menuStrip1.ForeColor = Color.White;
            this.menuStrip1.BackColor = Color.CadetBlue;
        }
    }
}
