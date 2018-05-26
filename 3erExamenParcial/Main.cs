using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3erExamenParcial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Actors frm = new Actors();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoleTypes frm = new RoleTypes();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilmGenres frm = new FilmGenres();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilmCertificate frm = new FilmCertificate();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Producers frm = new Producers();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FilmActorRole rs = new FilmActorRole();
            rs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FilmTitlesProducers frm = new FilmTitlesProducers();
            frm.Show();
        }
    }
}
