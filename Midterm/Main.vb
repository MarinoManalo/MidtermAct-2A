
Public Class Main
    Private Sub Main(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(ComputeBtn)
        CloseRoundButton(CloseBtn)
        Me.BackColor = Color.Black

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        CloseButton(CloseBtn)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SidePanel.Paint
        SidePanel.BackColor = Color.FromArgb(41, 41, 41)

        PanelTop.BackColor = Color.FromArgb(41, 41, 41)

        DetailsPanel.BackColor = Color.FromArgb(165, 255, 255, 255)

        CarmodelPanel.BackColor = Color.FromArgb(165, 255, 255, 255)

        CarPanel.BackColor = Color.FromArgb(41, 41, 41)

    End Sub
    ''    INTERESTS

    'SUV

    ''toyota
    Dim Fortuner As Integer = 1736000
    Dim Rush As Integer = 1000056
    Dim LandCruiser As Integer = 5000034

    ''mitsubishi
    Dim Montero As Integer = 1568000
    Dim Outlander As Integer = 2998000
    Dim Xpander As Integer = 1068000

    ''ford
    Dim Explorer As Integer = 3298000
    Dim Everest As Integer = 1799000
    Dim Territory As Integer = 2209000

    'Pickup Truck
    '' chevrolet 
    Dim Colorado As Integer = 1635200
    Dim Silverado As Integer = 2030800

    '' Toyota 
    Dim Hilux As Integer = 2186000
    Dim Tundra As Integer = 4500000

    '' ford
    Dim Ranger As Integer = 1249000
    Dim F150 As Integer = 3398000


    'Sedan
    ''   auidi
    Dim A8L As Integer = 8500000
    Dim A3Sedan As Integer = 1909240
    Dim Rs5Sportback As Integer = 8500000

    ''   honda 
    Dim City As Integer = 1128000
    Dim Civic As Integer = 1583000
    Dim CivicTypeR As Integer = 3000870

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassificationCb.SelectedIndexChanged

        TotalPriceTxt.Text = ""
        MonthlyDuesTxt.Text = ""
        YearToPaytxt.Text = ""
        CarPriceTxt.Text = ""
        AnnualIntTxt.Text = ""


        CarBrandCb.Items.Clear()
        CarModelCb.Items.Clear()
        LogoPb.Image = Nothing
        ModelPb.Image = Nothing
        CarModelPb.Image = Nothing

        Select Case ClassificationCb.SelectedIndex

            Case 0 'Suv
                CarBrandCb.Items.Add("Toyota")
                CarBrandCb.Items.Add("Mitsubishi")
                CarBrandCb.Items.Add("Ford")
            Case 1 'Pickup Truck
                CarBrandCb.Items.Add("Chevrolet")
                CarBrandCb.Items.Add("Toyota")
                CarBrandCb.Items.Add("Ford")
            Case 2 'Sedan
                CarBrandCb.Items.Add("Audi")
                CarBrandCb.Items.Add("Honda")
        End Select
    End Sub
    Private Sub CarbrandCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarBrandCb.SelectedIndexChanged
        LogoPb.Image = Nothing
        ModelPb.Image = Nothing
        CarModelPb.Image = Nothing

        TotalPriceTxt.Text = ""
        MonthlyDuesTxt.Text = ""
        YearToPaytxt.Text = ""
        CarPriceTxt.Text = ""


        Dim ToyotaInt As Integer = 12
        Dim MitsubishiIntt As Integer = 11
        Dim FordInt As Integer = 9
        Dim AuditInt As Integer = 13
        Dim ChevroletInt As Integer = 8
        Dim HondatInt As Integer = 7



        If ClassificationCb.SelectedIndex = 0 Then ' SUV

            Select Case CarBrandCb.SelectedIndex
                Case 0 ' Toyota 
                    AnnualIntTxt.Text = ToyotaInt
                    LogoPb.Image = My.Resources.ToyotaLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("Fortuner")
                    CarModelCb.Items.Add("Rush")
                    CarModelCb.Items.Add("Land Cruiser")

                Case 1 'mitsubishi
                    AnnualIntTxt.Text = MitsubishiIntt
                    LogoPb.Image = My.Resources.MitsubishiLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("Montero")
                    CarModelCb.Items.Add("Outlander")
                    CarModelCb.Items.Add("Xpander")

                Case 2 ' ford
                    AnnualIntTxt.Text = FordInt
                    LogoPb.Image = My.Resources.FordLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("Explorer")
                    CarModelCb.Items.Add("Everest")
                    CarModelCb.Items.Add("Territory")
            End Select
        ElseIf ClassificationCb.SelectedIndex = 1 Then 'Pickup Truck 
            Select Case CarBrandCb.SelectedIndex
                Case 0 'chevrolet
                    AnnualIntTxt.Text = ChevroletInt
                    LogoPb.Image = My.Resources.сhevroletLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("Colorado")
                    CarModelCb.Items.Add("Silverado")
                Case 1 ' Toyota 
                    AnnualIntTxt.Text = ToyotaInt
                    LogoPb.Image = My.Resources.ToyotaLogo
                    LogoPb.Image = My.Resources.ToyotaLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("Hilux")
                    CarModelCb.Items.Add("Tundra")

                Case 2 ' ford
                    AnnualIntTxt.Text = FordInt
                    LogoPb.Image = My.Resources.FordLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("Ranger")
                    CarModelCb.Items.Add("F-150")
            End Select
        ElseIf ClassificationCb.SelectedIndex = 2 Then 'sedan
            Select Case CarBrandCb.SelectedIndex
                Case 0 'auidi
                    AnnualIntTxt.Text = AuditInt
                    LogoPb.Image = My.Resources.AudiLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("A8 L")
                    CarModelCb.Items.Add("A3 Sedan")
                    CarModelCb.Items.Add("Rs 5 Sportback")
                Case 1 ' honda 
                    AnnualIntTxt.Text = HondatInt
                    LogoPb.Image = My.Resources.HondaLogo
                    CarModelCb.Items.Clear()
                    CarModelCb.Items.Add("City")
                    CarModelCb.Items.Add("Civic")
                    CarModelCb.Items.Add("Civic Type-R")
            End Select
        End If
    End Sub

    Private Sub CarModelCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarModelCb.SelectedIndexChanged

        ModelPb.Image = Nothing

        TotalPriceTxt.Text = ""
        MonthlyDuesTxt.Text = ""
        YearToPaytxt.Text = ""

        'suv
        If CarBrandCb.SelectedIndex = 0 And ClassificationCb.SelectedIndex = 0 Then ' toyota

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(Fortuner, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.Fortuner
                    CarModelPb.Image = My.Resources.FortunerCar
                Case 1

                    CarPriceTxt.Text = Format(Rush, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.Rush
                    CarModelPb.Image = My.Resources.RushCar
                Case 2
                    CarPriceTxt.Text = Format(LandCruiser, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.Toyota_Land_Cruiser_2022_1
                    CarModelPb.Image = My.Resources.FortunerCar
            End Select


        ElseIf CarBrandCb.SelectedIndex = 1 And ClassificationCb.SelectedIndex = 0 Then ' mitsubishi

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(Montero, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.monterologo_png
                    CarModelPb.Image = My.Resources.monterocar
                Case 1
                    CarPriceTxt.Text = Format(Outlander, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.Outlanderlogo
                    CarModelPb.Image = My.Resources.outlandercar_
                Case 2
                    CarPriceTxt.Text = Format(Xpander, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.Xpanderlogo
                    CarModelPb.Image = My.Resources.xpandercar_
            End Select
        ElseIf CarBrandCb.SelectedIndex = 2 And ClassificationCb.SelectedIndex = 0 Then ' Ford

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(Explorer, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.explorer_
                    CarModelPb.Image = My.Resources.ford_explorer
                Case 1
                    CarPriceTxt.Text = Format(Everest, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.everest_
                    CarModelPb.Image = My.Resources.ford_everest
                Case 2
                    CarPriceTxt.Text = Format(Territory, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.territory
                    CarModelPb.Image = My.Resources.ford_territory
            End Select

            'Pickup
        ElseIf CarBrandCb.SelectedIndex = 0 And ClassificationCb.SelectedIndex = 1 Then 'chev

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(Colorado, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.colorado_
                    CarModelPb.Image = My.Resources.colorado_1
                Case 1
                    CarPriceTxt.Text = Format(Silverado, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.silverado_1_logo
                    CarModelPb.Image = My.Resources.silverado

            End Select
        ElseIf CarBrandCb.SelectedIndex = 1 And ClassificationCb.SelectedIndex = 1 Then 'toyota

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(Hilux, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.hiluxlogo_
                    CarModelPb.Image = My.Resources.toyota_hilux_
                Case 1
                    CarPriceTxt.Text = Format(Tundra, "₱#,###,###.00")
                    ModelPb.Image = My.Resources._68610935ed0ea7f141f3a5ad533f1c45
                    CarModelPb.Image = My.Resources._21_Toyota_Tundra_TRD_SM

            End Select
        ElseIf CarBrandCb.SelectedIndex = 2 And ClassificationCb.SelectedIndex = 1 Then 'ford

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(Ranger, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.ford_ranger4134_removebg_preview
                    CarModelPb.Image = My.Resources.Ford_Ranger_2023_mk8_removebg_preview
                Case 1
                    CarPriceTxt.Text = Format(F150, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.f150png_removebg_preview
                    CarModelPb.Image = My.Resources._150f_removebg_preview
            End Select

            'sedan
        ElseIf CarBrandCb.SelectedIndex = 0 And ClassificationCb.SelectedIndex = 2 Then 'audi

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(A8L, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.A8L_removebg_preview
                    CarModelPb.Image = My.Resources.A8_removebg_preview
                Case 1
                    CarPriceTxt.Text = Format(A3Sedan, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.A3_removebg_preview
                    CarModelPb.Image = My.Resources.a3car_removebg_preview
                Case 2
                    CarPriceTxt.Text = Format(Rs5Sportback, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.RS5_removebg_preview
                    CarModelPb.Image = My.Resources.RS5car_removebg_preview
            End Select
        ElseIf CarBrandCb.SelectedIndex = 1 And ClassificationCb.SelectedIndex = 2 Then 'honda

            Select Case CarModelCb.SelectedIndex
                Case 0
                    CarPriceTxt.Text = Format(City, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.city_removebg_preview
                    CarModelPb.Image = My.Resources.citycar_removebg_preview
                Case 1
                    CarPriceTxt.Text = Format(Civic, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.Honda_Civic_Logo_2011
                    CarModelPb.Image = My.Resources.civiccar
                Case 2
                    CarPriceTxt.Text = Format(CivicTypeR, "₱#,###,###.00")
                    ModelPb.Image = My.Resources.typeR_removebg_preview
                    CarModelPb.Image = My.Resources.type_r_model
            End Select
        End If

    End Sub
    Private Sub ComputeBtn_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click

        Dim Carprice As Integer
        Dim annual As Integer
        Dim total1 As Integer


        If ClassificationCb.SelectedItem = Nothing Then
            MsgBox("Please select a car classification.")
        ElseIf CarBrandCb.SelectedItem = Nothing Then
            MsgBox("Please choose a car brand.")
        ElseIf CarModelCb.SelectedItem = Nothing Then
            MsgBox("Please select a car model.")
        ElseIf YearToPaytxt.Text = Nothing Then
            MsgBox("Please enter the number of years for payment.")
        ElseIf CarBrandCb.SelectedIndex = 0 And ClassificationCb.SelectedIndex = 0 Then ' toyota

            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.12
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

        ElseIf CarBrandCb.SelectedIndex = 1 And ClassificationCb.SelectedIndex = 0 Then ' mitsubishi
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.11
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

        ElseIf CarBrandCb.SelectedIndex = 2 And ClassificationCb.SelectedIndex = 0 Then ' Ford
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.9
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

            'Pickup
        ElseIf CarBrandCb.SelectedIndex = 0 And ClassificationCb.SelectedIndex = 1 Then 'chev
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.8
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

        ElseIf CarBrandCb.SelectedIndex = 1 And ClassificationCb.SelectedIndex = 1 Then 'toyota
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.12
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

        ElseIf CarBrandCb.SelectedIndex = 2 And ClassificationCb.SelectedIndex = 1 Then 'ford
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.9
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

            'sedan
        ElseIf CarBrandCb.SelectedIndex = 0 And ClassificationCb.SelectedIndex = 2 Then 'audi
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.13
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")

        ElseIf CarBrandCb.SelectedIndex = 1 And ClassificationCb.SelectedIndex = 2 Then 'honda
            Carprice = CarPriceTxt.Text
            annual = Carprice * 0.7
            total1 = annual * YearToPaytxt.Text
            TotalPriceTxt.Text = Format(Carprice + total1, "₱#,###,###.00")
            MonthlyDuesTxt.Text = Format(TotalPriceTxt.Text / (YearToPaytxt.Text * 12), "₱#,###,###.00")


        End If

    End Sub

    Private Sub CloseButton(XBtn As Button)
        Dim ans As DialogResult

        ans = MessageBox.Show("Are you sure you want to exit?",
                         "Exit Confirmation",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub CloseRoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(27, 27, 27)
        btn.ForeColor = Color.WhiteSmoke
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 13)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)

    End Sub
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(255, 163, 26)
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 13)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)

    End Sub


    Private Sub yearsToPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles YearToPaytxt.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub


End Class