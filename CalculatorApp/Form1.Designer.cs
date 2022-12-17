namespace CalculatorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNum1 = new System.Windows.Forms.TextBox();
            this.TextBoxNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.lableResult = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.labelResultInfo = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Button();
            this.dis = new System.Windows.Forms.Button();
            this.mount = new System.Windows.Forms.Button();
            this.ost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CalculatorApp.v.1.0";
            // 
            // TextBoxNum1
            // 
            this.TextBoxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNum1.Location = new System.Drawing.Point(168, 186);
            this.TextBoxNum1.Name = "TextBoxNum1";
            this.TextBoxNum1.Size = new System.Drawing.Size(200, 35);
            this.TextBoxNum1.TabIndex = 1;
            // 
            // TextBoxNum2
            // 
            this.TextBoxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNum2.Location = new System.Drawing.Point(168, 254);
            this.TextBoxNum2.Name = "TextBoxNum2";
            this.TextBoxNum2.Size = new System.Drawing.Size(200, 35);
            this.TextBoxNum2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Первое число:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Второе число:";
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(462, 186);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(101, 63);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // lableResult
            // 
            this.lableResult.AutoSize = true;
            this.lableResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableResult.Location = new System.Drawing.Point(177, 384);
            this.lableResult.Name = "lableResult";
            this.lableResult.Size = new System.Drawing.Size(0, 32);
            this.lableResult.TabIndex = 6;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(27, 384);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(144, 29);
            this.Result.TabIndex = 7;
            this.Result.Text = "Результат: ";
            // 
            // labelResultInfo
            // 
            this.labelResultInfo.AutoSize = true;
            this.labelResultInfo.Location = new System.Drawing.Point(183, 458);
            this.labelResultInfo.Name = "labelResultInfo";
            this.labelResultInfo.Size = new System.Drawing.Size(0, 20);
            this.labelResultInfo.TabIndex = 8;
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub.Location = new System.Drawing.Point(612, 186);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(101, 63);
            this.sub.TabIndex = 9;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // dis
            // 
            this.dis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dis.Location = new System.Drawing.Point(462, 264);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(101, 63);
            this.dis.TabIndex = 10;
            this.dis.Text = "/";
            this.dis.UseVisualStyleBackColor = false;
            this.dis.Click += new System.EventHandler(this.dis_Click);
            // 
            // mount
            // 
            this.mount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mount.Location = new System.Drawing.Point(612, 264);
            this.mount.Name = "mount";
            this.mount.Size = new System.Drawing.Size(101, 63);
            this.mount.TabIndex = 11;
            this.mount.Text = "*";
            this.mount.UseVisualStyleBackColor = false;
            this.mount.Click += new System.EventHandler(this.mount_Click);
            // 
            // ost
            // 
            this.ost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ost.Location = new System.Drawing.Point(612, 333);
            this.ost.Name = "ost";
            this.ost.Size = new System.Drawing.Size(101, 63);
            this.ost.TabIndex = 12;
            this.ost.Text = "%";
            this.ost.UseVisualStyleBackColor = false;
            this.ost.Click += new System.EventHandler(this.ost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 516);
            this.Controls.Add(this.ost);
            this.Controls.Add(this.mount);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.labelResultInfo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.lableResult);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNum2);
            this.Controls.Add(this.TextBoxNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CalculatorApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNum1;
        private System.Windows.Forms.TextBox TextBoxNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label lableResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label labelResultInfo;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button dis;
        private System.Windows.Forms.Button mount;
        private System.Windows.Forms.Button ost;
    }
}

