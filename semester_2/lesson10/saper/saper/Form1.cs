using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private const int
            MR = 10, // кол-во клеток по вертикали
            MC = 10, // кол-во клеток по горизонтали
            NM = 10, // кол-во мин
            W = 40, // ширина клетки
            H = 40;

        private static int time;
        DateTime dt;

        // игровое (минное) поле
        private int[,] Pole = new int[MR + 2, MC + 2];
        // значение элемента массива:
        // 0..8 - количество мин в соседних клетках
        // 9 - в клетке мина
        // 100..109 - клетка открыта
        // 200..209 - в клетку поставлен флаг

        private int nMin; // кол-во найденных мин
        private int nFlag; // кол-во поставленных флагов

        // статус игры
        private int status;
        // 0 - начало игры,
        // 1 - игра,
        // 2 – результат

        // графическая поверхность формы
        private Graphics g;

        public Form1()
        {
            InitializeComponent();

            // В неотображаемые эл-ты массива, соответствующие
            // клеткам границы игрового поля запишем число -3.
            // Это значение используется процедурой open()
            // для завершения рекурсивного процесса открытия
            // соседних пустых клеток
            for (int row = 0; row <= MR + 1; row++)
            {
                Pole[row, 0] = -3;
                Pole[row, MC + 1] = -3;
            }

            for (int col = 0; col <= MC + 1; col++)
            {
                Pole[0, col] = -3;
                Pole[MR + 1, col] = -3;
            }

            // устанавливаем размер формы в соответствии
            // с размером игрового поля
            this.ClientSize = new Size(W * MC + 1, 57 + H * MR + menuStrip1.Height + 1);
            button1.Location = new Point(this.ClientSize.Width / 2 - button1.Width / 2, 7);
            label1.Text = "0";
            label2.Text = "00:00";
            label1.Location = new Point(2 * W, 10);
            label2.Location = new Point(6 * W, 10);
            newGame(); // новая игра

            // графическая поверхность
            g = panel1.CreateGraphics();
        }

// новая игра
        private void newGame()
        {
            int row, col; // индексы клетки
            int n = 0; // количество поставленных мин
            int k; // кол-во мин в соседних клетках

            // очистить поле
            for (row = 1; row <= MR; row++)
            for (col = 1; col <= MC; col++)
                Pole[row, col] = 0;


            // инициализация генератора случайных чисел
            Random rnd = new Random();

            // расставим мины
            do
            {
                row = rnd.Next(MR) + 1;
                col = rnd.Next(MC) + 1;

                if (Pole[row, col] != 9)
                {
                    Pole[row, col] = 9;
                    n++;
                }
            } while (n != NM);

            // для каждой клетки вычислим кол-во 
            // мин в соседних клетках
            for (row = 1; row <= MR; row++)
            for (col = 1; col <= MC; col++)
                if (Pole[row, col] != 9)
                {
                    k = 0;

                    if (Pole[row - 1, col - 1] == 9) k++;
                    if (Pole[row - 1, col] == 9) k++;
                    if (Pole[row - 1, col + 1] == 9) k++;
                    if (Pole[row, col - 1] == 9) k++;
                    if (Pole[row, col + 1] == 9) k++;
                    if (Pole[row + 1, col - 1] == 9) k++;
                    if (Pole[row + 1, col] == 9) k++;
                    if (Pole[row + 1, col + 1] == 9) k++;

                    Pole[row, col] = k;
                }

            status = 0; // начало игры
            nMin = 0; // нет обнаруженных мин
            nFlag = 0; // нет поставленных флагов
            label1.Text = nFlag.ToString();
        }

// рисует поле
        private void showPole(Graphics g, int status)
        {
            for (int row = 1; row <= MR; row++)
            for (int col = 1; col <= MC; col++)
                this.kletka(g, row, col, status);
        }

