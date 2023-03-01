<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPaycheck = New System.Windows.Forms.Label()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.lblEGP = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFicaNum = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblFedTaxNum = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblStateTaxNum = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblNetPayNum = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(431, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(284, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Payroll Calculator"
        '
        'lblPaycheck
        '
        Me.lblPaycheck.AutoSize = True
        Me.lblPaycheck.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPaycheck.Location = New System.Drawing.Point(498, 86)
        Me.lblPaycheck.Name = "lblPaycheck"
        Me.lblPaycheck.Size = New System.Drawing.Size(135, 37)
        Me.lblPaycheck.TabIndex = 2
        Me.lblPaycheck.Text = "Paycheck"
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCalculation.Location = New System.Drawing.Point(488, 132)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(161, 37)
        Me.lblCalculation.TabIndex = 3
        Me.lblCalculation.Text = "Calculation"
        '
        'lblEGP
        '
        Me.lblEGP.AutoSize = True
        Me.lblEGP.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEGP.Location = New System.Drawing.Point(265, 279)
        Me.lblEGP.Name = "lblEGP"
        Me.lblEGP.Size = New System.Drawing.Size(222, 37)
        Me.lblEGP.TabIndex = 4
        Me.lblEGP.Text = "Enter Gross Pay:"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInput.Location = New System.Drawing.Point(511, 280)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(138, 39)
        Me.txtInput.TabIndex = 5
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(128, 342)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(129, 37)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute Taxes"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(358, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(588, 342)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFica.Location = New System.Drawing.Point(128, 424)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(51, 25)
        Me.lblFica.TabIndex = 9
        Me.lblFica.Text = "Fica:"
        '
        'lblFicaNum
        '
        Me.lblFicaNum.AutoSize = True
        Me.lblFicaNum.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFicaNum.Location = New System.Drawing.Point(187, 425)
        Me.lblFicaNum.Name = "lblFicaNum"
        Me.lblFicaNum.Size = New System.Drawing.Size(0, 25)
        Me.lblFicaNum.TabIndex = 10
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFedTax.Location = New System.Drawing.Point(335, 425)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(117, 25)
        Me.lblFedTax.TabIndex = 11
        Me.lblFedTax.Text = "Federal Tax:"
        '
        'lblFedTaxNum
        '
        Me.lblFedTaxNum.AutoSize = True
        Me.lblFedTaxNum.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFedTaxNum.Location = New System.Drawing.Point(458, 425)
        Me.lblFedTaxNum.Name = "lblFedTaxNum"
        Me.lblFedTaxNum.Size = New System.Drawing.Size(0, 25)
        Me.lblFedTaxNum.TabIndex = 12
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStateTax.Location = New System.Drawing.Point(570, 424)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(97, 25)
        Me.lblStateTax.TabIndex = 13
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblStateTaxNum
        '
        Me.lblStateTaxNum.AutoSize = True
        Me.lblStateTaxNum.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStateTaxNum.Location = New System.Drawing.Point(673, 424)
        Me.lblStateTaxNum.Name = "lblStateTaxNum"
        Me.lblStateTaxNum.Size = New System.Drawing.Size(0, 25)
        Me.lblStateTaxNum.TabIndex = 14
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNetPay.Location = New System.Drawing.Point(128, 477)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(265, 32)
        Me.lblNetPay.TabIndex = 15
        Me.lblNetPay.Text = "Net Paycheck Income:"
        '
        'lblNetPayNum
        '
        Me.lblNetPayNum.AutoSize = True
        Me.lblNetPayNum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNetPayNum.Location = New System.Drawing.Point(511, 477)
        Me.lblNetPayNum.Name = "lblNetPayNum"
        Me.lblNetPayNum.Size = New System.Drawing.Size(28, 32)
        Me.lblNetPayNum.TabIndex = 16
        Me.lblNetPayNum.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.lblNetPayNum)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTaxNum)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFedTaxNum)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFicaNum)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEGP)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.lblPaycheck)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPaycheck As Label
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lblEGP As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFicaNum As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblFedTaxNum As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblStateTaxNum As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblNetPayNum As Label
End Class
