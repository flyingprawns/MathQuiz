
namespace WindowsForms_MathQuiz
{
    partial class mathQuiz_Forms
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
            this.time_Label = new System.Windows.Forms.Label();
            this.timeText_Label = new System.Windows.Forms.Label();
            this.plusLeft_Label = new System.Windows.Forms.Label();
            this.plusRight_Label = new System.Windows.Forms.Label();
            this.plusPlus_Label = new System.Windows.Forms.Label();
            this.plusEquals_Label = new System.Windows.Forms.Label();
            this.plusSum_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minusDifference_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minusEquals_Label = new System.Windows.Forms.Label();
            this.minusMinus_Label = new System.Windows.Forms.Label();
            this.minusRight_Label = new System.Windows.Forms.Label();
            this.minusLeft_Label = new System.Windows.Forms.Label();
            this.multProduct_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.multEquals_Label = new System.Windows.Forms.Label();
            this.multMult_Label = new System.Windows.Forms.Label();
            this.multRight_Label = new System.Windows.Forms.Label();
            this.multLeft_Label = new System.Windows.Forms.Label();
            this.divQuotient_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.divEquals_Label = new System.Windows.Forms.Label();
            this.divDiv_Label = new System.Windows.Forms.Label();
            this.divRight_Label = new System.Windows.Forms.Label();
            this.divLeft_Label = new System.Windows.Forms.Label();
            this.startQuiz_Button = new System.Windows.Forms.Button();
            this.time_Timer = new System.Windows.Forms.Timer(this.components);
            this.tip_CheckBox = new System.Windows.Forms.CheckBox();
            this.tip_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plusSum_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusDifference_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multProduct_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divQuotient_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // time_Label
            // 
            this.time_Label.BackColor = System.Drawing.SystemColors.Control;
            this.time_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Label.Location = new System.Drawing.Point(259, 9);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(200, 30);
            this.time_Label.TabIndex = 0;
            // 
            // timeText_Label
            // 
            this.timeText_Label.AutoSize = true;
            this.timeText_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText_Label.Location = new System.Drawing.Point(146, 10);
            this.timeText_Label.Name = "timeText_Label";
            this.timeText_Label.Size = new System.Drawing.Size(107, 25);
            this.timeText_Label.TabIndex = 1;
            this.timeText_Label.Text = "Time Left:";
            // 
            // plusLeft_Label
            // 
            this.plusLeft_Label.Location = new System.Drawing.Point(50, 63);
            this.plusLeft_Label.Name = "plusLeft_Label";
            this.plusLeft_Label.Size = new System.Drawing.Size(60, 50);
            this.plusLeft_Label.TabIndex = 2;
            this.plusLeft_Label.Text = "?";
            this.plusLeft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRight_Label
            // 
            this.plusRight_Label.Location = new System.Drawing.Point(145, 63);
            this.plusRight_Label.Name = "plusRight_Label";
            this.plusRight_Label.Size = new System.Drawing.Size(60, 50);
            this.plusRight_Label.TabIndex = 3;
            this.plusRight_Label.Text = "?";
            this.plusRight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusPlus_Label
            // 
            this.plusPlus_Label.Location = new System.Drawing.Point(97, 63);
            this.plusPlus_Label.Name = "plusPlus_Label";
            this.plusPlus_Label.Size = new System.Drawing.Size(60, 50);
            this.plusPlus_Label.TabIndex = 4;
            this.plusPlus_Label.Text = "+";
            this.plusPlus_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusEquals_Label
            // 
            this.plusEquals_Label.Location = new System.Drawing.Point(197, 63);
            this.plusEquals_Label.Name = "plusEquals_Label";
            this.plusEquals_Label.Size = new System.Drawing.Size(60, 50);
            this.plusEquals_Label.TabIndex = 5;
            this.plusEquals_Label.Text = "=";
            this.plusEquals_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSum_NumericUpDown
            // 
            this.plusSum_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSum_NumericUpDown.Location = new System.Drawing.Point(272, 68);
            this.plusSum_NumericUpDown.Name = "plusSum_NumericUpDown";
            this.plusSum_NumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.plusSum_NumericUpDown.TabIndex = 2;
            this.plusSum_NumericUpDown.Enter += new System.EventHandler(this.answer_NumericUpDown_Enter);
            // 
            // minusDifference_NumericUpDown
            // 
            this.minusDifference_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusDifference_NumericUpDown.Location = new System.Drawing.Point(272, 126);
            this.minusDifference_NumericUpDown.Name = "minusDifference_NumericUpDown";
            this.minusDifference_NumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.minusDifference_NumericUpDown.TabIndex = 3;
            this.minusDifference_NumericUpDown.Enter += new System.EventHandler(this.answer_NumericUpDown_Enter);
            // 
            // minusEquals_Label
            // 
            this.minusEquals_Label.Location = new System.Drawing.Point(197, 121);
            this.minusEquals_Label.Name = "minusEquals_Label";
            this.minusEquals_Label.Size = new System.Drawing.Size(60, 50);
            this.minusEquals_Label.TabIndex = 10;
            this.minusEquals_Label.Text = "=";
            this.minusEquals_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusMinus_Label
            // 
            this.minusMinus_Label.Location = new System.Drawing.Point(97, 121);
            this.minusMinus_Label.Name = "minusMinus_Label";
            this.minusMinus_Label.Size = new System.Drawing.Size(60, 50);
            this.minusMinus_Label.TabIndex = 9;
            this.minusMinus_Label.Text = "-";
            this.minusMinus_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRight_Label
            // 
            this.minusRight_Label.Location = new System.Drawing.Point(145, 121);
            this.minusRight_Label.Name = "minusRight_Label";
            this.minusRight_Label.Size = new System.Drawing.Size(60, 50);
            this.minusRight_Label.TabIndex = 8;
            this.minusRight_Label.Text = "?";
            this.minusRight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeft_Label
            // 
            this.minusLeft_Label.Location = new System.Drawing.Point(50, 121);
            this.minusLeft_Label.Name = "minusLeft_Label";
            this.minusLeft_Label.Size = new System.Drawing.Size(60, 50);
            this.minusLeft_Label.TabIndex = 7;
            this.minusLeft_Label.Text = "?";
            this.minusLeft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multProduct_NumericUpDown
            // 
            this.multProduct_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multProduct_NumericUpDown.Location = new System.Drawing.Point(272, 178);
            this.multProduct_NumericUpDown.Name = "multProduct_NumericUpDown";
            this.multProduct_NumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.multProduct_NumericUpDown.TabIndex = 4;
            this.multProduct_NumericUpDown.Enter += new System.EventHandler(this.answer_NumericUpDown_Enter);
            // 
            // multEquals_Label
            // 
            this.multEquals_Label.Location = new System.Drawing.Point(197, 173);
            this.multEquals_Label.Name = "multEquals_Label";
            this.multEquals_Label.Size = new System.Drawing.Size(60, 50);
            this.multEquals_Label.TabIndex = 15;
            this.multEquals_Label.Text = "=";
            this.multEquals_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multMult_Label
            // 
            this.multMult_Label.Location = new System.Drawing.Point(97, 173);
            this.multMult_Label.Name = "multMult_Label";
            this.multMult_Label.Size = new System.Drawing.Size(60, 50);
            this.multMult_Label.TabIndex = 14;
            this.multMult_Label.Text = "X";
            this.multMult_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multRight_Label
            // 
            this.multRight_Label.Location = new System.Drawing.Point(145, 173);
            this.multRight_Label.Name = "multRight_Label";
            this.multRight_Label.Size = new System.Drawing.Size(60, 50);
            this.multRight_Label.TabIndex = 13;
            this.multRight_Label.Text = "?";
            this.multRight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multLeft_Label
            // 
            this.multLeft_Label.Location = new System.Drawing.Point(50, 173);
            this.multLeft_Label.Name = "multLeft_Label";
            this.multLeft_Label.Size = new System.Drawing.Size(60, 50);
            this.multLeft_Label.TabIndex = 12;
            this.multLeft_Label.Text = "?";
            this.multLeft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divQuotient_NumericUpDown
            // 
            this.divQuotient_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divQuotient_NumericUpDown.Location = new System.Drawing.Point(272, 231);
            this.divQuotient_NumericUpDown.Name = "divQuotient_NumericUpDown";
            this.divQuotient_NumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.divQuotient_NumericUpDown.TabIndex = 5;
            this.divQuotient_NumericUpDown.Enter += new System.EventHandler(this.answer_NumericUpDown_Enter);
            // 
            // divEquals_Label
            // 
            this.divEquals_Label.Location = new System.Drawing.Point(197, 220);
            this.divEquals_Label.Name = "divEquals_Label";
            this.divEquals_Label.Size = new System.Drawing.Size(60, 63);
            this.divEquals_Label.TabIndex = 20;
            this.divEquals_Label.Text = "=";
            this.divEquals_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divDiv_Label
            // 
            this.divDiv_Label.Location = new System.Drawing.Point(97, 220);
            this.divDiv_Label.Name = "divDiv_Label";
            this.divDiv_Label.Size = new System.Drawing.Size(60, 63);
            this.divDiv_Label.TabIndex = 19;
            this.divDiv_Label.Text = "/";
            this.divDiv_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRight_Label
            // 
            this.divRight_Label.Location = new System.Drawing.Point(145, 220);
            this.divRight_Label.Name = "divRight_Label";
            this.divRight_Label.Size = new System.Drawing.Size(60, 63);
            this.divRight_Label.TabIndex = 18;
            this.divRight_Label.Text = "?";
            this.divRight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeft_Label
            // 
            this.divLeft_Label.Location = new System.Drawing.Point(50, 220);
            this.divLeft_Label.Name = "divLeft_Label";
            this.divLeft_Label.Size = new System.Drawing.Size(60, 63);
            this.divLeft_Label.TabIndex = 17;
            this.divLeft_Label.Text = "?";
            this.divLeft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startQuiz_Button
            // 
            this.startQuiz_Button.AutoSize = true;
            this.startQuiz_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startQuiz_Button.Location = new System.Drawing.Point(148, 286);
            this.startQuiz_Button.Name = "startQuiz_Button";
            this.startQuiz_Button.Size = new System.Drawing.Size(157, 34);
            this.startQuiz_Button.TabIndex = 1;
            this.startQuiz_Button.Text = "Start the quiz!!!!!!";
            this.startQuiz_Button.UseVisualStyleBackColor = true;
            this.startQuiz_Button.Click += new System.EventHandler(this.startQuiz_Button_Click);
            // 
            // time_Timer
            // 
            this.time_Timer.Interval = 1000;
            this.time_Timer.Tick += new System.EventHandler(this.time_Timer_Tick);
            // 
            // tip_CheckBox
            // 
            this.tip_CheckBox.AutoSize = true;
            this.tip_CheckBox.Checked = true;
            this.tip_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tip_CheckBox.Location = new System.Drawing.Point(34, 338);
            this.tip_CheckBox.Name = "tip_CheckBox";
            this.tip_CheckBox.Size = new System.Drawing.Size(88, 17);
            this.tip_CheckBox.TabIndex = 21;
            this.tip_CheckBox.Text = "Show pro tip:";
            this.tip_CheckBox.UseVisualStyleBackColor = true;
            this.tip_CheckBox.CheckedChanged += new System.EventHandler(this.tip_CheckBox_CheckedChanged);
            // 
            // tip_Label
            // 
            this.tip_Label.AutoSize = true;
            this.tip_Label.Location = new System.Drawing.Point(120, 339);
            this.tip_Label.Name = "tip_Label";
            this.tip_Label.Size = new System.Drawing.Size(185, 13);
            this.tip_Label.TabIndex = 22;
            this.tip_Label.Text = "Use the \'Tab\' key for easy navigation!";
            // 
            // mathQuiz_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tip_Label);
            this.Controls.Add(this.tip_CheckBox);
            this.Controls.Add(this.startQuiz_Button);
            this.Controls.Add(this.divQuotient_NumericUpDown);
            this.Controls.Add(this.divEquals_Label);
            this.Controls.Add(this.divDiv_Label);
            this.Controls.Add(this.divRight_Label);
            this.Controls.Add(this.divLeft_Label);
            this.Controls.Add(this.multProduct_NumericUpDown);
            this.Controls.Add(this.multEquals_Label);
            this.Controls.Add(this.multMult_Label);
            this.Controls.Add(this.multRight_Label);
            this.Controls.Add(this.multLeft_Label);
            this.Controls.Add(this.minusDifference_NumericUpDown);
            this.Controls.Add(this.minusEquals_Label);
            this.Controls.Add(this.minusMinus_Label);
            this.Controls.Add(this.minusRight_Label);
            this.Controls.Add(this.minusLeft_Label);
            this.Controls.Add(this.plusSum_NumericUpDown);
            this.Controls.Add(this.plusEquals_Label);
            this.Controls.Add(this.plusPlus_Label);
            this.Controls.Add(this.plusRight_Label);
            this.Controls.Add(this.plusLeft_Label);
            this.Controls.Add(this.timeText_Label);
            this.Controls.Add(this.time_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mathQuiz_Forms";
            this.Text = "Math Quiz!";
            ((System.ComponentModel.ISupportInitialize)(this.plusSum_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusDifference_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multProduct_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divQuotient_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.Label timeText_Label;
        private System.Windows.Forms.Label plusLeft_Label;
        private System.Windows.Forms.Label plusRight_Label;
        private System.Windows.Forms.Label plusPlus_Label;
        private System.Windows.Forms.Label plusEquals_Label;
        private System.Windows.Forms.NumericUpDown plusSum_NumericUpDown;
        private System.Windows.Forms.NumericUpDown minusDifference_NumericUpDown;
        private System.Windows.Forms.Label minusEquals_Label;
        private System.Windows.Forms.Label minusMinus_Label;
        private System.Windows.Forms.Label minusRight_Label;
        private System.Windows.Forms.Label minusLeft_Label;
        private System.Windows.Forms.NumericUpDown multProduct_NumericUpDown;
        private System.Windows.Forms.Label multEquals_Label;
        private System.Windows.Forms.Label multMult_Label;
        private System.Windows.Forms.Label multRight_Label;
        private System.Windows.Forms.Label multLeft_Label;
        private System.Windows.Forms.NumericUpDown divQuotient_NumericUpDown;
        private System.Windows.Forms.Label divEquals_Label;
        private System.Windows.Forms.Label divDiv_Label;
        private System.Windows.Forms.Label divRight_Label;
        private System.Windows.Forms.Label divLeft_Label;
        private System.Windows.Forms.Button startQuiz_Button;
        private System.Windows.Forms.Timer time_Timer;
        private System.Windows.Forms.CheckBox tip_CheckBox;
        private System.Windows.Forms.Label tip_Label;
    }
}

