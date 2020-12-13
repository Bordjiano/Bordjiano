using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bordjiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Struck

        public struct Characteristic // Структура
        {
            public int id;
            public string name;
            public string type;
            public double calibr;
            public int amount;

            //Конструктор
            public Characteristic(string name, string type, double calibr, int amount)
            {
                this.id = 0;
                this.name = name;
                this.type = type;
                this.calibr = calibr;
                this.amount = amount;
            }

            public static void Update() // Метод виводу даних
            {
                DataTable table = new DataTable();
                table.Clear();
                // Таблиці створюємо колонки
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Type", typeof(string));
                table.Columns.Add("Calibr", typeof(double));
                table.Columns.Add("Amount", typeof(int));

                for (int i = 0; i < characteristics.Length; i++)
                {
                    characteristics[i].id = i + 1;
                    table.Rows.Add(characteristics[i].id, characteristics[i].name, characteristics[i].type, characteristics[i].calibr, characteristics[i].amount);
                }
                dataGridView1.DataSource = table;
            }

            public static void Add() // Метод додавання даних
            {
                Form2 f2 = new Form2();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    string name = f2.textBox1.Text;
                    string type = f2.textBox2.Text;
                    double calibr = Convert.ToDouble(f2.numericUpDown1.Value);
                    int amount = Convert.ToInt32(f2.numericUpDown2.Value);
                    if (name == "" || type == "")
                    {
                        MessageBox.Show("Fields cannot be empty");
                        Add();
                    }
                    else
                    {
                        Array.Resize(ref characteristics, characteristics.Length + 1);
                        characteristics[characteristics.Length - 1] = new Characteristic(name, type, calibr, amount);
                        Update();
                    }
                }
            }

            public static void Edit() // Метод редагування даних
            {
                Form2 f2 = new Form2();
                Form3 f3 = new Form3();
                if (f3.ShowDialog() == DialogResult.OK)
                {
                    int id = Convert.ToInt32(f3.numericUpDown1.Value) - 1;
                    if (id > characteristics.Length)
                    {
                        MessageBox.Show("This ID was not found");
                        Edit();
                    }
                    else
                    {
                        f2.textBox1.Text = characteristics[id].name;
                        f2.textBox2.Text = characteristics[id].type;
                        f2.numericUpDown1.Value = Convert.ToDecimal(characteristics[id].calibr);
                        f2.numericUpDown2.Value = Convert.ToDecimal(characteristics[id].amount);

                        if (f2.ShowDialog() == DialogResult.OK)
                        {
                            if (f2.textBox1.Text == "" || f2.textBox2.Text == "")
                            {
                                MessageBox.Show("Fields cannot be empty");
                                Edit();
                            }
                            else
                            {
                                characteristics[id].name = f2.textBox1.Text;
                                characteristics[id].type = f2.textBox2.Text;
                                characteristics[id].calibr = Convert.ToDouble(f2.numericUpDown1.Value);
                                characteristics[id].amount = Convert.ToInt32(f2.numericUpDown2.Value);
                                Update();
                            }
                        }
                    }
                }
            }

            public static void Remove() // Метод видаленн даних
            {
                Form3 f3 = new Form3();
                if (f3.ShowDialog() == DialogResult.OK)
                {
                    int id = Convert.ToInt32(f3.numericUpDown1.Value) - 1;
                    if (id > characteristics.Length)
                    {
                        MessageBox.Show("This ID was not found");
                        Remove();
                    }
                    else
                    {
                        for (int i = id; i < characteristics.Length - 1; i++)
                        {
                            characteristics[i] = characteristics[i + 1];
                        }
                        Array.Resize(ref characteristics, characteristics.Length - 1);
                        Update();
                    }
                }
            }

            public static void ListType() // Список типів озброєння та їх кількості по алфавіту
            {
                SortType(characteristics);
                DataTable table = new DataTable();
                table.Clear();
                table.Columns.Add("Tуpe", typeof(string));
                table.Columns.Add("Аmount", typeof(int));
                int amount = 1;
                for (int i = 0; i < characteristics.Length; i++)
                {
                    if (i + 1 >= characteristics.Length)
                    {
                        table.Rows.Add(characteristics[i].type, amount);
                    }
                    else if (characteristics[i].type == characteristics[i + 1].type)
                    {
                        amount++;
                        continue;
                    }
                    else
                    {
                        table.Rows.Add(characteristics[i].type, amount);
                        amount = 1;
                    }
                }
                dataGridView1.DataSource = table;
                SortID(characteristics);
            }

            public static void AmountCalibr() // Кількість озброєння заданого калібру
            {
                Form4 f4 = new Form4();
                SortCalibr(characteristics);
                string calibr = "";
                for (int i = 0; i < characteristics.Length; i++)
                {
                    if (i + 1 >= characteristics.Length)
                    {
                        f4.comboBox1.Items.Add(characteristics[i].calibr);
                    }
                    else if (characteristics[i].calibr == characteristics[i + 1].calibr)
                    {
                        continue;
                    }
                    else
                    {
                        f4.comboBox1.Items.Add(characteristics[i].calibr);
                    }
                }
                SortID(characteristics);
                if (f4.ShowDialog() == DialogResult.OK)
                {
                    if (f4.comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Field cannot be empty");
                        AmountCalibr();
                    }
                    else
                    {
                        calibr = f4.comboBox1.SelectedItem.ToString();

                        int amount = 0;
                        double calibr_ = Convert.ToDouble(calibr);
                        for (int i = 0; i < characteristics.Length; i++)
                        {
                            if (calibr_ == characteristics[i].calibr)
                                amount++;
                        }
                        MessageBox.Show("Amount: " + amount);
                        Update();
                    }
                }
            }

            public static void ListMaxCalibr() // Список озброєння макс калібру
            {
                SortCalibr(characteristics);
                DataTable table = new DataTable();
                table.Clear();
                table.Columns.Add("ІD", typeof(int));
                table.Columns.Add("Nаme", typeof(string));
                table.Columns.Add("Typе", typeof(string));
                table.Columns.Add("Calіbr", typeof(double));
                table.Columns.Add("Amоunt", typeof(int));
                double max = characteristics[characteristics.Length - 1].calibr;
                for (int i = 0; i < characteristics.Length; i++)
                {
                    if (characteristics[i].calibr == max)
                    {
                        table.Rows.Add(characteristics[i].id, characteristics[i].name, characteristics[i].type, characteristics[i].calibr, characteristics[i].amount);
                    }
                }
                dataGridView1.DataSource = table;
                SortID(characteristics);
            }

            public static void ListCalibr() // Список середнього калібру по типах озброєння
            {
                Form4 f4 = new Form4();
                DataTable table = new DataTable();
                table.Clear();
                table.Columns.Add(" ID", typeof(int));
                table.Columns.Add(" Nаme", typeof(string));
                table.Columns.Add(" Typе", typeof(string));
                table.Columns.Add(" Calіbr", typeof(double));
                table.Columns.Add(" Amоunt", typeof(int));
                f4.label1.Text = "Choose type";
                f4.Text = "Choose type";
                SortType(characteristics);
                for (int i = 0; i < characteristics.Length; i++)
                {
                    if (i + 1 >= characteristics.Length)
                    {
                        f4.comboBox1.Items.Add(characteristics[i].type);
                    }
                    else if (characteristics[i].type == characteristics[i + 1].type)
                    {
                        continue;
                    }
                    else
                    {
                        f4.comboBox1.Items.Add(characteristics[i].type);
                    }
                }
                if (f4.ShowDialog() == DialogResult.OK)
                {
                    string type = f4.comboBox1.SelectedItem.ToString();
                    if (type == "")
                    {
                        MessageBox.Show("Field cannot be empty");
                        ListCalibr();
                    }
                    else
                    {
                        SortAmount(characteristics);
                        for (int i = characteristics.Length - 1; i >= 0; i--)
                        {
                            if (type == characteristics[i].type)
                            {
                                table.Rows.Add(characteristics[i].id, characteristics[i].name, characteristics[i].type, characteristics[i].calibr, characteristics[i].amount);
                                SortID(characteristics);
                                dataGridView1.DataSource = table;
                                break;
                            }
                        }
                    }
                }
            }

            //
            public static Characteristic[] SortID(Characteristic[] str)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i].id.CompareTo(str[j].id) == 1)
                        {
                            var temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
                return str;
            }

            public static Characteristic[] SortType(Characteristic[] str)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i].type.CompareTo(str[j].type) == 1)
                        {
                            var temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
                return str;
            }

            public static Characteristic[] SortCalibr(Characteristic[] str)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i].calibr.CompareTo(str[j].calibr) == 1)
                        {
                            var temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
                return str;
            }

            public static Characteristic[] SortAmount(Characteristic[] str)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i].amount.CompareTo(str[j].amount) == 1)
                        {
                            var temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
                return str;
            }
        }

        #endregion

        //
        static Characteristic[] characteristics = new Characteristic[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            // Змінюємо властивості датагрід
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            // Записуємо в масив структури початкові дані
            characteristics[0] = new Characteristic("АК-74", "Автоматичний карабін", 5.45, 7);
            characteristics[1] = new Characteristic("СВД", "Снайперська гвинтівка", 7.62, 3);
            characteristics[2] = new Characteristic("Форт-17", "Самозарядний пістолет", 9.00, 6);
            characteristics[3] = new Characteristic("АКМ", "Автомат", 7.62, 12);
            characteristics[4] = new Characteristic("Вулкан", "Автомат", 7.62, 9);
            characteristics[5] = new Characteristic("Berrett M107A1", "Великокаліберна снайперська гвинтівка", 12.7, 2);
            characteristics[6] = new Characteristic("РПК-74", "Ручний кулемет", 7.62, 14);
            characteristics[7] = new Characteristic("ДЩК", "Великокаліберний кулемет", 12.7, 11);
            characteristics[8] = new Characteristic("Форт-301", "Автомат", 5.56, 3);
            characteristics[9] = new Characteristic("ПМ", "Самозарядний пістолет", 9.00, 17);

            Characteristic.Update();
        }

        #region Menu

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.Add();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.Edit();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.Remove();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.Update();
        }

        private void списокТипівОзброєнняТаЇхКількостіПоАлфавітуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.ListType();
        }

        private void кількістьОзброєнняЗаданогоКалібруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.AmountCalibr();
        }

        private void списокОзброєнняМаксКалібруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.ListMaxCalibr();
        }

        private void списокСередньогоКалібруПоТипахОзброєнняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Characteristic.ListCalibr();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
        #endregion

    }
}
