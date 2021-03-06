
namespace FontAwesomeExamples
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontAwesomeButton1 = new FontAwesomeControls.FontAwesomeButton();
            this.fontAwesomeLabel1 = new FontAwesomeControls.FontAwesomeLabel();
            this.fontAwesomePicture1 = new FontAwesomeControls.FontAwesomePicture();
            this.fontAwesomeSingle1 = new FontAwesomeControls.FontAwesomeSingle();
            ((System.ComponentModel.ISupportInitialize)(this.fontAwesomePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // fontAwesomeButton1
            // 
            this.fontAwesomeButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fontAwesomeButton1.IconName = "home";
            this.fontAwesomeButton1.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            this.fontAwesomeButton1.IconWidth = 25;
            this.fontAwesomeButton1.Image = ((System.Drawing.Image)(resources.GetObject("fontAwesomeButton1.Image")));
            this.fontAwesomeButton1.Location = new System.Drawing.Point(42, 293);
            this.fontAwesomeButton1.Name = "fontAwesomeButton1";
            this.fontAwesomeButton1.Size = new System.Drawing.Size(139, 71);
            this.fontAwesomeButton1.TabIndex = 0;
            this.fontAwesomeButton1.Text = "fontAwesomeButton1";
            this.fontAwesomeButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fontAwesomeButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fontAwesomeButton1.UseVisualStyleBackColor = true;
            // 
            // fontAwesomeLabel1
            // 
            this.fontAwesomeLabel1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fontAwesomeLabel1.IconName = "check";
            this.fontAwesomeLabel1.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            this.fontAwesomeLabel1.IconWidth = 20;
            this.fontAwesomeLabel1.Image = ((System.Drawing.Image)(resources.GetObject("fontAwesomeLabel1.Image")));
            this.fontAwesomeLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fontAwesomeLabel1.Location = new System.Drawing.Point(134, 188);
            this.fontAwesomeLabel1.Name = "fontAwesomeLabel1";
            this.fontAwesomeLabel1.Size = new System.Drawing.Size(144, 33);
            this.fontAwesomeLabel1.TabIndex = 1;
            this.fontAwesomeLabel1.Text = "fontAwesomeLabel1";
            this.fontAwesomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fontAwesomePicture1
            // 
            this.fontAwesomePicture1.BackgroundIconColor = System.Drawing.Color.Gold;
            this.fontAwesomePicture1.BackgroundIconName = "circle";
            this.fontAwesomePicture1.BackgroundIconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            this.fontAwesomePicture1.BackgroundIconWidth = 200;
            this.fontAwesomePicture1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fontAwesomePicture1.BackgroundImage")));
            this.fontAwesomePicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fontAwesomePicture1.IconColor = System.Drawing.Color.White;
            this.fontAwesomePicture1.IconName = "star";
            this.fontAwesomePicture1.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            this.fontAwesomePicture1.IconWidth = 50;
            this.fontAwesomePicture1.Image = ((System.Drawing.Image)(resources.GetObject("fontAwesomePicture1.Image")));
            this.fontAwesomePicture1.Location = new System.Drawing.Point(256, 280);
            this.fontAwesomePicture1.Name = "fontAwesomePicture1";
            this.fontAwesomePicture1.Size = new System.Drawing.Size(96, 97);
            this.fontAwesomePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fontAwesomePicture1.TabIndex = 2;
            this.fontAwesomePicture1.TabStop = false;
            // 
            // fontAwesomeSingle1
            // 
            this.fontAwesomeSingle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fontAwesomeSingle1.BackgroundImage")));
            this.fontAwesomeSingle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fontAwesomeSingle1.IconColor = System.Drawing.Color.DodgerBlue;
            this.fontAwesomeSingle1.IconName = "users";
            this.fontAwesomeSingle1.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Duotone;
            this.fontAwesomeSingle1.Location = new System.Drawing.Point(121, 33);
            this.fontAwesomeSingle1.Name = "fontAwesomeSingle1";
            this.fontAwesomeSingle1.Size = new System.Drawing.Size(166, 133);
            this.fontAwesomeSingle1.TabIndex = 3;
            this.fontAwesomeSingle1.Text = "fontAwesomeSingle1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.fontAwesomeSingle1);
            this.Controls.Add(this.fontAwesomePicture1);
            this.Controls.Add(this.fontAwesomeLabel1);
            this.Controls.Add(this.fontAwesomeButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fontAwesomePicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesomeControls.FontAwesomeButton fontAwesomeButton1;
        private FontAwesomeControls.FontAwesomeLabel fontAwesomeLabel1;
        private FontAwesomeControls.FontAwesomePicture fontAwesomePicture1;
        private FontAwesomeControls.FontAwesomeSingle fontAwesomeSingle1;
    }
}