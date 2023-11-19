namespace temp_scope;

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
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 450);
        this.Text = "TermoScope";

        //Лейблы
        Label label1 = new Label();
        label1.Text = "Запуск измерения:";
        label1.Size = new Size(120, 16);
        label1.Location = new Point(10, 25);
        this.Controls.Add(label1);

        Label label2 = new Label();
        label2.Text = "Остановить измерение:";
        label2.Size = new Size(140, 16);
        label2.Location = new Point(140, 25);
        this.Controls.Add(label2);

        Label label3 = new Label();
        label3.Text = "Построение карты:";
        label3.Size = new Size(140, 16);
        label3.Location = new Point(10, 70);
        this.Controls.Add(label3);

        //Разделители
        Label separatorLabel1 = new Label();
        separatorLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
        separatorLabel1.Size = new Size(280, 2);
        separatorLabel1.Location = new Point(5, 115); // Установите положение линии на форме
        this.Controls.Add(separatorLabel1);

        Panel verticalLine = new Panel();
        verticalLine.Width = 2; // Ширина вертикальной линии
        verticalLine.BackColor = System.Drawing.Color.Gray; // Цвет фона линии
        verticalLine.Location = new Point(288, 25); // Установите положение линии на форме
        verticalLine.Height = 400; // Высота вертикальной линии
        this.Controls.Add(verticalLine);

        //Кнопки
        Button button1 = new Button();
        button1.Text = "Старт"; // Установите текст кнопки
        //button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, (this.ClientSize.Height - button1.Height) / 2); // Разместите кнопку в середине экрана
        button1.Location = new System.Drawing.Point(10, 40); // Установите положение кнопки на форме (координаты X и Y)
        button1.Click += new EventHandler(button1_Click); // Добавьте обработчик события нажатия на кнопку
        this.Controls.Add(button1); // Добавьте кнопку на форму

        Button button2 = new Button();
        button2.Text = "Стоп"; // Установите текст кнопки
        //button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, (this.ClientSize.Height - button1.Height) / 2); // Разместите кнопку в середине экрана
        button2.Location = new System.Drawing.Point(142, 40); // Установите положение кнопки на форме (координаты X и Y)
        //button1.Click += new EventHandler(button2_Click); // Добавьте обработчик события нажатия на кнопку
        this.Controls.Add(button2); // Добавьте кнопку на форму
        //Панель элементов
        ToolStrip toolStrip1 = new ToolStrip();
        toolStrip1.Dock = DockStyle.Top; // Устанавливает докирование панели инструментов в верхней части формы.
        // Создайте кнопки или другие элементы управления для панели инструментов.
        ToolStripDropDownButton dropDownButton = new ToolStripDropDownButton("Файл");

        ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Найти и подключиться");
        ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Отключить устройство");
        ToolStripMenuItem menuItem3 = new ToolStripMenuItem("Запуск измерения");
        ToolStripMenuItem menuItem4 = new ToolStripMenuItem("Остановить измерение");
        ToolStripMenuItem menuItem5 = new ToolStripMenuItem("Сохранить полученную карту");
        ToolStripMenuItem menuItem6 = new ToolStripMenuItem("Выход");

        // Добавьте элементы в выпадающее меню
        dropDownButton.DropDownItems.Add(menuItem1);
        dropDownButton.DropDownItems.Add(menuItem2);
        dropDownButton.DropDownItems.Add(menuItem3);
        dropDownButton.DropDownItems.Add(menuItem4);
        dropDownButton.DropDownItems.Add(menuItem5);
        dropDownButton.DropDownItems.Add(menuItem6);

        
        ToolStripButton button_strip_2 = new ToolStripButton("Сохранить карту");
        ToolStripButton button_strip_3 = new ToolStripButton("Выход");

        // Добавьте элементы управления на панель инструментов.
        toolStrip1.Items.Add(dropDownButton);
        toolStrip1.Items.Add(button_strip_2);
        toolStrip1.Items.Add(button_strip_3);

        // Добавьте обработчики событий для кнопок (если необходимо).
        //button1.Click += Button1_Click;
        //button2.Click += Button2_Click;
        //button3.Click += Button3_Click;

        // Добавьте панель инструментов на форму.
        this.Controls.Add(toolStrip1);

        //Строка состояния
        StatusStrip statusStrip1 = new StatusStrip();
        this.Controls.Add(statusStrip1); // Добавьте строку состояния на форму
        ToolStripStatusLabel toolStripStatusLabel1 = new ToolStripStatusLabel();
        toolStripStatusLabel1.Text = "Готово"; // Установите текст элемента
        statusStrip1.Items.Add(toolStripStatusLabel1); // Добавьте элемент на строку состояния

        //Прогрессбар
        ProgressBar progressBar1 = new ProgressBar();
        progressBar1.Minimum = 0; // Минимальное значение
        progressBar1.Maximum = 100; // Максимальное значение
        progressBar1.Value = 50; // Текущее значение
        progressBar1.Size  = new Size(260, 16);
        progressBar1.Location = new Point(12, 86);
        this.Controls.Add(progressBar1);
    }

    #endregion
}
