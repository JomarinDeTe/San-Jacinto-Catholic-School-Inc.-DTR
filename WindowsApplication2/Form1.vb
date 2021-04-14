Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        toolmain.Visible = False
        toolhi.Visible = False
        toolguest.Visible = False
        GroupBox1.Visible = False


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = My.Computer.Clock.LocalTime.Date
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label3.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim user, pass As String
        user = TextBox1.Text
        pass = TextBox2.Text
        If user = "admin" And pass = "admin" Then
            Me.Hide()

            TextBox1.Text = ""
            TextBox2.Text = ""
        Else : MsgBox("You entered wrong account! Re-enter username and password", vbExclamation)
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub toolhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolhi.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Toologin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toologin.Click

        GroupBox1.Visible = True

        If Toologin.Text = "Log out" Then
            Toologin.Text = "Log in"

            GroupBox3.Enabled = True
            toolhi.Visible = False
            toolguest.Visible = False
            toolmain.Visible = False
            TextBox1.Text = ""
            TextBox2.Text = ""

        Else
            Toologin.Text = "Log in"


        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtinput.Text = txtinput.Text & btn7.Text
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtinput.Text = txtinput.Text & btn8.Text
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtinput.Text = txtinput.Text & btn9.Text
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtinput.Text = txtinput.Text & btn4.Text
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtinput.Text = txtinput.Text & btn5.Text
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtinput.Text = txtinput.Text & btn6.Text
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtinput.Text = txtinput.Text & btn1.Text
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtinput.Text = txtinput.Text & btn2.Text
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtinput.Text = txtinput.Text & btn3.Text
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtinput.Text = txtinput.Text & btn0.Text
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Dim str As String
        Dim loc As Integer
        If txtinput.Text.Length > 0 Then
            str = txtinput.Text.Chars(txtinput.Text.Length - 1)
            loc = txtinput.Text.Length
            txtinput.Text = txtinput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
