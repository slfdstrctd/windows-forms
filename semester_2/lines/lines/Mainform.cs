using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Reflection;
using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace lines
{
    public partial class Mainform : Form
    {
        Device dr;
        PresentParameters ppr = new PresentParameters();
        Line myline;
        Color bc = Color.BurlyWood, gc = Color.Red;
        public static float xmin = 0, xmax = 10, ymin = -2, ymax = 2, tmin = 0, tmax = 100, t = 0, sx, sy;
        int ndx = 1000, fps = 0;
        Vector2[] mln;
        object frm;
        string usergood = "0";

        public Mainform()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "fml файлы (*.fml)|*.fml";
            //openFileDialog1.FileName = "";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            //{
            //    System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open);
            //    System.IO.BinaryReader rd = new System.IO.BinaryReader(fs);

            //    //ans = rd.ReadString();
            //    xmin = (float) rd.ReadDouble();
            //    xmax = (float) rd.ReadDouble();
            //    ymin = (float) rd.ReadDouble();
            //    ymax = (float) rd.ReadDouble();
            //    tmin = (float) rd.ReadDouble();
            //    tmax = (float) rd.ReadDouble();

            //    rd.Close();
            //    fs.Close();
            //}
            //testlimits();
            //mformula();
        }

        private void testlimits()
        {
           // if (xmin >= xmax) xmax = xmin + 100;
            //if (ymin >= ymax) ymax = ymin + 100;
           // if (tmin >= tmax) tmax = tmin + 100;
            //if (kz < 0) kz = -kz;
            //m2211.Text = xmin.ToString().Replace(",", ".");
            //m2221.Text = xmax.ToString().Replace(",", ".");
            //m2231.Text = ymin.ToString().Replace(",", ".");
            //m2241.Text = ymax.ToString().Replace(",", ".");
            //m2251.Text = tmin.ToString().Replace(",", ".");
            //m2261.Text = tmax.ToString().Replace(",", ".");
            //m2271.Text = dz.ToString().Replace(",", ".");
            //m2281.Text = kz.ToString().Replace(",", ".");
            //t = tmin;
            //sx = (xmax - xmin) / nq;
            //sy = (ymax - ymin) / nq;
        }

        private void фонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bc = colorDialog1.Color;
            }
        }

        private void графикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gc = colorDialog1.Color;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void инструкцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string it = "Для ввода формулы и границ используйте пункт меню Правка." + "\r";
            it += "Для обзора используйте указатель и правую кнопку мыши." + "\r";
            it += "Для приближения/удаления используйте ролик мыши." + "\r";
            it += "Правила ввода формул и данных." + "\r";
            it += " 1. Десятичный разделитель - точка (123.456)." + "\r";
            it += " 2. Доступны операторы: +,-,/,* и скобки." + "\r";
            it += " 3. Имена функций вводить строчными символами." + "\r";
            it += " 4. Доступны математические функции:" + "\r";
            it += "     cos(...) - косинус" + "\r";
            it += "     sin(...) - синус" + "\r";
            it += "     tan(...) - тангенс" + "\r";
            it += "     acs(...) - арккосинус" + "\r";
            it += "     asn(...) - арксинус" + "\r";
            it += "     atn(...) - арктангенс" + "\r";
            it += "     abs(...) - модуль" + "\r";
            it += "     lg(...) - десятичный логарифм" + "\r";
            it += "     ln(...) - натуральный логарифм" + "\r";
            it += "     sqrt(...) - квадратный корень" + "\r";
            it += "     pow(A,B) - A в степени B" + "\r";
            it += "     rnd(...) - округление" + "\r";
            it += " 5. В формулах доступны константы: pi, e" + "\r";
            it += " 6. После ввода необходимо нажать ENTER!" + "\r";
            MessageBox.Show(it, "Инструкции", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string it = "Динамические графики" + "\r";
            MessageBox.Show(it, "О программе \"Динамические графики\"", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void формулаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string ans = Interaction.InputBox("f(x,t)= ", "Формула", "");
            //mformula(ans);
        }

        private void границыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }

        //private void mformula(string ans)
        //{

            //string topfx = "using System;using System.Windows.Forms;class MyFormulaClass{public float Calculate(double x, double y, double t){double c=";
            //string mainfx;
            //string bottomfx = ";return (float)c;}}";
            //ans = ans.Replace(" ", "");
            //mainfx = ans;
            //mainfx = mainfx.Replace("sin", "Math.Sin");
            //mainfx = mainfx.Replace("cos", "Math.Cos");
            //mainfx = mainfx.Replace("tan", "Math.Tan");
            //mainfx = mainfx.Replace("asn", "Math.Asin");
            //mainfx = mainfx.Replace("acs", "Math.Acos");
            //mainfx = mainfx.Replace("atn", "Math.Atan");
            //mainfx = mainfx.Replace("abs", "Math.Abs");
            //mainfx = mainfx.Replace("lg", "Math.Log10");
            //mainfx = mainfx.Replace("ln", "Math.Log");
            //mainfx = mainfx.Replace("sqrt", "Math.Sqrt");
            //mainfx = mainfx.Replace("pow", "Math.Pow");
            //mainfx = mainfx.Replace("rnd", "Math.Round");
            //mainfx = mainfx.Replace("pi", "Math.PI");
            //mainfx = mainfx.Replace("e", "Math.E");
            ////Настройка компиляции
            //CodeDomProvider provider = new CSharpCodeProvider();
            //CompilerParameters cparams = new CompilerParameters();
            //cparams.ReferencedAssemblies.Add("System.dll");
            //cparams.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            //cparams.GenerateInMemory = true;
            ////Компиляция
            //CompilerResults result = null;
            //result = provider.CompileAssemblyFromSource(cparams, topfx + mainfx + bottomfx);
            //if (result.Errors.HasErrors)
            //{
            //    //Ошибки компиляции
            //    MessageBox.Show("Синтаксическая ошибка", "Формула", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    Assembly assembly = result.CompiledAssembly;
            //    frm = Activator.CreateInstance(assembly.CreateInstance("MyFormulaClass").GetType());
            //    usergood = ans;
            //}
        //}

        //private void newdata()
        //{
            //if (frm != null)
            //{
            //    var invoker = (Func<double, double, double, float>)Delegate.CreateDelegate(typeof(Func<double, double, double, float>), frm, "Calculate");
            //    //po.MaxDegreeOfParallelism = (m24.Checked) ? Environment.ProcessorCount : 1;
            //    //Parallel.For(0, ndx, po, stz);
            //    //Parallel.For(0, ndx, po, stn);
            //    mln = new Vector2[1];
            //}
           
           // Запись из массива в буфер
             //GraphicsStream gs = vbplane.Lock(0, 0, LockFlags.None);
            //gs.Write(mln);
            //vbplane.Unlock();
            //gs.Dispose();
        //}

        //private void stz(int i)
        //{
            //var invoker = (Func<double, double, double, float>)Delegate.CreateDelegate(typeof(Func<double, double, double, float>), frm, "Calculate");
            //for (int j = 0; j < ndx; j++)
            //{
            //    double y = ymin + sy * i, x = xmin + sx * j;
            //    //mln[i * ndx + j] = (float)invoker(x, y, t) * kz + dz; //Формула
            //}
        //}

        //private void stn(int i)
        //{
            //for (int j = 0; j < ndx; j++)
            //{
            //    //mln[i * ndx + j].Normal = Vector3.Normalize(Vector3.Cross(mln[i * nqv + j + 1].Position - dp[i * nqv + j].Position, dp[i * nqv + j + nqv].Position - dp[i * nqv + j].Position));
            //}
        //}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "fml файлы (*.fml)|*.fml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                System.IO.FileStream fs = new System.IO.FileStream(saveFileDialog1.FileName, System.IO.FileMode.Create);
                System.IO.BinaryWriter wr = new System.IO.BinaryWriter(fs);

                wr.Write(usergood);
                wr.Write(xmin);
                wr.Write(xmax);
                wr.Write(ymin);
                wr.Write(ymax);
                wr.Write(tmin);
                wr.Write(tmax);

                wr.Close();
                fs.Close();
            }
        }

        //Инициализация 3D устройства
        private bool InitializeGraphics()
        {
            try
            {
                ppr.Windowed = true;
                ppr.SwapEffect = SwapEffect.Discard;
                ppr.EnableAutoDepthStencil = true;
                ppr.AutoDepthStencilFormat = DepthFormat.D16;
                dr = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, ppr);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Загрузка формы
        private void Mainform_Load(object sender, EventArgs e)
        {
            if (!this.InitializeGraphics())
            {
                MessageBox.Show("Невозможно инициализировать Direct3D устройство. Программа будет закрыта.");
                this.Close();
            }

            myline = new Line(dr); //Создание линии
            mln = new Vector2[ndx + 1]; //Массив точек
            timer1.Start();
        }

        //Вывод по таймеру
        private void timer1_Tick(object sender, EventArgs e)
        {
            float ar = (float)this.ClientSize.Height / (float)this.ClientSize.Width;
            sx = (float)this.ClientSize.Width / (xmax - xmin);
            sy = (float)this.ClientSize.Height / (ymax - ymin);
            graphf();
            //newdata();

            if (dyn.Checked) t += 0.017f;
            if (t > tmax | t < tmin) t = tmin;
            try
            {
                dr.BeginScene();
                dr.Clear(ClearFlags.ZBuffer | ClearFlags.Target, bc, 1f, 0);
                myline.Antialias = true; //Сглаживание
                myline.Width = 2.0f; //Толщина
                myline.Draw(mln, gc); //Цвет
                dr.EndScene();
                dr.Present();
            }
            catch
            {
                return;
            }
            fps++;
        }

        //График формулы
        private void graphf()
        {
            float dx = (xmax - xmin) / (float)ndx;
            for (int i = 0; i <= ndx; i++)
            {
                float x = xmin + (float)i * dx;
                float ymid = (ymax + ymin) / 2;
                mln[i] = new Vector2((x - xmin) * sx, ((float)this.ClientSize.Height - 1) / 2 - (myf(x) - ymid) * sy);
            }
        }

        //Расчет y = f(x,t)
        private float myf(float x)
        {
            double y = Math.Sin(x - t * 5) * Math.Cos((x - t) * 5);
            return (float)y;
        }

        //Статика
        private void m41_Click(object sender, EventArgs e)
        {
            t = 0;
            stat.Checked = true;
            dyn.Checked = false;
            cons.Checked = false;
        }

        //Динамика
        private void m42_Click(object sender, EventArgs e)
        {
            dyn.Checked = true;
            stat.Checked = false;
            cons.Checked = false;
        }

        //Пауза
        private void m43_Click(object sender, EventArgs e)
        {
            cons.Checked = true;
            stat.Checked = false;
            dyn.Checked = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "FPS = " + fps.ToString();
            toolStripStatusLabel2.Text = "f(x,t) = 30*cos(x-5*t)*sin(0.1*x)";
            toolStripStatusLabel3.Text = $"| x = {xmin} : {xmax}";
            toolStripStatusLabel4.Text = $"| y = {ymin} : {ymax}";
            toolStripStatusLabel5.Text = $"| t = {tmin} : {tmax}";
            fps = 0;
        }
    }
}
