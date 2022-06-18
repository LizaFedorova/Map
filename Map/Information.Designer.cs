
namespace Map
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMetall = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.buttonPlastic = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.textBoxMetall = new System.Windows.Forms.TextBox();
            this.textBoxPlastic = new System.Windows.Forms.TextBox();
            this.buttonPlasticMarkers = new System.Windows.Forms.Button();
            this.pictureTime = new System.Windows.Forms.PictureBox();
            this.picturePlasticMarkers = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlasticMarkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(376, 1055);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 76);
            this.label1.TabIndex = 11;
            this.label1.Text = "Информация об \r\nотходах\r\n";
            // 
            // buttonMetall
            // 
            this.buttonMetall.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonMetall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMetall.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMetall.Location = new System.Drawing.Point(73, 160);
            this.buttonMetall.Name = "buttonMetall";
            this.buttonMetall.Size = new System.Drawing.Size(227, 55);
            this.buttonMetall.TabIndex = 12;
            this.buttonMetall.Text = "Металлолом";
            this.buttonMetall.UseVisualStyleBackColor = false;
            this.buttonMetall.Click += new System.EventHandler(this.buttonMetall_Click);
            // 
            // buttonTime
            // 
            this.buttonTime.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTime.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTime.Location = new System.Drawing.Point(73, 484);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(227, 55);
            this.buttonTime.TabIndex = 13;
            this.buttonTime.Text = "Длительность разложения отходов";
            this.buttonTime.UseVisualStyleBackColor = false;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // buttonPlastic
            // 
            this.buttonPlastic.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPlastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlastic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlastic.Location = new System.Drawing.Point(73, 266);
            this.buttonPlastic.Name = "buttonPlastic";
            this.buttonPlastic.Size = new System.Drawing.Size(227, 55);
            this.buttonPlastic.TabIndex = 14;
            this.buttonPlastic.Text = "Пластик";
            this.buttonPlastic.UseVisualStyleBackColor = false;
            this.buttonPlastic.Click += new System.EventHandler(this.buttonPlastic_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.Location = new System.Drawing.Point(73, 623);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(227, 49);
            this.buttonMenu.TabIndex = 15;
            this.buttonMenu.Text = "В меню\r\n";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // textBoxMetall
            // 
            this.textBoxMetall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMetall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMetall.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMetall.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMetall.Location = new System.Drawing.Point(398, 116);
            this.textBoxMetall.Multiline = true;
            this.textBoxMetall.Name = "textBoxMetall";
            this.textBoxMetall.ReadOnly = true;
            this.textBoxMetall.Size = new System.Drawing.Size(772, 556);
            this.textBoxMetall.TabIndex = 17;
            this.textBoxMetall.Text = resources.GetString("textBoxMetall.Text");
            this.textBoxMetall.Visible = false;
            // 
            // textBoxPlastic
            // 
            this.textBoxPlastic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPlastic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlastic.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPlastic.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlastic.Location = new System.Drawing.Point(398, 17);
            this.textBoxPlastic.Multiline = true;
            this.textBoxPlastic.Name = "textBoxPlastic";
            this.textBoxPlastic.Size = new System.Drawing.Size(763, 762);
            this.textBoxPlastic.TabIndex = 18;
            this.textBoxPlastic.Text = resources.GetString("textBoxPlastic.Text");
            this.textBoxPlastic.Visible = false;
            // 
            // buttonPlasticMarkers
            // 
            this.buttonPlasticMarkers.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPlasticMarkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlasticMarkers.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlasticMarkers.Location = new System.Drawing.Point(73, 376);
            this.buttonPlasticMarkers.Name = "buttonPlasticMarkers";
            this.buttonPlasticMarkers.Size = new System.Drawing.Size(227, 55);
            this.buttonPlasticMarkers.TabIndex = 19;
            this.buttonPlasticMarkers.Text = "Маркировка пластика";
            this.buttonPlasticMarkers.UseVisualStyleBackColor = false;
            this.buttonPlasticMarkers.Click += new System.EventHandler(this.buttonPlasticMarkers_Click);
            // 
            // pictureTime
            // 
            this.pictureTime.Image = global::Map.Properties.Resources.мусор_как_долго_разлагается;
            this.pictureTime.Location = new System.Drawing.Point(373, 0);
            this.pictureTime.Name = "pictureTime";
            this.pictureTime.Size = new System.Drawing.Size(809, 849);
            this.pictureTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTime.TabIndex = 21;
            this.pictureTime.TabStop = false;
            this.pictureTime.Visible = false;
            // 
            // picturePlasticMarkers
            // 
            this.picturePlasticMarkers.Image = global::Map.Properties.Resources.маркировка;
            this.picturePlasticMarkers.Location = new System.Drawing.Point(373, 0);
            this.picturePlasticMarkers.Name = "picturePlasticMarkers";
            this.picturePlasticMarkers.Size = new System.Drawing.Size(809, 849);
            this.picturePlasticMarkers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlasticMarkers.TabIndex = 20;
            this.picturePlasticMarkers.TabStop = false;
            this.picturePlasticMarkers.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Map.Properties.Resources.ee2131f3ca3be41f419c85cf2a61fea3;
            this.pictureBox2.Location = new System.Drawing.Point(73, 655);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Map.Properties.Resources._10818c11b7bf2f08a743ab31bec6273c;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.pictureTime);
            this.Controls.Add(this.picturePlasticMarkers);
            this.Controls.Add(this.buttonPlasticMarkers);
            this.Controls.Add(this.textBoxPlastic);
            this.Controls.Add(this.textBoxMetall);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonPlastic);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.buttonMetall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.DoubleBuffered = true;
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlasticMarkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMetall;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.Button buttonPlastic;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxMetall;
        private System.Windows.Forms.TextBox textBoxPlastic;
        private System.Windows.Forms.Button buttonPlasticMarkers;
        private System.Windows.Forms.PictureBox picturePlasticMarkers;
        private System.Windows.Forms.PictureBox pictureTime;
    }
}