namespace SqliteManipulations.Forms
{
    partial class AddOrChangePersonForm
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
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSex = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEye = new System.Windows.Forms.TextBox();
            this.richTextBoxHobby = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstname.Location = new System.Drawing.Point(148, 36);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(173, 38);
            this.textBoxFirstname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия:";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastname.Location = new System.Drawing.Point(439, 36);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(173, 38);
            this.textBoxLastname.TabIndex = 2;
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDob.Location = new System.Drawing.Point(216, 115);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(183, 22);
            this.dateTimePickerDob.TabIndex = 4;
            this.dateTimePickerDob.ValueChanged += new System.EventHandler(this.dateTimePickerDob_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата рождения:";
            // 
            // checkBoxSex
            // 
            this.checkBoxSex.AutoSize = true;
            this.checkBoxSex.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSex.Location = new System.Drawing.Point(537, 110);
            this.checkBoxSex.Name = "checkBoxSex";
            this.checkBoxSex.Size = new System.Drawing.Size(75, 31);
            this.checkBoxSex.TabIndex = 6;
            this.checkBoxSex.Text = "Пол";
            this.checkBoxSex.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Улица:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(157, 164);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(173, 38);
            this.textBoxStreet.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(339, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дом:";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHouse.Location = new System.Drawing.Point(423, 164);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(189, 38);
            this.textBoxHouse.TabIndex = 9;
            this.textBoxHouse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxHouse_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Квартира:";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFlat.Location = new System.Drawing.Point(157, 225);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(173, 38);
            this.textBoxFlat.TabIndex = 11;
            this.textBoxFlat.TextChanged += new System.EventHandler(this.textBoxFlat_TextChanged);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "основная",
            "подготовительная",
            "суетная"});
            this.comboBoxGroup.Location = new System.Drawing.Point(425, 294);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(206, 35);
            this.comboBoxGroup.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(39, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Класс:";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClass.Location = new System.Drawing.Point(157, 291);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(173, 38);
            this.textBoxClass.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(331, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Группа:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(39, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Цвет глаз:";
            // 
            // textBoxEye
            // 
            this.textBoxEye.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEye.Location = new System.Drawing.Point(157, 346);
            this.textBoxEye.Name = "textBoxEye";
            this.textBoxEye.Size = new System.Drawing.Size(173, 38);
            this.textBoxEye.TabIndex = 17;
            // 
            // richTextBoxHobby
            // 
            this.richTextBoxHobby.Location = new System.Drawing.Point(157, 409);
            this.richTextBoxHobby.Name = "richTextBoxHobby";
            this.richTextBoxHobby.Size = new System.Drawing.Size(474, 127);
            this.richTextBoxHobby.TabIndex = 19;
            this.richTextBoxHobby.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(39, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "Хобби:";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPerson.Location = new System.Drawing.Point(44, 546);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(147, 57);
            this.buttonAddPerson.TabIndex = 21;
            this.buttonAddPerson.Text = "Добавить";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(415, 114);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 27);
            this.labelAge.TabIndex = 22;
            // 
            // AddOrChangePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 615);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBoxHobby);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxEye);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.checkBoxSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstname);
            this.Name = "AddOrChangePersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEye;
        private System.Windows.Forms.RichTextBox richTextBoxHobby;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Label labelAge;
    }
}