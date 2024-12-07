using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class frmBarcode : Form
    {
        public frmBarcode()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtBarcode.Text=randomLong().ToString();
            txtBarcode1.Text = randomLong1().ToString();
            txtBarcode2.Text = randomLong2().ToString();
            txtBarcode3.Text = randomLong3().ToString();
            txtBarcode4.Text = randomLong4().ToString();
            txtBarcode5.Text = randomLong5().ToString();
            txtBarcode6.Text = randomLong6().ToString();
            txtBarcode7.Text = randomLong7().ToString();
            txtBarcode8.Text = randomLong8().ToString();
            txtBarcode9.Text = randomLong9().ToString();
            txtBarcode10.Text = randomLong10().ToString();
            txtBarcode11.Text = randomLong11().ToString();
            txtBarcode12.Text = randomLong12().ToString();
            txtBarcode13.Text = randomLong13().ToString();
            txtBarcode14.Text = randomLong14().ToString();
            txtBarcode15.Text = randomLong15().ToString();
            txtBarcode16.Text = randomLong16().ToString();
            txtBarcode17.Text = randomLong17().ToString();
            txtBarcode18.Text = randomLong18().ToString();
            txtBarcode19.Text = randomLong19().ToString();

            try
            {
                BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                Image img = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode.Text, Color.Black, Color.White, 100, 30);
                pictureBox1.Image = img;
                Image img1 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode1.Text, Color.Black, Color.White, 100, 30);
                pictureBox2.Image = img1;
                Image img2 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode2.Text, Color.Black, Color.White, 100, 30);
                pictureBox3.Image = img2;
                Image img3 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode3.Text, Color.Black, Color.White, 100, 30);
                pictureBox4.Image = img3;
                Image img4 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode4.Text, Color.Black, Color.White, 100, 30);
                pictureBox5.Image = img4;
                Image img5 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode5.Text, Color.Black, Color.White, 100, 30);
                pictureBox6.Image = img5;
                Image img6 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode6.Text, Color.Black, Color.White, 100, 30);
                pictureBox7.Image = img6;
                Image img7 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode7.Text, Color.Black, Color.White, 100, 30);
                pictureBox8.Image = img7;
                Image img8 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode8.Text, Color.Black, Color.White, 100, 30);
                pictureBox9.Image = img8;
                Image img9 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox10.Image = img9;
                Image img10 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox11.Image = img10;
                Image img11 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox12.Image = img11;
                Image img12 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox13.Image = img12;
                Image img13 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox14.Image = img13;
                Image img14 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox15.Image = img14;
                Image img15 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox16.Image = img15;
                Image img16 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox17.Image = img16;
                Image img17 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox18.Image = img17;
                Image img18 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox19.Image = img18;
                Image img19 = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode9.Text, Color.Black, Color.White, 100, 30);
                pictureBox20.Image = img19;

                this.appData1.Clear();
                
                using(MemoryStream ms =new MemoryStream())
                   using(MemoryStream ms1 = new MemoryStream())
                using (MemoryStream ms2 = new MemoryStream())
                using (MemoryStream ms3 = new MemoryStream())
                using (MemoryStream ms4 = new MemoryStream())
                using (MemoryStream ms5 = new MemoryStream())
                using (MemoryStream ms6 = new MemoryStream())
                using (MemoryStream ms7 = new MemoryStream())
                using (MemoryStream ms8 = new MemoryStream())
                using (MemoryStream ms9 = new MemoryStream())
                using (MemoryStream ms10 = new MemoryStream())
                using (MemoryStream ms11 = new MemoryStream())
                using (MemoryStream ms12 = new MemoryStream())
                using (MemoryStream ms13 = new MemoryStream())
                using (MemoryStream ms14 = new MemoryStream())
                using (MemoryStream ms15 = new MemoryStream())
                using (MemoryStream ms16 = new MemoryStream())
                using (MemoryStream ms17 = new MemoryStream())
                using (MemoryStream ms18 = new MemoryStream())
                using (MemoryStream ms19 = new MemoryStream())

                {
                    img.Save(ms,ImageFormat.Png);
                   
                        this.appData1.Barcode.AddBarcodeRow(txtBarcode.Text,ms.ToArray());

                   img1.Save(ms1, ImageFormat.Png);
                    
                       this.appData1.Barcode.AddBarcodeRow(txtBarcode1.Text, ms1.ToArray());


                   // img2.Save(ms2, ImageFormat.Png);
                   
                      //  this.appData1.Barcode.AddBarcodeRow(txtBarcode2.Text, ms2.ToArray());

                  //  img3.Save(ms3, ImageFormat.Png);
                   
                    //    this.appData1.Barcode.AddBarcodeRow(txtBarcode3.Text, ms3.ToArray());

                   // img4.Save(ms4, ImageFormat.Png);
                   
                      //  this.appData1.Barcode.AddBarcodeRow(txtBarcode4.Text, ms4.ToArray());

                   // img5.Save(ms5, ImageFormat.Png);
                    //
                      //  this.appData1.Barcode.AddBarcodeRow(txtBarcode5.Text, ms5.ToArray());

                    //img6.Save(ms6, ImageFormat.Png);
                   
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode6.Text, ms6.ToArray());

                   // img7.Save(ms7, ImageFormat.Png);
                   
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode7.Text, ms7.ToArray());

                    //img8.Save(ms8, ImageFormat.Png);
                    
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode8.Text, ms8.ToArray());
                  //  img9.Save(ms9, ImageFormat.Png);
                    
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode9.Text, ms9.ToArray());
                  //  img10.Save(ms10, ImageFormat.Png);
                    
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode10.Text, ms10.ToArray());
                    //img11.Save(ms11, ImageFormat.Png);
                    
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode11.Text, ms11.ToArray());
                   // img12.Save(ms12, ImageFormat.Png);
                    
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode12.Text, ms12.ToArray());
                    //img13.Save(ms13, ImageFormat.Png);
                   
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode13.Text, ms13.ToArray());
                    //img14.Save(ms14, ImageFormat.Png);
                    
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode14.Text, ms14.ToArray());
                    //img15.Save(ms15, ImageFormat.Png);
                  
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode15.Text, ms15.ToArray());
                   // img16.Save(ms16, ImageFormat.Png);
                    
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode16.Text, ms16.ToArray());
                  //  img17.Save(ms17, ImageFormat.Png);
                    
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode17.Text, ms17.ToArray());
                    //img18.Save(ms18, ImageFormat.Png);
                    
                       // this.appData1.Barcode.AddBarcodeRow(txtBarcode18.Text, ms18.ToArray());
                 //   img19.Save(ms19, ImageFormat.Png);
                   
                        //this.appData1.Barcode.AddBarcodeRow(txtBarcode19.Text, ms19.ToArray());
                }
                using(frmReport frm=new frmReport(this.appData1.Barcode))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ". Please contact your Admin.", "ALERT", MessageBoxButtons.OKCancel);
            }

           

        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {


        }
        private long randomLong()
        {

            long min = 100000000000;
            long max = 999999999999;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
            


        }
        private long randomLong1()
        {

            long min = 10000000000;
            long max = 99999999999;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong2()
        {

            long min = 100000000001;
            long max = 900000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong3()
        {

            long min = 11111111111;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong4()
        {

            long min = 22222222222;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong5()
        {

            long min = 33333333333;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong6()
        {

            long min = 44444444444;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong7()
        {

            long min = 55555555555;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong8()
        {

            long min = 66666666666;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong9()
        {

            long min = 77777777777;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong10()
        {

            long min = 12345678912;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong11()
        {

            long min = 987654321123;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong12()
        {

            long min = 192739125312;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong13()
        {

            long min = 982617283958;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong14()
        {

            long min = 152789315728;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong15()
        {

            long min = 210328571572;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong16()
        {

            long min = 313927857212;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong17()
        {

            long min = 412526124623;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong18()
        {

            long min = 512524632134;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }
        private long randomLong19()
        {

            long min = 721246234512;
            long max = 100000000000;
            Random random = new Random();
            long randomNumber = min + random.Next() % (max - min);
            return randomNumber;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory fi=new frmInventory();
            fi.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducts fi=new frmProducts();
            fi.ShowDialog();
        }

        private void txtBarcode8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void frmBarcode_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frmBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
