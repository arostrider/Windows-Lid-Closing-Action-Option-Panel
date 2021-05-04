
namespace ClosingTheLid
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
            this.button_doNothing = new System.Windows.Forms.RadioButton();
            this.button_sleep = new System.Windows.Forms.RadioButton();
            this.button_hibernate = new System.Windows.Forms.RadioButton();
            this.button_shutdown = new System.Windows.Forms.RadioButton();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.checkbox_onBattery = new System.Windows.Forms.CheckBox();
            this.checkbox_pluggedIn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_doNothing
            // 
            this.button_doNothing.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_doNothing.ForeColor = System.Drawing.SystemColors.Control;
            this.button_doNothing.Location = new System.Drawing.Point(12, 12);
            this.button_doNothing.Name = "button_doNothing";
            this.button_doNothing.Size = new System.Drawing.Size(172, 40);
            this.button_doNothing.TabIndex = 0;
            this.button_doNothing.TabStop = true;
            this.button_doNothing.Text = "DO NOTHING";
            this.button_doNothing.UseVisualStyleBackColor = true;
            this.button_doNothing.MouseLeave += new System.EventHandler(this.button_doNothing_MouseLeave);
            this.button_doNothing.MouseHover += new System.EventHandler(this.button_doNothing_MouseHover);
            // 
            // button_sleep
            // 
            this.button_sleep.AutoSize = true;
            this.button_sleep.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sleep.ForeColor = System.Drawing.SystemColors.Control;
            this.button_sleep.Location = new System.Drawing.Point(12, 58);
            this.button_sleep.Name = "button_sleep";
            this.button_sleep.Size = new System.Drawing.Size(101, 39);
            this.button_sleep.TabIndex = 1;
            this.button_sleep.TabStop = true;
            this.button_sleep.Text = "SLEEP";
            this.button_sleep.UseVisualStyleBackColor = true;
            this.button_sleep.MouseLeave += new System.EventHandler(this.button_sleep_MouseLeave);
            this.button_sleep.MouseHover += new System.EventHandler(this.button_sleep_MouseHover);
            // 
            // button_hibernate
            // 
            this.button_hibernate.AutoSize = true;
            this.button_hibernate.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hibernate.ForeColor = System.Drawing.SystemColors.Control;
            this.button_hibernate.Location = new System.Drawing.Point(12, 100);
            this.button_hibernate.Name = "button_hibernate";
            this.button_hibernate.Size = new System.Drawing.Size(153, 39);
            this.button_hibernate.TabIndex = 2;
            this.button_hibernate.TabStop = true;
            this.button_hibernate.Text = "HIBERNATE";
            this.button_hibernate.UseVisualStyleBackColor = true;
            this.button_hibernate.MouseLeave += new System.EventHandler(this.button_hibernate_MouseLeave);
            this.button_hibernate.MouseHover += new System.EventHandler(this.button_hibernate_MouseHover);
            // 
            // button_shutdown
            // 
            this.button_shutdown.AutoSize = true;
            this.button_shutdown.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_shutdown.ForeColor = System.Drawing.SystemColors.Control;
            this.button_shutdown.Location = new System.Drawing.Point(12, 145);
            this.button_shutdown.Name = "button_shutdown";
            this.button_shutdown.Size = new System.Drawing.Size(163, 39);
            this.button_shutdown.TabIndex = 3;
            this.button_shutdown.TabStop = true;
            this.button_shutdown.Text = "SHUT DOWN";
            this.button_shutdown.UseVisualStyleBackColor = true;
            this.button_shutdown.MouseLeave += new System.EventHandler(this.button_shutdown_MouseLeave);
            this.button_shutdown.MouseHover += new System.EventHandler(this.button_shutdown_MouseHover);
            // 
            // button_apply
            // 
            this.button_apply.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apply.Location = new System.Drawing.Point(15, 190);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(160, 45);
            this.button_apply.TabIndex = 6;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(208, 190);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(160, 45);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            this.button_close.MouseHover += new System.EventHandler(this.button_close_MouseHover);
            // 
            // checkbox_onBattery
            // 
            this.checkbox_onBattery.AutoSize = true;
            this.checkbox_onBattery.Checked = true;
            this.checkbox_onBattery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_onBattery.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_onBattery.ForeColor = System.Drawing.SystemColors.Control;
            this.checkbox_onBattery.Location = new System.Drawing.Point(208, 101);
            this.checkbox_onBattery.Name = "checkbox_onBattery";
            this.checkbox_onBattery.Size = new System.Drawing.Size(148, 39);
            this.checkbox_onBattery.TabIndex = 5;
            this.checkbox_onBattery.Text = "on battery";
            this.checkbox_onBattery.UseVisualStyleBackColor = true;
            this.checkbox_onBattery.MouseLeave += new System.EventHandler(this.checkbox_onBattery_MouseLeave);
            this.checkbox_onBattery.MouseHover += new System.EventHandler(this.checkbox_onBattery_MouseHover);
            // 
            // checkbox_pluggedIn
            // 
            this.checkbox_pluggedIn.AutoSize = true;
            this.checkbox_pluggedIn.Checked = true;
            this.checkbox_pluggedIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_pluggedIn.Font = new System.Drawing.Font("VP Pixel Simplified DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_pluggedIn.ForeColor = System.Drawing.SystemColors.Control;
            this.checkbox_pluggedIn.Location = new System.Drawing.Point(208, 59);
            this.checkbox_pluggedIn.Name = "checkbox_pluggedIn";
            this.checkbox_pluggedIn.Size = new System.Drawing.Size(144, 39);
            this.checkbox_pluggedIn.TabIndex = 4;
            this.checkbox_pluggedIn.Text = "plugged in";
            this.checkbox_pluggedIn.UseVisualStyleBackColor = true;
            this.checkbox_pluggedIn.MouseLeave += new System.EventHandler(this.checkbox_pluggedIn_MouseLeave);
            this.checkbox_pluggedIn.MouseHover += new System.EventHandler(this.checkbox_pluggedIn_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(389, 247);
            this.Controls.Add(this.checkbox_pluggedIn);
            this.Controls.Add(this.checkbox_onBattery);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_shutdown);
            this.Controls.Add(this.button_hibernate);
            this.Controls.Add(this.button_sleep);
            this.Controls.Add(this.button_doNothing);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton button_doNothing;
        private System.Windows.Forms.RadioButton button_sleep;
        private System.Windows.Forms.RadioButton button_hibernate;
        private System.Windows.Forms.RadioButton button_shutdown;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.CheckBox checkbox_onBattery;
        private System.Windows.Forms.CheckBox checkbox_pluggedIn;
    }
}

