using System;
using System.Media;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ApplicationAlarm
{
    [Serializable]
    public partial class Form1 : Form
    {


        SoundPlayer soundPlayer = null;
        ClassPerem classPerem = new ClassPerem();









        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer();

        }

        private void ChoiceSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "WAV|*.wav",
                Multiselect = false,
                ValidateNames = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                classPerem.fileName = openFileDialog.FileName;
                FileNameBox.Text = classPerem.fileName;

            }
        }

        private void ButtonAddAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count <= 10)
                {

                    classPerem.Hour = (int)numericUpDown1.Value;
                    classPerem.Minute = (int)numericUpDown2.Value;




                    Array.Resize(ref classPerem.massHours, classPerem.indexHour++);
                    Array.Resize(ref classPerem.massMinutes, classPerem.indexMinute++);


                    for (int i = 0; i < classPerem.massHours.Length; i++)
                    {
                        if (classPerem.massHours[i].Equals(0))
                        {
                            classPerem.massHours[i] = classPerem.hour;
                        }


                    }

                    for (int i = 0; i < classPerem.massMinutes.Length; i++)
                    {
                        if (classPerem.massMinutes[i].Equals(0))
                        {
                            classPerem.massMinutes[i] = classPerem.minute;
                        }

                    }

                    listBox1.Items.Add("Будильник сработает в: " + classPerem.hour + " : " + classPerem.minute + " ОТКЛЮЧЕН");
                }
                else
                {
                    MessageBox.Show("Будильников может быть не больше 10");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




        }

        private void ButtonOffAlarm_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    AlarmOff(0, timer2);
                    break;
                case 1:
                    AlarmOff(1, timer3);
                    break;
                case 2:
                    AlarmOff(2, timer4);
                    break;
                case 3:
                    AlarmOff(3, timer5);
                    break;
                case 4:
                    AlarmOff(4, timer6);
                    break;
                case 5:
                    AlarmOff(5, timer7);
                    break;
                case 6:
                    AlarmOff(6, timer8);
                    break;
                case 7:
                    AlarmOff(7, timer9);
                    break;
                case 8:
                    AlarmOff(8, timer10);
                    break;
                case 9:
                    AlarmOff(9, timer11);
                    break;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }


        public void TimerEnd(int index, Timer timer)
        {

            if (classPerem.btn == true)
            {
                //timer.Stop();
                classPerem.btn = false;


            }
            else if (DateTime.Now.Hour == classPerem.massHours[index] && DateTime.Now.Minute == classPerem.massMinutes[index])
            {
                timer.Stop();
                soundPlayer.SoundLocation = classPerem.fileName;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, "Будильник сработает в: " + classPerem.massHours[index] + " : " + classPerem.massMinutes[index] + " ОТКЛЮЧЕН");
                soundPlayer.Play();
            }



        }

        public void AlarmOn(int index, Timer timer)
        {
            try
            {
                timer.Start();
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, "Будильник сработает в: " + classPerem.massHours[index] + " : " + classPerem.massMinutes[index] + " ВКЛЮЧЕН");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AlarmOff(int index, Timer timer)
        {
            try
            {
                timer.Stop();
                timer.Dispose();
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, "Будильник сработает в: " + classPerem.massHours[index] + " : " + classPerem.massMinutes[index] + " ОТКЛЮЧЕН");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn==true)
            {
                classPerem.btn = false;
            }
            else
            TimerEnd(0, timer2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(1, timer3);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(2, timer4);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(3, timer5);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(4, timer6);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(5, timer7);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(6, timer8);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(7, timer9);
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(8, timer10);
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (classPerem.btn == true)
            {
                classPerem.btn = false;
            }
            TimerEnd(9, timer11);
        }

        private void OnAlarm_Click(object sender, EventArgs e)
        {

            if (classPerem.fileName == String.Empty)
            {
                MessageBox.Show("Выберите мелодию");

            }
            else
            {

                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        AlarmOn(0, timer2);
                        break;
                    case 1:
                        AlarmOn(1, timer3);
                        break;
                    case 2:
                        AlarmOn(2, timer4);
                        break;
                    case 3:
                        AlarmOn(3, timer5);
                        break;
                    case 4:
                        AlarmOn(4, timer6);
                        break;
                    case 5:
                        AlarmOn(5, timer7);
                        break;
                    case 6:
                        AlarmOn(6, timer8);
                        break;
                    case 7:
                        AlarmOn(7, timer9);
                        break;
                    case 8:
                        AlarmOn(8, timer10);
                        break;
                    case 9:
                        AlarmOn(9, timer11);
                        break;


                }
            }


        }

        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];

            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];

            }
            array = newArray;


        }


        

       
        private void DeleteAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                classPerem.btn = true;
                soundPlayer.Stop();
                int index = listBox1.SelectedIndex;
                int index1 = index;
                listBox1.Items.Remove(listBox1.SelectedItem);
                RemoveAt(ref classPerem.massHours, index1);
                RemoveAt(ref classPerem.massMinutes, index1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }






        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //classPerem.Save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //classPerem = ClassPerem.GetClassPerem();

            //for (int i = 0; i < classPerem.massHours.Length; i++)
            //{

            //    listBox1.Items.Add("Будильник сработает в: " + classPerem.massHours[i] + " : " + classPerem.massMinutes[i] + " ОТКЛЮЧЕН");

            //}

            //FileNameBox.Text = classPerem.fileName;
        }
    }
}