// рисует клетку
        private void kletka(Graphics g,
            int row, int col, int status)
        {
            int x, y; // координаты левого верхнего угла клетки

            x = (col - 1) * W + 1;
            y = (row - 1) * H + 1;

            // не открытые клетки - серые
            if (Pole[row, col] < 100)
                g.FillRectangle(SystemBrushes.ControlLight,
                    x - 1, y - 1, W, H);

            // открытые или помеченные клетки
            if (Pole[row, col] >= 100)
            {
                // открываем клетку, открытые - белые
                if (Pole[row, col] != 109)
                    g.FillRectangle(Brushes.White,
                        x - 1, y - 1, W, H);
                else
                    // на этой мине подорвались!
                    g.FillRectangle(Brushes.Red,
                        x - 1, y - 1, W, H);

                // если в соседних клетках есть мины,
                // указываем их количество
                if ((Pole[row, col] >= 101) && (Pole[row, col] <= 108))
                    g.DrawString((Pole[row, col] - 100).ToString(),
                        new Font("Tahoma", 10,
                            System.Drawing.FontStyle.Regular),
                        Brushes.Blue, x + 3, y + 2);
            }

            // в клетке поставлен флаг
            if (Pole[row, col] >= 200)
                this.flag(g, x, y);

            // рисуем границу клетки
            g.DrawRectangle(Pens.Black,
                x - 1, y - 1, W, H);

            // если игра завершена (status = 2),
            // показываем мины
            if ((status == 2) && ((Pole[row, col] % 10) == 9))
                this.mina(g, x, y);
        }

// открывает текущую и все соседние с ней клетки,
// в которых нет мин
        private void open(int row, int col)
        {
            // координаты области вывода
            int x = (col - 1) * W + 1,
                y = (row - 1) * H + 1;

            if (Pole[row, col] == 0)
            {
                Pole[row, col] = 100;

                // отобразить содержимое клетки
                this.kletka(g, row, col, status);

                // открыть примыкающие клетки
                // слева, справа, сверху, снизу
                this.open(row, col - 1);
                this.open(row - 1, col);
                this.open(row, col + 1);
                this.open(row + 1, col);

                //примыкающие диагонально
                this.open(row - 1, col - 1);
                this.open(row - 1, col + 1);
                this.open(row + 1, col - 1);
                this.open(row + 1, col + 1);
            }
            else if ((Pole[row, col] < 100) &&
                     (Pole[row, col] != -3))
            {
                Pole[row, col] += 100;

                // отобразить содержимое клетки
                this.kletka(g, row, col, status);
            }
        }

// рисует мину
        private void mina(Graphics g, int x, int y)
        {
            // корпус
            g.FillRectangle(Brushes.Green,
                x + 16, y + 26, 8, 4);
            g.FillRectangle(Brushes.Green,
                x + 8, y + 30, 24, 4);
            g.DrawPie(Pens.Black,
                x + 6, y + 28, 28, 16, 0, -180);
            g.FillPie(Brushes.Green,
                x + 6, y + 28, 28, 16, 0, -180);

            // полоса на корпусе
            g.DrawLine(Pens.Black,
                x + 12, y + 32, x + 28, y + 32);

            // вертикальный "ус"
            g.DrawLine(Pens.Black,
                x + 20, y + 22, x + 20, y + 26);

            // боковые "усы"
            g.DrawLine(Pens.Black,
                x + 8, y + 30, x + 6, y + 28);
            g.DrawLine(Pens.Black,
                x + 32, y + 30, x + 34, y + 28);
        }

// рисует флаг
        private void flag(Graphics g, int x, int y)
        {
            Point[] p = new Point[3];
            Point[] m = new Point[5];

            g.FillRectangle(SystemBrushes.ControlLight,
                x - 1, y - 1, W, H);

            // флажок
            p[0].X = x + 4;
            p[0].Y = y + 4;
            p[1].X = x + 30;
            p[1].Y = y + 12;
            p[2].X = x + 4;
            p[2].Y = y + 20;
            g.FillPolygon(Brushes.Red, p);

            // древко
            g.DrawLine(Pens.Black,
                x + 4, y + 4, x + 4, y + 35);

            // буква M на флажке
            m[0].X = x + 8;
            m[0].Y = y + 14;
            m[1].X = x + 8;
            m[1].Y = y + 8;
            m[2].X = x + 10;
            m[2].Y = y + 10;
            m[3].X = x + 12;
            m[3].Y = y + 8;
            m[4].X = x + 12;
            m[4].Y = y + 14;
            g.DrawLines(Pens.White, m);
        }

