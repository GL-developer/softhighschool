
namespace softwarehighschool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label_runtime = new System.Windows.Forms.Label();
            this.label_runrate = new System.Windows.Forms.Label();
            this.label_downtime = new System.Windows.Forms.Label();
            this.label_downrate = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_counter = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connection = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ip
            // 
            this.label_ip.BackColor = System.Drawing.Color.Transparent;
            this.label_ip.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ip.ForeColor = System.Drawing.Color.White;
            this.label_ip.Location = new System.Drawing.Point(35, 103);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(55, 33);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP";
            this.label_ip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_port
            // 
            this.label_port.BackColor = System.Drawing.Color.Transparent;
            this.label_port.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_port.ForeColor = System.Drawing.Color.White;
            this.label_port.Location = new System.Drawing.Point(35, 136);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(55, 31);
            this.label_port.TabIndex = 1;
            this.label_port.Text = "Port";
            this.label_port.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_runtime
            // 
            this.label_runtime.BackColor = System.Drawing.Color.Transparent;
            this.label_runtime.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_runtime.ForeColor = System.Drawing.Color.White;
            this.label_runtime.Location = new System.Drawing.Point(118, 281);
            this.label_runtime.Name = "label_runtime";
            this.label_runtime.Size = new System.Drawing.Size(134, 51);
            this.label_runtime.TabIndex = 2;
            this.label_runtime.Text = "0";
            this.label_runtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_runrate
            // 
            this.label_runrate.BackColor = System.Drawing.Color.Transparent;
            this.label_runrate.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_runrate.ForeColor = System.Drawing.Color.White;
            this.label_runrate.Location = new System.Drawing.Point(118, 332);
            this.label_runrate.Name = "label_runrate";
            this.label_runrate.Size = new System.Drawing.Size(134, 54);
            this.label_runrate.TabIndex = 3;
            this.label_runrate.Text = "0";
            this.label_runrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_downtime
            // 
            this.label_downtime.BackColor = System.Drawing.Color.Transparent;
            this.label_downtime.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_downtime.ForeColor = System.Drawing.Color.White;
            this.label_downtime.Location = new System.Drawing.Point(332, 281);
            this.label_downtime.Name = "label_downtime";
            this.label_downtime.Size = new System.Drawing.Size(136, 51);
            this.label_downtime.TabIndex = 4;
            this.label_downtime.Text = "0";
            this.label_downtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_downrate
            // 
            this.label_downrate.BackColor = System.Drawing.Color.Transparent;
            this.label_downrate.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_downrate.ForeColor = System.Drawing.Color.White;
            this.label_downrate.Location = new System.Drawing.Point(332, 331);
            this.label_downrate.Name = "label_downrate";
            this.label_downrate.Size = new System.Drawing.Size(136, 54);
            this.label_downrate.TabIndex = 5;
            this.label_downrate.Text = "0";
            this.label_downrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_state
            // 
            this.label_state.BackColor = System.Drawing.Color.Transparent;
            this.label_state.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_state.ForeColor = System.Drawing.Color.White;
            this.label_state.Location = new System.Drawing.Point(494, 281);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(216, 51);
            this.label_state.TabIndex = 6;
            this.label_state.Text = "-";
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_counter
            // 
            this.label_counter.BackColor = System.Drawing.Color.Transparent;
            this.label_counter.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_counter.ForeColor = System.Drawing.Color.White;
            this.label_counter.Location = new System.Drawing.Point(577, 341);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(133, 56);
            this.label_counter.TabIndex = 7;
            this.label_counter.Text = "0";
            this.label_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(106, 110);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 23);
            this.textBox_ip.TabIndex = 8;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(106, 142);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 23);
            this.textBox_port.TabIndex = 9;
            // 
            // button_connection
            // 
            this.button_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(143)))));
            this.button_connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connection.FlatAppearance.BorderSize = 0;
            this.button_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connection.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_connection.ForeColor = System.Drawing.Color.White;
            this.button_connection.Location = new System.Drawing.Point(35, 175);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(171, 38);
            this.button_connection.TabIndex = 10;
            this.button_connection.Text = "이더넷 연결";
            this.button_connection.UseVisualStyleBackColor = false;
            this.button_connection.Click += new System.EventHandler(this.button_connection_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(143)))));
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(224, 110);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(104, 38);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "가동 시작";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(143)))));
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stop.FlatAppearance.BorderSize = 0;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_stop.ForeColor = System.Drawing.Color.White;
            this.button_stop.Location = new System.Drawing.Point(347, 109);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(115, 39);
            this.button_stop.TabIndex = 12;
            this.button_stop.Text = "가동 정지";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_down
            // 
            this.button_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(143)))));
            this.button_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_down.FlatAppearance.BorderSize = 0;
            this.button_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_down.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_down.ForeColor = System.Drawing.Color.White;
            this.button_down.Location = new System.Drawing.Point(224, 165);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(104, 33);
            this.button_down.TabIndex = 13;
            this.button_down.Text = "비가동 시작";
            this.button_down.UseVisualStyleBackColor = false;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(143)))));
            this.button_reset.FlatAppearance.BorderSize = 0;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(347, 165);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(115, 33);
            this.button_reset.TabIndex = 14;
            this.button_reset.Text = "데이터 리셋";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::softwarehighschool.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(736, 407);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_connection);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label_downrate);
            this.Controls.Add(this.label_downtime);
            this.Controls.Add(this.label_runrate);
            this.Controls.Add(this.label_runtime);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Name = "MainForm";
            this.Text = "softwarehighschool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_runtime;
        private System.Windows.Forms.Label label_runrate;
        private System.Windows.Forms.Label label_downtime;
        private System.Windows.Forms.Label label_downrate;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_reset;
    }
}

