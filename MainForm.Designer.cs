namespace ALPARGE
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.MMKullaniciIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.projelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMYeniTalep = new System.Windows.Forms.ToolStripMenuItem();
            this.MMTalepOnaylama = new System.Windows.Forms.ToolStripMenuItem();
            this.MMProjeSorumlusu = new System.Windows.Forms.ToolStripMenuItem();
            this.MMButcePlanlama = new System.Windows.Forms.ToolStripMenuItem();
            this.MMProjeOnay = new System.Windows.Forms.ToolStripMenuItem();
            this.projeTakipVeTamamlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeKapatmaOnayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMTumProjeler = new System.Windows.Forms.ToolStripMenuItem();
            this.etkinliklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMToplantilar = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeAnaliziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bütçeAnaliziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMProjeUyumSure = new System.Windows.Forms.ToolStripMenuItem();
            this.MMProjeTamamlanmaOran = new System.Windows.Forms.ToolStripMenuItem();
            this.MMPersonelCalismaSure = new System.Windows.Forms.ToolStripMenuItem();
            this.MMPersCalismaPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMDosyalar = new System.Windows.Forms.ToolStripMenuItem();
            this.MMTextNotlar = new System.Windows.Forms.ToolStripMenuItem();
            this.özelMenülerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projelerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMGrupTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.MMKullaniciTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.MMMusteriler = new System.Windows.Forms.ToolStripMenuItem();
            this.MMCatiProje = new System.Windows.Forms.ToolStripMenuItem();
            this.MMProjeKaynaklar = new System.Windows.Forms.ToolStripMenuItem();
            this.MMProjeGorevTipleri = new System.Windows.Forms.ToolStripMenuItem();
            this.MMSaatUcreti = new System.Windows.Forms.ToolStripMenuItem();
            this.MMmeyerTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMSistem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new Components.TabMenuEx();
            this.MToolBox = new BaseControls.BC_ToolBox();
            this.tbDashBoard = new System.Windows.Forms.ToolStripButton();
            this.tbProjeListesi = new System.Windows.Forms.ToolStripButton();
            this.tbProjeZamanPlan = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.MToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.projelerToolStripMenuItem,
            this.etkinliklerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.taleplerToolStripMenuItem,
            this.özelMenülerToolStripMenuItem,
            this.tanımlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1008, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMDashboard,
            this.MMKullaniciIslem,
            this.MMCikis});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // MMDashboard
            // 
            this.MMDashboard.Name = "MMDashboard";
            this.MMDashboard.Size = new System.Drawing.Size(166, 22);
            this.MMDashboard.Text = "Dashboard";
            this.MMDashboard.Click += new System.EventHandler(this.MMDashboard_Click);
            // 
            // MMKullaniciIslem
            // 
            this.MMKullaniciIslem.Name = "MMKullaniciIslem";
            this.MMKullaniciIslem.Size = new System.Drawing.Size(166, 22);
            this.MMKullaniciIslem.Text = "Kullanıcı İşlemleri";
            this.MMKullaniciIslem.Click += new System.EventHandler(this.MMKullaniciIslem_Click);
            // 
            // MMCikis
            // 
            this.MMCikis.Name = "MMCikis";
            this.MMCikis.Size = new System.Drawing.Size(166, 22);
            this.MMCikis.Text = "Çıkış";
            this.MMCikis.Click += new System.EventHandler(this.MMCikis_Click);
            // 
            // projelerToolStripMenuItem
            // 
            this.projelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMYeniTalep,
            this.MMTalepOnaylama,
            this.MMProjeSorumlusu,
            this.MMButcePlanlama,
            this.MMProjeOnay,
            this.projeTakipVeTamamlamaToolStripMenuItem,
            this.projeKapatmaOnayıToolStripMenuItem,
            this.MMTumProjeler});
            this.projelerToolStripMenuItem.Name = "projelerToolStripMenuItem";
            this.projelerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.projelerToolStripMenuItem.Text = "Proje Yönetimi";
            // 
            // MMYeniTalep
            // 
            this.MMYeniTalep.Name = "MMYeniTalep";
            this.MMYeniTalep.Size = new System.Drawing.Size(199, 22);
            this.MMYeniTalep.Text = "Yeni Proje Talebi";
            this.MMYeniTalep.Click += new System.EventHandler(this.MMYeniTalep_Click);
            // 
            // MMTalepOnaylama
            // 
            this.MMTalepOnaylama.Name = "MMTalepOnaylama";
            this.MMTalepOnaylama.Size = new System.Drawing.Size(199, 22);
            this.MMTalepOnaylama.Text = "Talep Onaylama";
            this.MMTalepOnaylama.Click += new System.EventHandler(this.MMTalepOnaylama_Click);
            // 
            // MMProjeSorumlusu
            // 
            this.MMProjeSorumlusu.Name = "MMProjeSorumlusu";
            this.MMProjeSorumlusu.Size = new System.Drawing.Size(199, 22);
            this.MMProjeSorumlusu.Text = "Proje Sorumlusu Atama";
            this.MMProjeSorumlusu.Click += new System.EventHandler(this.MMProjeSorumlusu_Click);
            // 
            // MMButcePlanlama
            // 
            this.MMButcePlanlama.Name = "MMButcePlanlama";
            this.MMButcePlanlama.Size = new System.Drawing.Size(199, 22);
            this.MMButcePlanlama.Text = "Bütçe Zaman Planlama";
            this.MMButcePlanlama.Click += new System.EventHandler(this.MMButcePlanlama_Click);
            // 
            // MMProjeOnay
            // 
            this.MMProjeOnay.Name = "MMProjeOnay";
            this.MMProjeOnay.Size = new System.Drawing.Size(199, 22);
            this.MMProjeOnay.Text = "Proje Onayı";
            this.MMProjeOnay.Click += new System.EventHandler(this.MMProjeOnay_Click);
            // 
            // projeTakipVeTamamlamaToolStripMenuItem
            // 
            this.projeTakipVeTamamlamaToolStripMenuItem.Name = "projeTakipVeTamamlamaToolStripMenuItem";
            this.projeTakipVeTamamlamaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.projeTakipVeTamamlamaToolStripMenuItem.Text = "Onaylı Proje İşlemleri";
            this.projeTakipVeTamamlamaToolStripMenuItem.Click += new System.EventHandler(this.projeTakipVeTamamlamaToolStripMenuItem_Click);
            // 
            // projeKapatmaOnayıToolStripMenuItem
            // 
            this.projeKapatmaOnayıToolStripMenuItem.Name = "projeKapatmaOnayıToolStripMenuItem";
            this.projeKapatmaOnayıToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.projeKapatmaOnayıToolStripMenuItem.Text = "Proje Kapatma İşlemleri";
            this.projeKapatmaOnayıToolStripMenuItem.Click += new System.EventHandler(this.projeKapatmaOnayıToolStripMenuItem_Click);
            // 
            // MMTumProjeler
            // 
            this.MMTumProjeler.Name = "MMTumProjeler";
            this.MMTumProjeler.Size = new System.Drawing.Size(199, 22);
            this.MMTumProjeler.Text = "Tüm Projeler";
            this.MMTumProjeler.Click += new System.EventHandler(this.MMTumProjeler_Click);
            // 
            // etkinliklerToolStripMenuItem
            // 
            this.etkinliklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMToplantilar});
            this.etkinliklerToolStripMenuItem.Name = "etkinliklerToolStripMenuItem";
            this.etkinliklerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.etkinliklerToolStripMenuItem.Text = "Etkinlikler";
            // 
            // MMToplantilar
            // 
            this.MMToplantilar.Name = "MMToplantilar";
            this.MMToplantilar.Size = new System.Drawing.Size(162, 22);
            this.MMToplantilar.Text = "Proje Toplantıları";
            this.MMToplantilar.Click += new System.EventHandler(this.MMToplantilar_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeAnaliziToolStripMenuItem,
            this.bütçeAnaliziToolStripMenuItem,
            this.MMProjeUyumSure,
            this.MMProjeTamamlanmaOran,
            this.MMPersonelCalismaSure,
            this.MMPersCalismaPlan});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // projeAnaliziToolStripMenuItem
            // 
            this.projeAnaliziToolStripMenuItem.Name = "projeAnaliziToolStripMenuItem";
            this.projeAnaliziToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.projeAnaliziToolStripMenuItem.Text = "Proje Analizi";
            // 
            // bütçeAnaliziToolStripMenuItem
            // 
            this.bütçeAnaliziToolStripMenuItem.Name = "bütçeAnaliziToolStripMenuItem";
            this.bütçeAnaliziToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.bütçeAnaliziToolStripMenuItem.Text = "Bütçe Analizi";
            // 
            // MMProjeUyumSure
            // 
            this.MMProjeUyumSure.Name = "MMProjeUyumSure";
            this.MMProjeUyumSure.Size = new System.Drawing.Size(221, 22);
            this.MMProjeUyumSure.Text = "Personel Proje Çalışmaları";
            this.MMProjeUyumSure.Click += new System.EventHandler(this.MMProjeUyumSure_Click);
            // 
            // MMProjeTamamlanmaOran
            // 
            this.MMProjeTamamlanmaOran.Name = "MMProjeTamamlanmaOran";
            this.MMProjeTamamlanmaOran.Size = new System.Drawing.Size(221, 22);
            this.MMProjeTamamlanmaOran.Text = "Proje Tamamlanma Oranları";
            this.MMProjeTamamlanmaOran.Click += new System.EventHandler(this.MMProjeTamamlanmaOran_Click);
            // 
            // MMPersonelCalismaSure
            // 
            this.MMPersonelCalismaSure.Name = "MMPersonelCalismaSure";
            this.MMPersonelCalismaSure.Size = new System.Drawing.Size(221, 22);
            this.MMPersonelCalismaSure.Text = "Personel Çalışma Süreleri";
            this.MMPersonelCalismaSure.Click += new System.EventHandler(this.MMPersonelCalismaSure_Click);
            // 
            // MMPersCalismaPlan
            // 
            this.MMPersCalismaPlan.Name = "MMPersCalismaPlan";
            this.MMPersCalismaPlan.Size = new System.Drawing.Size(221, 22);
            this.MMPersCalismaPlan.Text = "Personel Çalışma Planı";
            this.MMPersCalismaPlan.Click += new System.EventHandler(this.MMPersCalismaPlan_Click);
            // 
            // taleplerToolStripMenuItem
            // 
            this.taleplerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMDosyalar,
            this.MMTextNotlar});
            this.taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            this.taleplerToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.taleplerToolStripMenuItem.Text = "Döküman Yönetimi";
            // 
            // MMDosyalar
            // 
            this.MMDosyalar.Name = "MMDosyalar";
            this.MMDosyalar.Size = new System.Drawing.Size(131, 22);
            this.MMDosyalar.Text = "Dosyalar";
            this.MMDosyalar.Click += new System.EventHandler(this.MMDosyalar_Click);
            // 
            // MMTextNotlar
            // 
            this.MMTextNotlar.Name = "MMTextNotlar";
            this.MMTextNotlar.Size = new System.Drawing.Size(131, 22);
            this.MMTextNotlar.Text = "Text Notlar";
            this.MMTextNotlar.Click += new System.EventHandler(this.MMTextNotlar_Click);
            // 
            // özelMenülerToolStripMenuItem
            // 
            this.özelMenülerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taleplerimToolStripMenuItem,
            this.projelerimToolStripMenuItem,
            this.görevlerimToolStripMenuItem,
            this.onaylarımToolStripMenuItem});
            this.özelMenülerToolStripMenuItem.Name = "özelMenülerToolStripMenuItem";
            this.özelMenülerToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.özelMenülerToolStripMenuItem.Text = "Özel Menüler";
            // 
            // taleplerimToolStripMenuItem
            // 
            this.taleplerimToolStripMenuItem.Name = "taleplerimToolStripMenuItem";
            this.taleplerimToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.taleplerimToolStripMenuItem.Text = "Taleplerim";
            // 
            // projelerimToolStripMenuItem
            // 
            this.projelerimToolStripMenuItem.Name = "projelerimToolStripMenuItem";
            this.projelerimToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.projelerimToolStripMenuItem.Text = "Projelerim";
            // 
            // görevlerimToolStripMenuItem
            // 
            this.görevlerimToolStripMenuItem.Name = "görevlerimToolStripMenuItem";
            this.görevlerimToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.görevlerimToolStripMenuItem.Text = "Görevlerim";
            // 
            // onaylarımToolStripMenuItem
            // 
            this.onaylarımToolStripMenuItem.Name = "onaylarımToolStripMenuItem";
            this.onaylarımToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.onaylarımToolStripMenuItem.Text = "Onaylarım";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMGrupTanim,
            this.MMKullaniciTanim,
            this.MMMusteriler,
            this.MMCatiProje,
            this.MMProjeKaynaklar,
            this.MMProjeGorevTipleri,
            this.MMSaatUcreti,
            this.MMmeyerTanim});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // MMGrupTanim
            // 
            this.MMGrupTanim.Name = "MMGrupTanim";
            this.MMGrupTanim.Size = new System.Drawing.Size(204, 22);
            this.MMGrupTanim.Text = "Kullanıcı Grupları";
            this.MMGrupTanim.Click += new System.EventHandler(this.MMGrupTanim_Click);
            // 
            // MMKullaniciTanim
            // 
            this.MMKullaniciTanim.Name = "MMKullaniciTanim";
            this.MMKullaniciTanim.Size = new System.Drawing.Size(204, 22);
            this.MMKullaniciTanim.Text = "Kullanıcı Tanımları";
            this.MMKullaniciTanim.Click += new System.EventHandler(this.MMKullaniciTanim_Click);
            // 
            // MMMusteriler
            // 
            this.MMMusteriler.Name = "MMMusteriler";
            this.MMMusteriler.Size = new System.Drawing.Size(204, 22);
            this.MMMusteriler.Text = "Müşteriler";
            this.MMMusteriler.Click += new System.EventHandler(this.MMMusteriler_Click);
            // 
            // MMCatiProje
            // 
            this.MMCatiProje.Name = "MMCatiProje";
            this.MMCatiProje.Size = new System.Drawing.Size(204, 22);
            this.MMCatiProje.Text = "Çatı Projeler";
            this.MMCatiProje.Click += new System.EventHandler(this.MMCatiProje_Click);
            // 
            // MMProjeKaynaklar
            // 
            this.MMProjeKaynaklar.Name = "MMProjeKaynaklar";
            this.MMProjeKaynaklar.Size = new System.Drawing.Size(204, 22);
            this.MMProjeKaynaklar.Text = "Proje Kaynakları";
            this.MMProjeKaynaklar.Click += new System.EventHandler(this.MMProjeKaynaklar_Click);
            // 
            // MMProjeGorevTipleri
            // 
            this.MMProjeGorevTipleri.Name = "MMProjeGorevTipleri";
            this.MMProjeGorevTipleri.Size = new System.Drawing.Size(204, 22);
            this.MMProjeGorevTipleri.Text = "Proje Görev Tipleri";
            this.MMProjeGorevTipleri.Click += new System.EventHandler(this.MMProjeGorevTipleri_Click);
            // 
            // MMSaatUcreti
            // 
            this.MMSaatUcreti.Name = "MMSaatUcreti";
            this.MMSaatUcreti.Size = new System.Drawing.Size(204, 22);
            this.MMSaatUcreti.Text = "Saat Ücretleri";
            this.MMSaatUcreti.Click += new System.EventHandler(this.MMSaatUcreti_Click);
            // 
            // MMmeyerTanim
            // 
            this.MMmeyerTanim.Name = "MMmeyerTanim";
            this.MMmeyerTanim.Size = new System.Drawing.Size(204, 22);
            this.MMmeyerTanim.Text = "Meyer Bağlantı Tanımları";
            this.MMmeyerTanim.Click += new System.EventHandler(this.MMmeyerTanim_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMSistem,
            this.aboutMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // MMSistem
            // 
            this.MMSistem.Name = "MMSistem";
            this.MMSistem.Size = new System.Drawing.Size(152, 22);
            this.MMSistem.Text = "Sistem";
            this.MMSistem.Click += new System.EventHandler(this.MMSistem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "Hakkında";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.AutoScroll = true;
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 50);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(1008, 511);
            this.tabMenu.TabIndex = 2;
            this.tabMenu.Load += new System.EventHandler(this.tabMenu_Load);
            // 
            // MToolBox
            // 
            this.MToolBox.AutoSize = false;
            this.MToolBox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbDashBoard,
            this.tbProjeListesi,
            this.tbProjeZamanPlan});
            this.MToolBox.Location = new System.Drawing.Point(0, 24);
            this.MToolBox.Name = "MToolBox";
            this.MToolBox.Size = new System.Drawing.Size(1008, 26);
            this.MToolBox.TabIndex = 3;
            this.MToolBox.Text = "bC_ToolBox1";
            // 
            // tbDashBoard
            // 
            this.tbDashBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("tbDashBoard.Image")));
            this.tbDashBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDashBoard.Name = "tbDashBoard";
            this.tbDashBoard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tbDashBoard.Size = new System.Drawing.Size(33, 23);
            this.tbDashBoard.Text = "Dashoard";
            this.tbDashBoard.ToolTipText = "Dashoard ";
            this.tbDashBoard.Click += new System.EventHandler(this.tbDashBoard_Click);
            // 
            // tbProjeListesi
            // 
            this.tbProjeListesi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbProjeListesi.Image = ((System.Drawing.Image)(resources.GetObject("tbProjeListesi.Image")));
            this.tbProjeListesi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbProjeListesi.Name = "tbProjeListesi";
            this.tbProjeListesi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tbProjeListesi.Size = new System.Drawing.Size(33, 23);
            this.tbProjeListesi.Text = "Talepler";
            this.tbProjeListesi.Click += new System.EventHandler(this.tbProjeListesi_Click);
            // 
            // tbProjeZamanPlan
            // 
            this.tbProjeZamanPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbProjeZamanPlan.Image = global::ALPARGE.Properties.Resources.edit;
            this.tbProjeZamanPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbProjeZamanPlan.Name = "tbProjeZamanPlan";
            this.tbProjeZamanPlan.Size = new System.Drawing.Size(28, 23);
            this.tbProjeZamanPlan.Text = "toolStripButton1";
            this.tbProjeZamanPlan.ToolTipText = "Proje Bütçe Zaman Planlama";
            this.tbProjeZamanPlan.Click += new System.EventHandler(this.tbProjeZamanPlan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.MToolBox);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALPARGE PROJE YÖNETİM SİSTEMİ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MToolBox.ResumeLayout(false);
            this.MToolBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private Components.TabMenuEx tabMenu;
        private System.Windows.Forms.ToolStripMenuItem taleplerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMDosyalar;
        private System.Windows.Forms.ToolStripMenuItem projelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etkinliklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private BaseControls.BC_ToolBox MToolBox;
        private System.Windows.Forms.ToolStripButton tbDashBoard;
        private System.Windows.Forms.ToolStripMenuItem MMYeniTalep;
        private System.Windows.Forms.ToolStripMenuItem MMTalepOnaylama;
        private System.Windows.Forms.ToolStripMenuItem MMProjeSorumlusu;
        private System.Windows.Forms.ToolStripMenuItem MMButcePlanlama;
        private System.Windows.Forms.ToolStripMenuItem MMProjeOnay;
        private System.Windows.Forms.ToolStripMenuItem projeTakipVeTamamlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeKapatmaOnayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMTextNotlar;
        private System.Windows.Forms.ToolStripMenuItem özelMenülerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleplerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projelerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevlerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylarımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMDashboard;
        private System.Windows.Forms.ToolStripMenuItem MMCikis;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMGrupTanim;
        private System.Windows.Forms.ToolStripMenuItem MMKullaniciTanim;
        private System.Windows.Forms.ToolStripButton tbProjeListesi;
        private System.Windows.Forms.ToolStripMenuItem MMMusteriler;
        private System.Windows.Forms.ToolStripMenuItem MMCatiProje;
        private System.Windows.Forms.ToolStripMenuItem MMTumProjeler;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem MMToplantilar;
        private System.Windows.Forms.ToolStripMenuItem projeAnaliziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bütçeAnaliziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMProjeUyumSure;
        private System.Windows.Forms.ToolStripMenuItem MMKullaniciIslem;
        private System.Windows.Forms.ToolStripMenuItem MMProjeKaynaklar;
        private System.Windows.Forms.ToolStripMenuItem MMProjeGorevTipleri;
        private System.Windows.Forms.ToolStripButton tbProjeZamanPlan;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMSistem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMSaatUcreti;
        private System.Windows.Forms.ToolStripMenuItem MMmeyerTanim;
        private System.Windows.Forms.ToolStripMenuItem MMProjeTamamlanmaOran;
        private System.Windows.Forms.ToolStripMenuItem MMPersonelCalismaSure;
        private System.Windows.Forms.ToolStripMenuItem MMPersCalismaPlan;
    }
}

