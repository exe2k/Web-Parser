
namespace Web_Parser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.URLText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ParseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ElementText = new System.Windows.Forms.TextBox();
            this.ElementInnerText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.incrementBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLText
            // 
            this.URLText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.URLText.Location = new System.Drawing.Point(12, 29);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(733, 34);
            this.URLText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // ParseBtn
            // 
            this.ParseBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ParseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ParseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParseBtn.Location = new System.Drawing.Point(852, 29);
            this.ParseBtn.Name = "ParseBtn";
            this.ParseBtn.Size = new System.Drawing.Size(142, 92);
            this.ParseBtn.TabIndex = 2;
            this.ParseBtn.Text = "Parse";
            this.ParseBtn.UseVisualStyleBackColor = false;
            this.ParseBtn.Click += new System.EventHandler(this.ParseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "StartTag<>";
            // 
            // ElementText
            // 
            this.ElementText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementText.Location = new System.Drawing.Point(15, 97);
            this.ElementText.Name = "ElementText";
            this.ElementText.Size = new System.Drawing.Size(388, 34);
            this.ElementText.TabIndex = 4;
            this.ElementText.Text = "DIV";
            // 
            // ElementInnerText
            // 
            this.ElementInnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementInnerText.Location = new System.Drawing.Point(441, 97);
            this.ElementInnerText.Name = "ElementInnerText";
            this.ElementInnerText.Size = new System.Drawing.Size(364, 34);
            this.ElementInnerText.TabIndex = 6;
            this.ElementInnerText.Text = "</";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "EndTag<>";
            // 
            // Output
            // 
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(15, 155);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(979, 485);
            this.Output.TabIndex = 7;
            this.Output.Text = "The result goes here...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(50, 20);
            this.StatusText.Text = "Ready";
            // 
            // incrementBtn
            // 
            this.incrementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incrementBtn.Location = new System.Drawing.Point(761, 29);
            this.incrementBtn.Name = "incrementBtn";
            this.incrementBtn.Size = new System.Drawing.Size(44, 33);
            this.incrementBtn.TabIndex = 9;
            this.incrementBtn.Text = "+1";
            this.incrementBtn.UseVisualStyleBackColor = true;
            this.incrementBtn.Click += new System.EventHandler(this.incrementBtn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 679);
            this.Controls.Add(this.incrementBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ElementInnerText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElementText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLText);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WEB Parser By Andreas Li v1.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ParseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ElementText;
        private System.Windows.Forms.TextBox ElementInnerText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.Button incrementBtn;
    }
}

