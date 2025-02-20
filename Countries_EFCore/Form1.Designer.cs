namespace Countries_EFCore;

partial class Form1
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
        listBox1 = new ListBox();
        buttonDelete = new Button();
        button1 = new Button();
        labelName = new Label();
        textBoxName = new TextBox();
        textBoxCapital = new TextBox();
        label1 = new Label();
        textBoxPopulation = new TextBox();
        label2 = new Label();
        textBoxSquare = new TextBox();
        label3 = new Label();
        label4 = new Label();
        comboBox1 = new ComboBox();
        buttonAdd = new Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(252, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(165, 334);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // buttonDelete
        // 
        buttonDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        buttonDelete.Location = new Point(423, 241);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(84, 41);
        buttonDelete.TabIndex = 1;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        button1.Location = new Point(423, 303);
        button1.Name = "button1";
        button1.Size = new Size(84, 41);
        button1.TabIndex = 2;
        button1.Text = "Edit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        labelName.Location = new Point(29, 68);
        labelName.Name = "labelName";
        labelName.Size = new Size(49, 20);
        labelName.TabIndex = 3;
        labelName.Text = "Name";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(29, 89);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(100, 23);
        textBoxName.TabIndex = 4;
        // 
        // textBoxCapital
        // 
        textBoxCapital.Location = new Point(29, 144);
        textBoxCapital.Name = "textBoxCapital";
        textBoxCapital.Size = new Size(100, 23);
        textBoxCapital.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.Location = new Point(29, 123);
        label1.Name = "label1";
        label1.Size = new Size(56, 20);
        label1.TabIndex = 5;
        label1.Text = "Capital";
        // 
        // textBoxPopulation
        // 
        textBoxPopulation.Location = new Point(29, 191);
        textBoxPopulation.Name = "textBoxPopulation";
        textBoxPopulation.Size = new Size(100, 23);
        textBoxPopulation.TabIndex = 8;
        textBoxPopulation.KeyPress += textBoxPopulation_KeyPress;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.Location = new Point(29, 170);
        label2.Name = "label2";
        label2.Size = new Size(80, 20);
        label2.TabIndex = 7;
        label2.Text = "Population";
        // 
        // textBoxSquare
        // 
        textBoxSquare.Location = new Point(29, 241);
        textBoxSquare.Name = "textBoxSquare";
        textBoxSquare.Size = new Size(100, 23);
        textBoxSquare.TabIndex = 10;
        textBoxSquare.KeyPress += textBoxSquare_KeyPress;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label3.Location = new Point(29, 220);
        label3.Name = "label3";
        label3.Size = new Size(97, 20);
        label3.TabIndex = 9;
        label3.Text = "Square (km2)";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label4.Location = new Point(29, 12);
        label4.Name = "label4";
        label4.Size = new Size(73, 20);
        label4.TabIndex = 11;
        label4.Text = "Continent";
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(29, 35);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 12;
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        buttonAdd.Location = new Point(29, 303);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 41);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(524, 356);
        Controls.Add(buttonAdd);
        Controls.Add(comboBox1);
        Controls.Add(label4);
        Controls.Add(textBoxSquare);
        Controls.Add(label3);
        Controls.Add(textBoxPopulation);
        Controls.Add(label2);
        Controls.Add(textBoxCapital);
        Controls.Add(label1);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        Controls.Add(button1);
        Controls.Add(buttonDelete);
        Controls.Add(listBox1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox listBox1;
    private Button buttonDelete;
    private Button button1;
    private Label labelName;
    private TextBox textBoxName;
    private TextBox textBoxCapital;
    private Label label1;
    private TextBox textBoxPopulation;
    private Label label2;
    private TextBox textBoxSquare;
    private Label label3;
    private Label label4;
    private ComboBox comboBox1;
    private Button buttonAdd;
}
