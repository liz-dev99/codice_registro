namespace Codice.App;

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
        label1 = new Label();
        txtRut = new TextBox();
        label2 = new Label();
        txtNombre = new TextBox();
        label3 = new Label();
        txtEmail = new TextBox();
        btnAgregarEstudiante = new Button();
        lstEstudiantes = new ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(26, 106);
        label1.Name = "label1";
        label1.Size = new Size(43, 20);
        label1.TabIndex = 0;
        label1.Text = "RUT: ";
        // 
        // txtRut
        // 
        txtRut.Location = new Point(99, 99);
        txtRut.Name = "txtRut";
        txtRut.Size = new Size(125, 27);
        txtRut.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(26, 66);
        label2.Name = "label2";
        label2.Size = new Size(67, 20);
        label2.TabIndex = 2;
        label2.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(99, 59);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(125, 27);
        txtNombre.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(26, 141);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 4;
        label3.Text = "Email:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(99, 134);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(125, 27);
        txtEmail.TabIndex = 5;
        // 
        // btnAgregarEstudiante
        // 
        btnAgregarEstudiante.Location = new Point(26, 179);
        btnAgregarEstudiante.Name = "btnAgregarEstudiante";
        btnAgregarEstudiante.Size = new Size(158, 29);
        btnAgregarEstudiante.TabIndex = 6;
        btnAgregarEstudiante.Text = "Agregar Estudiante";
        btnAgregarEstudiante.UseVisualStyleBackColor = true;
        btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
        // 
        // lstEstudiantes
        // 
        lstEstudiantes.FormattingEnabled = true;
        lstEstudiantes.Location = new Point(26, 230);
        lstEstudiantes.Name = "lstEstudiantes";
        lstEstudiantes.Size = new Size(198, 184);
        lstEstudiantes.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lstEstudiantes);
        Controls.Add(btnAgregarEstudiante);
        Controls.Add(txtEmail);
        Controls.Add(label3);
        Controls.Add(txtNombre);
        Controls.Add(label2);
        Controls.Add(txtRut);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Instituto Códice - Registro Académico";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtRut;
    private Label label2;
    private TextBox txtNombre;
    private Label label3;
    private TextBox txtEmail;
    private Button btnAgregarEstudiante;
    private ListBox lstEstudiantes;
}
