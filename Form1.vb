
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Form1
    Dim ligacao As MySqlConnection
    Dim comando As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim strSql As String

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Me.ligacao = ligacao
        'Me.comando = comando
        'Me.da = da
        'Me.dr = dr
        'Me.strSql = strSql
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles caixa_comboo.SelectedIndexChanged
        Dim caixa_combo2() As String = {"Romance", "Fantasia", "Investigação Criminal", "Poesia", "Ficção", "Terror", "Biografia"}
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles caixa_autor.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' Dados de ligação
            Dim servidor = "localhost"
            Dim base_dados = "gestao_livros"
            Dim user = "root"
            Dim pwd = "alaise19"
            Dim connectionString As String = $"server={servidor};user id={user};password={pwd};database={base_dados}"

            ' Inicializa a ligação com a base de dados
            ligacao = New MySqlConnection(connectionString)

            ' Abre a ligação
            ligacao.Open()

            ' Consulta para buscar os géneros
            strSql = "SELECT DISTINCT Genero FROM tb_livros"
            comando = New MySqlCommand(strSql, ligacao)
            dr = comando.ExecuteReader()

            ' Limpa a ComboBox antes de preencher
            caixa_comboo.Items.Clear()

            ' Adiciona cada género à ComboBox
            While dr.Read()
                caixa_comboo.Items.Add(dr("Genero").ToString())
            End While

            dr.Close()
            ligacao.Close()

            ' Seleciona o primeiro item (se houver)
            If caixa_comboo.Items.Count > 0 Then
                caixa_comboo.SelectedIndex = 0
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar géneros: " & ex.Message)
        End Try
    End Sub



    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        If caixa_titulo.Text = "" Or caixa_autor.Text = "" Or caixa_comboo.Text = "" Or caixa_ano.Text = "" Then
            MessageBox.Show("Campos vazios", "Preencha todos os campos")

        Else
            Try
                strSql = "insert into tb_livros(Titulo,Autor,Ano,Genero)
        Values (@TITULO,@AUTOR,@ANO,@GENERO)"

                comando = New MySqlCommand(strSql, ligacao)
                comando.Parameters.AddWithValue("@TITULO", caixa_titulo.Text)
                comando.Parameters.AddWithValue("@AUTOR", caixa_autor.Text)
                comando.Parameters.AddWithValue("@ANO", caixa_ano.Text)
                comando.Parameters.AddWithValue("@GENERO", caixa_comboo.Text)
                If ligacao.State = ConnectionState.Open Then
                    ligacao.Close()

                End If
                ligacao.Open()
                comando.ExecuteNonQuery()
                ligacao.Close()

                MsgBox("Dados inseridos com sucesso")
            Catch ex As Exception
                MsgBox("Erro ao inserir os dados: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub lbl_ano_Click(sender As Object, e As EventArgs) Handles lbl_ano.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            PictureBox1.Image = Image.FromFile("C:\Imagens\livro.png")
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar imagem: " & ex.Message)
        End Try


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            PictureBox1.Image = Image.FromFile("C:\Imagens\livro.png")
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar imagem: " & ex.Message)
        End Try


    End Sub
    Private Sub caixa_livro_TextChanged(sender As Object, e As EventArgs) Handles caixa_titulo.TextChanged

        Try
            ' Titulo = InputBox("Indique o titulo do livro: ")
            strSql = " Select * From tb_livros where Titulo=TITULO"
            comando = New MySqlCommand(strSql, ligacao)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_livro_Click(sender As Object, e As EventArgs) Handles lbl_livro.Click

    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        Try
            strSql = "UPDATE tb_livros SET " &
         "titulo = @Titulo, " &
         "autor = @Autor, " &
         "ano = @Ano, " &
         "genero = @Genero " &
         "WHERE id = @ID"

            comando = New MySqlCommand(strSql, ligacao)
            comando.Parameters.AddWithValue("@id", caixa_ID.Text)
            comando.Parameters.AddWithValue("@Titulo", caixa_titulo.Text)
            comando.Parameters.AddWithValue("@Autor", caixa_autor.Text)
            comando.Parameters.AddWithValue("@Ano", caixa_ano.Text)
            comando.Parameters.AddWithValue("@Genero", caixa_comboo.Text)


            'comando.Parameters.AddWithValue("@ID", caixa_id.Text) ' Supondo que tens uma TextBox chamada "caixa_id"
            If ligacao.State = ConnectionState.Open Then
                ligacao.Close()
            End If
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()

            MsgBox("Dados atualizados com sucesso")
        Catch ex As Exception
            MsgBox("Erro ao atualizar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim id As Integer
        Try
            id = InputBox("Indique o ID do livro que pretendes eliminar ")
            strSql = "DELETE FROM tb_livros Where id=@ID "

            comando = New MySqlCommand(strSql, ligacao)
            comando.Parameters.AddWithValue("@ID", id.ToString)
            ligacao.Open()
            comando.ExecuteNonQuery()
            MsgBox("Livro  eliminado com sucesso!")
            ligacao.Close()

        Catch ex As Exception
            MsgBox("Erro ao eliminar dados:" & ex.Message)

        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Dim datatable As New DataTable
        Try

            strSql = "Select * From tb_livros"
            ligacao.Open()
            da = New MySqlDataAdapter(strSql, ligacao)
            da.Fill(datatable)
            DataGridView1.DataSource = datatable
        Catch ex As Exception
            MsgBox("Erro ao mostrar os dados: " & ex.Message)
            If ligacao.State = ConnectionState.Open Then
                ligacao.Close()
            End If
        End Try
    End Sub

    Private Sub btn_vizualizar_Click(sender As Object, e As EventArgs) Handles btn_vizualizar.Click
        Dim Titulo As String

        Try
            Titulo = InputBox("Indica o título do livro que queres visualizar:")

            strSql = "SELECT * FROM tb_livros WHERE titulo LIKE CONCAT('%', @TITULO, '%')" 'LIKE CONCAT('%', @TITULO, '%') diz ao MySQL: procura por qualquer título que contenha esse texto.'
            comando = New MySqlCommand(strSql, ligacao)
            comando.Parameters.AddWithValue("@TITULO", Titulo)


            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabela As New DataTable()

            adaptador.Fill(tabela)

            DataGridView1.DataSource = tabela

        Catch ex As Exception
            MsgBox("Erro ao buscar os dados: " & ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles caixa_ID.TextChanged

    End Sub



End Class




