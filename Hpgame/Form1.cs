using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Hpgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Random enemy = new Random();
            Pers per = new Pers();
            Model mod = new Model();
            InitializeComponent();
            System.Media.SoundPlayer attack1 = new System.Media.SoundPlayer("atk1.wav");
            System.Media.SoundPlayer attack2 = new System.Media.SoundPlayer("atk2.wav");
            Timer game = new Timer();
            game.Interval = 16;
            pictureBox1.Height = 46;
            pictureBox1.Width = 45;
            pictureBox2.Location = new Point(53, 0);
            pictureBox2.BackColor = Color.Crimson;
            pictureBox3.Image = Image.FromFile("portrait.gif");
            pictureBox3.Size = new Size(52,58);
            pictureBox3.Location = new Point(0, 0);
            PictureBox doboz = new PictureBox();
            doboz.Image = Image.FromFile("doboz.gif");
            doboz.Size = new Size(32, 32);
            doboz.SizeMode = PictureBoxSizeMode.StretchImage;
            doboz.Location = new Point(enemy.Next(0,1200),enemy.Next(0,700));
            this.Controls.Add(doboz);
            
            per.Import();
            
            button1.Text = "Start Game";
            button2.Text = "Previous Score";

            button1.Click += (s, e) =>
            {
                
                game.Start();
                this.Controls.Remove(button1);
                this.Controls.Remove(button2);
            };
            button2.Click += (s, e) =>
            {
                MessageBox.Show("Ez volt az Előző Eredményed: " + per.prerecord);
            };
            List<PictureBox> gnome = new List<PictureBox>();
            List<PictureBox> flipendo = new List<PictureBox>();
            List<PictureBox> incendio = new List<PictureBox>();
            List<PictureBox> gecinoveny = new List<PictureBox>();
            List<PictureBox> spora = new List<PictureBox>();

            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Up && mod.irany != 1)
                {
                    mod.irany = 1;
                    pictureBox1.Image = Image.FromFile("Nmove.gif");

                }
                if (e.KeyCode == Keys.Right && mod.irany != 2)
                {
                    mod.irany = 2;
                    pictureBox1.Image = Image.FromFile("Emove.gif");
                }
                if (e.KeyCode == Keys.Down && mod.irany != 3)
                {
                    mod.irany = 3;
                    pictureBox1.Image = Image.FromFile("Smove.gif");
                }
                if (e.KeyCode == Keys.Left && mod.irany != 4)
                {
                    mod.irany = 4;
                    pictureBox1.Image = Image.FromFile("Wmove.gif");
                }
                if (e.KeyCode == Keys.A && mod.attack1 == 0)
                {
                    if(mod.irany == 1)
                    {
                        
                        pictureBox1.Image = Image.FromFile("Nspell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        attack1.Play();
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 2)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Espell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 3)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Sspell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 4)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Wspell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 5)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Nspell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 6)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Espell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 7)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Sspell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }
                    if (mod.irany == 8)
                    {
                        attack1.Play();
                        pictureBox1.Image = Image.FromFile("Wspell.gif");
                        PictureBox atk1 = new PictureBox();
                        atk1.Image = Image.FromFile("atk1.gif");
                        atk1.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk1.Size = new Size(16, 16);
                        atk1.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk1.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk1.Height / 2);
                        mod.atk1.Add(mod.irany);
                        flipendo.Add(atk1);
                        this.Controls.Add(flipendo[flipendo.Count() - 1]);
                        mod.attack1 = 10;
                    }

                }
                if (e.KeyCode == Keys.S && mod.attack2 == 0)
                {
                    if(mod.irany == 1)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Nspell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 2)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Espell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 3)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Sspell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 4)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Wspell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 5)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Nspell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 6)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Espell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 7)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Sspell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    if (mod.irany == 8)
                    {
                        attack2.Play();
                        pictureBox1.Image = Image.FromFile("Wspell.gif");
                        PictureBox atk2 = new PictureBox();
                        atk2.Image = Image.FromFile("atk2.gif");
                        atk2.SizeMode = PictureBoxSizeMode.StretchImage;
                        atk2.Size = new Size(16, 16);
                        atk2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - atk2.Width / 2, pictureBox1.Location.Y + pictureBox1.Height / 2 - atk2.Height / 2);
                        mod.atk2.Add(mod.irany);
                        incendio.Add(atk2);
                        this.Controls.Add(incendio[incendio.Count() - 1]);
                        mod.attack2 = 20;
                    }
                    
                }
            };
            KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Up && mod.irany == 1)
                {
                    mod.irany = 5;
                    pictureBox1.Image = Image.FromFile("Nstand.gif");
                }
                if (e.KeyCode == Keys.Right && mod.irany == 2)
                {
                    mod.irany = 6;
                    pictureBox1.Image = Image.FromFile("Estand.gif");
                }
                if (e.KeyCode == Keys.Down && mod.irany == 3)
                {
                    mod.irany = 7;
                    pictureBox1.Image = Image.FromFile("Sstand.gif");
                }
                if (e.KeyCode == Keys.Left && mod.irany == 4)
                {
                    mod.irany = 8;
                    pictureBox1.Image = Image.FromFile("Wstand.gif");

                }
            };
            int time = 20;
            int dobanim = 0;
            int sporulacio = 0;
            game.Tick += (s, e) =>
            {
                for (int i = 0; i < flipendo.Count(); i++)
                {
                    if (mod.atk1[i] == 1 || mod.atk1[i] == 5)
                    {
                        flipendo[i].Location = new Point(flipendo[i].Location.X, flipendo[i].Location.Y - 9);
                    }
                    if (mod.atk1[i] == 2 || mod.atk1[i] == 6)
                    {
                        flipendo[i].Location = new Point(flipendo[i].Location.X + 9, flipendo[i].Location.Y);
                    }
                    if (mod.atk1[i] == 3 || mod.atk1[i] == 7)
                    {
                        flipendo[i].Location = new Point(flipendo[i].Location.X, flipendo[i].Location.Y + 9);
                    }
                    if (mod.atk1[i] == 4 || mod.atk1[i] == 8)
                    {
                        flipendo[i].Location = new Point(flipendo[i].Location.X - 9, flipendo[i].Location.Y);
                    }
                }
                for (int i = 0; i < incendio.Count(); i++)
                {
                    if (mod.atk2[i] == 1 || mod.atk2[i] == 5)
                    {
                        incendio[i].Location = new Point(incendio[i].Location.X, incendio[i].Location.Y - 9);
                    }
                    if (mod.atk2[i] == 2 || mod.atk2[i] == 6)
                    {
                        incendio[i].Location = new Point(incendio[i].Location.X + 9, incendio[i].Location.Y);
                    }
                    if (mod.atk2[i] == 3 || mod.atk2[i] == 7)
                    {
                        incendio[i].Location = new Point(incendio[i].Location.X, incendio[i].Location.Y + 9);
                    }
                    if (mod.atk2[i] == 4 || mod.atk2[i] == 8)
                    {
                        incendio[i].Location = new Point(incendio[i].Location.X - 9, incendio[i].Location.Y);
                    }
                }
                for (int i = 0; i < flipendo.Count(); i++)
                {
                    if (flipendo[i].Location.X < -20 || flipendo[i].Location.X > 1350 || flipendo[i].Location.Y < -20 || flipendo[i].Location.Y > 850)
                    {
                        this.Controls.Remove(flipendo[i]);
                        flipendo.Remove(flipendo[i]);
                        mod.atk1.Remove(mod.atk1[i]);
                    }
                }
                for (int i = 0; i < incendio.Count(); i++)
                {
                    if (incendio[i].Location.X < -20 || incendio[i].Location.X > 1350 || incendio[i].Location.Y < -20 || incendio[i].Location.Y > 850)
                    {
                        this.Controls.Remove(incendio[i]);
                        incendio.Remove(incendio[i]);
                        mod.atk2.Remove(mod.atk2[i]);
                    }
                }
                for (int i = 0; i < flipendo.Count(); i++)
                {
                    if (flipendo[i].Bounds.IntersectsWith(doboz.Bounds)&& dobanim == 0)
                    {
                        doboz.Image = Image.FromFile("dobozhit.gif");
                        dobanim = 54;
                        mod.hp += 30;
                        mod.score -= 5;
                        this.Controls.Remove(flipendo[i]);
                        flipendo.Remove(flipendo[i]);
                        mod.atk1.Remove(mod.atk1[i]);
                    }
                }
                for (int i = 0; i < incendio.Count(); i++)
                {
                    if (incendio[i].Bounds.IntersectsWith(doboz.Bounds)&& dobanim ==0)
                    {
                        doboz.Image = Image.FromFile("dobozhit.gif");
                        dobanim = 54;
                        mod.hp += 30;
                        this.Controls.Remove(incendio[i]);
                        incendio.Remove(incendio[i]);
                        mod.atk2.Remove(mod.atk2[i]);
                    }
                }

                if(dobanim == 1)
                {
                    doboz.Location = new Point(enemy.Next(0, 1200), enemy.Next(0, 700));
                    doboz.Image = Image.FromFile("doboz.gif");

                }
                if(dobanim > 0)
                {
                    dobanim--;
                }

                for (int i = 0; i < flipendo.Count(); i++)
                {
                    bool igen = false;
                    for (int j = 0; j < gnome.Count(); j++)
                    {
                        if (flipendo[i].Bounds.IntersectsWith(gnome[j].Bounds))
                        {

                            if (mod.gnomehit[j] == false)
                            {
                                igen = true;
                                mod.gnomehit[j] = true;
                            }
                            else
                            {
                                mod.gnomno++;
                                igen = true;
                                this.Controls.Remove(gnome[j]);
                                gnome.Remove(gnome[j]);
                                mod.csekkbox.Remove(mod.csekkbox[j]);
                                mod.gnomehit.Remove(mod.gnomehit[j]);
                                mod.score++;

                            }

                        }
                    }
                    if (igen == true)
                    {
                        this.Controls.Remove(flipendo[i]);
                        flipendo.Remove(flipendo[i]);
                        mod.atk1.Remove(mod.atk1[i]);

                    }
                }

                if (mod.attack1 > 0)
                {
                    mod.attack1--;
                }
                if (mod.attack2 > 0)
                {
                    mod.attack2--;
                }
                if (mod.irany == 1)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 6);

                }
                else if (mod.irany == 2)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 6, pictureBox1.Location.Y);
                }
                else if (mod.irany == 3)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 6);
                }
                else if (mod.irany == 4)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 6, pictureBox1.Location.Y);
                }
                if (gnome.Count() < mod.szamgnom) //generaltatom a gnomokat
                {
                    PictureBox gnomi = new PictureBox();
                    gnomi.Location = new Point(enemy.Next(0, 1250), enemy.Next(0, 750));
                    gnomi.Size = new Size(32, 32);
                    gnomi.Image = Image.FromFile("Sgnome.gif");
                    mod.gnomehit.Add(false);
                    bool enemi;
                    if (enemy.Next(0, 2) == 0) { enemi = true; }
                    else { enemi = false; }
                    mod.csekkbox.Add(enemi);

                    gnomi.SizeMode = PictureBoxSizeMode.StretchImage;
                    gnome.Add(gnomi);
                    this.Controls.Add(gnome[gnome.Count() - 1]);
                }
                if (gecinoveny.Count() < mod.szamnov) //generaltatom a horklumpokat
                {
                    PictureBox gnomi = new PictureBox();
                    gnomi.Location = new Point(enemy.Next(0, 1250), enemy.Next(0, 750));
                    gnomi.Size = new Size(32, 32);
                    gnomi.Image = Image.FromFile("Hork.gif");
                    gnomi.SizeMode = PictureBoxSizeMode.StretchImage;
                    gecinoveny.Add(gnomi);
                    this.Controls.Add(gecinoveny[gecinoveny.Count() - 1]);
                }

                if (sporulacio == 0)
                {
                    sporulacio = 120;
                    for (int i = 0; i < gecinoveny.Count(); i++)
                    {
                        PictureBox spor = new PictureBox();
                        spor.Image = Image.FromFile("HorkA.gif");
                        spor.Size = new Size(32, 32);
                        spor.SizeMode = PictureBoxSizeMode.StretchImage;
                        spor.Location = new Point(gecinoveny[i].Location.X + gecinoveny[i].Width / 2 - spor.Width / 2, gecinoveny[i].Location.Y + gecinoveny[i].Height / 2 - spor.Height / 2);
                        int szam1 = -Convert.ToInt32((gecinoveny[i].Location.X - pictureBox1.Location.X) / 60);
                        int szam2 = -Convert.ToInt32((gecinoveny[i].Location.Y - pictureBox1.Location.Y) / 60);
                        int[] sporak = { szam1, szam2 };
                        mod.loirany.Add(sporak);
                        spora.Add(spor);
                        this.Controls.Add(spora[spora.Count() - 1]);
                    }
                }

                for (int i = 0; i < spora.Count(); i++)
                {
                    spora[i].Location = new Point(spora[i].Location.X + mod.loirany[i][0], spora[i].Location.Y + mod.loirany[i][1]);
                }
                for (int i = 0; i < spora.Count(); i++)
                {
                    if (spora[i].Location.X < -20 || spora[i].Location.X > 1340 || spora[i].Location.Y < -20 || spora[i].Location.Y > 820)
                    {
                        this.Controls.Remove(spora[i]);
                        spora.Remove(spora[i]);
                        mod.loirany.Remove(mod.loirany[i]);

                    }
                }
                for (int j = 0; j < incendio.Count(); j++)
                {
                    for (int i = 0; i < spora.Count(); i++)
                    {
                        if (spora[i].Bounds.IntersectsWith(incendio[j].Bounds))
                        {
                            this.Controls.Remove(spora[i]);
                            spora.Remove(spora[i]);
                            mod.loirany.Remove(mod.loirany[i]);
                        }
                    }
                }
                for(int i = 0; i < spora.Count(); i++)
                {
                    if (spora[i].Bounds.IntersectsWith(pictureBox1.Bounds)){
                        mod.hp--;
                        this.Controls.Remove(spora[i]);
                        spora.Remove(spora[i]);
                        mod.loirany.Remove(mod.loirany[i]);
                    }
                }
                for(int i = 0; i < incendio.Count(); i++)
                {
                    bool igenn = false;
                    for(int j = 0; j < gecinoveny.Count(); j++)
                    {
                        
                        if (incendio[i].Bounds.IntersectsWith(gecinoveny[j].Bounds))
                        {
                            mod.noveno++;
                            this.Controls.Remove(gecinoveny[j]);
                            gecinoveny.Remove(gecinoveny[j]);
                            mod.score++;
                            
                            igenn = true;
                        }

                    }
                    if(igenn == true)
                    {
                        this.Controls.Remove(incendio[i]);
                        incendio.Remove(incendio[i]);
                        mod.atk2.Remove(mod.atk2[i]);
                    }
                }

                for (int i = 0; i < gnome.Count(); i++)
                {
                    if (mod.csekkbox[i] == true)
                    {
                        if (gnome[i].Location.X < pictureBox1.Location.X)
                        {
                            gnome[i].Location = new Point(gnome[i].Location.X + 3, gnome[i].Location.Y);
                            if (time == 20)
                            {
                                gnome[i].Image = Image.FromFile("Egnome.gif");
                            }

                        }
                        if (gnome[i].Location.X > pictureBox1.Location.X)
                        {
                            gnome[i].Location = new Point(gnome[i].Location.X - 3, gnome[i].Location.Y);
                            if (time == 20)
                            {
                                gnome[i].Image = Image.FromFile("Wgnome.gif");
                            }
                        }
                    }
                    else
                    {
                        if (gnome[i].Location.Y < pictureBox1.Location.Y)
                        {
                            gnome[i].Location = new Point(gnome[i].Location.X, gnome[i].Location.Y + 3);
                            if (time == 20)
                            {
                                gnome[i].Image = Image.FromFile("Sgnome.gif");
                            }
                        }
                        if (gnome[i].Location.Y > pictureBox1.Location.Y)
                        {
                            gnome[i].Location = new Point(gnome[i].Location.X, gnome[i].Location.Y - 3);
                            if (time == 20)
                            {
                                gnome[i].Image = Image.FromFile("Ngnome.gif");
                            }
                        }
                    }
                }
                label2.Text = "A score : " + mod.score;
                for (int i = 0; i < gnome.Count(); i++)
                {
                    if (gnome[i].Bounds.IntersectsWith(pictureBox1.Bounds) && mod.hurtme == 0)
                    {
                        mod.hurtme = 20;
                        mod.hp -= 3;
                    }
                }
                if (mod.hurtme > 0)
                {
                    mod.hurtme--;
                }
                pictureBox2.Size = new Size(mod.hp * 2, pictureBox2.Height);
                label1.Location = new Point(pictureBox2.Width + 52, 0);
                label1.Text = Convert.ToString(mod.hp);
                if (mod.hp < 1)
                {
                    game.Stop();
                    MessageBox.Show("Meghaltál a Harry Potter és a Lövedékek Pokla játékban :(" );
                    per.Export(mod.score);
                    Application.Restart();
                }

                if(mod.noveno > 5)
                {
                    mod.szamnov++;
                    mod.noveno = 0;
                }
                if (mod.gnomno > 8)
                {
                    mod.szamgnom++;
                    mod.gnomno = 0;
                }

                sporulacio--;

                time--;
                if (time == 0)
                {
                    time = 20;
                    for (int i = 0; i < mod.csekkbox.Count(); i++)
                    {
                        bool enemi;
                        if (enemy.Next(0, 2) == 0) { enemi = true; }
                        else { enemi = false; }
                        mod.csekkbox[i] = enemi;
                    }
                }

            };

        }

    };
}
