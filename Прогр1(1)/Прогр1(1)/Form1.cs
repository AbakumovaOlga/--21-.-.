using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прогр1_1_
{
    public partial class FKitchen : Form
    {
        private Egg[] eggs;

        private Salt salt;

        private WaterTap waterTap;

        private Knife knife;

        private Pan pan;

        private Stove stove;

        private Butter butter;

        public FKitchen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            butter = new Butter();
            salt = new Salt();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (FOpen.Checked)
            {
                waterTap.Open = true;
            }
        }

        private void FClose_CheckedChanged(object sender, EventArgs e)
        {
            if (FClose.Checked)
            {
                waterTap.Open = false;
            }
        }

        private void FOff_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = false;
        }

        private void FOn_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = true;
        }

        private void FWash_Click(object sender, EventArgs e)
        {
          if (eggs == null)
            {
                MessageBox.Show("Яиц то нет, что мыть? Допустим, что руки уже чистые :)", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц то нет, что мыть? Допустим, что руки уже чистые :)", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!waterTap.Open)
            {
                MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            pan.Init(eggs.Length);

            for (int i = 0; i < eggs.Length; ++i)
            {
                eggs[i].Dirty = false;
            }
            FCountEggs.Enabled = false;
            FClose.Checked = true;
            MessageBox.Show("Яйца помыли, можно разбивать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FCountEggs_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FHit_Click(object sender, EventArgs e)
        {

            if (eggs == null)
            {
                MessageBox.Show("Яиц то нет, что разбивать собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц то нет, что разбивать собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Dirty)
                {
                    MessageBox.Show("Они же грязные! Фу!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!butter.Count)
            {
                MessageBox.Show("Без масла пригорит", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                butter = new Butter();
                pan.AddButter(butter);
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                knife.Hit(eggs[i]);
                pan.AddEgg(eggs[i]);
            }

            MessageBox.Show("Яйца разбили на сковороду. Можно готовить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FButter_CheckedChanged(object sender, EventArgs e)
        {
            if (FButter.Checked)
            {
                butter.Count = true;
            }
        }

        private void FCook_Click(object sender, EventArgs e)
        {
       
            if (!stove.State)
            {
                MessageBox.Show("Ну это мы так долго будем готовить! Плиту включите.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            if (!salt.Count)
            {
                MessageBox.Show("Без соли не вкусно", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                salt = new Salt();
                pan.AddSalt(salt);
            }
            
            stove.Pan = pan;
            
            if (!pan.Check())
            {
                MessageBox.Show("Чего-то не хватает", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else stove.Cooking();

            if (stove.Pan.IsReady())
            {
                FOff.Checked = true;
                MessageBox.Show("Яйца пожарились!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FSalt_CheckedChanged(object sender, EventArgs e)
        {
            if (FSalt.Checked)
            {
                salt.Count = true;
            }
        }

        private void FGet_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
    

            if (stove.Pan.IsReady())
            {
                eggs = pan.GetEggs();
                MessageBox.Show("Мы сделали это! Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то не так", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void FOK_Click(object sender, EventArgs e)
        {
            eggs = new Egg[Convert.ToInt32(FCountEggs.Value)];

            for (int i = 0; i < eggs.Length; ++i)
            {
                eggs[i] = new Egg();
            }
            FCountEggs.Enabled = false;
        }
    }

}
