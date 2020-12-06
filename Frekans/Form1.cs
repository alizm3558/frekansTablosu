using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frekans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(textBox1, "Sadece sayı girebilirsiniz!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        int a=0;
        int genelH=0;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            listBox10.Visible = false;
         
           // button2.Enabled = true;
            button1.Enabled = true;
          
      

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {


                    e.Handled = true;
                    e.SuppressKeyPress = true;

                    a = listBox1.Items.Count;
                    listBox1.Items.Add((a + 1) + ". sayı: " + textBox1.Text);
                    listBox2.Items.Add(textBox1.Text);
                    //  listSiralama.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                    label2.Text = ("Veri adeti: " + Convert.ToString(listBox1.Items.Count));
                    if (listBox1.Items.Count == 0)
                    {

                        label2.Visible = false;
                    }
                    else
                    {
                        label2.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Giriş alanı boş bırakılamaz..");
                }
                /// sıralama başlar

                double[] sayilar = new double[listBox2.Items.Count];
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    sayilar[i] = Convert.ToDouble(listBox2.Items[i]);
                }
                for (int i = 0; i < sayilar.Length; i++)
                {
                    for (int j = i + 1; j < sayilar.Length; j++)
                    {
                        if (sayilar[(j)] < sayilar[(i)]) //selection algoritması
                        {
                            double degistir = sayilar[(j)];
                            sayilar[(j)] = sayilar[(i)];
                            sayilar[(i)] = degistir;
                        }

                    }
                }
                listSiralama.Items.Clear();
                for (int j = 0; j < sayilar.Length; j++)
                {
                    listSiralama.Items.Add(sayilar[j]); // diziyi yazdırıyo

                }



                // //////////////    sıralama biter

                if (listSiralama.Items.Count != 0) // frekans tablosu
                {
                    listBox13.Items.Clear();
                    double R = 0; int h = 0, k = 0, n = 0;
                    n = listSiralama.Items.Count; // veri sayısı
                    R = Math.Round((Convert.ToDouble(listSiralama.Items[listSiralama.Items.Count - 1]) - Convert.ToDouble(listSiralama.Items[0])), 2); // dağılım genişliği
                    k = Convert.ToInt32(Math.Ceiling(Math.Sqrt(n)));
                    h = Convert.ToInt32(Math.Ceiling(R / k));
                    genelH = h;
                    listBox13.Items.Add("n:" + n + " " + " R:" + R + " " + " k:" + k+" "  + " h:" + h);
                    //Math.Round(ortalama,2)
                    listBox3.Items.Clear();
                    listBox14.Items.Clear();
                    listBox4.Items.Clear();
                    listBox15.Items.Clear();
                    listBox6.Items.Clear();
                    double ilkdeger = 0;
                    ilkdeger = Convert.ToDouble(listSiralama.Items[0]);
                    Boolean kontrol = Convert.ToString(listSiralama.Items[0]).Contains(",");

                    listBox3.Items.Add(ilkdeger);
                   
                    //listBox14.Items.Add((ilkdeger+(h-1)));
                   // listBox4.Items.Add((ilkdeger - 0.5));
                   // listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                   // listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 1))) / 2);

                    if (kontrol==false)
                    {
                        listBox14.Items.Add((ilkdeger + (h - 1)));
                        listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                        listBox4.Items.Add((ilkdeger - 0.5));
                        listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 1))) / 2);
                    }
                    else
                    {
                        listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 0.1))) / 2);
                        listBox4.Items.Add((ilkdeger - 0.05));
                        listBox14.Items.Add((ilkdeger + (h - 0.1)));
                        listBox15.Items.Add((ilkdeger + (h - 0.1)) + 0.05);

                    }

                    for (int i=1;i<k;i++)
                    {
                        ilkdeger = ilkdeger +Convert.ToDouble(h);
                        listBox3.Items.Add( ilkdeger);
                        //listBox4.Items.Add((ilkdeger - 0.5));

                        if (kontrol == false)
                        {
                           
                            listBox4.Items.Add((ilkdeger - 0.5));
                            listBox14.Items.Add((ilkdeger + (h - 1)));
                            listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                            listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 1))) / 2);
                            
                        }
                        else
                        {
                            
                            listBox4.Items.Add((ilkdeger - 0.05));
                            listBox14.Items.Add((ilkdeger + (h - 0.1)));
                            listBox15.Items.Add((ilkdeger + (h - 0.1)) + 0.05);
                            listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 0.1))) / 2);
                        }
                     

                      
                       
                    }

                    //Math.Ceiling(sayi) bir üst sayıya yuvarlıyor.
                }

                ///////  sınıf frekansı başladı///
                listBox5.Items.Clear();
                listBox8.Items.Clear();
                if (listSiralama.Items.Count != 0) // frekans tablosu
                {

                    for (int i=0;i<listBox3.Items.Count;i++)
                    {
                        double frekansAlt, frekansUst;
                        frekansAlt = Convert.ToDouble(listBox3.Items[i]);
                        frekansUst = Convert.ToDouble(listBox14.Items[i]);

                        double sayac = 0;
                        for (int b=0;b<listSiralama.Items.Count;b++)
                        {/// for sok
                           // for(double)
                            if (Convert.ToDouble(listSiralama.Items[b])>=frekansAlt&& Convert.ToDouble(listSiralama.Items[b])<= frekansUst)
                            {
                                sayac = sayac + 1;
                            }
                            
                        }
                        listBox5.Items.Add(sayac);
                        double sonuc= (sayac / Convert.ToDouble(listSiralama.Items.Count));
                        listBox8.Items.Add(Math.Round(sonuc,2)); //oransal frekans
                    }
                
                }

                //////  frekanslar bitti /////

                listBox7.Items.Clear();
                if (listBox5.Items.Count != 0) // eklenik frekans başlar
                {
                    listBox7.Items.Add(listBox5.Items[0]);
                    int ilk = Convert.ToInt32(listBox5.Items[0]);
                    for (int i = 1; i < listBox5.Items.Count; i++)
                    {
                        ilk = ilk + Convert.ToInt32(listBox5.Items[i]);
                        listBox7.Items.Add(ilk);
                    }
                    ilk = 0;



                } // eklenik frekans bitiyor
                listBox9.Items.Clear();
                if (listBox7.Items.Count!=0) // oransal eklenik başlıyr
                {
                    for (int i=0;i<listBox7.Items.Count;i++)
                    {
                        double eklenik = Convert.ToDouble(listBox7.Items[i]);
                        listBox9.Items.Add((eklenik/Convert.ToDouble(listSiralama.Items.Count)));
                        
                    }

                } // oransal eklenik biter




            } /// enter bitiyor
           

        }
                 /////////////////// -- keydown biter -- ///////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count!=0) {
                DialogResult soru = new DialogResult();
                soru = MessageBox.Show("Emin misiniz?", "Dip bucak temizlik için;", MessageBoxButtons.YesNo);
                if (soru == DialogResult.Yes)
                {
                    listBox13.Items.Clear();
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox15.Items.Clear();
                    listBox14.Items.Clear();
                    listBox4.Items.Clear();
                    listBox3.Items.Clear();
                    listBox6.Items.Clear();

                    /////
                    double[] sayilar = new double[listBox2.Items.Count];
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        sayilar[i] = Convert.ToDouble(listBox2.Items[i]);
                    }
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        for (int j = i + 1; j < sayilar.Length; j++)
                        {
                            if (sayilar[(j)] < sayilar[(i)]) //selection algoritması
                            {
                                double degistir = sayilar[(j)];
                                sayilar[(j)] = sayilar[(i)];
                                sayilar[(i)] = degistir;
                            }

                        }
                    }
                    listSiralama.Items.Clear();
                    for (int j = 0; j < sayilar.Length; j++)
                    {
                        listSiralama.Items.Add(sayilar[j]); // diziyi yazdırıyo

                    }
                    if (listSiralama.Items.Count != 0) // frekans tablosu
                    {
                        listBox13.Items.Clear();
                        double R = 0; int h = 0, k = 0, n = 0;
                        n = listSiralama.Items.Count; // veri sayısı
                        R = Math.Round((Convert.ToDouble(listSiralama.Items[listSiralama.Items.Count - 1]) - Convert.ToDouble(listSiralama.Items[0])), 2); // dağılım genişliği
                        k = Convert.ToInt32(Math.Ceiling(Math.Sqrt(n)));
                        h = Convert.ToInt32(Math.Ceiling(R / k));
                        genelH = h;
                        listBox13.Items.Add(n + " " + " " + R + " " + " " + k + " " + h);
                        //Math.Round(ortalama,2)
                    }


                    ////


                    label2.Text = ("Veri adeti: " + Convert.ToString(listBox1.Items.Count));
                    if (listBox1.Items.Count == 0)
                    {

                        label2.Visible = false;
                    }
                    else
                    {
                        label2.Visible = true;
                    }
                    listBox5.Items.Clear();
                    listBox8.Items.Clear();
                    if (listSiralama.Items.Count != 0) // frekans tablosu
                    {

                        for (int i = 0; i < listBox3.Items.Count; i++)
                        {
                            double frekansAlt, frekansUst;
                            frekansAlt = Convert.ToDouble(listBox3.Items[i]);
                            frekansUst = Convert.ToDouble(listBox14.Items[i]);

                            double sayac = 0;
                            for (int b = 0; b < listSiralama.Items.Count; b++)
                            {/// for sok
                                // for(double)
                                if (Convert.ToDouble(listSiralama.Items[b]) >= frekansAlt && Convert.ToDouble(listSiralama.Items[b]) <= frekansUst)
                                {
                                    sayac = sayac + 1;
                                }

                            }
                            listBox5.Items.Add(sayac);
                            double sonuc = (sayac / Convert.ToDouble(listSiralama.Items.Count));
                            listBox8.Items.Add(Math.Round(sonuc, 2)); //oransal frekans
                        }

                    }

                    listBox7.Items.Clear();
                    if (listBox5.Items.Count != 0) // eklenik frekans başlar
                    {
                        listBox7.Items.Add(listBox5.Items[0]);
                        int ilk = Convert.ToInt32(listBox5.Items[0]);
                        for (int i = 1; i < listBox5.Items.Count; i++)
                        {
                            ilk = ilk + Convert.ToInt32(listBox5.Items[i]);
                            listBox7.Items.Add(ilk);
                        }
                        ilk = 0;



                    } // eklenik frekans bitiyor
                    listBox9.Items.Clear();
                    if (listBox7.Items.Count != 0) // oransal eklenik başlıyr
                    {
                        for (int i = 0; i < listBox7.Items.Count; i++)
                        {
                            double eklenik = Convert.ToDouble(listBox7.Items[i]);
                            listBox9.Items.Add((eklenik / Convert.ToDouble(listSiralama.Items.Count)));

                        }

                    } // oransal eklenik biter
                } // evet cevabı biter
                else
                {
                    MessageBox.Show("Görev iptal edildi..");
                    
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir veri bulunamadı.");
             
            }
            if (listSiralama.Items.Count != 0) // frekans tablosu
            {
                listBox6.Items.Clear();
                listBox13.Items.Clear();
                //
                double R = 0; int h = 0, k = 0, n = 0;
                n = listSiralama.Items.Count; // veri sayısı
                R = Math.Round((Convert.ToDouble(listSiralama.Items[listSiralama.Items.Count - 1]) - Convert.ToDouble(listSiralama.Items[0])), 2); // dağılım genişliği
                k = Convert.ToInt32( Math.Ceiling(Math.Sqrt(n)));
                h = Convert.ToInt32(Math.Ceiling(R / k));
                genelH = h;
                listBox13.Items.Add("n:" + n + " " + " R:" + R + " " + " k:" + k + " " + " h:" + h);
                //Math.Round(ortalama,2)
                listBox3.Items.Clear();
                listBox14.Items.Clear();
                listBox4.Items.Clear();
                listBox15.Items.Clear();
                double ilkdeger = 0;
                ilkdeger = Convert.ToDouble(listSiralama.Items[0]);
                listBox3.Items.Add(ilkdeger);
                listBox4.Items.Add((ilkdeger - 0.5));
                listBox14.Items.Add((ilkdeger + (h - 1)));
                listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                listBox6.Items.Add((ilkdeger+(ilkdeger + (h - 1)))/2);
                for (int i = 1; i < k; i++)
                {
                    ilkdeger = ilkdeger + Convert.ToDouble(h);
                    listBox3.Items.Add(ilkdeger);
                    listBox4.Items.Add((ilkdeger - 0.5));
                    listBox14.Items.Add((ilkdeger + (h - 1)));
                    listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                    listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 1))) / 2);
                }

                //Math.Ceiling(sayi) bir üst sayıya yuvarlıyor.
            }
            listBox7.Items.Clear();
            if (listBox5.Items.Count != 0) // eklenik frekans başlar
            {
                listBox7.Items.Add(listBox5.Items[0]);
                int ilk = Convert.ToInt32(listBox5.Items[0]);
                for (int i = 1; i < listBox5.Items.Count; i++)
                {
                    ilk = ilk + Convert.ToInt32(listBox5.Items[i]);
                    listBox7.Items.Add(ilk);
                }
                ilk = 0;



            } // eklenik frekans bitiyor

        }//buton biter
        int indis = -1;
        private void button2_Click(object sender, EventArgs e)
        {
           
                 
            if (indis>-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox2.Items.RemoveAt(indis);
                listBox1.Items.Clear();
                listBox6.Items.Clear();
              

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add((i + 1) + ". sayı: " + listBox2.Items[i]);
                }

                //
                double[] sayilar = new double[listBox2.Items.Count];
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    sayilar[i] = Convert.ToDouble(listBox2.Items[i]);
                }
                for (int i = 0; i < sayilar.Length; i++)
                {
                    for (int j = i + 1; j < sayilar.Length; j++)
                    {
                        if (sayilar[(j)] < sayilar[(i)]) //selection algoritması
                        {
                            double degistir = sayilar[(j)];
                            sayilar[(j)] = sayilar[(i)];
                            sayilar[(i)] = degistir;
                        }

                    }
                }
                listSiralama.Items.Clear();
                for (int j = 0; j < sayilar.Length; j++)
                {
                    listSiralama.Items.Add(sayilar[j]); // diziyi yazdırıyo

                }

                if (listSiralama.Items.Count != 0) // frekans tablosu
                {
                    listBox13.Items.Clear();
                    double R = 0; int h = 0, k = 0, n = 0;
                    n = listSiralama.Items.Count; // veri sayısı
                    R = Math.Round((Convert.ToDouble(listSiralama.Items[listSiralama.Items.Count - 1]) - Convert.ToDouble(listSiralama.Items[0])), 2); // dağılım genişliği
                    k = Convert.ToInt32(Math.Ceiling(Math.Sqrt(n)));
                    h = Convert.ToInt32(Math.Ceiling(R / k));
                    genelH = h;
                    listBox13.Items.Add(n + " " + " " + R + " " + " " + k + " " + h);
                    //Math.Round(ortalama,2)
                }
                //

                label2.Text = ("Veri adeti: " + Convert.ToString(listBox1.Items.Count));
                if (listBox1.Items.Count == 0)
                {

                    label2.Visible = false;
                }
                else
                {
                    label2.Visible = true;
                } 
            }
            else
            {
                MessageBox.Show("Herhangi bir veri bulunamadı.");
                listBox6.Items.Clear();//deneme
            }
            indis = -1;
            if (listSiralama.Items.Count != 0) // frekans tablosu
            {
                listBox13.Items.Clear();
                double R = 0; int h = 0, k = 0, n = 0;
                n = listSiralama.Items.Count; // veri sayısı
                R = Math.Round((Convert.ToDouble(listSiralama.Items[listSiralama.Items.Count - 1]) - Convert.ToDouble(listSiralama.Items[0])), 2); // dağılım genişliği
                k = Convert.ToInt32(Math.Ceiling(Math.Sqrt(n)));
                h = Convert.ToInt32(Math.Ceiling(R / k));
                genelH = h;
                listBox13.Items.Add("n:" + n + " " + " R:" + R + " " + " k:" + k + " " + " h:" + h);
                //Math.Round(ortalama,2)
                listBox3.Items.Clear();
                listBox14.Items.Clear();
                listBox4.Items.Clear();
                listBox15.Items.Clear();
                double ilkdeger = 0;
                ilkdeger = Convert.ToDouble(listSiralama.Items[0]);
                listBox3.Items.Add(ilkdeger);
                listBox4.Items.Add((ilkdeger - 0.5));
                listBox14.Items.Add((ilkdeger + (h - 1)));
                listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 1))) / 2);
                for (int i = 1; i < k; i++)
                {
                    ilkdeger = ilkdeger + Convert.ToDouble(h);
                    listBox3.Items.Add(ilkdeger);
                    listBox4.Items.Add((ilkdeger - 0.5));
                    listBox14.Items.Add((ilkdeger + (h - 1)));
                    listBox15.Items.Add((ilkdeger + (h - 1)) + 0.5);
                    listBox6.Items.Add((ilkdeger + (ilkdeger + (h - 1))) / 2);
                }

                //Math.Ceiling(sayi) bir üst sayıya yuvarlıyor.
            }

            listBox5.Items.Clear();
            listBox8.Items.Clear();
            if (listSiralama.Items.Count != 0) // frekans tablosu
            {

                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    double frekansAlt, frekansUst;
                    frekansAlt = Convert.ToDouble(listBox3.Items[i]);
                    frekansUst = Convert.ToDouble(listBox14.Items[i]);

                    double sayac = 0;
                    for (int b = 0; b < listSiralama.Items.Count; b++)
                    {/// for sok
                        // for(double)
                        if (Convert.ToDouble(listSiralama.Items[b]) >= frekansAlt && Convert.ToDouble(listSiralama.Items[b]) <= frekansUst)
                        {
                            sayac = sayac + 1;
                        }

                    }
                    listBox5.Items.Add(sayac);
                    double sonuc = (sayac / Convert.ToDouble(listSiralama.Items.Count));
                    listBox8.Items.Add(Math.Round(sonuc, 2)); //oransal frekans
                }

            }
            listBox7.Items.Clear();
            if (listBox5.Items.Count!=0) // eklenik frekans başlar
            {
                listBox7.Items.Add(listBox5.Items[0]);
                int ilk = Convert.ToInt32(listBox5.Items[0]);
                for (int i=1;i< listBox5.Items.Count;i++)
                {
                   ilk = ilk + Convert.ToInt32(listBox5.Items[i]);
                    listBox7.Items.Add(ilk);
                }
                ilk = 0;



            }
            listBox9.Items.Clear();
            if (listBox7.Items.Count != 0) // oransal eklenik başlıyr
            {
                for (int i = 0; i < listBox7.Items.Count; i++)
                {
                    double eklenik = Convert.ToDouble(listBox7.Items[i]);
                    listBox9.Items.Add((eklenik / Convert.ToDouble(listSiralama.Items.Count)));
                   
                }

            }
            listBox9.Items.Clear();
            if (listBox7.Items.Count != 0) // oransal eklenik başlıyr
            {
                for (int i = 0; i < listBox7.Items.Count; i++)
                {
                    double eklenik = Convert.ToDouble(listBox7.Items[i]);
                    listBox9.Items.Add((eklenik / Convert.ToDouble(listSiralama.Items.Count)));

                }

            } // oransal eklenik biter


        }// biter

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            indis = listBox1.SelectedIndex;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listSiralama.Items.Count != 0)
            {
                listBox10.Items.Clear();
                int n, sayac = 0, i, j, k, l;
                button1.Enabled = false;
                //button2.Enabled = false;
                listBox10.Visible = true;

                double[] dizi = new double[listSiralama.Items.Count];
                for (i = 0; i < listSiralama.Items.Count; i++)
                {
                    dizi[i] = Convert.ToDouble(listSiralama.Items[i]);   // diziye listboxdaki değerler alınıyor..
                }

                for (j = 0; j < dizi.Length; j++)
                {
                    for (k = 0; k < dizi.Length; k++)
                    {
                        //eğer tekrar eden değer bulunursa if'in içindeki kod çalışıyor www.bilisimogretmeni.com
                        if (dizi[j] == dizi[k])
                        {
                            //bu for da, dizinin bütün değerleri için ekranda yazdırmanın önüne geçmek için.
                            //örneğin 2 üç kez tekrar ediyor olabilir ama ekranda sadece bir tane 2nin üç kez girildiğini görmemiz lazım aksi takdirde ekranda kaç kez girildiyse o kadar yazdırıyor. www.bilisimogretmeni.com
                            for (l = 0; l < j; l++)
                            {
                                //eğer değerin kaç kez girildiğini önceden yazdırmışsam bunu tekrar yazdırmama gerek yok
                                if (dizi[l] == dizi[j])
                                    //sayacı -1'e eşitliyorum çünkü sonrasında 1 artıracak 0 olacak ve en son ekrana yazdırırken sayaç 0 değilse yazdıracak www.bilisimogretmeni.com
                                    sayac = -1;
                            }
                            sayac++;
                        }
                    }
                    if (sayac != 0)
                    {
                        listBox10.Items.Add(dizi[j] + " =>" + sayac + " tane.");
                        listBox11.Items.Add(dizi[j]); // sayılar var.
                        listBox12.Items.Add(sayac);   // sayıların adetleri var.
                    }
                    sayac = 0;
                }


            }
            else { MessageBox.Show("Veri bulunamadı.."); }


        } // buton biter

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count!=0)
            {
                button1.Enabled = true;
               // button2.Enabled = true;
                listBox10.Visible = false;
                ortalama.Visible = false;
                varyans.Visible = false;
                standart.Visible = false;
                oms.Visible = false;
                q1.Visible = false;
                q3.Visible = false;
                carpiklik.Visible = false;
                sivri.Visible = false;
                katsayi.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

           // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
           // button2.Enabled = false;
            if (listSiralama.Items.Count!=0)
            {
                // kodları yaz
                double ort = 0,top=0;
                double[] sayilar = new double[listSiralama.Items.Count];
                double[] toplamDizisi = new double[listSiralama.Items.Count];
                for (int i=0;i<listSiralama.Items.Count;i++) // ortalama başlar
                {
                    top = top + Convert.ToDouble(listSiralama.Items[i]);
                   // sayilar[i] = Convert.ToDouble(listSiralama.Items[i]);

                }
                ort = top / listSiralama.Items.Count;
                ortalama.Text ="Ortalama: "+Convert.ToString(Math.Round(ort,2));
                ////////   ortalama bulundu./////////

                /////////  örneklem varyans ///////
                double orneklem = 0;
                for (int i = 0; i < listSiralama.Items.Count; i++) // ortalama başlar
                {
                    orneklem = orneklem+ ((Convert.ToDouble(listSiralama.Items[i]) - ort)* (Convert.ToDouble(listSiralama.Items[i]) - ort));

                }
                double sonuc = orneklem / Convert.ToDouble(listSiralama.Items.Count-1);
                varyans.Text = "Ö. varyansı: " + Convert.ToString(Math.Round(sonuc,2));
                double sapma=Convert.ToDouble(Math.Sqrt(sonuc));
                standart.Text = Convert.ToString("S. sapma: "+Math.Round(sapma,2)); // standat sapma

                double orneklem2 = 0;
                for (int i = 0; i < listSiralama.Items.Count; i++) // ortalama başlar
                {
                    orneklem2 = orneklem2 + (Math.Abs(Convert.ToDouble(listSiralama.Items[i]) - ort) );

                }
                double sonuc2 = orneklem2 / Convert.ToDouble(listSiralama.Items.Count );
                oms.Text = "OMS: " + Convert.ToString(Math.Round(sonuc2,2));
                // OMS biter
                //////////////  çeyreklikler //////////////
                /*double j1, n1, q11, l1, fq1, j3, n3, q33, l3, fq3,h,deger,j1toplam=0;
                deger = Convert.ToDouble(listBox5.Items.Count) / 4;
                int jsayac = 0,j1indis=0,dongu=0;
                while (jsayac==-1)
                { 
                    if (Convert.ToDouble(listBox5.Items[dongu])<=deger)
                    {
                        j1toplam = j1toplam + Convert.ToDouble(listBox5.Items[dongu]);
                        j1indis = j1indis + 1;
                        jsayac = 0;
                        dongu++;
                    }
                    jsayac = -1;
                }
                q1.Text =Convert.ToString(j1toplam)+Convert.ToString(dongu);*/
                


                /// //////// çeyreklikler biter ///////////////

                double carpiklikOlcutu = orneklem * orneklem * orneklem; // çarpıklık ölçütü
                carpiklik.Text = "Ç. ölçütü: " + Convert.ToString(carpiklikOlcutu);
                double sivrilikolcutu = carpiklikOlcutu*orneklem;
                sivri.Text = "S. ölçütü: " + Convert.ToString(sivrilikolcutu);
                //q1.Text = "Q1: "+"Daha sonra bulacağım :)";
                //q1.ForeColor = Color.Red;
                //q3.ForeColor = Color.Red;
                //q3.Text = "Q3: " + "Daha sonra bulacağım :)";
                katsayi.Text = "D. katsayısı: "+Convert.ToString(Math.Round((sapma/ort),2));

                double n = 0,l1,j1,fq1,n1=0;
                int  indis = 0;
                n =Convert.ToDouble(Convert.ToDouble(listSiralama.Items.Count) /4 );
                while (n1 < Convert.ToDouble(listBox5.Items[indis]))
                {
                    n1 = n1 + Convert.ToDouble(listBox5.Items[indis]);
                    indis++;

                }
                indis = indis - 1;
                j1 =n-n1; //j1 tamam

                // q1.Text = Convert.ToString(j1);

                ////////////// çeyreklikler ////////////////

                 /////  q1 başlar //////
                int adet_n = listSiralama.Items.Count;
                double nBolu4 =Convert.ToDouble(adet_n)/Convert.ToDouble(4);
                Boolean anahtar = false;
                int  sayac=0;
                int toplama = 0;
                while (anahtar==false) //j1i bulmak için
                {
                    if (toplama < nBolu4)
                    {
                        toplama =toplama+ Convert.ToInt32(listBox5.Items[sayac]);
                        sayac++;
                        anahtar = false;
                    }
                   
                    else
                    {
                        anahtar = true;
                    }
                   

                }
                int sonSayac = sayac - 1; //+1li sayaç
                int sontoplama = toplama - Convert.ToInt32(listBox5.Items[sayac-1]);
                double sonuc_j1 = nBolu4-Convert.ToDouble(sontoplama); // sonuc_j1 çalışıyor.
                                                                    // q1.Text =(sayac+1).ToString();
                double q1_l1 = Convert.ToDouble(listBox4.Items[sonSayac]); // çalışıyor.
                double h = Convert.ToDouble(listSiralama.Items[listSiralama.Items.Count - 1]) - Convert.ToDouble(listSiralama.Items[0]) ; // h çalışıyor.
                double fq_1 = Convert.ToDouble(listBox5.Items[sonSayac]); // çalışıyor.
                double q1_sonuc = (q1_l1+((sonuc_j1*h)/fq_1));
                 q1.Text = "Q1: " + q1_sonuc.ToString();
                // q1 çalışıyor.

                /////// q1 biter ///////////

                //////////// q2 başlar /////////// 
                double bolu4= (3 *Convert.ToDouble(listSiralama.Items.Count)) / 4;
                Boolean anahtar2 = false;
                int sayac2 = 0;
                int toplama2 = 0;
                while (anahtar2 == false) //j1i bulmak için
                {
                    if (toplama2 < bolu4)
                    {
                        toplama2 = toplama2 + Convert.ToInt32(listBox5.Items[sayac2]);
                        sayac2++;
                        anahtar2 = false;
                    }

                    else
                    {
                        anahtar2 = true;
                    }


                }
                int sonSayac2 = sayac2 - 1; //+1li sayaç
                int sontoplama2 = toplama2 - Convert.ToInt32(listBox5.Items[sayac2 - 1]);
                double sonuc_j3 = bolu4 - Convert.ToDouble(sontoplama2); // çalışıyor.
                double q3_l3 = Convert.ToDouble(listBox4.Items[sonSayac2-1]); // çalışıyor.
                double fq_3 = Convert.ToDouble(listBox5.Items[sonSayac2-1]); // çalışıyor.
                double q3_sonuc = q3_l3 + ((sonuc_j3 * h) / fq_3);
                 q3.Text ="Q3: "+ q3_sonuc.ToString();


                // tamamlanmadı..



                //q3.Text =sonuc_j3.ToString();








                ////////////////// bitti ///////////////////






                katsayi.Visible = true;
                ortalama.Visible = true;
                varyans.Visible = true;
                standart.Visible = true;
                oms.Visible = true;
                q1.Visible = true;
                q3.Visible = true;
                carpiklik.Visible = true;
                sivri.Visible = true;


                

            }
            else
            {
                MessageBox.Show("Veri bulunamadı..");
            }

        }// buton biter
    }
}

