Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim query = From line In IO.File.ReadAllLines("Justices.txt")
                        Let data = line.Split(",")
                        Let firstname = data(0)
                        Let lastname = data(1)
                        Let Fullname = firstname & "," & lastname
                        Let State = data(3)
                        Select Fullname & "," & State


            'write lines
            IO.File.WriteAllLines("Justice.txt", query)

            MessageBox.Show("Data transfered")


        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim query = From line In IO.File.ReadAllLines("Justices.txt")
                        Let data = line.Split(",")
                        Let firstname = data(0)
                        Let Lastname = data(1)
                        Let fullname = (firstname & "," & Lastname).ToUpper
                        Let yrAppointed = CInt(data(4))
                        Select fullname & " was appointed in " & yrAppointed


            IO.File.WriteAllLines("Just.txt", query)
            MessageBox.Show("Data Transfered")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query = From line In IO.File.ReadAllLines("Justices.txt")
                    Let lastNAme = line.Split(",")(1)
                    Let pres = line.Split(",")(2)
                    Let presLastName = pres.Split(" ").Last
                    Let phrase = lastNAme & " was appointed by " & presLastName
                    Select phrase


        IO.File.WriteAllLines("pres.txt", query)
        MessageBox.Show("Done")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query = From line In IO.File.ReadAllLines("Justices.txt")
                    Let lastNAme = line.Split(",")(1)
                    Let yrAppointed = CInt(line.Split(",")(4))
                    Let years = Today.Year - yrAppointed
                    Let phrase = lastNAme & " appointed  " & years & " years ago"
                    Select phrase


        IO.File.WriteAllLines("years.txt", query)
        MessageBox.Show("Done")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query = From line In IO.File.ReadAllLines("Justices.txt")
                    Let data = line.Split(",")
                    Let firstname = data(0)
                    Let Lastname = data(1)
                    Let yrAppointed = CInt(data(4))
                    Let newLine = Lastname & ", " & firstname & "," & yrAppointed
                    Select newLine


        IO.File.WriteAllLines("NewLine.txt", query)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query = From line In IO.File.ReadAllLines("Justices.txt")
                    Let data = line.Split(",")
                    Let lastName = data(1)
                    Let pres = data(2)
                    Let state = data(3)
                    Let presLastName = pres.Split(" ").Last
                    Let newLine = presLastName & ", " & lastName & ", " & state
                    Select newLine


        IO.File.WriteAllLines("NewLine.txt", query)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim games() As String = IO.File.ReadAllLines("SuperBowelWinners.txt")

        Dim query = From line In games
                    Let data = line.Split(",")
                    Let year = data(0)
                    Let teamName = data(2)
                    Let teamName2 = data(3)
                    Let finalScore = data(4)
                    Let location = data(5)
                    Select year, teamName, teamName2, finalScore, location

        DataGridView1.DataSource = query.ToList
        DataGridView1.Columns("year").HeaderText = "Year"
        DataGridView1.Columns("teamName").HeaderText = "Team Name 1"
        DataGridView1.Columns("teamName2").HeaderText = "Team Name 2"
        DataGridView1.Columns("finalScore").HeaderText = "Final Score"
        DataGridView1.Columns("location").HeaderText = "Location"

    End Sub
End Class
