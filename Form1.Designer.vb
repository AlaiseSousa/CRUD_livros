<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.lbl_livro = New System.Windows.Forms.Label()
        Me.lbl_autor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.caixa_titulo = New System.Windows.Forms.TextBox()
        Me.caixa_autor = New System.Windows.Forms.TextBox()
        Me.caixa_ano = New System.Windows.Forms.TextBox()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.btn_vizualizar = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.caixa_comboo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.caixa_ID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ano.Location = New System.Drawing.Point(324, 190)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(155, 23)
        Me.lbl_ano.TabIndex = 0
        Me.lbl_ano.Text = "Ano de Publicação:"
        '
        'lbl_livro
        '
        Me.lbl_livro.AutoSize = True
        Me.lbl_livro.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_livro.Location = New System.Drawing.Point(-1, 131)
        Me.lbl_livro.Name = "lbl_livro"
        Me.lbl_livro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_livro.Size = New System.Drawing.Size(131, 23)
        Me.lbl_livro.TabIndex = 1
        Me.lbl_livro.Text = ": Titulo do Livro"
        '
        'lbl_autor
        '
        Me.lbl_autor.AutoSize = True
        Me.lbl_autor.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autor.Location = New System.Drawing.Point(12, 176)
        Me.lbl_autor.Name = "lbl_autor"
        Me.lbl_autor.Size = New System.Drawing.Size(58, 23)
        Me.lbl_autor.TabIndex = 2
        Me.lbl_autor.Text = "Autor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Coral
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(334, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gestão de Livros"
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genero.Location = New System.Drawing.Point(368, 126)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(70, 23)
        Me.lbl_genero.TabIndex = 4
        Me.lbl_genero.Text = "Genero:"
        '
        'caixa_titulo
        '
        Me.caixa_titulo.Location = New System.Drawing.Point(136, 123)
        Me.caixa_titulo.Multiline = True
        Me.caixa_titulo.Name = "caixa_titulo"
        Me.caixa_titulo.Size = New System.Drawing.Size(172, 31)
        Me.caixa_titulo.TabIndex = 5
        '
        'caixa_autor
        '
        Me.caixa_autor.Location = New System.Drawing.Point(90, 177)
        Me.caixa_autor.Multiline = True
        Me.caixa_autor.Name = "caixa_autor"
        Me.caixa_autor.Size = New System.Drawing.Size(198, 36)
        Me.caixa_autor.TabIndex = 6
        '
        'caixa_ano
        '
        Me.caixa_ano.Location = New System.Drawing.Point(496, 190)
        Me.caixa_ano.Multiline = True
        Me.caixa_ano.Name = "caixa_ano"
        Me.caixa_ano.Size = New System.Drawing.Size(154, 32)
        Me.caixa_ano.TabIndex = 7
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_adicionar.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar.Location = New System.Drawing.Point(-1, 266)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(153, 40)
        Me.btn_adicionar.TabIndex = 11
        Me.btn_adicionar.Text = "Adicionar Livros"
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'btn_vizualizar
        '
        Me.btn_vizualizar.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_vizualizar.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vizualizar.Location = New System.Drawing.Point(183, 266)
        Me.btn_vizualizar.Name = "btn_vizualizar"
        Me.btn_vizualizar.Size = New System.Drawing.Size(150, 40)
        Me.btn_vizualizar.TabIndex = 12
        Me.btn_vizualizar.Text = "Visualizar Livros"
        Me.btn_vizualizar.UseVisualStyleBackColor = False
        '
        'btn_atualizar
        '
        Me.btn_atualizar.BackColor = System.Drawing.Color.Bisque
        Me.btn_atualizar.Location = New System.Drawing.Point(524, 251)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(145, 38)
        Me.btn_atualizar.TabIndex = 13
        Me.btn_atualizar.Text = "Atualizar Livros "
        Me.btn_atualizar.UseVisualStyleBackColor = False
        '
        'btn_listar
        '
        Me.btn_listar.BackColor = System.Drawing.Color.Bisque
        Me.btn_listar.Location = New System.Drawing.Point(339, 289)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(164, 39)
        Me.btn_listar.TabIndex = 14
        Me.btn_listar.Text = "Listar livros"
        Me.btn_listar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Bisque
        Me.Button5.Location = New System.Drawing.Point(703, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 38)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Eliminar Livros"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(123, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(642, 160)
        Me.DataGridView1.TabIndex = 16
        '
        'caixa_comboo
        '
        Me.caixa_comboo.FormattingEnabled = True
        Me.caixa_comboo.Location = New System.Drawing.Point(444, 123)
        Me.caixa_comboo.Name = "caixa_comboo"
        Me.caixa_comboo.Size = New System.Drawing.Size(186, 26)
        Me.caixa_comboo.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gerir_Livros_B.My.Resources.Resources.livro_gestão_WPF
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 354)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Gerir_Livros_B.My.Resources.Resources.imgem_livros_gestão
        Me.PictureBox2.InitialImage = Global.Gerir_Livros_B.My.Resources.Resources.imgem_livros_gestão1
        Me.PictureBox2.Location = New System.Drawing.Point(656, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(12, 66)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(38, 23)
        Me.lbl_id.TabIndex = 20
        Me.lbl_id.Text = "ID :"
        '
        'caixa_ID
        '
        Me.caixa_ID.Location = New System.Drawing.Point(57, 66)
        Me.caixa_ID.Multiline = True
        Me.caixa_ID.Name = "caixa_ID"
        Me.caixa_ID.Size = New System.Drawing.Size(120, 35)
        Me.caixa_ID.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.caixa_ID)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.caixa_comboo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.btn_vizualizar)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.caixa_ano)
        Me.Controls.Add(Me.caixa_autor)
        Me.Controls.Add(Me.caixa_titulo)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_autor)
        Me.Controls.Add(Me.lbl_livro)
        Me.Controls.Add(Me.lbl_ano)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Gerir Livros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_ano As Label
    Friend WithEvents lbl_livro As Label
    Friend WithEvents lbl_autor As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_genero As Label
    Friend WithEvents caixa_titulo As TextBox
    Friend WithEvents caixa_autor As TextBox
    Friend WithEvents caixa_ano As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents btn_vizualizar As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents btn_listar As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents caixa_comboo As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents caixa_ID As TextBox
End Class
