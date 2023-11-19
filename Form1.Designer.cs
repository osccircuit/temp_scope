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
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        Button button1 = new Button();
        button1.Text = "Нажми меня"; // Установите текст кнопки
        button1.Location = new System.Drawing.Point(50, 50); // Установите положение кнопки на форме (координаты X и Y)
        button1.Click += new EventHandler(button1_Click); // Добавьте обработчик события нажатия на кнопку
        this.Controls.Add(button1); // Добавьте кнопку на форму
    }

    #endregion
}
