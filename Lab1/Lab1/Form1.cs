using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления Button:
	1. Name - имя элемента в коде
	2. Text - текст на кнопке
	3. Width - ширина
	4. Height - высота
	5. Location - координаты относительно левого верхнего угла
	6. Cursor - курсор, отображаемый при наведении
	7. Focus - устанавливает фокус на кнопку
	8. Hide - скрывает кнопку
	9. Show - показывает кнопку
	
	События элемента управления Button:
	1. Click - нажатие на кнопку
	2. MouseDown - нажатие кнопки мыши по элементу
	3. MouseUp - отпускание кнопки мыши на элементе
	4. MouseEnter - указатель зашел на кнопку
	5. MouseLeave - указатель вышел с кнопки
	6. MouseHover - указатель задержался на кнопке";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления TextBox:
	1. Text - изначальный текст
	2. MaxLength - максимальное количество символов
	3. PasswordChar - символ, которым скрывается введенный текст
	4. ReadOnly - запрет на редактирование текста
	5. Multiline - ввод нескольких строк
	6. WordWrap - автоматический перенос строки
	7. Focus - устанавливает фокус на поле
	8. ResetText - сбрасывает текст на значение по умолчанию

	События элемента управления TextBox:
	1. TextChanged - изменение текста
	2. Click - щелчок по полю";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления Label:
	1. Text - показываемый текст
	2. TextAlign - выравнивание текста
	3. Visible - отображается ли элемент
	4. Location - координаты относительно левого верхнего угла
	5. Font - шрифт текста
	6. FontHeight - высота шрифта
	7. Hide - скрывает текст
	8. Show - показывает текст

	События элемента управления Label:
	1. TextChanged - изменение текста
	2. FontChanged - изменение шрифта
	3. VisibleChanged - изменение видимости
	4. Click - нажатие на текст
	5. MouseHover - указатель задержался на тексте";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления MaskedTextBox:
	1. Text - изначальный текст
	2. Mask - маска ввода текста
	3. PasswordChar - символ, которым скрывается введенный текст
	4. ReadOnly - запрет на редактирование текста
	5. InsertKeyMode - режим вставки текста
	6. Focus - устанавливает фокус на поле
	7. ResetText - сбрасывает текст на значение по умолчанию

	События элемента управления MaskedTextBox:
	1. MaskInputRejected - введен неподходящий символ
	2. TextChanged - изменение текста";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления ComboBox:
	1. Text - изначальный текст
	2. Items - элементы в списке
	3. ItemHeight - толщина элемента в пикселях
	4. Sorted - сортируются ли элементы в списке
	5. MaxDropDownItems - максимальное кол-во элементов в списке
	6. DropDownStyle - стиль поля
	7. ResetText - сбрасывает текст на значение по умолчанию

	События элемента управления ComboBox:
	1. SelectedIndexChanged - изменение выбранного элемента
	2. SelectionChangeCommitted - выбор элемента
	3. SelectedValueChanged - выбор элемента с другим значением
	4. DropDown - раскрытие списка
	5. DropDownClosed - сворачивание списка";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления CheckBox:
	1. Checked - включен ли флажок
	2. CheckState - состояние флажка
	3. CheckAlign - положение флажка
	4. Text - подпись рядом с флажком
	5. AutoCheck - изменение состояния при нажатии
	6. ThreeState - изпользование трех состояний флажка

	События элемента управления:
	1. CheckedChanged - включение или выключение флажка
	2. CheckedStateChanged - изменение состояния флажка";
        }

        private void groupBox1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления GroupBox:
	1. Text - текст на рамке
	2. AutoSize - авто-изменение размера по содержимому
	3. AutoSizeMode - поведение автоматического изменения размера
	4. Dock - какая граница привязана к контейнеру

	События элемента управления GroupBox:
	1. Resize - изменение размера
	2. VisibleChanged - изменение видимости";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления PictureBox:
	1. Image - отображаемое изображение
	2. ImageLocation - путь или ссылка на картинку
	3. SizeMode - как будет размещаться рисунок
	4. BorderStyle - тип рамки изображения
	5. InitialImage - изображение при загрузке картинки
	6. ErrorImage - изображение при ошибке загрузки
	7. Load - загружает отображаемое изображение по указанному URL

	События элемента управления PictureBox:
	1. LoadCompleted - завершение загрузки изображения
	2. LoadProgressChanged - изменение хода загрузки";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления ListBox:
	1. Items - элементы в списке
	2. SelectionMode - сколько элементов можно выбрать
	3. MultiColumn - расположение по столбцам при нехватке места
	4. ColumnWidth - ширина столбца
	5. ItemHeight - высота элемента из списка
	6. ScrollAlwaysVisible - постоянное отображение полосы прокрутки
	7. HorisontalScrollbar - полоса прокрутки для длинных элементов
	8. Sort - сортирует элементы списка

	События элемента управления ListBox:
	1. SelectedIndexChanged - изменение выбранного элемента
	2. SelectedValueChanged - выбор элемента с другим значением";
        }

        private void свойстваMenuStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления MenuStrip:
	1. Items - все элементы меню
	2. BackColor - цвет фона
	3. TextDirection - направление текста

	События элемента управления MenuStrip:
	1. ItemClicked - щелчок по элементу меню";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления NumericUpDown:
	1. Value - значение числового поля
	2. Maximum - максимальное значение
	3. Minimum - минимальное значение
	4. Increment - величина изменения при клике
	5. DecimalPlaces - количество отображаемых десятичных разрядов
	6. TextAlign - выравнивание числа
	7. UpDownAlign - с какой стороны расположены стрелки
	8. Hexadecimal - шеснадцатеричное отображение числа
	9. UpButton - увеличивает значение
	10. DownButton - уменьшает значение
	11. Focus - устанавливает фокус на поле

	События элемента управления NumericUpDown:
	1. ValueChanged - изменение значения";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления DateTimePicker:
	1. Value - текущее значение даты
	2. MaxDate - максимальное значение даты
	3. MinDate - минимальное значение даты
	4. Format - формат отображения даты и времени
	5. CustomFormat - пользовательский формат отбражения
	6. ShowUpDown - кнопки вверх-вниз вместо календаря
	7. DropDownAlign - с какой стороны открывается календарь
	8. Focus - устанавливает фокус на поле

	События элемента управления DateTimePicker:
	1. ValueChanged - изменение даты";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления RadioButton:
	1. Text - подпись переключателя
	2. Checked - активирован ли переключатель
	3. CheckAlign - с какой стороны расположен переключатель
	4. TextAlign - выравнивание текста
	5. Appearance - обычное отображение или в виде кнопки
	6. AutoCheck - изменение состояния при нажатии

	События элемента управления RadioButton:
	1. CheckedChanged - изменение состояния переключателя";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            label3.Text = @"Свойства и методы элемента управления FolderBrowserDialog:
	1. SelectedPath - выбранная папка
	2. RootFolder - папка, с которой начинатся обзор
	3. Description - текст в окне выбора папки
	4. ShowNewFolderButton - отображать кнопку создания папки
	5. ShowDialog - открывает диалоговое окно";
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления Panel:
	1. BorderStyle - тип рамки панели
	2. AutoSize - авто-изменение размера по содержимому
	3. AutoSizeMode - поведение автоматического изменения размера
	4. Dock - какая граница привязана к контейнеру

	События элемента управления Panel:
	1. Resize - изменение размера
	2. VisibleChanged - изменение видимости ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = @"Свойства и методы элемента управления DataGridView:
	1. Columns - все столбцы
	2. AutoSizeColumsMode - режим авто-изменения размера столбцов
	3. AutoSizeRowsMode - режим авто-изменения размера строк
	4. ColumnsHeadersHeight - высота заголовков таблицы
	5. MultiSelect - возможность выбора более одной ячейки
	6. ReadOnly - может ли пользователь редактировать ячейки
	7. CancelEdit - отменяет редактирование и все сделанные изменения
	8. ClearSelection - снимает выделение с ячеек
	9. Sort - сортировка элементов

	События элемента управления DataGridView:
	1. CellContentClick - щелчок по содержимому ячейки
	2. CellClick - щелчок на любой части ячейки
	4. CellParsing - остановка режима правки с изменением содержимого
	5. CellBeginEdit - запуск режима правки
	6. CellEndEdit - остановка режима правки
	7. CellEnter - ячейка получает фокус
	8. CellLeave - ячейка теряет фокус";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                button2.Text = "Скрыть Panel";
            }
            else
            {
                panel1.Visible = false;
                button2.Text = "Показать Panel";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button2.Text = "Показать Panel";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
			label3.Text = @"Свойства и методы элемента управления FolderBrowserDialog:
	1. SelectedPath - выбранная папка
	2. RootFolder - папка, с которой начинатся обзор
	3. Description - текст в окне выбора папки
	4. ShowNewFolderButton - отображать кнопку создания папки
	5. ShowDialog - открывает диалоговое окно";
		}

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label3.Text = @"Свойства и методы элемента управления OpenFileDialog:
	1. FileName - путь к выбранному файлу
	2. InitialDirectory - изначально отображаемый каталог
	3. AddExtension - добавляется ли расширение к имени файла
	4. CheckFileExists - проверка существования файла
	5. CheckPathExists - проверка существования пути
	6. DefaultExt - расширение по умолчанию
	7. Title - название диалогового окна
	8. MultiSelect - возможность выбора нескольких файлов
	9. ShowDialog - открывает диалоговое окно

	События элемента управления OpenFileDialog:
	1. FileOk - нажатие кнопки Открыть";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label3.Text = @"Свойства и методы элемента управления SaveFileDialog:
	1. FileName - путь к выбранному файлу
	2. InitialDirectory - изначально отображаемый каталог
	3. AddExtension - добавляется ли расширение к имени файла
	4. CheckFileExists - проверка существования файла
	5. CheckPathExists - проверка существования пути
	6. DefaultExt - расширение по умолчанию
	7. Title - название диалогового окна
	8. OverwritePrompt - запрос перезаписи существующего файла
	9. ShowDialog - открывает диалоговое окно

	События элемента управления SaveFileDialog:
	1. FileOk - нажатие кнопки Сохранить";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
			
            if (progressBar1.Value == 100)
            {
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                label3.Text = @"Свойства и методы элемента управления ProgressBar:
	1. Value - положение индикатора
	2. PerformStep - увеличение положения индикатора
	3. Step - шаг, на который увеличивает PerformStep
	4. Maximum - максимальное значение диапазона
	5. Minimum - минимальное значение диапазона
	6. Style - тип отображения ProgressBar
	7. Hide - скрывает элемент
	8. Show - отображает элемент

	События элемента управления ProgressBar:
	1. VisibleChanged - изменение видимости";
                button6.Text = "ProgressBar";
            }
            else if (progressBar1.Visible == true && progressBar1.Value < 100)
            {
                progressBar1.Value += 25;
            }
            else if (progressBar1.Visible == false)
            {
                progressBar1.Visible = true;
                button6.Text = ">>";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            label3.Text = @"Свойства и методы элемента управления ProgressBar:
	1. Value - положение индикатора
	2. PerformStep - увеличение положения индикатора
	3. Step - шаг, на который увеличивает PerformStep
	4. Maximum - максимальное значение диапазона
	5. Minimum - минимальное значение диапазона
	6. Style - тип отображения ProgressBar
	7. Hide - скрывает элемент
	8. Show - отображает элемент

	События элемента управления ProgressBar:
	1. VisibleChanged - изменение видимости";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();
        }
    }
}