// щелчок кнопкой в клетке игрового поля
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            // игра завершена
            if (status == 2) return;

            // первый щелчок
            if (status == 0)
            {
                timer1.Start();
                status = 1;
            }

            // преобразуем координаты мыши в индексы
            // клетки поля, в которой был сделан щелчок;
            // (e.X, e.Y) - координаты точки формы,
            // в которой была нажата кнопка мыши;            
            int row = (int) (e.Y / H) + 1,
                col = (int) (e.X / W) + 1;

            // координаты области вывода
            int x = (col - 1) * W + 1,
                y = (row - 1) * H + 1;

            // щелчок левой кнопки мыши
            if (e.Button == MouseButtons.Left)
            {
                // открыта клетка, в которой есть мина                   
                if (Pole[row, col] == 9)
                {
                    Pole[row, col] += 100;

                    // игра закончена
                    status = 2;

                    clearTimer();

                    // перерисовать форму
                    this.panel1.Invalidate();
                }
                else if (Pole[row, col] < 9)
                    this.open(row, col);
            }

            // щелчок правой кнопки мыши
            if (e.Button == MouseButtons.Right)
            {
                // в клетке не было флага, ставим его
                if (Pole[row, col] <= 9)
                {
                    nFlag += 1;

                    if (Pole[row, col] == 9)
                        nMin += 1;

                    Pole[row, col] += 200;

                    if ((nMin == NM) && (nFlag == NM))
                    {
                        // игра закончена
                        status = 2;

                        clearTimer();

                        // перерисовываем все игровое поле
                        this.Invalidate();
                    }
                    else
                        // перерисовываем только клетку
                        this.kletka(g, row, col, status);
                }
                else
                    // в клетке был поставлен флаг,
                    // повторный щелчок правой кнопки мыши
                    // убирает его и закрывает клетку
                if (Pole[row, col] >= 200)
                {
                    nFlag -= 1;
                    Pole[row, col] -= 200;

                    // перерисовываем клетку                
                    this.kletka(g, row, col, status);
                }
            }

            label1.Text = nFlag.ToString();
        }

        private void clearTimer()
        {
            timer1.Stop();
            time = 0;
            label2.Text = "00:00";
        }

// команда Новая игра
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearTimer();
            newGame();
            showPole(g, status);
        }

// обработка события Paint панели
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            showPole(g, status);
        }

// выбор в меню Справка команды О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 aboutBox = new Form2();
            aboutBox.ShowDialog();
        }

// выбор в меню Справка команды Правила игры
        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, "saper_02.htm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label2.Text = dt.AddSeconds(time).ToString("mm:ss");
        }


        // 0..8 - количество мин в соседних клетках
        // 9 - в клетке мина
        // 100..109 - клетка открыта
        // 200..209 - в клетку поставлен флаг

        private int flagNum(int row, int col)
        {
            //int n = Pole[row, col];
            int sum = 0;

            // int x = (col - 1) * W + 1,
            //     y = (row - 1) * H + 1;

            for (int i = row - 1; i < row + 2; i++)
            {
                for (int j = col - 1; j < col + 2; j++)
                {
                    if (i >= 0 && j >= 0 && i <= MR && j <= MC)
                        if (Pole[i, j] >= 200)
                            sum++;
                }
            }

            return sum;
        }


        private void openNear(int row, int col)
        {
            for (int i = row - 1; i < row + 2; i++)
            {
                for (int j = col - 1; j < col + 2; j++)
                {
                    // MessageBox.Show(i + " " + j);
                    //open(row, col);
                    if (i >= 0 && j >= 0 && i <= MR + 1 && j <= MC + 1)
                    {
                        // открыта клетка, в которой есть мина                   
                        if (Pole[i, j] == 9)
                        {
                            Pole[i, j] += 100;

                            // игра закончена
                            status = 2;

                            clearTimer();

                            // перерисовать форму
                            this.panel1.Invalidate();
                        }
                        else if (Pole[i, j] < 9)
                            this.open(i, j);
                    }

                    // if (Pole[i, j] >= 200)
                    // sum++;
                }
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Генерал Шпилёв, вы подорвались на мине!");
            int row = (int) (e.Y / H) + 1,
                col = (int) (e.X / W) + 1;

            // координаты области вывода
            int x = (col - 1) * W + 1,
                y = (row - 1) * H + 1;

            if (e.Button == MouseButtons.Left)
            {
                if (status == 2) return;

                // первый щелчок
                if (status == 0)
                {
                    timer1.Start();
                    status = 1;
                }

                // MessageBox.Show(Pole[row, col] + " " + flagNum(row, col).ToString());

                // если стоит достаточное кол-во флагов
                if (Pole[row, col] % 100 == flagNum(row, col))
                {
                    // MessageBox.Show("open");

                    openNear(row, col);
                }
            }
        }
    }
}


// если нажата 1-8
// если количество флагов = 