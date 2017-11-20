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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdHamandTurkeySandwhich = New System.Windows.Forms.RadioButton()
        Me.rdChickenPatty = New System.Windows.Forms.RadioButton()
        Me.rdCheseeburger = New System.Windows.Forms.RadioButton()
        Me.rdHamburger = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkJalepenos = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdFrings = New System.Windows.Forms.RadioButton()
        Me.rdFriedGreenBeans = New System.Windows.Forms.RadioButton()
        Me.rdFries = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdHamandTurkeySandwhich)
        Me.GroupBox1.Controls.Add(Me.rdChickenPatty)
        Me.GroupBox1.Controls.Add(Me.rdCheseeburger)
        Me.GroupBox1.Controls.Add(Me.rdHamburger)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal"
        '
        'RdHamandTurkeySandwhich
        '
        Me.RdHamandTurkeySandwhich.AutoSize = True
        Me.RdHamandTurkeySandwhich.Location = New System.Drawing.Point(22, 151)
        Me.RdHamandTurkeySandwhich.Name = "RdHamandTurkeySandwhich"
        Me.RdHamandTurkeySandwhich.Size = New System.Drawing.Size(160, 17)
        Me.RdHamandTurkeySandwhich.TabIndex = 3
        Me.RdHamandTurkeySandwhich.TabStop = True
        Me.RdHamandTurkeySandwhich.Text = "Ham and Turkey Sandwhich"
        Me.RdHamandTurkeySandwhich.UseVisualStyleBackColor = True
        '
        'rdChickenPatty
        '
        Me.rdChickenPatty.AutoSize = True
        Me.rdChickenPatty.Location = New System.Drawing.Point(22, 111)
        Me.rdChickenPatty.Name = "rdChickenPatty"
        Me.rdChickenPatty.Size = New System.Drawing.Size(91, 17)
        Me.rdChickenPatty.TabIndex = 2
        Me.rdChickenPatty.TabStop = True
        Me.rdChickenPatty.Text = "Chicken Patty"
        Me.rdChickenPatty.UseVisualStyleBackColor = True
        '
        'rdCheseeburger
        '
        Me.rdCheseeburger.AutoSize = True
        Me.rdCheseeburger.Location = New System.Drawing.Point(22, 74)
        Me.rdCheseeburger.Name = "rdCheseeburger"
        Me.rdCheseeburger.Size = New System.Drawing.Size(91, 17)
        Me.rdCheseeburger.TabIndex = 1
        Me.rdCheseeburger.TabStop = True
        Me.rdCheseeburger.Text = "Cheseeburger"
        Me.rdCheseeburger.UseVisualStyleBackColor = True
        '
        'rdHamburger
        '
        Me.rdHamburger.AutoSize = True
        Me.rdHamburger.Location = New System.Drawing.Point(22, 38)
        Me.rdHamburger.Name = "rdHamburger"
        Me.rdHamburger.Size = New System.Drawing.Size(77, 17)
        Me.rdHamburger.TabIndex = 0
        Me.rdHamburger.TabStop = True
        Me.rdHamburger.Text = "Hamburger"
        Me.rdHamburger.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(24, 239)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(223, 38)
        Me.lblResult.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkJalepenos)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(366, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 192)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'chkJalepenos
        '
        Me.chkJalepenos.AutoSize = True
        Me.chkJalepenos.Location = New System.Drawing.Point(20, 151)
        Me.chkJalepenos.Name = "chkJalepenos"
        Me.chkJalepenos.Size = New System.Drawing.Size(74, 17)
        Me.chkJalepenos.TabIndex = 3
        Me.chkJalepenos.Text = "Jalepenos"
        Me.chkJalepenos.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(20, 111)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(20, 74)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(20, 38)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdFrings)
        Me.GroupBox3.Controls.Add(Me.rdFriedGreenBeans)
        Me.GroupBox3.Controls.Add(Me.rdFries)
        Me.GroupBox3.Location = New System.Drawing.Point(348, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'rdFrings
        '
        Me.rdFrings.AutoSize = True
        Me.rdFrings.Location = New System.Drawing.Point(38, 65)
        Me.rdFrings.Name = "rdFrings"
        Me.rdFrings.Size = New System.Drawing.Size(53, 17)
        Me.rdFrings.TabIndex = 2
        Me.rdFrings.TabStop = True
        Me.rdFrings.Text = "Frings"
        Me.rdFrings.UseVisualStyleBackColor = True
        '
        'rdFriedGreenBeans
        '
        Me.rdFriedGreenBeans.AutoSize = True
        Me.rdFriedGreenBeans.Location = New System.Drawing.Point(38, 42)
        Me.rdFriedGreenBeans.Name = "rdFriedGreenBeans"
        Me.rdFriedGreenBeans.Size = New System.Drawing.Size(113, 17)
        Me.rdFriedGreenBeans.TabIndex = 1
        Me.rdFriedGreenBeans.TabStop = True
        Me.rdFriedGreenBeans.Text = "Fried Green Beans"
        Me.rdFriedGreenBeans.UseVisualStyleBackColor = True
        '
        'rdFries
        '
        Me.rdFries.AutoSize = True
        Me.rdFries.Location = New System.Drawing.Point(38, 19)
        Me.rdFries.Name = "rdFries"
        Me.rdFries.Size = New System.Drawing.Size(47, 17)
        Me.rdFries.TabIndex = 0
        Me.rdFries.TabStop = True
        Me.rdFries.Text = "Fries"
        Me.rdFries.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(27, 333)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(134, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(24, 277)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(223, 38)
        Me.lblTotal.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 441)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdHamandTurkeySandwhich As System.Windows.Forms.RadioButton
    Friend WithEvents rdChickenPatty As System.Windows.Forms.RadioButton
    Friend WithEvents rdCheseeburger As System.Windows.Forms.RadioButton
    Friend WithEvents rdHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkJalepenos As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdFrings As System.Windows.Forms.RadioButton
    Friend WithEvents rdFriedGreenBeans As System.Windows.Forms.RadioButton
    Friend WithEvents rdFries As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
