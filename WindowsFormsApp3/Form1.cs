using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Image Image;
        Rectangle rectangle;
        Image Image1;
        Rectangle rectangle2;
        Timer timer = new Timer();
        Graphics grah;
        public int x = 0, y = 0;
        public int HupX = 200, HdownY = 550;
       // public int Panels1 = 0, Panels11 = 0, Panels12 = 0, Panels13 = 0, Panels2 = 900, i = 0, f = 0,j=0,k=0,tt=0,o=0;
        public int panx1=150, panx2=200, panx3=250, panx4=150, panx5=300, panx6=350, panx7=400, panx8=450, panx9=500, panx10=550, panx11=600, panx12=650, panx13, panx14, panx15, panx16, panx17, panx18, panx19, panx20;//панели по игрику
        public int pany1=700, pany2= 800, pany3=-180, pany4=500, pany5=300, pany6=600, pany7=450, pany8=500, pany9=-190, pany10=-600, pany11=-650, pany12=-700, pany13, pany14, pany15, pany16, pany17, pany18, pany19, pany20;//панели по иксу
        public int tron = 50;
        public int o1 = 0,o2=0, o3 = 0, o4 = 0, o5 = 0,o6=0, o7 = 0, o8 = 0, o9 = 0, o10 = 0, o11 = 0, o12 = 0;
        public int Hx1 = 0, Hy1 = 0, Tik = 0, ooo = 0, kit = 0, f = 0, k = 0, o = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public override bool AutoScroll { get; set; }

        public Form1()
        {
            InitializeComponent();
            Image = WindowsFormsApp3.Properties.Resources._2;
            rectangle = new Rectangle(20, 20, 70, 70);
            Image1 = WindowsFormsApp3.Properties.Resources._3;
            rectangle2 = new Rectangle(20, 20, 100, 100);
            this.KeyUp += new KeyEventHandler(Ups);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
          

        }


        //
        private void Ups(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            
            switch (key)
            {
                case Keys.A:
                    {
                       
                        HupX -= tron;
                        if (x == 0)
                        {
                            HeroesPichur.RotateFlip(RotateFlipType.Rotate180FlipY);
                            x = 1;
                            y = 0;
                        }
                        Tik = HupX;

                        break;
                    }

                case Keys.D:
                    {
                     
                        HupX += tron;
                        if (y == 0)
                        {
                            HeroesPichur.RotateFlip(RotateFlipType.Rotate180FlipY);
                            y = 1;
                            x = 0;
                        }
                        Tik = HupX ;
                        break;
                    }
                case Keys.Z:
                    {
                        timer.Stop();
                        break;
                    }

                case Keys.X:
                    {
                        timer.Start();

                        break;
                    }

                default:
                    break;

                    // e.IsInputKey = true;
                    //  break;
            }

        //    HupX -= tron;


        }
        int l=0;
        private void Paint_on(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            l = (r.Next(1, 5));

            timer.Tick += paintSame;
            timer.Interval = 1;
            timer.Start();
        }
        private void paintSame(object sender, EventArgs e)
        {
            AutoScroll = true;
            grah = this.CreateGraphics();
            grah.Clear(this.BackColor);

            /*    if(i==0)//верх герой
                {
                    f+=2;

                    grah.DrawImage(HeroesPichur, new Point(HupX, HdownY -f*2));
                    if (f==50)
                    {
                        i = 1;
                        j = HdownY - f*2;
                        f = 0;
                        u = f;

                    }
                }
                if (i == 1)//низ герой
                {
                    f+=2;
                    grah.DrawImage(HeroesPichur, new Point(HupX,j +f*2));
                    if (f == 50)
                    {
                        i = 0;
                        HdownY = j + f*2;
                        f = 0;

                    }
                }*/
                
           // MessageBox.Show("msfd");
            Hx1 = Tik;
            Hy1 = HdownY+100 ;
            grah.DrawImage(HeroesPichur, new Point(HupX, HdownY));
          
            if ((Hy1 == o1 && ((Hx1==panx1+50)||(Hx1 == panx1-50)||(Hx1 == panx1))) || (Hy1 == o2 && Hx1 == panx2)||(Hy1 == o3 && Hx1 == panx3) || (Hy1 == o4 && Hx1 == panx4)|| (Hy1 == o5 && Hx1 == panx5) || (Hy1 == o6 && Hx1 == panx6)|| (Hy1 == o7 && Hx1 == panx7) || (Hy1 == o8 && Hx1 == panx8)|| (Hy1 == o9 && Hx1 == panx9) || (Hy1 == o10 && Hx1 == panx10) || (Hy1 == o11 && Hx1 == panx11) || (Hy1 == o12 && Hx1 == panx12))
            {
                ooo = 1;
            }
            if (ooo == 1)
            {
                if (k != 100)
                {
                    
                    if (o == 1)
                    {
                        f = 0;
                        o = 0;
                    }
                    k++;
                    f++;
                    grah.DrawImage(DujPanel1, new Point(panx1, o1 + f+k));
                    grah.DrawImage(DujPanel2, new Point(panx2, o2 + f+k));
                    grah.DrawImage(DujPanel3, new Point(panx3, o3 + f+k));
                     grah.DrawImage(DujPanel4, new Point(panx4, o4 + f+k));
                      grah.DrawImage(DujPanel5, new Point(panx5, o5 + f + k));
                      grah.DrawImage(DujPanel6, new Point(panx6, o6 + f + k));
                      grah.DrawImage(DujPanel7, new Point(panx7, o7 + f + k));
                      grah.DrawImage(DujPanel8, new Point(panx8, o8 + f + k));
                      grah.DrawImage(DujPanel9, new Point(panx9, o9 + f + k));
                      grah.DrawImage(DujPanel10, new Point(panx10, o10 + f + k));
                      grah.DrawImage(DujPanel11, new Point(panx11, o11 + f + k));
                      grah.DrawImage(DujPanel12, new Point(panx12, o12 + f + k));
                    Random random = new Random();

                    if (o1 >= 800){
                        panx1 = random.Next(50,300);
                        o1 = random.Next(50,120);
                    }
                  //  else if (panx2 > 900) { } else if (panx3 > 900) { } else if (panx4 > 900) { } else if (panx5 > 900) { } else if (panx6 > 900) { } else if (panx7 > 900) { } else if (panx8 > 900) { } else if (panx9 > 900) { } else if (panx10 > 900) { } else if (panx11 > 900) { } else if (panx12 > 900) { } 
                }
                if(k==100)
                { ooo = 0;
                   
                  /*  o1 = f + o1+k;
                    o2 = f + o2+k;
                    o3 = f + o3+k;
                    o4 = f + o4+k;*/
                    pany1 = f + o1 + k;
                    pany2 = f + o2 + k;
                    pany3 = f + o3 + k;
                    pany4 = f + o4 + k;
                    pany5 = f + o5 + k;
                    pany6 = f + o6 + k;
                    pany7 = f + o7 + k;
                    pany8 = f + o8 + k;
                    pany9 = f + o9 + k;
                    pany10 = f + o10 + k;
                    pany11 = f + o11 + k;
                    pany12 = f + o12 + k;
                    k = 0;
                    f = 0;
                }
            }
            if(ooo==0)
            {
                if(o==0)
                { f = 0;
                    o = 1;
                }
                f++;
                grah.DrawImage(DujPanel1, new Point(panx1, pany1 - f));
                grah.DrawImage(DujPanel2, new Point(panx2, pany2 - f));
                  grah.DrawImage(DujPanel3, new Point(panx3, pany3 - f ));
                  grah.DrawImage(DujPanel4, new Point(panx4, pany4 - f ));
                 grah.DrawImage(DujPanel5, new Point(panx5, pany5 - f));
                 grah.DrawImage(DujPanel6, new Point(panx6, pany6 - f ));
                 grah.DrawImage(DujPanel7, new Point(panx7, pany7 - f ));
                 grah.DrawImage(DujPanel8, new Point(panx8, pany8 - f ));
                 grah.DrawImage(DujPanel9, new Point(panx9, pany9 - f ));
                 grah.DrawImage(DujPanel10, new Point(panx10, pany10 - f ));
                 grah.DrawImage(DujPanel11, new Point(panx11, pany11 - f ));
                 grah.DrawImage(DujPanel12, new Point(panx12, pany12 - f ));
                o1 = pany1-f;
                o2 = pany2-f;
                o3 = pany3-f;
                o4 = pany4-f;
                o5 = pany5 - f;
                o6 = pany6 - f;
                o7 = pany7 - f;
                o8 = pany8 - f;
                o9 = pany9 - f;
                o10 = pany10 - f;
                o11 = pany11 - f;
                o12 = pany12 - f;
            }
            if (HdownY-120 > o1)//Death
            {
                timer.Stop();

                MessageBox.Show("Nice try, good luck!");
            }
        }

    }
}
