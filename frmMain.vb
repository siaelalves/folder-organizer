'''' Desenvolvido por Siael Carvalho. Última atualização: 11/06/2015 21:26
'''' Contato: siaelalves@outlook.com | (32) 9122-3016
Public Class frmMain

    Public settings As String(,,)
    '
    Public debugmode As Boolean = False
    '
    Public tempfolder As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Public userfolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    '
    Public registryHive As String = "HKEY_CURRENT_USER\Software\Intelicode"
    Public registryHiveApp As String = "HKEY_CURRENT_USER\Software\Intelicode\Download File Manager"
    '
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        My.Settings.pictureFolder = My.Computer.FileSystem.SpecialDirectories.MyPictures
        My.Settings.documentFolder = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        My.Settings.musicFolder = My.Computer.FileSystem.SpecialDirectories.MyMusic
        My.Settings.videoFolder = userfolder & "\Videos"
        If My.Settings.downloadFolder = "" Then
            My.Settings.downloadFolder = userfolder & "\Downloads"
        End If
        '
        '''' Lista na tabela as extensões que serão organizadas
        '''' e as pastas que elas serão movidas.
        Dim lst As ListViewItem
        For Each ext In My.Settings.pictures
            lst = New ListViewItem
            lst.Text = ext
            lst.SubItems.Add(My.Settings.pictureFolder)
            lstClas.Items.Add(lst)
        Next
        '
        For Each ext In My.Settings.documents
            lst = New ListViewItem
            lst.Text = ext
            lst.SubItems.Add(My.Settings.documentFolder)
            lstClas.Items.Add(lst)
        Next
        '
        For Each ext In My.Settings.musics
            lst = New ListViewItem
            lst.Text = ext
            lst.SubItems.Add(My.Settings.musicFolder)
            lstClas.Items.Add(lst)
        Next
        '
        For Each ext In My.Settings.videos
            lst = New ListViewItem
            lst.Text = ext
            lst.SubItems.Add(My.Settings.videoFolder)
            lstClas.Items.Add(lst)
        Next
        '
        txtDwnLc.Text = My.Settings.downloadFolder
    End Sub

    Private Sub cmdOrg_Click(sender As Object, e As EventArgs) Handles cmdOrg.Click
        '''' Envia cada arquivo com as extensões listadas na tabela/coluna1 para a pasta
        '''' especificada na tabela/coluna2
        '
        'prgMv.Value = 0
        txtSt.Text = ""
        cmdOrg.Enabled = False
        '
        txtSt.Text &= "Organizando pasta " & My.Settings.downloadFolder & Chr(13)
        txtSt.Text &= Chr(13)
        Dim infoF As IO.FileInfo
        Dim infoD As IO.DirectoryInfo = New IO.DirectoryInfo(My.Settings.downloadFolder)
        '
        txtSt.Text &= Chr(13)
        txtSt.Text &= infoD.GetFiles.Count & " arquivos encontrados." & Chr(13)
        txtSt.Text &= infoD.GetDirectories.Count & " pastas encontradas." & Chr(13)
        'prgMv.Step = Math.Round(Int(100 / infoD.GetFiles.Count))
        '
        Dim fn As Integer = 0
        For Each fl In IO.Directory.GetFiles(My.Settings.downloadFolder)
            infoF = New IO.FileInfo(fl)
            For i As Integer = 0 To lstClas.Items.Count - 1
                '
                If infoF.Extension = lstClas.Items(i).Text Then
                    Try
                        IO.File.Move(fl, lstClas.Items(i).SubItems(1).Text & "\" & infoF.Name)
                        fn += 1
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Download Folder Manager")
                        txtSt.Text &= Chr(13)
                        txtSt.Text &= "Um erro ocorreu ao realizar a seguinte operação:" & Chr(13)
                        txtSt.Text &= Chr(13)
                        txtSt.Text &= " Mover arquivo " & fl & " para pasta " & lstClas.Items(i).SubItems(1).Text & "\" & infoF.Name & Chr(13)
                        txtSt.Text &= Chr(13)
                    End Try
                End If
            Next
            'prgMv.Increment(prgMv.Step)
        Next
        '
        'prgMv.Value = 100
        txtSt.Text &= Chr(13) & Chr(13)
        txtSt.Text &= fn & " de " & infoD.GetFiles.Count & " arquivo(s) movido(s)."
        txtSt.Text &= Chr(13)
        txtSt.Text &= "Operação concluída!"
        cmdOrg.Enabled = True
    End Sub

    Private Sub cmdAltLc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdAltLc.LinkClicked
        If dlgDwnLc.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.downloadFolder = dlgDwnLc.SelectedPath
            txtDwnLc.Text = My.Settings.downloadFolder
        End If
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        abt.ShowDialog()
    End Sub


    Public Sub ProgressUpdate(sender As Object, e As Net.DownloadProgressChangedEventArgs)
        lblPrg.Text = Math.Round(e.BytesReceived / 1024) & " KB / " & Math.Round(e.TotalBytesToReceive / 1024) & " KB"
        prgAtu.Value = e.ProgressPercentage
    End Sub

    Public Sub ProgressFull(sender As Object, e As Net.DownloadDataCompletedEventArgs)
        Beep()
        MsgBox("Atualização concluída. Arquivo salvo na pasta " & userfolder & "\Downloads\Folder Manager.exe", MsgBoxStyle.Information, "Atualização")
        prgAtu.Value = 0
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Dim wcl As New System.Net.WebClient
        AddHandler wcl.DownloadProgressChanged, AddressOf ProgressUpdate
        '
        'AddHandler wcl.DownloadFileCompleted, AddressOf ProgressFull
        '
        ''''Obter informações sobre uma nova versão
        lblPrg.Text = "Verificando se há uma atualização disponível . . ."
        Me.Cursor = Cursors.WaitCursor
        Dim av As Boolean
        Try
            av = Int(wcl.DownloadString(New Uri("https://onedrive.live.com/download?cid=84EC7E624320CA09&resid=84ec7e624320ca09%21160&authkey=AFZd25m2anTnF2E")).Split(",")(1)) > My.Settings.update
        Catch ex As Exception
            MsgBox("Houve um erro ao verificar as atualizações. Tente novamente mais tarde.", vbExclamation, "Atualizações")
            Exit Sub
        End Try
        Me.Cursor = Cursors.Default
        '
        ''''Se houver uma versão mais recente
        If av = True Then
            ''''Faz o download da versão
            If My.Computer.FileSystem.FileExists(userfolder & "\Downloads\Folder Manager.exe") = True Then My.Computer.FileSystem.DeleteFile(userfolder & "\Downloads\Folder Manager.exe")
            Try
                wcl.DownloadFileAsync(New Uri("https://onedrive.live.com/download?cid=84EC7E624320CA09&resid=84ec7e624320ca09%21155&authkey=AO3LTO-yzbndP68"), userfolder & "\Downloads\Folder Manager.exe")
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao fazer download da nova atualização. Tente novamente mais tarde.", vbExclamation, "Atualizações")
                Exit Sub
            End Try
        Else
            MsgBox("Não há atualizações disponíveis ainda", MsgBoxStyle.Information, "Folder Manager")
            lblPrg.Text = ""
        End If
    End Sub
End Class
