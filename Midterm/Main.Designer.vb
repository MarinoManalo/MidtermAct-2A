<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComputeBtn = New System.Windows.Forms.Button()
        Me.YearToPaytxt = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CarModelCb = New System.Windows.Forms.ComboBox()
        Me.CarBrandCb = New System.Windows.Forms.ComboBox()
        Me.ClassificationCb = New System.Windows.Forms.ComboBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.CarPriceTxt = New System.Windows.Forms.TextBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.AnnualInte = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalPriceTxt = New System.Windows.Forms.TextBox()
        Me.AnnualIntTxt = New System.Windows.Forms.TextBox()
        Me.MonthlyDuesTxt = New System.Windows.Forms.TextBox()
        Me.CarPanel = New System.Windows.Forms.Panel()
        Me.CarModelPb = New System.Windows.Forms.PictureBox()
        Me.CarmodelPanel = New System.Windows.Forms.Panel()
        Me.ModelPb = New System.Windows.Forms.PictureBox()
        Me.LogoPb = New System.Windows.Forms.PictureBox()
        Me.SidePanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsPanel.SuspendLayout()
        Me.CarPanel.SuspendLayout()
        CType(Me.CarModelPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarmodelPanel.SuspendLayout()
        CType(Me.ModelPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.Controls.Add(Me.Label3)
        Me.SidePanel.Controls.Add(Me.ComputeBtn)
        Me.SidePanel.Controls.Add(Me.YearToPaytxt)
        Me.SidePanel.Controls.Add(Me.PictureBox2)
        Me.SidePanel.Controls.Add(Me.Label4)
        Me.SidePanel.Controls.Add(Me.Label2)
        Me.SidePanel.Controls.Add(Me.Label1)
        Me.SidePanel.Controls.Add(Me.CarModelCb)
        Me.SidePanel.Controls.Add(Me.CarBrandCb)
        Me.SidePanel.Controls.Add(Me.ClassificationCb)
        Me.SidePanel.Controls.Add(Me.CloseBtn)
        Me.SidePanel.Location = New System.Drawing.Point(-5, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(213, 610)
        Me.SidePanel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Year(s) to pay"
        '
        'ComputeBtn
        '
        Me.ComputeBtn.Location = New System.Drawing.Point(50, 451)
        Me.ComputeBtn.Name = "ComputeBtn"
        Me.ComputeBtn.Size = New System.Drawing.Size(117, 53)
        Me.ComputeBtn.TabIndex = 13
        Me.ComputeBtn.Text = "Compute"
        Me.ComputeBtn.UseVisualStyleBackColor = True
        '
        'YearToPaytxt
        '
        Me.YearToPaytxt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearToPaytxt.Location = New System.Drawing.Point(39, 396)
        Me.YearToPaytxt.Name = "YearToPaytxt"
        Me.YearToPaytxt.Size = New System.Drawing.Size(139, 29)
        Me.YearToPaytxt.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Midterm.My.Resources.Resources.MyLogo
        Me.PictureBox2.Location = New System.Drawing.Point(17, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(165, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Classification"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Car Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Car Brand"
        '
        'CarModelCb
        '
        Me.CarModelCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CarModelCb.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarModelCb.FormattingEnabled = True
        Me.CarModelCb.Location = New System.Drawing.Point(39, 298)
        Me.CarModelCb.Name = "CarModelCb"
        Me.CarModelCb.Size = New System.Drawing.Size(139, 31)
        Me.CarModelCb.TabIndex = 5
        '
        'CarBrandCb
        '
        Me.CarBrandCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CarBrandCb.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarBrandCb.FormattingEnabled = True
        Me.CarBrandCb.Location = New System.Drawing.Point(39, 229)
        Me.CarBrandCb.Name = "CarBrandCb"
        Me.CarBrandCb.Size = New System.Drawing.Size(139, 31)
        Me.CarBrandCb.TabIndex = 4
        '
        'ClassificationCb
        '
        Me.ClassificationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassificationCb.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassificationCb.FormattingEnabled = True
        Me.ClassificationCb.Items.AddRange(New Object() {"SUV", "Pickup Truck", "Sedan"})
        Me.ClassificationCb.Location = New System.Drawing.Point(39, 160)
        Me.ClassificationCb.Name = "ClassificationCb"
        Me.ClassificationCb.Size = New System.Drawing.Size(139, 31)
        Me.ClassificationCb.TabIndex = 3
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(50, 517)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(117, 53)
        Me.CloseBtn.TabIndex = 2
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'CarPriceTxt
        '
        Me.CarPriceTxt.Enabled = False
        Me.CarPriceTxt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarPriceTxt.Location = New System.Drawing.Point(45, 145)
        Me.CarPriceTxt.Name = "CarPriceTxt"
        Me.CarPriceTxt.Size = New System.Drawing.Size(139, 29)
        Me.CarPriceTxt.TabIndex = 13
        '
        'PanelTop
        '
        Me.PanelTop.Location = New System.Drawing.Point(205, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(808, 63)
        Me.PanelTop.TabIndex = 1
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Controls.Add(Me.Label9)
        Me.DetailsPanel.Controls.Add(Me.TotalPrice)
        Me.DetailsPanel.Controls.Add(Me.AnnualInte)
        Me.DetailsPanel.Controls.Add(Me.Label6)
        Me.DetailsPanel.Controls.Add(Me.Label5)
        Me.DetailsPanel.Controls.Add(Me.TotalPriceTxt)
        Me.DetailsPanel.Controls.Add(Me.AnnualIntTxt)
        Me.DetailsPanel.Controls.Add(Me.MonthlyDuesTxt)
        Me.DetailsPanel.Controls.Add(Me.CarPriceTxt)
        Me.DetailsPanel.Location = New System.Drawing.Point(234, 80)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(227, 501)
        Me.DetailsPanel.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 32)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Details"
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.TotalPrice.Font = New System.Drawing.Font("Times New Roman", 15.25!, System.Drawing.FontStyle.Bold)
        Me.TotalPrice.Location = New System.Drawing.Point(41, 295)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(107, 24)
        Me.TotalPrice.TabIndex = 19
        Me.TotalPrice.Text = "Total Price"
        '
        'AnnualInte
        '
        Me.AnnualInte.AutoSize = True
        Me.AnnualInte.BackColor = System.Drawing.Color.Transparent
        Me.AnnualInte.Font = New System.Drawing.Font("Times New Roman", 15.25!, System.Drawing.FontStyle.Bold)
        Me.AnnualInte.Location = New System.Drawing.Point(41, 236)
        Me.AnnualInte.Name = "AnnualInte"
        Me.AnnualInte.Size = New System.Drawing.Size(147, 24)
        Me.AnnualInte.TabIndex = 18
        Me.AnnualInte.Text = "Annual Interest"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(41, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Monthly Dues"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(41, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Car Price"
        '
        'TotalPriceTxt
        '
        Me.TotalPriceTxt.Enabled = False
        Me.TotalPriceTxt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceTxt.Location = New System.Drawing.Point(45, 322)
        Me.TotalPriceTxt.Name = "TotalPriceTxt"
        Me.TotalPriceTxt.Size = New System.Drawing.Size(139, 29)
        Me.TotalPriceTxt.TabIndex = 16
        '
        'AnnualIntTxt
        '
        Me.AnnualIntTxt.Enabled = False
        Me.AnnualIntTxt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnualIntTxt.Location = New System.Drawing.Point(45, 263)
        Me.AnnualIntTxt.Name = "AnnualIntTxt"
        Me.AnnualIntTxt.Size = New System.Drawing.Size(139, 29)
        Me.AnnualIntTxt.TabIndex = 15
        '
        'MonthlyDuesTxt
        '
        Me.MonthlyDuesTxt.Enabled = False
        Me.MonthlyDuesTxt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyDuesTxt.Location = New System.Drawing.Point(45, 204)
        Me.MonthlyDuesTxt.Name = "MonthlyDuesTxt"
        Me.MonthlyDuesTxt.Size = New System.Drawing.Size(139, 29)
        Me.MonthlyDuesTxt.TabIndex = 14
        '
        'CarPanel
        '
        Me.CarPanel.Controls.Add(Me.CarModelPb)
        Me.CarPanel.Location = New System.Drawing.Point(480, 242)
        Me.CarPanel.Name = "CarPanel"
        Me.CarPanel.Size = New System.Drawing.Size(510, 339)
        Me.CarPanel.TabIndex = 3
        '
        'CarModelPb
        '
        Me.CarModelPb.BackColor = System.Drawing.Color.Transparent
        Me.CarModelPb.Location = New System.Drawing.Point(35, 59)
        Me.CarModelPb.Name = "CarModelPb"
        Me.CarModelPb.Size = New System.Drawing.Size(449, 255)
        Me.CarModelPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CarModelPb.TabIndex = 2
        Me.CarModelPb.TabStop = False
        '
        'CarmodelPanel
        '
        Me.CarmodelPanel.Controls.Add(Me.ModelPb)
        Me.CarmodelPanel.Controls.Add(Me.LogoPb)
        Me.CarmodelPanel.Location = New System.Drawing.Point(480, 80)
        Me.CarmodelPanel.Name = "CarmodelPanel"
        Me.CarmodelPanel.Size = New System.Drawing.Size(510, 146)
        Me.CarmodelPanel.TabIndex = 3
        '
        'ModelPb
        '
        Me.ModelPb.BackColor = System.Drawing.Color.Transparent
        Me.ModelPb.Location = New System.Drawing.Point(212, 41)
        Me.ModelPb.Name = "ModelPb"
        Me.ModelPb.Size = New System.Drawing.Size(202, 102)
        Me.ModelPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModelPb.TabIndex = 1
        Me.ModelPb.TabStop = False
        '
        'LogoPb
        '
        Me.LogoPb.BackColor = System.Drawing.Color.Transparent
        Me.LogoPb.Location = New System.Drawing.Point(12, 3)
        Me.LogoPb.Name = "LogoPb"
        Me.LogoPb.Size = New System.Drawing.Size(180, 143)
        Me.LogoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPb.TabIndex = 0
        Me.LogoPb.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 605)
        Me.Controls.Add(Me.CarmodelPanel)
        Me.Controls.Add(Me.CarPanel)
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.CarPanel.ResumeLayout(False)
        CType(Me.CarModelPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarmodelPanel.ResumeLayout(False)
        CType(Me.ModelPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents CloseBtn As Button
    Friend WithEvents CarModelCb As ComboBox
    Friend WithEvents CarBrandCb As ComboBox
    Friend WithEvents ClassificationCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoPb As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents CarPanel As Panel
    Friend WithEvents CarmodelPanel As Panel
    Friend WithEvents CarModelPb As PictureBox
    Friend WithEvents ModelPb As PictureBox
    Friend WithEvents CarPriceTxt As TextBox
    Friend WithEvents YearToPaytxt As TextBox
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents TotalPriceTxt As TextBox
    Friend WithEvents AnnualIntTxt As TextBox
    Friend WithEvents MonthlyDuesTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalPrice As Label
    Friend WithEvents AnnualInte As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
End Class
